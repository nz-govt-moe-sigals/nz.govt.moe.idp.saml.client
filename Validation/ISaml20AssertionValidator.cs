using System;
using NZ.MOE.IdP.SAML.Client.Schema.Core;

namespace NZ.MOE.IdP.SAML.Client.Validation
{
    internal interface ISaml20AssertionValidator
    {
        void ValidateAssertion(Assertion assertion);
        void ValidateTimeRestrictions(Assertion assertion, TimeSpan allowedClockSkew);
    }
}