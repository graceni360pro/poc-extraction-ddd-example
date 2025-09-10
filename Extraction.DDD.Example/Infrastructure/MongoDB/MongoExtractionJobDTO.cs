
namespace Hyland.Experience.Idp.Extraction.Api.Models.Mongo;
// properties specific to an Extraction Job stored in MongoDB can be added here
public class MongoExtractionJobDTO
{
	// Specific to MongoDB
	public DateTime LastReadAt { get; set; }

	// Common with application model, but not referenced directly to avoid coupling
	public string JobId { get; set; } = string.Empty;
	public MongoExtractedFieldDTO[] ExtractedFields { get; set; } = [];
}
public class MongoExtractedFieldDTO
{
	public string Id { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string? ExtractedValue { get; set; }
	public float? ExtractionConfidence { get; set; }
	public ExtractionReviewStatus? ReviewStatus { get; set; }
	public List<long> BoundingBox { get; set; } = [];
	public int? PageIndex { get; set; }
	public decimal? OcrConfidence { get; set; }

}