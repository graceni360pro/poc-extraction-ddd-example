namespace Extraction.DDD.Example.Application.UseCases.ExtractionJobProcessor.ExtractFromTextDocument
{
	public interface IExtractFromTextDocument
	{
		void Execute(ExtractFromTextDocumentRequestDTO requestDTO);
	}
}
