using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _008_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null)
            {
                Formatting = Formatting.Indented,
                IndentChar = '\t',
                Indentation = 1,
                QuoteChar = '\'',                
            };

            xmlWriter.IndentChar = ' ';
            xmlWriter.Indentation = 4;

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            xmlWriter.Close();

            Console.ReadKey();
        }
    }
}
