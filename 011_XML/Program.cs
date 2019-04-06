using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _011_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            XPathExpression expression = navigator.Compile("sum(ListOfBooks/Book/Price/text())");

            Console.WriteLine(expression.ReturnType);

            if (expression.ReturnType == XPathResultType.Number)
            {
                sum = (double)navigator.Evaluate(expression);
                Console.WriteLine(sum);
            }

            sum = (double)navigator.Evaluate("sum(//Price/text())*10");
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
