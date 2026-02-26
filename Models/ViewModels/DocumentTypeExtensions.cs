namespace Glitchy_UI.Models.ViewModels;

public static class DocumentTypeExtensions
{
    public static string ToDisplayName(this DocumentType type)
    {
        return type switch
        {
            DocumentType.General => "General",
            DocumentType.Medical => "Medical",
            DocumentType.IdentityAndRegistration => "Identity & Registration",
            DocumentType.ProfessionalQualification => "Professional Qualification",
            DocumentType.ClinicalCertificatesExtendedPractice => "Clinical Certificates & Extended Practice",
            DocumentType.InsuranceAndIndemnity => "Insurance & Indemnity",
            DocumentType.EmploymentWorkforceCredentials => "Employment & Workforce Credentials",
            DocumentType.ContinuingProfessionalDevelopment => "Continuing Professional Development (CPD)",
            DocumentType.ControlledDrugHighRiskAuthority => "Controlled Drug & High-Risk Authority",
            DocumentType.ComplianceMandatoryTraining => "Compliance & Mandatory Training",
            DocumentType.MembershipsProfessionalAffiliations => "Memberships & Professional Affiliations",
            _ => "Unknown"
        };
    }

    public static string ToShortDisplayName(this DocumentType type)
    {
        return type switch
        {
            DocumentType.General => "General",
            DocumentType.Medical => "Medical",
            DocumentType.IdentityAndRegistration => "Identity & Registration",
            DocumentType.ProfessionalQualification => "Qualifications",
            DocumentType.ClinicalCertificatesExtendedPractice => "Clinical Certificates",
            DocumentType.InsuranceAndIndemnity => "Insurance",
            DocumentType.EmploymentWorkforceCredentials => "Employment Credentials",
            DocumentType.ContinuingProfessionalDevelopment => "CPD",
            DocumentType.ControlledDrugHighRiskAuthority => "Controlled Drug Authority",
            DocumentType.ComplianceMandatoryTraining => "Compliance Training",
            DocumentType.MembershipsProfessionalAffiliations => "Memberships",
            _ => "Unknown"
        };
    }
}
