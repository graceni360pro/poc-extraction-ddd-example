namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	/// <summary>
	/// The repository's purpose is to abstract persistence for a model. It should provide the illusion of an in-memory collection.
	/// It knows how to re-hydrate objects from the persistence model, and how to persist objects.
	/// Rules:
	/// 1. It should not post or retrieve DTOs.
	/// 2. If the type of object stored/retrieved is a domain object, the repository should ideally should not be storing the subcomponents of the domain object separately. This risks breaking the integrity of the domain object (like rules that should apply to the whole object, not just parts of it).
	/// 
	/// Here we're storing the whole Extraction Job, which is an application-layer-specific object (not a domain object) that also contains a domain object.
	/// Ideally we should be able to swap out the application layer's implementation (using a Job pattern) without affecting how the domain object is stored.
	/// We can refactor this later to store the extraction results separate from the extraction job, but still leave users of this repository unaffected.
	/// NOTE: The repository interface lives in the layer that it's subject lives in (in this case, the application layer), but the implementation of the repository always lives in the infrastructure layer.
	/// </summary>
	public interface IExtractionJobRepository
	{
		public StoreExtractionJobResponseDTO StoreExtractionJob(ExtractionJob extractionJob);
		public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO);
	}
}
