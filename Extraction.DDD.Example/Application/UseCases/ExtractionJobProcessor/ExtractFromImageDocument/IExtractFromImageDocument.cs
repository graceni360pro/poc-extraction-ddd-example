namespace Extraction.DDD.Example.Application.UseCases.ExtractionJobProcessor.ExtractFromImageDocument
{
	public interface IExtractFromImageDocument
	{
		void Execute(ExtractFromImageDocumentRequestDTO requestDTO);
	}
}
