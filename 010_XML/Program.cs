using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace _010_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XPathDocument("books.xml");

            XPathNavigator navigator = document.CreateNavigator();

            Console.WriteLine("Navigator is readonly. CanEdit = {0}", navigator.CanEdit);

            var xmldoc = new XmlDocument();
            xmldoc.Load("books.xml");

            navigator = xmldoc.CreateNavigator();
            Console.WriteLine("Now you can edit navigator. CanEdit = {0}.", navigator.CanEdit);

            navigator.MoveToChild("ListOfBooks", "");
            navigator.MoveToChild("Book", "");

            navigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>insert_after</InsertAfter>");
            navigator.AppendChild("<AppendChild>append_child</AppendChild>");

            navigator.MoveToNext("Book", "");

            navigator.InsertBefore("<InsertBefore>11111111</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>22222222</InsertAfter>");
            navigator.AppendChild("<AppendChild>33333333</AppendChild>");

            xmldoc.Save("books.xml");
                       

            Console.ReadKey();

        }
    }
}
