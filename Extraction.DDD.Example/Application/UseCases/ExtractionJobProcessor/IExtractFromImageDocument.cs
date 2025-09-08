namespace Extraction.DDD.Example.Application.Actors.ExtractionJobProcessor
{
	public interface IExtractFromImageDocument
	{
		void Execute(ExtractFromImageDocumentRequestDTO requestDTO);
	}
}
