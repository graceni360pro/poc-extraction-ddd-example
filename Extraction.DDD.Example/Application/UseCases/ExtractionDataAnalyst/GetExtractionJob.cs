using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst;

namespace Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst
{
	public class GetExtractionJob : IGetExtractionJob
	{
		private readonly IExtractionJobRepository extractionJobRepository;

		public GetExtractionJob(IExtractionJobRepository extractionJobRepository)
		{
			this.extractionJobRepository = extractionJobRepository;
		}
		public GetExtractDocumentResponseDTO Execute(GetExtractionJobRequestDTO requestDTO)
		{
			GetExtractionJobRepositoryRequestDTO repositoryGetExtractionJobRequestDTO = new GetExtractionJobRepositoryRequestDTO();
			ExtractionJob extractionJob = extractionJobRepository.GetExtractionJob(repositoryGetExtractionJobRequestDTO);

			// Adapt to an output DTO for the use case.
			// The ExtractionJob is an Application model (since it's an implementation detail of the use-case), but since it contains a domain model (ExtractedField), it must be adapted.
			// Domain models should not be exposed to the clients of the Application Layer so that we can evolve the domain model more easily without necessarily impacting the clients of the Application Layer.
			GetExtractDocumentResponseDTO response = GetExtractedDocumentRsponseDTOMapper.ToDto(extractionJob);
			return response;
		}
	}
}