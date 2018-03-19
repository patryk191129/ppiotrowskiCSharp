using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Dictionary
    {

        struct Dict
        {
            public string keyword;
            public List<SurnameData> surnames;
        }


        struct SurnameData
        {
            public string surname;
            public int value;
        }

        List<SurnameData> _surnames;
        List<Dict> _twoElementsDictionary;
        List<Dict> _threeElementsDictionary;


        public int ReturnTwoElementsDictionaryCount()
        {
            return _twoElementsDictionary.Count;
        }

        public int ReturnThreeElementsDictionaryCount()
        {
            return _threeElementsDictionary.Count;
        }

        public List<string> ReturnValues(string name)
        {
            List<string> values = new List<string>();

            if (name.Length < 2 || name.Length > 3)
                return null;

            name = char.ToUpper(name[0]) + name.Substring(1);

            switch(name.Length)
            {
                case 2:
                    values = ReturnDictionaryValues(values, _twoElementsDictionary, name);
                    break;
                case 3:
                    values = ReturnDictionaryValues(values, _threeElementsDictionary, name);
                    break;               
            }

            return values;
        }



        private List<string> ReturnDictionaryValues(List<string> values, List<Dict> dictionary, string name)
        {

            int idx = dictionary.FindIndex(x => x.keyword == name);

            if(idx != -1)
            {
                foreach(SurnameData surnameList in dictionary[idx].surnames)
                    values.Add(surnameList.surname+"     ["+surnameList.value+"]");
            }

            return values;
        }

        public long InitializeDictionary(string fileDirectory)
        {
            var processTime = System.Diagnostics.Stopwatch.StartNew(); 
            string line;
            _surnames = new List<SurnameData>();
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            StreamReader sr = new StreamReader(fileDirectory,enc);
            try
            {
                // Open the text file using a stream reader.
                while ((line = sr.ReadLine()) != null)
                {
                    SurnameData _surnameData = new SurnameData();
                    string[] readedLine = line.Split();
                    _surnameData.value = Int32.Parse(readedLine[0]);
                    _surnameData.surname = readedLine[1];

                    _surnames.Add(_surnameData);
                }
            }
            catch(IOException e)
            {
                Console.Write("Unable to load file");
            }
            catch(FormatException e)
            {
                Console.Write("Invalid file");
            }

            sr.Close();
            processTime.Stop();
            return processTime.ElapsedMilliseconds;
        }

        private void CreateDictionary(List<Dict> dictionary, int elements)
        {
            foreach(SurnameData data in _surnames)
            {

                if (data.surname.Length < elements)
                    continue;

                string tmpKeyword = data.surname.Substring(0, elements);

                int idx = dictionary.FindIndex(x => x.keyword == tmpKeyword);

                if(idx == -1)
                {
                    Dict tmpDict = new Dict();
                    tmpDict.keyword = tmpKeyword;
                    tmpDict.surnames = new List<SurnameData>();
                    SurnameData tmpSurnameData = new SurnameData();
                    tmpSurnameData.surname = data.surname;
                    tmpSurnameData.value = data.value;
                    tmpDict.surnames.Add(tmpSurnameData);
                    dictionary.Add(tmpDict);
                }
                else
                {
                    SurnameData tmpSurnameData = new SurnameData();
                    tmpSurnameData.surname = data.surname;
                    tmpSurnameData.value = data.value;
                    dictionary[idx].surnames.Add(tmpSurnameData);
                }
            }

        }

        public long CreateTwoElementsDictionary()
        {
            var processTime = System.Diagnostics.Stopwatch.StartNew();

            _twoElementsDictionary = new List<Dict>();
            CreateDictionary(_twoElementsDictionary, 2);

            processTime.Stop();
            return processTime.ElapsedMilliseconds;
        }

        public long CreateThreeElementsDictionary()
        {
            var processTime = System.Diagnostics.Stopwatch.StartNew();

            _threeElementsDictionary = new List<Dict>();
            CreateDictionary(_threeElementsDictionary, 3);

            processTime.Stop();
            return processTime.ElapsedMilliseconds;
        }

    }
}
