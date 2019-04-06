using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _007_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("Book");
            xmlWriter.WriteStartAttribute("FontSize");
            xmlWriter.WriteString("8");
            xmlWriter.WriteString("18");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Title-1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            Console.ReadKey();

        }
    }
}
