using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _005_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new XmlTextReader("books.xml");

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("Title"))
                    {
                        Console.WriteLine("<{0}>", reader.GetAttribute("FontSize"));
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
