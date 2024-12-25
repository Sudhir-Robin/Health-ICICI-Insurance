using One.Health.CommonEntity;
using One.Health.Response.ICICI;

namespace One.Health.Services.NivaBupa;

public interface IKYCService
{
    public IResponse Invoke(IRequest request);
}
