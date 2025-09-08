namespace Extraction.DDD.Example.Application.Ports.DocumentOcrWorkDispatcher
{
	public interface IDocumentOcrWorkDispatcher
	{
		public void PublishDocumentRecognitionRequestAsync(PublishDocumentRecognitionRequestDTO requestDTO);
	}
}
