using Extraction.DDD.Example.Application.Ports.DocumentOcrWorkDispatcher;

namespace Extraction.DDD.Example.Infrastructure.RecognitionOcrWorkDispatcherMessageQueue
{
	public class RecognitionOcrWorkDispatcherMessageQueue : IDocumentOcrWorkDispatcher
	{
		public void PublishDocumentRecognitionRequestAsync(PublishDocumentRecognitionRequestDTO requestDTO)
		{
			// Talks to a message queue system to publish the request
			throw new NotImplementedException();
		}
	}
}
