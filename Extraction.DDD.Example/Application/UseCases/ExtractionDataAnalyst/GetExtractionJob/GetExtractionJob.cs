using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;

namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.GetExtractionJob
{
	public class GetExtractionJob : IGetExtractionJob
	{
		private readonly IExtractionJobRepository extractionJobRepository;

		public GetExtractionJob(IExtractionJobRepository extractionJobRepository)
		{
			this.extractionJobRepository = extractionJobRepository;
		}
		public GetExtractionJobResponseDTO Execute(GetExtractionJobRequestDTO requestDTO)
		{
			// Call the repository to get the ExtractionJob.
			GetExtractionJobRepositoryRequestDTO repositoryGetExtractionJobRequestDTO = new GetExtractionJobRepositoryRequestDTO();
			ExtractionJob extractionJob = extractionJobRepository.GetExtractionJob(repositoryGetExtractionJobRequestDTO);

			// Adapt to an output DTO for the use case.
			// The ExtractionJob is an Application model (since it's an implementation detail of the use-case), but since it contains a domain model (ExtractedField), it must be adapted.
			// Domain models should not be exposed to the clients of the Application Layer so that we can evolve the domain model more easily without necessarily impacting the clients of the Application Layer.
			GetExtractionJobResponseDTO response = GetExtractionJobResponseMapper.ToDto(extractionJob);
			return response;
		}
	}
}