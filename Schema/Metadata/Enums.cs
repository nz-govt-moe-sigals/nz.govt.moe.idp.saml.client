using System;
using System.Xml.Serialization;

namespace NZ.MOE.IdP.SAML.Client.Schema.Metadata
{
    /// <summary>
    /// Contact type enum
    /// </summary>
    [Serializable]
    [XmlType(Namespace=Saml20Constants.METADATA)]
    public enum ContactType {


        /// <summary>
        /// technical
        /// </summary>
        technical,


        /// <summary>
        /// support
        /// </summary>
        support,


        /// <summary>
        /// administrative
        /// </summary>
        administrative,


        /// <summary>
        /// billing
        /// </summary>
        billing,


        /// <summary>
        /// other
        /// </summary>
        other,
    }

    /// <summary>
    /// Key types enum
    /// </summary>
    [Serializable]
    [XmlType(Namespace=Saml20Constants.METADATA)]
    public enum KeyTypes
    {
        /// <summary>
        /// encryption
        /// </summary>
        encryption,
        /// <summary>
        /// signing
        /// </summary>
        signing,
    }
}