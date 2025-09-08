namespace Extraction.DDD.Example.Domain;

public class ExtractedField
{
	/// <summary>
	/// Field id. Purpose to be clarified.
	/// </summary>
	public string Id { get; set; } = string.Empty;
	/// <summary>
	/// Name of the field.
	/// </summary>
	public string Name { get; set; } = string.Empty;
	/// <summary>
	/// Extracted Value
	/// </summary>
	public string? ExtractedValue { get; set; }
	/// <summary>
	/// Extraction Confidence , 0..1
	/// </summary>
	public float? ExtractionConfidence { get; set; }
	/// <summary>
	/// Review Status can either be 'ReviewRequired' or 'ReviewNotRequired'
	/// </summary>
	public ExtractionReviewStatus? ReviewStatus { get; set; }
	/// <summary>
	/// BoundingBox = [Top, Left, Height, Width]
	/// </summary>
	public List<long> BoundingBox { get; set; } = [];
	/// <summary>
	/// convert to real BoundingBox
	/// </summary>
	public BoundingBox GetBoundingBox()
	{
		return new BoundingBox
		{
			Top = (int)BoundingBox[0],
			Left = (int)BoundingBox[1],
			Height = (int)BoundingBox[2],
			Width = (int)BoundingBox[3]
		};
	}
	/// <summary>
	/// Page Index, 0 based
	/// </summary>
	public int? PageIndex { get; set; }
	/// <summary>
	/// OCR Confidence, 0..1
	/// </summary>
	public decimal? OcrConfidence { get; set; }
}
