using Extraction.DDD.Example.Application.Ports.Extractor;
using Extraction.DDD.Example.Infrastructure.AwsBedrock;

namespace Hyland.Experience.Idp.Extraction.Api.Services
{
	public interface AwsBedrockExtractionServiceClient
	{
		HeaderFieldExtractionResult ExtractHeaderFieldsFromTextAsync(HeaderFieldExtractionRequestDTO requestDTO);
	}
}