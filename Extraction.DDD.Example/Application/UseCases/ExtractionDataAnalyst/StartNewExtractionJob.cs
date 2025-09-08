using Extraction.DDD.Example.Application.Ports.DocumentOcrWorkDispatcher;
using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;

namespace Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst
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
			StoreExtractionJobResponseDTO storeResponse = extractionJobRepository.StoreExtractionJob(new StoreExtractionJobRequestDTO());

			PublishDocumentRecognitionRequestDTO publishRequestDTO = new PublishDocumentRecognitionRequestDTO();
			documentOcrWorkDispatcher.PublishDocumentRecognitionRequestAsync(publishRequestDTO);

			return new StartNewExtractionJobResponseDTO();
		}
	}
}