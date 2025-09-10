using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Domain;
using Hyland.Experience.Idp.Extraction.Api.Models.Mongo;

namespace Extraction.DDD.Example.Infrastructure.MongoDB;

public class MongoDBExtractionJobCache : IExtractionJobRepository
{
	public ExtractionJob GetExtractionJob(GetExtractionJobRepositoryRequestDTO requestDTO)
	{
		// Retrieve the job from MongoDB (not implemented)
		var jobData = new MongoExtractionJobDTO();

		// adapt mongo DTO to extraction job (not implemented, instead let's just instantiate it)
		ExtractedField extractedField = new ExtractedField("some id", "some name", "some value", 1, ExtractionReviewStatus.ReviewRequired, [0,1,2,3], 0, (decimal?)0.5);
		IEnumerable<ExtractedField> extractedFields = new List<ExtractedField>() { extractedField };
		ExtractionJob extractionJob = new ExtractionJob("job id", extractedFields);
		return extractionJob;
	}

	public StoreExtractionJobResponseDTO StoreExtractionJob(ExtractionJob extractionJob)
	{
		// adapt extraction job to mongo DTO (not implemented)
		

		// Store the job in MongoDB
		var jobData = new MongoExtractionJobDTO();

		// Adapt result to the response DTO
		return new StoreExtractionJobResponseDTO();
	}
}
