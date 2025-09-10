namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	/// <summary>
	/// The repository's purpose is to abstract persistence for the domain model. It stores and retrieves domain objects.
	/// It knows how to re-hydrate domain objects from the persistence model and how to persist domain objects.
	/// It should not receive or return DTOs, only domain objects.
	/// </summary>
	public interface IExtractionJobRepository
	{
		public StoreExtractionJobResponseDTO StoreExtractionJob(ExtractionJob extractionJob);
		public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO);
	}
}
