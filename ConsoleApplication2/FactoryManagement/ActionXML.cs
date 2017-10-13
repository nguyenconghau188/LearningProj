using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FactoryManagement
{
    public static class ActionXML
    {
        public static void CreateXML()
        {
            string contentXML = "<item>" +
                                "<name>wrench</name>" +
                                "<name>salipro</name>" +
                                "</item>";
            XmlDocument docXML = new XmlDocument();
            docXML.LoadXml(contentXML);

            XmlTextWriter writer = new XmlTextWriter("../../data.xml", null);
            writer.Formatting = Formatting.Indented;
            docXML.Save(writer);
        }
    }
}
