using NZ.MOE.IdP.SAML.Client.Schema.Core;

namespace NZ.MOE.IdP.SAML.Client.Validation
{
    interface ISaml20SubjectValidator
    {
        void ValidateSubject(Subject subject);
    }
}