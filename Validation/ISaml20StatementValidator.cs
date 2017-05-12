using NZ.MOE.IdP.SAML.Client.Schema.Core;

namespace NZ.MOE.IdP.SAML.Client.Validation
{
    internal interface ISaml20StatementValidator
    {
        void ValidateStatement(StatementAbstract statement);
    }
}