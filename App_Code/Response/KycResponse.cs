namespace One.Health.Response.ICICI;
public class KycResponse : IResponse
{
public string? correlationId { get; set; }
public bool? status { get; set; }
public string? statusMessage { get; set; }
public string? message { get; set; }
}
public class kyc_details
{
    public string? il_kyc_ref_no { get; set; }
    public string? certificate_type { get; set; }
    public string? certificate_number { get; set; }
    public string? Certificate_type_poa { get; set; }
    public string? Certificate_number_poa { get; set; }
    public string? first_name { get; set; }
    public string? middle_name { get; set; }
    public string? last_name { get; set; }
    public string? full_name { get; set; }
    public string? gender { get; set; }
    public string? dob { get; set; }
    public string? mobile_number { get; set; }
    public string? email { get; set; }
    public string? ckyc_number { get; set; }
    public Address? permanent_address { get; set; }
    public Address? alternate_address { get; set; }
}

public class Address{
    public string? address_line_1 { get; set; }
    public string? address_line_2 { get; set; }
    public string? address_line_3 { get; set; }
    public int? pin_code { get; set; }
    public string? city { get; set; }
    public string? state { get; set; }
    public string? district { get; set; }
}