namespace Extraction.DDD.Example.Application.UseCases.ExtractionJobProcessor
{
	public interface IExtractFromTextDocument
	{
		void Execute(ExtractFromTextDocumentRequestDTO requestDTO);
	}
}
