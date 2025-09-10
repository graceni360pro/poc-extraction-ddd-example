namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst
{ 
	public interface IGetExtractionJob
	{
		GetExtractionJobResponseDTO Execute(GetExtractionJobRequestDTO requestDTO);
	}
}
