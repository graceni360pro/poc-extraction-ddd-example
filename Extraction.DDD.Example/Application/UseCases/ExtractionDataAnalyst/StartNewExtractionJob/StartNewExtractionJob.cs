using Extraction.DDD.Example.Application.Ports.DocumentOcrWorkDispatcher;
using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.StartNewExtractionJob
{ 
	public class StartNewExtractionJob : IStartNewExtractionJob
	{
		private readonly IDocumentOcrWorkDispatcher documentOcrWorkDispatcher;
		private readonly IExtractionJobRepository extractionJobRepository;

		public StartNewExtractionJob(
			IDocumentOcrWorkDispatcher documentOcrWorkDispatcher,
			IExtractionJobRepository extractionJobRepository)
		{
			this.documentOcrWorkDispatcher = documentOcrWorkDispatcher;
			this.extractionJobRepository = extractionJobRepository;
		}
		public StartNewExtractionJobResponseDTO Execute(StartNewExtractionJobRequestDTO requestDTO)
		{
			// Create ExtractionJob (can be a factory)
			ExtractionJob extractionJob = new ExtractionJob("jobId", new List<ExtractedField>());

			// Store ExtractionJob (not a DTO). Pass clean application / domain objects to the repository.
			// The repository will adapt them to the persistence model if needed.
			StoreExtractionJobResponseDTO storeResponse = extractionJobRepository.StoreExtractionJob(extractionJob);

			PublishDocumentRecognitionRequestDTO publishRequestDTO = new PublishDocumentRecognitionRequestDTO();
			documentOcrWorkDispatcher.PublishDocumentRecognitionRequestAsync(publishRequestDTO);

			return new StartNewExtractionJobResponseDTO();
		}
	}
}