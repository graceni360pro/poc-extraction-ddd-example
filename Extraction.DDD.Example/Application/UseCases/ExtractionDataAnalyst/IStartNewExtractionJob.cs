namespace Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst
{
	public interface IStartNewExtractionJob
	{
		StartNewExtractionJobResponseDTO Execute(StartNewExtractionJobRequestDTO requestDTO);
	}
}
