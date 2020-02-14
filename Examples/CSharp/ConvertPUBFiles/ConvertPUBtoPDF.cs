using Aspose.Pub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ConvertPUBFiles
{
    public class ConvertPUBtoPDF
    {
        public static void Run()
        {
            //ExStart: ConvertPUBtoPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Data();

            string fileName = dataDir + "halloween-flyer.pub";

            var parser = PubFactory.CreateParser(fileName);

            var doc = parser.Parse();

            Aspose.Pub.PubFactory.CreatePdfConverter().ConvertToPdf(doc, dataDir + "result_out.pdf");
            //ExEnd: ConvertPUBtoPDF
        }
    }
}
