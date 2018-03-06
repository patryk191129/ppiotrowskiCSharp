using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab1
{
    class GenerateHTML
    {

        #region Zmienne

        List<string> lines = new List<string>();
        bool _addedFooter;
        bool _addedHeader;

        #endregion


        #region Konstruktor

        public GenerateHTML()
        {
            _addedFooter = false;
            _addedHeader = false;
            AddHtmlHeader();
        }

        public GenerateHTML(string inputFile, string outputFile)
        {

            try
            {
                AddHtmlHeader();
                string line;
                StreamReader sr = new StreamReader(inputFile);

                // Open the text file using a stream reader.
                while((line = sr.ReadLine()) != null)
                {
                    List<string> rowElements = new List<string>();

                    string []readedLine = line.Split();

                    foreach (string actualLine in readedLine)
                    {
                        rowElements.Add(actualLine);
                    }
                    AddRow(rowElements);
                }
                SaveToFile(outputFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie można znalezc pliku");
                Console.WriteLine(e.Message);
            }
        }

        #endregion


        #region Metody odpowiedzialne za wstawianie elementów strony

        private void AddHtmlHeader()
        {
            if (!_addedHeader)
            {
                _addedHeader = true;
                lines.Add("<html><head></head><body><table border='1'>");
            }
        }

        private void AddHtmlFooter()
        {
            if (!_addedFooter)
            {
                _addedFooter = true;
                lines.Add("</table></body></html>");
            }

        }

        public void AddRow(List<string> dataElements)
        {
            lines.Add("<tr>");

            foreach(string elements in dataElements)
            {               
                lines.Add("<td>"+elements+"</td>");
            }
                lines.Add("</tr>");
        }

        public void AddRow(List<string> dataElements, bool opt)
        {
            //Opt = 0 nagłowek
            //Opt = 1 stopka

            switch(opt)
            {
                case false:
                    lines.Add("<thead>");
                    AddRow(dataElements);
                    lines.Add("</thead>");
                    break;
                case true:
                    lines.Add("<tfoot>");
                    AddRow(dataElements);
                    lines.Add("</tfoot>");
                    break;
            }

        }


        #endregion


        #region Zapis do pliku

        public void SaveToFile(string filename)
        {
            AddHtmlFooter();

            using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(filename))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        #endregion

    }
}
