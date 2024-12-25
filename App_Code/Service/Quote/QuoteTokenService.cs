using System.Net;
using One.Health.CommonEntity;
using One.Health.Response.ICICI;
using One.Health.Services.ICICI;

public class QuoteTokenService : IQuoteService
{
    private readonly IConfiguration config;
    private string? tokenUrl, scope, grantType, clientId, client_secret, username, password;

    public QuoteTokenService(IConfiguration config)
    {
        this.config = config;
        tokenUrl = Convert.ToString(config["PremiumToken:TokenUrl"]);
        scope = Convert.ToString(config["PremiumToken:Scope"]);
        username = Convert.ToString(config["PremiumToken:username"]);
        password = Convert.ToString(config["PremiumToken:password"]);
        grantType = Convert.ToString(config["PremiumToken:grant_type"]);
        clientId = Convert.ToString(config["PremiumToken:Client_id"]);
        client_secret = Convert.ToString(config["PremiumToken:Client_Secret"]);

    }
    public IResponse Invoke(IRequest request)
    {
        TokenPremiumResponse tokenPremiumResponse = new TokenPremiumResponse();

        var formData = new Dictionary<string, string>
        {
            { "grant_type", grantType },
            { "username", username },
            { "password", password },
            { "scope", scope },
            { "client_id", clientId },
            { "client_secret", client_secret }
        };
        using (var client = new HttpClient())
        {
            // Convert the dictionary to `application/x-www-form-urlencoded` content
            var content = new FormUrlEncodedContent(formData);

            // Send POST request with the form data
            var response = client.PostAsync(tokenUrl, content);
            if (response.Result.StatusCode == HttpStatusCode.OK)
            {
                tokenPremiumResponse = response.Result.Content.ReadFromJsonAsync<TokenPremiumResponse>().Result;
            }
        }

        return tokenPremiumResponse;
    }
}