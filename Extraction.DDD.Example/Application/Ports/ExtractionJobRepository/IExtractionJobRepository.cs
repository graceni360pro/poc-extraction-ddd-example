namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	/// <summary>
	/// The repository's purpose is to abstract persistence for the domain model. It stores and retrieves domain objects.
	/// It knows how to re-hydrate domain objects from the persistence model and how to persist domain objects.
	/// It should not receive or return DTOs, only domain objects.
	/// 
	/// HOWEVER, in this case we are cheating a bit. We're storing the whole Extraction Job, which is an application-layer detail, with the domain object.
	/// Why is this a problem? Because we should be able to swap out the application layer's implementation (using a Job pattern) without affecting how the domain object is stored.
	/// We can refactor this later to store the extraction results separate from the extraction job.
	/// </summary>
	public interface IExtractionJobRepository
	{
		public StoreExtractionJobResponseDTO StoreExtractionJob(ExtractionJob extractionJob);
		public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO);
	}
}
