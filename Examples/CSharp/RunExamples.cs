using CSharp.ConvertPUBFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Aspose.PUB 
            // =====================================================
            // =====================================================

            // ConvertPUBFiles
            // =====================================================            
            ConvertPUBtoPDF.Run();

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
    }
}
