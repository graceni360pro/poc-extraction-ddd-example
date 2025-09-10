namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.GetExtractionJob
{
	public class GetExtractionJobResponseDTO
	{
		public string JobId { get; set; } = string.Empty;
		public ExtractedFieldDTO[] ExtractedFields { get; set; } = [];
	}

	public class ExtractedFieldDTO
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
