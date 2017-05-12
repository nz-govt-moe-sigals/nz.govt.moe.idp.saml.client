using NZ.MOE.IdP.SAML.Client.Schema.Core;

namespace NZ.MOE.IdP.SAML.Client.Validation
{
    internal interface ISaml20SubjectConfirmationDataValidator
    {
        void ValidateSubjectConfirmationData(SubjectConfirmationData data);
    }
}