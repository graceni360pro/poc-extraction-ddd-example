using Extraction.DDD.Example.Application.Actors.ExtractionDataAnalyst;
using Extraction.DDD.Example.Application.Actors.ExtractionJobProcessor;
using Extraction.DDD.Example.Application.Ports.DocumentOcrWorkDispatcher;
using Extraction.DDD.Example.Application.Ports.ExtractionJobRepository;
using Extraction.DDD.Example.Application.Ports.Extractor;
using Extraction.DDD.Example.Infrastructure.MongoDB;
using Extraction.DDD.Example.Infrastructure.RecognitionMessageQueue;
using Extraction.DDD.Example.Infrastructure.RecognitionOcrWorkDispatcherMessageQueue;
using Hyland.Experience.Idp.Extraction.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------------

// Application Services
builder.Services.AddSingleton<IGetExtractionJob, GetExtractionJob>();
builder.Services.AddSingleton<IStartNewExtractionJob, StartNewExtractionJob>();
builder.Services.AddSingleton<IExtractFromImageDocument, ExtractFromImageDocument>();
builder.Services.AddSingleton<IExtractFromTextDocument, ExtractFromTextDocument>();

// Ports
builder.Services.AddSingleton<IExtractor, AwsBedrockExtractionServiceAdapter>();
builder.Services.AddSingleton<IExtractionJobRepository, MongoDBExtractionJobCache>();
builder.Services.AddSingleton<IDocumentOcrWorkDispatcher, RecognitionOcrWorkDispatcherMessageQueue>();

// Infrastructure services
builder.Services.AddSingleton<CompletedDocumentOcrWorkMessageQueueHandler>();

// ---------------------------------------------------------------

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
