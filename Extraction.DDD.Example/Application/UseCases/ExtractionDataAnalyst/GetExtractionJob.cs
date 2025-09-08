using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;

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
			GetExtractionJobRepositoryResponseDTO extractionJob = extractionJobRepository.GetExtractionJob(repositoryGetExtractionJobRequestDTO);

			// convert to GetExtractDocumentResponseDTO and return
			return new GetExtractDocumentResponseDTO();
		}
	}
}