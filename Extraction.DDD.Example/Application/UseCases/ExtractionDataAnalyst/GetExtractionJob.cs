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

			// Adapt to an output DTO for the use case. The domain model should not be exposed to the clients of the Application Layer.
			GetExtractDocumentResponseDTO response = GetExtractedDocumentRsponseDTOMapper.ToDto(extractionJob);
			return response;
		}
	}
}