
using One.Health.CommonEntity;
using One.Health.Response.ICICI;
using One.Health.Services.ICICI;

namespace One.Health.Services.ICICI;

public class QuoteService : IQuoteService
{

    private readonly QuoteTokenService quoteTokenService;
    private readonly IConfiguration config;
    public QuoteService(QuoteTokenService quoteTokenService, IConfiguration config)
    {
        this.config = config;
        this.quoteTokenService = quoteTokenService;
    }
    public IResponse Invoke(IRequest request)
    {
        PremiumResponse premiumResponse = new PremiumResponse();
        TokenPremiumResponse tokenPremiumResponse = new TokenPremiumResponse();
        tokenPremiumResponse =(TokenPremiumResponse)quoteTokenService.Invoke(request);

        return premiumResponse;
    }
}