namespace Microsoft.PowerShell.Cmdletization.Xml
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml;
    using System.Xml.Serialization;

    [GeneratedCode("sgen", "4.0")]
    internal sealed class InstanceMethodParameterMetadataSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader)
        {
            return xmlReader.IsStartElement("InstanceMethodParameterMetadata", "");
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            return ((XmlSerializationReader1) reader).Read76_Item();
        }

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write76_Item(objectToSerialize);
        }
    }
}

