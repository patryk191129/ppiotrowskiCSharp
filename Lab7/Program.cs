using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static int Main(string[] args)
        {
            Arguments arguments = new Arguments(args);

            string inputDir = System.IO.Directory.GetCurrentDirectory();
            string outputDir = System.IO.Directory.GetCurrentDirectory();
            string res = "";
            string watermarkName = "";
            int[] imageSize = new int[2];


            if (arguments["inputdir"] != null)
                inputDir = arguments["inputdir"];

            if (arguments["outputdir"] != null)
                outputDir = arguments["outputdir"];
            if (arguments["watermark"] != null)
                watermarkName = arguments["watermark"];


            if (arguments["res"] != null)
            {
                res = arguments["res"];
                Console.WriteLine("PARAMETR "+res);

                string []output = res.Split('x');
               

                try
                {
                    imageSize[0] = int.Parse(output[0]);
                    imageSize[1] = int.Parse(output[1]);
                }
                catch
                {
                    Console.WriteLine("Error: invalid -res arguments\n");
                    return -1;
                }


                CopyImages copyImages = new CopyImages(inputDir, outputDir, watermarkName, imageSize);

            }
            else
            {
                Console.WriteLine("Error: Not found param '-res'\n");
                return -1;
            }

            return 0;
        }
    }
}
