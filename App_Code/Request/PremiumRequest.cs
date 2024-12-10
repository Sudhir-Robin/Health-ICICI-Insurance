
using One.Health.CommonEntity;

namespace One.Health.Request.ICICI;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class PremiumRequest : IRequest
    {
        public List<InsuredDetails>? InsuredDetails { get; set; }
        public string? PlanCode { get; set; }
        public string? SubProductCode { get; set; }
        public decimal? SumInsured { get; set; }
        public int? NoOfAdult { get; set; }
        public int? NoOfChildren { get; set; }
        public int? AgeOfEldestMember { get; set; }
        public string? GSTToState { get; set; }
        public decimal? VoluntaryCopaymentPercentage { get; set; }
        public string? PreHospitalization { get; set; }
        public string? PostHospitalization { get; set; }
        public string? PEDWaitingPeriod { get; set; }
        public string? SpecificConditionWaiting { get; set; }
        public decimal? ProposalAnnualIncome { get; set; }
        public string? ZoneUpgradation { get; set; }
        public string? City { get; set; }
        public string? ProposerDOB { get; set; }
        public int? Pincode { get; set; }
        public string? VoluntaryDeductible { get; set; }
        public string? RevisedZone { get; set; }
        public string? ZoneRefiling { get; set; }
        public string? CibilScoreApplicable { get; set; }
        public string? CibilScorePercent { get; set; }
        public string? PEDApplicability { get; set; }
        public string? NCDReduction { get; set; }
        public decimal? ActualDeductible { get; set; }
        public decimal? CrossSellDiscount { get; set; }
        public bool? IsElevate { get; set; }
        public string? PEDWaitingPeriodReduction { get; set; }
        public string? RoomModifier { get; set; }
        public string? JumpStart { get; set; }
        public string? NRIApplicable { get; set; }
        public string? WorldwideWaitingPeriodReduction { get; set; }
        public string? MaternityWaitingPeriodReduction { get; set; }
        public string? GuaranteedSuperBonus { get; set; }
        public string? CrossSellDiscountApplicable { get; set; }
        public string? SalaryCorporateDiscountApplicable { get; set; }
        public string? NRIDiscountApplicable { get; set; }
        public decimal? DiscountInLieuOfCommission { get; set; }
        public string? NetworkAdvantageApplicable { get; set; }
        public string? DiscountInLieuOfCommissionApplicable { get; set; }
        public string? InfiniteCare { get; set; }
        public string? PolicyStartDate { get; set; }
        public string? PolicyEndDate { get; set; }
        public string? BusinessType { get; set; }
        public string? DealId { get; set; }
        public string? Tenure { get; set; }
        public string? CustomerType { get; set; }
        public string? CustomerDetails { get; set; }
        public string? Channel { get; set; }
        public bool? IsPOSDealId { get; set; }
        public string? POSStarttime { get; set; }
        public string? POSEndtime { get; set; }
        public string? IsRegisteredCustomer { get; set; }
        public string? CorrelationId { get; set; }
    }
public class InsuredDetails
    {
        public string? InsuredName { get; set; }
        public string? RelationshipWithApplicant { get; set; }
        public string? Gender { get; set; }
        public string? DateOfBirth { get; set; }
        public decimal? Ageinyears { get; set; }
        public decimal? Weight { get; set; }
        public string? PEDIllness { get; set; }
        public string? PreviousInsurerDetails { get; set; }
        public string? PortabilityWaiver { get; set; }
        public decimal? HeightsInFeets { get; set; }
        public decimal? HeightsInInches { get; set; }
        public string? PortabilityDOJ { get; set; }
        public string? OccupationOfInsured { get; set; }
        public string? PED40Remarks { get; set; }
        public string? PED41Remarks { get; set; }
        public string? VaccinationDate { get; set; }
        public string? PneumococcalVaccine { get; set; }
        public string? PneumococcalApplicable { get; set; }
        public string? PneumococcalDate { get; set; }
        public string? InsuredOccupation { get; set; }
        public decimal? InsuredLoading { get; set; }
        public decimal? PortabilitySI { get; set; }
        public string? InsuredType { get; set; }
        public string? CoverGroups { get; set; }
        public bool? Applicable { get; set; }
        public bool? AddOn1 { get; set; }
        public bool? AddOn3 { get; set; }
        public bool? AddOn9 { get; set; }
        public bool? AddOn10 { get; set; }
        public bool? AddOn11 { get; set; }
        public bool? AddOn12 { get; set; }
        public bool? AddOn5 { get; set; }
        public bool? AddOn6 { get; set; }
        public bool? AddOn7 { get; set; }
        public bool? AddOn8 { get; set; }
        public bool? AddOn4 { get; set; }
        public bool? AddOn2 { get; set; }
        public bool? AddOn13 { get; set; }
        public string? AddOn1SI { get; set; }
        public string? AddOn2SI { get; set; }
        public string? AddOn3SI { get; set; }
        public string? AddOn4SI { get; set; }
        public string? AddOn5SI { get; set; }
        public string? AddOn6SI { get; set; }
        public string? AddOn7SI { get; set; }
        public string? AddOn8SI { get; set; }
        public string? AddOn9SI { get; set; }
        public string? AddOn10SI { get; set; }
        public string? AddOn11SI { get; set; }
        public string? AddOn12SI { get; set; }
        public string? AddOn13SI { get; set; }
        public bool? AddOn14 { get; set; }
        public bool? AddOn15 { get; set; }
        public bool? AddOn16 { get; set; }
        public bool? AddOn17 { get; set; }
        public bool? AddOn18 { get; set; }
        public bool? AddOn19 { get; set; }
        public bool? AddOn20 { get; set; }
        public bool? AddOn21 { get; set; }
        public bool? AddOn22 { get; set; }
        public string? InitialWaitingperiodCI { get; set; }
    }