using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Application.Ports.Extractor;
using Extraction.DDD.Example.Domain;

namespace Extraction.DDD.Example.Application.Actors.ExtractionJobProcessor
{
	public class ExtractFromTextDocument : IExtractFromTextDocument
	{
		private readonly IExtractor extractor;
		private readonly IExtractionJobRepository extractionJobRepository;

		public ExtractFromTextDocument(
			IExtractor extractor,
			IExtractionJobRepository extractionJobRepository
			)
		{
			this.extractor = extractor;
			this.extractionJobRepository = extractionJobRepository;
		}
		public void Execute(ExtractFromTextDocumentRequestDTO requestDTO)
		{
			// Get Text Layout from OCR (not implemented here)

			// Call extractor to extract header fields
			HeaderFieldExtractionRequestDTO headerFieldRequest = new HeaderFieldExtractionRequestDTO();
			IEnumerable<ExtractedField> extractionResult = extractor.ExtractHeaderFieldsFromTextAsync(headerFieldRequest);

			// Call extractor to extract table fields, reasoning, etc. (not implemented here)

			// Get existing extraction job
			GetExtractionJobRepositoryRequestDTO getExtractionJobRepositoryRequestDTO = new GetExtractionJobRepositoryRequestDTO();
			ExtractionJob extractionJob = extractionJobRepository.GetExtractionJob(getExtractionJobRepositoryRequestDTO);

			// Process extractionResult and extractionJob as needed (not implemented here)

			// Store updated extraction job
			StoreExtractionJobRequestDTO storeExtractionJobRequestDTO = new StoreExtractionJobRequestDTO();
			extractionJobRepository.StoreExtractionJob(storeExtractionJobRequestDTO);

		}
	}
}