using System;
using System.Xml.Serialization;

namespace NZ.MOE.IdP.SAML.Client.Schema.XEnc
{
    /// <summary>
    /// ItemsChoice for Referencelists
    /// </summary>
    [Serializable]
    [XmlType(Namespace=Saml20Constants.XENC, IncludeInSchema=false)]
    public enum ItemsChoiceType3
    {
        /// <summary>
        /// DataReference
        /// </summary>
        DataReference,


        /// <summary>
        /// KeyReference
        /// </summary>
        KeyReference,
    }
}