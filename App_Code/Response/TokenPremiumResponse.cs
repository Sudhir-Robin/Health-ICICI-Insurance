namespace One.Health.Response.ICICI;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class TokenPremiumResponse :IResponse
    {
        public int statusCode { get; set; }
        public string? access_token { get; set; }
        public string? token_type { get; set; }
        public int expires_in { get; set; }
        public string? scope { get; set; }
    }

