namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.StartNewExtractionJob
{
	public interface IStartNewExtractionJob
	{
		StartNewExtractionJobResponseDTO Execute(StartNewExtractionJobRequestDTO requestDTO);
	}
}
