using One.Health.Common.Response;
using One.Health.CommonEntity;
using One.Health.Response.ICICI;
using One.Health.Services.NivaBupa;

namespace One.Health.Services.ICICI;

public class ProposalService : IProposalService
{
    private readonly IConfiguration config;
    public ProposalService(IConfiguration config)
    {
        this.config = config;
    }
    public IResponse Invoke(IRequest request)
    {
        CommonResponse response1 = new CommonResponse();
        return response1;
    }

}