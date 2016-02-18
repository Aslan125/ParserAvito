
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace ParserAvito
{
    //author Magomed Dadagov
    
    public class UserCollection<TKey, TValue> :  Dictionary<TKey, TValue>,IXmlSerializable
    {

        public void ReadXml(XmlReader reader)
        {
            XmlSerializer keyDeserializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueDeserializer = new XmlSerializer(typeof(TKey));
            bool wasEmpty = reader.IsEmptyElement;
            if (wasEmpty)
            {
                return;
            }
            reader.ReadStartElement();
            while (reader.NodeType!=XmlNodeType.EndElement)
            {
                
                reader.ReadStartElement("item");
                reader.ReadStartElement("key");
                TKey key = (TKey)keyDeserializer.Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                TValue value = (TValue)valueDeserializer.Deserialize(reader);
                reader.ReadEndElement();
                this.Add(key,value);
                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
            
        }


        public void WriteXml(XmlWriter writer)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            foreach (KeyValuePair<TKey,TValue> pair in this)
            {
                writer.WriteStartElement("item");
                writer.WriteStartElement("key");
                keySerializer.Serialize(writer, pair.Key);
                writer.WriteEndElement();
                writer.WriteStartElement("value");
                valueSerializer.Serialize(writer, pair.Value);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }


            
        }


        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
    }
}
