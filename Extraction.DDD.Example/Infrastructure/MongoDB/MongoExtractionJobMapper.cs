using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Hyland.Experience.Idp.Extraction.Api.Models.Mongo;
using System;
using System.Linq;

namespace Hyland.Experience.Idp.Extraction.Api.Models.Mongo
{
	public static class MongoExtractionJobMapper
	{
		public static MongoExtractionJobDTO Create(ExtractionJob job, DateTime lastReadAt)
		{
			return new MongoExtractionJobDTO
			{
				JobId = job.JobId,
				LastReadAt = lastReadAt,
				ExtractedFields = job.ExtractedFields?.Select(f => new MongoExtractedFieldDTO
				{
					Id = f.Id,
					Name = f.Name,
					ExtractedValue = f.ExtractedValue,
					ExtractionConfidence = f.ExtractionConfidence,
					ReviewStatus = f.ReviewStatus,
					BoundingBox = f.BoundingBox?.ToList() ?? [],
					PageIndex = f.PageIndex,
					OcrConfidence = f.OcrConfidence
				}).ToArray() ?? []
			};
		}
	}
}
