using Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst;
using Microsoft.AspNetCore.Mvc;

namespace Extraction.DDD.Example.Client.ExtractionDataAnalyst.RestApi
{
    [ApiController]
    [Route("[controller]")]
    public class ExtractDocumentController : ControllerBase
    {
        private readonly ILogger<ExtractDocumentController> _logger;
		private readonly StartNewExtractionJob _startNewExtractionJobUseCase;
		private readonly GetExtractionJob _getExtractionJobUseCase;

		public ExtractDocumentController(ILogger<ExtractDocumentController> logger,
			StartNewExtractionJob startNewExtractionJobUseCase,
			GetExtractionJob getExtractionJobUseCase)
        {
            _logger = logger;
			_startNewExtractionJobUseCase = startNewExtractionJobUseCase;
			_getExtractionJobUseCase = getExtractionJobUseCase;
		}
		[HttpGet(Name = "StartNewExtractionJob")]
		public StartNewExtractionJobResponse Post()
		{
			StartNewExtractionJobResponseDTO response = _startNewExtractionJobUseCase.Execute(new StartNewExtractionJobRequestDTO());
			// Map DTO to Response
			return new StartNewExtractionJobResponse();
		}

		[HttpGet(Name = "GetExtractionJob")]
        public GetExtractionJobResponse Get()
        {
			GetExtractDocumentResponseDTO response = _getExtractionJobUseCase.Execute(new GetExtractionJobRequestDTO());
			// Map DTO to Response
			return new GetExtractionJobResponse();
		}
    }
}
