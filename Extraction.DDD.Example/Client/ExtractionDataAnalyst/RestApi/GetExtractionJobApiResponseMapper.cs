using Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst;

namespace Extraction.DDD.Example.Client.ExtractionDataAnalyst.RestApi
{
	public static class GetExtractionJobApiResponseMapper
	{
		public static GetExtractionJobApiResponse ToDto(GetExtractionJobResponseDTO extractionJob)
		{
			return new GetExtractionJobApiResponse
			{
				JobId = extractionJob.JobId,
				ExtractedFields = extractionJob.ExtractedFields.Select(f => ToDto(f)).ToArray()
			};
		}

		public static ExtractedFieldApiDTO ToDto(ExtractedFieldDTO field)
		{
			return new ExtractedFieldApiDTO
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
