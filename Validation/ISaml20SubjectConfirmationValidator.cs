using nz.moe.idp.saml.client.Schema.Core;

namespace nz.moe.idp.saml.client.Validation
{
    internal interface ISaml20SubjectConfirmationValidator
    {
        void ValidateSubjectConfirmation(SubjectConfirmation subjectConfirmation);
    }
}