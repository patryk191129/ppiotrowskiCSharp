using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Lab7
{
    class CopyImages
    {

        string _inputDir;
        string _outputDir;
        string _watermark;
        int[] _imageSize;
        string[] imageExtensions = new string[5] { ".bmp", ".jpg", ".gif", ".tar", ".png" };
        List<string> imageList;
        bool _addWatermark;

        Bitmap _watermarkBmp;


        public CopyImages(string inputDir, string outputDir, string watermark, int[] imageSize)
        {      

            imageList = new List<string>();
            _watermark = watermark;
            _inputDir = inputDir;
            _outputDir = outputDir;
            _imageSize = imageSize;
            _addWatermark = _watermark.Length > 0;

            try
            {
                DirectoryInfo inputDirectory = new DirectoryInfo(inputDir);

                FileInfo []fileInfo = inputDirectory.GetFiles();


                if(_addWatermark)
                {
                    _watermarkBmp =(Bitmap) Image.FromFile(_inputDir + "//" + _watermark);
                    _watermarkBmp = new Bitmap(_watermarkBmp, new Size(_imageSize[0], _imageSize[1]));

                }


                //Dodanie do listy wszystkich plikow graficznych z katalogu
                foreach(FileInfo currentFileInfo in fileInfo)
                {
                    foreach(string currExtension in imageExtensions)
                    {
                        if(currentFileInfo.Extension == currExtension)
                        {
                            imageList.Add(currentFileInfo.Name);
                            break;
                        }
                    }
                }


                foreach(String currentImage in imageList)
                {
                    if (currentImage != _watermark)
                    {
                        Bitmap inputBitmap = (Bitmap)Image.FromFile(_inputDir + "//" + currentImage);
                        Bitmap outputBitmap = new Bitmap(inputBitmap, new Size(_imageSize[0], _imageSize[1]));
                        if (_addWatermark)
                        {
                            Graphics imageGraphics = Graphics.FromImage(outputBitmap);
                            imageGraphics.DrawImage(_watermarkBmp, 0, 0, _watermarkBmp.Width, _watermarkBmp.Height);

                        }


                        SaveImage(outputBitmap, currentImage);
                    }
                }


            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Error: "+e.Message);
            }




        }


        private void SaveImage(Bitmap image, string filename)
        {

            DirectoryInfo outputDirectory = new DirectoryInfo(_outputDir);

            FileInfo[] fileInfo = outputDirectory.GetFiles();

            string nameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
            string fileExtension = Path.GetExtension(filename);

            if(!File.Exists(_outputDir + "//" + filename))
                image.Save(_outputDir + "//" + filename);
            else
            {
                int i = 1;

                while (File.Exists(_outputDir + "//" + nameWithoutExtension + "_" + i + fileExtension))
                    i++;

                image.Save(_outputDir + "//" + nameWithoutExtension + "_" + i + fileExtension);


            }





            




        }



    }
}
