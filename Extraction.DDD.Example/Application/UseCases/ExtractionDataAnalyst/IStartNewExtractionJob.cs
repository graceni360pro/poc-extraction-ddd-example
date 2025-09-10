namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst
{
	public interface IStartNewExtractionJob
	{
		StartNewExtractionJobResponseDTO Execute(StartNewExtractionJobRequestDTO requestDTO);
	}
}
