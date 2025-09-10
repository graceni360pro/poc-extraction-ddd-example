using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst
{
	public class GetExtractDocumentResponseDTO
	{
		public ExtractedFieldDto[] ExtractedFields { get; set; } = [];
	}

	public class ExtractedFieldDto
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
}
