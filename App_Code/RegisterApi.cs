using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using One.Health.Common.Response;
using One.Health.CommonEntity;
using One.Health.Response.ICICI;
using One.Health.Services.ICICI;

public static class RegisterApi
{
    public static void RegisterEndPoint(this WebApplication app)
    {
        app.MapPost("/ICICIQuote", ([FromBody] QuoteRequest request, [FromKeyedServices("ICICIQuoteService")] IQuoteService service) =>
        {
            IResponse response = service.Invoke(request);
            CommonResponse commonResponse = (CommonResponse)response;
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(commonResponse));
            return Results.Json(commonResponse);
        });
    }
}