using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Hyland.Experience.Idp.Extraction.Api.Models.Mongo;

namespace Extraction.DDD.Example.Infrastructure.MongoDB;

public class MongoDBExtractionJobCache : IExtractionJobRepository
{
	public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO)
	{
		// Get the job from MongoDB
		throw new NotImplementedException();
	}

	public StoreExtractionJobResponseDTO StoreExtractionJob(StoreExtractionJobRequestDTO requestDTO)
	{
		// Store the job in MongoDB
		var jobData = new MongoExtractionJobData();

		// Adapt result to the response DTO
		return new StoreExtractionJobResponseDTO();
	}
}
