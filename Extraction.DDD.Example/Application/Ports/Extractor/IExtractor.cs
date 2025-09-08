using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.Ports.Extractor
{
	public interface IExtractor
	{
		public IList<ExtractedField> ExtractHeaderFieldsFromTextAsync(HeaderFieldExtractionRequestDTO requestDTO);
	}
}
