namespace Microsoft.PowerShell.Cmdletization.Xml
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml;
    using System.Xml.Serialization;

    [GeneratedCode("sgen", "4.0")]
    internal sealed class StaticMethodMetadataSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader)
        {
            return xmlReader.IsStartElement("StaticMethodMetadata", "");
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            return ((XmlSerializationReader1) reader).Read72_StaticMethodMetadata();
        }

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write72_StaticMethodMetadata(objectToSerialize);
        }
    }
}

