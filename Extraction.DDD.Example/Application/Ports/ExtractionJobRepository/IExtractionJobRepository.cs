namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	public interface IExtractionJobRepository
	{
		public StoreExtractionJobResponseDTO StoreExtractionJob(ExtractionJob extractionJob);
		public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO);
	}
}
