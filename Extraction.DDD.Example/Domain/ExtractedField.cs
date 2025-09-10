namespace Extraction.DDD.Example.Domain;

public class ExtractedField
{
	public string Id { get; }
	public string Name { get; }
	public string? ExtractedValue { get; }
	public float? ExtractionConfidence { get; }
	public ExtractionReviewStatus? ReviewStatus { get; }
	public List<long> BoundingBox { get; }
	public int? PageIndex { get; }
	public decimal? OcrConfidence { get; }

	public ExtractedField(
		string id,
		string name,
		string? extractedValue,
		float? extractionConfidence,
		ExtractionReviewStatus? reviewStatus,
		List<long> boundingBox,
		int? pageIndex,
		decimal? ocrConfidence)
	{
		Id = id;
		Name = name;
		ExtractedValue = extractedValue;
		ExtractionConfidence = extractionConfidence;
		ReviewStatus = reviewStatus;
		BoundingBox = boundingBox;
		PageIndex = pageIndex;
		OcrConfidence = ocrConfidence;

		// Run business validation on creation. That way, the domain object is always clean and valid.
	}
}
