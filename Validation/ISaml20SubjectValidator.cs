using nz.moe.idp.saml.client.Schema.Core;

namespace nz.moe.idp.saml.client.Validation
{
    interface ISaml20SubjectValidator
    {
        void ValidateSubject(Subject subject);
    }
}