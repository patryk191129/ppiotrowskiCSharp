using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO.Compression;

namespace Lab3
{
    class PackProjectFiles
    {
        string _fileLocation;
        string _projectDirectory;
        string _copyDirectory;
        string _slnFileName;
        string _copyName = "Kopia";

        List<string> _projDirectories;
        List<string> _csprojList;
        Form1 _form1;



        public PackProjectFiles(string _fileLocation, string _projectDirectory,Form1 _form1)
        {
            this._fileLocation = _fileLocation;
            this._projectDirectory = _projectDirectory;
            this._form1 = _form1;


            _projDirectories = new List<string>();
            _csprojList = new List<string>();


            LoadSlnFile();
            CreateCopyDirectory();

        }


        private void GetSlnFilename(string directory)
        {        
            _slnFileName = Path.GetFileName(directory);
        }

        private void LoadSlnFile()
        { 
            GetSlnFilename(_fileLocation);
            StreamReader sr = new StreamReader(_fileLocation);
            string line = "";

            // Open the text file using a stream reader.
            while ((line = sr.ReadLine()) != null)
            {
                List<string> rowElements = new List<string>();

                string[] readedLine = line.Split();

                //readedLine[2] = lokalizacja plików projektu
                //readedLine[3] = lokalizacja pliku csproj
                if(readedLine[0].Length >= 7 && readedLine[0].Substring(0,7) == "Project")
                {
                    string tmp = readedLine[3].Substring(1, readedLine[3].Length - 3);
                    string tmp2 = readedLine[2].Substring(1, readedLine[2].Length - 3);                    
                    _csprojList.Add(tmp);
                    _projDirectories.Add(tmp2);
                    UpdateLog("Found project: " + tmp);
                }

            }


        }

        private List<string> ReturnProjectFileDirectory(string vcproj)
        {
            List<string> filenames = new List<string>();

            XmlDocument _xlmDocument = new XmlDocument();
            _xlmDocument.Load(vcproj);
            XmlNodeList elemList = _xlmDocument.GetElementsByTagName("Compile");
            XmlAttributeCollection tmp = elemList[0].Attributes;

            for(int i=0;i<elemList.Count;i++)
            {
                filenames.Add(elemList[i].Attributes["Include"].Value);
            }

            return filenames;
        }


        private void CreateCopyDirectory()
        {
            _copyDirectory = _projectDirectory + "//" + _copyName;

            if (!Directory.Exists(_copyDirectory))            
                Directory.CreateDirectory(_copyDirectory);

            string srcFile = "";
            string destFile = "";


            File.Copy(_fileLocation, _copyDirectory + "//" + _slnFileName, true);

                for (int i=0;i< _projDirectories.Count;i++)
                {
                    string _tmpDir = _copyDirectory + "//" + _projDirectories[i];
                    string _vcprojDir = _projectDirectory + "//" +_csprojList[i];

                    if(!Directory.Exists(_tmpDir))
                        Directory.CreateDirectory(_tmpDir);

                    List<string> filenames = ReturnProjectFileDirectory(_vcprojDir);
                    File.Copy(_vcprojDir, _copyDirectory + "//" + _csprojList[i], true);


                    for (int j=0;j<filenames.Count;j++)
                    {
                        srcFile = _projectDirectory + "//"+_projDirectories[i]+ "//" + filenames[j];
                        destFile = _tmpDir + "//" + filenames[j];

                        try
                        {
                        if (!Directory.Exists(Path.GetDirectoryName(destFile)))
                            Directory.CreateDirectory(Path.GetDirectoryName(destFile));    

                            File.Copy(srcFile, destFile, true);
                            UpdateLog("Copied file to: " + destFile);
                        }
                        catch(IOException copyError)
                        {
                            UpdateLog("Error, file " + srcFile + "does not exist");
                        }

                    }
                

                }

            


        }


        private void UpdateLog(string logInfo)
        {
            if (_form1 != null)
                _form1.UpdateServerLog(logInfo);
        }


    }
}
