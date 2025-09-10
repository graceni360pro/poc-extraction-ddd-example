using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst
{
	public static class GetExtractionJobResponseMapper
	{
		public static GetExtractionJobResponseDTO ToDto(ExtractionJob extractionJob)
		{
			return new GetExtractionJobResponseDTO
			{
				ExtractedFields = extractionJob.ExtractedFields.Select(f => ToDto(f)).ToArray()
			};
		}

		public static ExtractedFieldDTO ToDto(ExtractedField field)
		{
			return new ExtractedFieldDTO
			{
				Id = field.Id,
				Name = field.Name,
				ExtractedValue = field.ExtractedValue,
				ExtractionConfidence = field.ExtractionConfidence,
				ReviewStatus = field.ReviewStatus,
				BoundingBox = field.BoundingBox.ToList(),
				PageIndex = field.PageIndex,
				OcrConfidence = field.OcrConfidence
			};
		}
	}
}
