
using One.Health.CommonEntity;

namespace One.Health.Request.ICICI;

public class KycRequest : IRequest
{
    public string? correlationId { get; set; }
    public string? certificate_type { get; set; }
    public bool? pep_flag { get; set; }
    public pan_details? pan_details { get; set; }
    public ckyc_details? ckyc_details { get; set; }
    public aadhaar_details? aadhaar_details { get; set; }
    public cin_details? cin_details { get; set; }
    public epic_details? epic_details { get; set; }
    public dl_details? dl_details { get; set; }
    public passport_details? passport_details { get; set; }
}

public class pan_details
{
    public string? pan { get; set; }
    public string? dob { get; set; }
}
public class ckyc_details
{
    public string? ckyc_number { get; set; }
    public string? dob { get; set; }
}
public class aadhaar_details
{
    public string? aadhaar_number { get; set; }
    public string? full_name { get; set; }
    public DateTime dob { get; set; }
    public string? gender { get; set; }
}
public class cin_details
{
    public string? cin { get; set; }
    public string? doi { get; set; }
}
public class epic_details
{
    public string? epic_number { get; set; }
    public string? dob { get; set; }
}
public class dl_details
{
    public string? dl_number { get; set; }
    public string? dob { get; set; }
}
public class passport_details
{
    public string? file_number { get; set; }
    public string? dob { get; set; }
}