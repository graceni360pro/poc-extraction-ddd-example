using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.Ports.ExtractionJobRepository
{
	public class ExtractionJob
	{
		public ExtractedField[] ExtractedFields { get; set; } = [];
	}
}