using nz.moe.idp.saml.client.Schema.Core;
using nz.moe.idp.saml.client.Schema.Protocol;

namespace nz.moe.idp.saml.client.Validation
{
    internal interface ISaml20NameIDValidator
    {
        void ValidateNameID(NameID nameID);
        void ValidateEncryptedID(EncryptedElement encryptedID);
    }
}