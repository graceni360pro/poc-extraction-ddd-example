namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.GetExtractionJob
{ 
	public interface IGetExtractionJob
	{
		GetExtractionJobResponseDTO Execute(GetExtractionJobRequestDTO requestDTO);
	}
}
