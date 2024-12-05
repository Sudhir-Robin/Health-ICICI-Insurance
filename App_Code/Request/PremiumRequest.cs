using One.Health.CommonEntity;

namespace One.Health.Request.ICICI;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class PremiumRequest : IRequest
    {
        public PolicyDetails? policyDetails { get; set; }
        public List<MemberDetail>? memberDetails { get; set; }
    }
public class MemberDetail
    {
        public string? dob { get; set; }
        public string? loadingPercentage { get; set; }
        public string? personalAccidentOpted { get; set; }
        public string? dmOpted { get; set; }
        public string? diaPedTenure { get; set; }
        public string? htnPedTenure { get; set; }
        public string? diaLoading { get; set; }
        public string? htnLoading { get; set; }
    }

    public class PolicyDetails
    {
        public string? planId { get; set; }
        public string? billCycle { get; set; }
        public string? safeguardOpted { get; set; }
        public string? safeguardPlusOpted { get; set; }
        public string? discount { get; set; }
        public string? medicalPractDiscount { get; set; }
        public string? premiumCalculationDate { get; set; }
        public string? paymentMode { get; set; }
    }