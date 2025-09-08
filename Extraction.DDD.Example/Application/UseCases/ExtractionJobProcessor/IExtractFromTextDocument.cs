namespace Extraction.DDD.Example.Application.Actors.ExtractionJobProcessor
{
	public interface IExtractFromTextDocument
	{
		void Execute(ExtractFromTextDocumentRequestDTO requestDTO);
	}
}
