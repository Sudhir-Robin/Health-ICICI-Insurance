using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace One.Health.Response.ICICI;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class PremiumResponse : IResponse
{
    public List<ProductResponse>? productResponse { get; set; }
    public string? statusCode { get; set; }
    public string? errorMsg { get; set; }
}

public class DiscountDetails
{
    public string? memberDiscount { get; set; }
    public string? onlineDiscount { get; set; }
    public string? staffDiscount { get; set; }
    public string? medicalPractDiscount { get; set; }
    public string? completeCareDiscount { get; set; }
}

public class Member
{
    public string? dob { get; set; }
    public string? loadingAmount { get; set; }
}

public class ModePremiumBifurcation
{
    public string? netPremium { get; set; }
    public string? grossPremium { get; set; }
    public string? basePremium { get; set; }
    public string? hospitalCashPremium { get; set; }
    public string? personalAccidentPremium { get; set; }
    public string? safeguardPremium { get; set; }
    public string? safeguardPlusPremium { get; set; }
    public string? smartHealthPremium { get; set; }
    public string? diseaseManagementPremium { get; set; }
    public string? acuteCarePremium { get; set; }
    public string? totalUwLoading { get; set; }
    public UwLoading? uwLoading { get; set; }
}

public class PaymentMode
{
    public string? modeOfPayment { get; set; }
    public ModePremiumBifurcation? modePremiumBifurcation { get; set; }
    public DiscountDetails? discountDetails { get; set; }
    public TaxDetails? taxDetails { get; set; }
}

public class PerMemberLoading
{
    public List<Member>? member { get; set; }
}

public class PremiumBifurcation
{
    public string? netPremium { get; set; }
    public string? grossPremium { get; set; }
    public string? basePremium { get; set; }
    public string? hospitalCashPremium { get; set; }
    public string? personalAccidentPremium { get; set; }
    public string? safeguardPremium { get; set; }
    public string? safeguardPlusPremium { get; set; }
    public string? smartHealthPremium { get; set; }
    public string? diseaseManagementPremium { get; set; }
    public string? acuteCarePremium { get; set; }
    public string? totalUwLoading { get; set; }
    public UwLoading? uwLoading { get; set; }
}

public class ProductResponse
{
    public List<Tenure>? tenures { get; set; }
}


public class TaxDetails
{
    public string? gstRate { get; set; }
    public string? gstTaxableAmount { get; set; }
}

public class Tenure
{
    public string? billCycle { get; set; }
    public PremiumBifurcation? premiumBifurcation { get; set; }
    public DiscountDetails? discountDetails { get; set; }
    public TaxDetails? taxDetails { get; set; }
    public List<PaymentMode>? paymentMode { get; set; }
}

public class UwLoading
{
    public List<PerMemberLoading>? perMemberLoading { get; set; }
}

