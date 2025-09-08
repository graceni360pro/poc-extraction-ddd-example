using Extraction.DDD.Example.Application.Ports.Extractor;
using Extraction.DDD.Example.Infrastructure.AwsBedrock;

namespace Hyland.Experience.Idp.Extraction.Api.Services;

/// <summary>
/// AWS Bedrock extraction service.
/// </summary>
public class AwsBedrockExtractionServiceClientImpl : AwsBedrockExtractionServiceClient
{
	public HeaderFieldExtractionResult ExtractHeaderFieldsFromTextAsync(HeaderFieldExtractionRequestDTO requestDTO)
	{
		// Call AWS Bedrock API

		// Get result of extraction


		// Adapt to Domain's HeaderFieldExtractionResult
		return new HeaderFieldExtractionResult("","", [],1, "");
	}
}
