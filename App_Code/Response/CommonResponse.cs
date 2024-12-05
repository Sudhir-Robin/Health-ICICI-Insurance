using One.Health.Response.ICICI;

namespace One.Health.Common.Response;
public class CommonResponse : IResponse
{
    public bool success { get; set; }
    public string? message { get; set; }
    public int error_code { get; set; }
    public object? data { get; set; }

}




