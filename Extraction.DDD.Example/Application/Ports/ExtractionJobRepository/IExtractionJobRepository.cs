namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	/// <summary>
	/// The repository's purpose is to abstract persistence for a model. It should provide the illusion of an in-memory collection.
	/// It knows how to re-hydrate objects from the persistence model, and how to persist objects.
	/// Rules:
	/// 1. It should not post or retrieve DTOs. Otherwise this forces the consumer to re-hydrate the real model which scatters this logic around the codebase instead of centralizing it in the repository.
	/// 2. A repository should only manage one aggregate root (a root entity and its children). It should not manage multiple aggregate roots.
	/// 3. An implementation of a repository may use multiple tables/collections. However, the closer the persistence model is to the domain model, the better, so that it is less confusing.
	/// --------------------------------------------------
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
