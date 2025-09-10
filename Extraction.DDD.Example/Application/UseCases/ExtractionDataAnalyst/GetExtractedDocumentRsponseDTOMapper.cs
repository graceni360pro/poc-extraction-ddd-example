using Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst;
using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst
{
	public static class GetExtractedDocumentRsponseDTOMapper
	{
		public static GetExtractDocumentResponseDTO ToDto(ExtractionJob extractionJob)
		{
			return new GetExtractDocumentResponseDTO
			{
				ExtractedFields = extractionJob.ExtractedFields.Select(f => ToDto(f)).ToArray()
			};
		}

		public static ExtractedFieldDto ToDto(ExtractedField field)
		{
			return new ExtractedFieldDto
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
