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
		private readonly IStartNewExtractionJob _startNewExtractionJobUseCase;
		private readonly IGetExtractionJob _getExtractionJobUseCase;

		public ExtractDocumentController(ILogger<ExtractDocumentController> logger,
			IStartNewExtractionJob startNewExtractionJobUseCase,
			IGetExtractionJob getExtractionJobUseCase)
        {
            _logger = logger;
			_startNewExtractionJobUseCase = startNewExtractionJobUseCase;
			_getExtractionJobUseCase = getExtractionJobUseCase;
		}
		[HttpGet(Name = "StartNewExtractionJob")]
		public StartNewExtractionJobApiResponseDTO Post()
		{
			StartNewExtractionJobResponseDTO response = _startNewExtractionJobUseCase.Execute(new StartNewExtractionJobRequestDTO());
			// Map DTO to Response
			return new StartNewExtractionJobApiResponseDTO();
		}

		[HttpGet(Name = "GetExtractionJob")]
        public GetExtractionJobApiResponseDTO Get()
        {
			GetExtractionJobResponseDTO getExtractionJobResponse = _getExtractionJobUseCase.Execute(new GetExtractionJobRequestDTO());

			// Map DTO to Response
			GetExtractionJobApiResponseMapper.ToDto(getExtractionJobResponse);
			return new GetExtractionJobApiResponseDTO();
		}
    }
}
