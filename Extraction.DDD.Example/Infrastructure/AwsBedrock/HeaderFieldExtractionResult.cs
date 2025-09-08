namespace Extraction.DDD.Example.Infrastructure.AwsBedrock;

public class HeaderFieldExtractionResult(string fieldName, string value, FieldExtractionResultPosition[] positions, int pageNumber, string? reason)
{
	/// <summary>
	/// Field Name property
	/// </summary>
	public string FieldName { get; } = fieldName;

	/// <summary>
	/// Extracted value from document
	/// </summary>
	public string Value { get; } = value;

	/// <summary>
	/// Position of the extracted value
	/// </summary>
	public FieldExtractionResultPosition[] Positions { get; } = positions;

	/// <summary>
	/// Page number, 1-based form where value is extracted
	/// </summary>
	public int PageNumber { get; } = pageNumber;

	/// <summary>
	/// Reasoning if available for the extraction
	/// </summary>
	public string? Reason { get; } = reason;
}
