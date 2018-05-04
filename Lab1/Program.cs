using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {

        static void GenerateHtmlForStrings()
        {
            List<string> stringElements = new List<string>();
            stringElements.Add("Zm1");
            stringElements.Add("Zm2");
            stringElements.Add("Zm3");

            GenerateHTML _generateHTML = new GenerateHTML();
            _generateHTML.AddRow(stringElements);
            _generateHTML.AddRow(stringElements);


            _generateHTML.SaveToFile("index.html");
        }

        static void GenerateHtmlForNumbers()
        {
            List<string> numberElements = new List<string>();
            List<string> numberElements2 = new List<string>();

            //numberElements.Add(30);
            numberElements.Add(55.ToString());

            numberElements2.Add(192.ToString());
            numberElements2.Add(42.55f.ToString());


            GenerateHTML _generateHTML = new GenerateHTML();
            _generateHTML.AddRow(numberElements);
            _generateHTML.AddRow(numberElements2);


            _generateHTML.SaveToFile("index2.html");
        }

        static void GenerateHtmlFromFile()
        {
            GenerateHTML _generateHTML = new GenerateHTML("inputFiles.txt", "index3.html");
        }

        static void GenerateHtmlWithHeaderAndFooter()
        {
            GenerateHTML _generateHTML = new GenerateHTML();

            List<string> headerElements = new List<string>();
            List<string> stringElements = new List<string>();
            List<string> footerElements = new List<string>();
            headerElements.Add("Kolumna1");
            headerElements.Add("Kolumna2");

            footerElements.Add("Stopka1");
            footerElements.Add("Stopka2");

            stringElements.Add("Zm1");
            stringElements.Add("Zm2");


            _generateHTML.AddRow(headerElements,false);

            for(int i=0;i<5;i++)
            {
                _generateHTML.AddRow(stringElements);
            }

            _generateHTML.AddRow(footerElements, true);
            _generateHTML.SaveToFile("index4.html");

        }

        static void Main(string[] args)
        {
            GenerateHtmlForStrings();
            GenerateHtmlForNumbers();
            GenerateHtmlFromFile();
            GenerateHtmlWithHeaderAndFooter();
        }
    }
}
