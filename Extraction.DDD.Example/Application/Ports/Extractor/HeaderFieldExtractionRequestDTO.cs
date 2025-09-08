namespace Extraction.DDD.Example.Application.Ports.Extractor
{
	public class HeaderFieldExtractionRequestDTO
	{
		// Why is this in the application layer and not the business layer?
		//	It's not important to the business that we're sending an extraction request somewhere.
		//	It's just an implementation detail of how we get the data we need to the business layer.
	}
}