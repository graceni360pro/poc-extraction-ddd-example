using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	public class ExtractionJob
	{
		public string JobId { get; }
		public IEnumerable<ExtractedField> ExtractedFields { get; }

		public ExtractionJob(string jobId, IEnumerable<ExtractedField> extractedFields)
		{
			JobId = jobId;
			ExtractedFields = extractedFields;
		}
	}
}