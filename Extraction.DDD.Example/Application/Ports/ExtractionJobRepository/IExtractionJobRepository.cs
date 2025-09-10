namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	public interface IExtractionJobRepository
	{
		public StoreExtractionJobResponseDTO StoreExtractionJob(StoreExtractionJobRequestDTO requestDTO);
		public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO);
	}
}
