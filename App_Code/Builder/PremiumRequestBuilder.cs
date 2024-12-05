using One.Health.Common;
using One.Health.CommonEntity;
using One.Health.Request.ICICI;

namespace One.Health.ICICI;

public class PremiumRequestBuilder : IRequestBuilder
{
    public IRequest Build(IRequest request)
    {
        PremiumRequest premiumReq = new PremiumRequest();

        return premiumReq;
    }
}