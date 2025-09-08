namespace Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst
{
	public interface IGetExtractionJob
	{
		GetExtractDocumentResponseDTO Execute(GetExtractionJobRequestDTO requestDTO);
	}
}
