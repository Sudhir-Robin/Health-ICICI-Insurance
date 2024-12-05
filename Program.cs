using One.Health.Common;
using One.Health.Common.Response;
using One.Health.CommonEntity;
using One.Health.ICICI;
using One.Health.Response.ICICI;
using One.Health.Services.ICICI;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
builder.Services.AddSingleton<IConfiguration>(configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddKeyedSingleton<IQuoteService, PremiumService>("ICICIQuoteService");
builder.Services.AddKeyedSingleton<IResponse, PremiumResponse>("ICICIQuoteResponse");
builder.Services.AddKeyedSingleton<IResponse, TokenPremiumResponse>("ICICITokenResponse");
builder.Services.AddKeyedSingleton<IResponse, CommonResponse>("ICICICommonResponse");
builder.Services.AddKeyedSingleton<IRequestBuilder, PremiumRequestBuilder>("ICICIQuoteBuilder");
builder.Services.AddKeyedSingleton<IRequest, QuoteRequest>("Quote");


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();


app.RegisterEndPoint();
app.Run();