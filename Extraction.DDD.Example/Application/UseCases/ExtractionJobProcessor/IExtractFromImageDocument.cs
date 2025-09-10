namespace Extraction.DDD.Example.Application.UseCases.ExtractionJobProcessor
{
	public interface IExtractFromImageDocument
	{
		void Execute(ExtractFromImageDocumentRequestDTO requestDTO);
	}
}
