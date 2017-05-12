using NZ.MOE.IdP.SAML.Client.Schema.Core;
using NZ.MOE.IdP.SAML.Client.Schema.Protocol;

namespace NZ.MOE.IdP.SAML.Client.Validation
{
    internal interface ISaml20AttributeValidator
    {
        void ValidateAttribute(SamlAttribute samlAttribute);
        void ValidateEncryptedAttribute(EncryptedElement encryptedElement);
    }
}