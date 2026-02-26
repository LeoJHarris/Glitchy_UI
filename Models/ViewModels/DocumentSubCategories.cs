namespace Glitchy_UI.Models.ViewModels;

/// <summary>
/// Contains predefined sub-categories for each document type based on pharmacy/healthcare professional requirements
/// </summary>
public static class DocumentSubCategories
{
    public static class IdentityAndRegistration
    {
        public const string AHPRARegistration = "AHPRA Registration";
        public const string ProfessionalLicense = "Professional License";
        public const string BoardCertificate = "Board Certificate";
    }

    public static class ProfessionalQualification
    {
        public const string PharmacyDegree = "Pharmacy Degree";
        public const string PostgraduateQualifications = "Postgraduate Qualifications";
        public const string VaccinationAccreditation = "Vaccination Accreditation";
        public const string ImmunisationCertificate = "Immunisation Certificate";
        public const string CompoundingCertificate = "Compounding Certificate";
        public const string DiabetesEducatorCertificate = "Diabetes Educator Certificate";
    }

    public static class ClinicalCertificatesExtendedPractice
    {
        public const string MinorAilmentsAccreditation = "Minor Ailments Accreditation";
        public const string TravelHealthCertification = "Travel Health Certification";
        public const string WoundCareTraining = "Wound Care Training";
    }

    public static class InsuranceAndIndemnity
    {
        public const string ProfessionalIndemnityInsurance = "Professional Indemnity Insurance";
        public const string CertificateOfCurrency = "Certificate of Currency";
        public const string LiabilityCover = "Liability Cover";
    }

    public static class EmploymentWorkforceCredentials
    {
        public const string References = "References";
        public const string LettersOfGoodStanding = "Letters of Good Standing";
        public const string TaxFileNumber = "Tax File Number";
        public const string SuperannuationDetails = "Superannuation Details";
        public const string PoliceCheck = "Police Check";
        public const string WorkingWithChildrenCheck = "Working with Children Check";
        public const string RightToWorkDocumentation = "Right to Work Documentation";
        public const string VisaDocumentation = "Visa Documentation";
    }

    public static class ContinuingProfessionalDevelopment
    {
        public const string CPDLogExport = "CPD Log Export";
        public const string IndividualCPDCertificates = "Individual CPD Certificates";
        public const string AnnualCPDSummary = "Annual CPD Summary";
        public const string MandatoryTrainingCertificates = "Mandatory Training Certificates";
        public const string CPRCertificate = "CPR Certificate";
        public const string FirstAidCertificate = "First Aid Certificate";
    }

    public static class ControlledDrugHighRiskAuthority
    {
        public const string MethadoneAccreditation = "Methadone Accreditation";
        public const string BuprenorphineAccreditation = "Buprenorphine Accreditation";
        public const string S8PortalAccess = "S8 Portal Access";
        public const string SafeScriptAccess = "SafeScript Access";
        public const string QScriptAccess = "QScript Access";
    }

    public static class ComplianceMandatoryTraining
    {
        public const string InfectionControl = "Infection Control";
        public const string PrivacyDataSecurityTraining = "Privacy/Data Security Training";
        public const string ColdChainCertification = "Cold Chain Certification";
        public const string WorkplaceHealthSafety = "Workplace Health & Safety";
        public const string CulturalSafetyTraining = "Cultural Safety Training";
        public const string CybersecurityAwareness = "Cybersecurity Awareness";
    }

    public static class MembershipsProfessionalAffiliations
    {
        public const string PSAMembership = "PSA Membership";
        public const string SHPAMembership = "SHPA Membership";
        public const string GuildMembership = "Guild Membership";
        public const string OtherProfessionalMembership = "Other Professional Membership";
    }
}
