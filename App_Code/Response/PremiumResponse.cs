using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace One.Health.Response.ICICI;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class PremiumResponse : IResponse
{
    public decimal? basicPremium { get; set; }
    public decimal? totalPremium { get; set; }
    public decimal? totalTax { get; set; }
    public string? zone { get; set; }
    public decimal? installmentNetPremium { get; set; }
    public decimal? installmentTaxAmount { get; set; }
    public decimal? installmentTotalPremium { get; set; }
    public string? message { get; set; }
    public bool? status { get; set; }
    public string? statusMessage { get; set; }
    public string? correlationId { get; set; }
}
