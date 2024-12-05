using One.Health.CommonEntity;
using One.Health.Response.ICICI;

namespace One.Health.Services.NivaBupa;

public interface IProposalService
{
    public IResponse Invoke(IRequest request);
}