
using One.Health.CommonEntity;
using One.Health.Response.ICICI;

namespace One.Health.Services.ICICI;

public interface IQuoteService
{
    public IResponse Invoke(IRequest request);
}