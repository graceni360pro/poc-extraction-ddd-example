using Extraction.DDD.Example.Application.UseCases.ExtractionJobProcessor;

namespace Extraction.DDD.Example.Infrastructure.RecognitionMessageQueue
{
	public class CompletedDocumentOcrWorkMessageQueueHandler
	{
		private readonly IExtractFromImageDocument extractFromImageDocument;
		private readonly IExtractFromTextDocument extractFromTextDocument;

		public CompletedDocumentOcrWorkMessageQueueHandler(
			IExtractFromImageDocument extractFromImageDocument,
			IExtractFromTextDocument extractFromTextDocument
			)
		{
			this.extractFromImageDocument = extractFromImageDocument;
			this.extractFromTextDocument = extractFromTextDocument;
		}

		// Listens to the Message Queue for completed OCR work messages
		public void SubscribeToMessageQueue()
		{
		}

		// Event handler for message received from the queue
		private void OnMessageReceived(object sender, EventArgs e)
		{
			// Parse message and call appropriate application services
			// Calls the appropriate application services to handle the completed OCR data
			bool isImageDocument = true; // Determine based on message content
			if (isImageDocument)
			{
				extractFromImageDocument.Execute(new ExtractFromImageDocumentRequestDTO());
			}
			else
			{
				extractFromTextDocument.Execute(new ExtractFromTextDocumentRequestDTO());
			}
		}
	}
}
