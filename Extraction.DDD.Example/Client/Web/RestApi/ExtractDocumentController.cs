using Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.GetExtractionJob;
using Extraction.DDD.Example.Application.UseCases.ExtractionDataAnalyst.StartNewExtractionJob;
using Microsoft.AspNetCore.Mvc;

namespace Extraction.DDD.Example.Client.Web.RestApi
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
		public StartNewExtractionJobApiResponse Post()
		{
			StartNewExtractionJobResponseDTO response = _startNewExtractionJobUseCase.Execute(new StartNewExtractionJobRequestDTO());
			// Map DTO to Response
			return new StartNewExtractionJobApiResponse();
		}

		[HttpGet(Name = "GetExtractionJob")]
        public GetExtractionJobApiResponse Get()
        {
			GetExtractionJobResponseDTO getExtractionJobResponse = _getExtractionJobUseCase.Execute(new GetExtractionJobRequestDTO());

			// Map DTO to Response
			GetExtractionJobApiResponseMapper.ToDto(getExtractionJobResponse);
			return new GetExtractionJobApiResponse();
		}
    }
}
