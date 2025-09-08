using Extraction.DDD.Example.Application.Ports.Extractor;
using Extraction.DDD.Example.Domain;

namespace Hyland.Experience.Idp.Extraction.Api.Services;

/// <summary>
/// AWS Bedrock extraction service.
/// </summary>
public class AwsBedrockExtractionServiceAdapter : IExtractor
{
	private readonly AwsBedrockExtractionServiceClient awsBedrockExtractionServiceClient;

	public AwsBedrockExtractionServiceAdapter(
		AwsBedrockExtractionServiceClient awsBedrockExtractionServiceClient)
	{
		this.awsBedrockExtractionServiceClient = awsBedrockExtractionServiceClient;
	}
	public IList<ExtractedField> ExtractHeaderFieldsFromTextAsync(HeaderFieldExtractionRequestDTO requestDTO)
	{
		// Call AWS Bedrock API
		var result = awsBedrockExtractionServiceClient.ExtractHeaderFieldsFromTextAsync(requestDTO);

		// Adapt to Domain's HeaderFieldExtractionResult
		return new List<ExtractedField>();
	}
}
