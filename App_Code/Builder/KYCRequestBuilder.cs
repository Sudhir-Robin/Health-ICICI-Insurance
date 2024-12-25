using One.Health.Common;
using One.Health.CommonEntity;
using One.Health.Request.ICICI;

namespace One.Health.ICICI;

public class KYCRequestBuilder : IRequestBuilder
{

    public KYCRequestBuilder()
    {
        
    }
    public IRequest Build(IRequest request)
    {
        KYCRequest kYCRequest = (KYCRequest)request;
        
        return kYCRequest;
    }
}
