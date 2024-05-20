using Aspose.Pub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ConvertPUBFiles
{
    public class ConvertPUBtoDifferentFormats
    {
        public static void Run()
        {
            //ExStart: ConvertPUBtoDifferentFormats
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Data();

            string fileName = dataDir + "halloween-flyer.pub";

            var parser = PubFactory.CreateParser(fileName);

            var doc = parser.Parse();

            //Convert to jpg and save result as file "halloween-flyer_out.jpg"
            ConvertToFile(doc, PubExportFormats.Jpg, dataDir + "halloween-flyer_out.jpg");
            //Convert to tiff using file stream and save resultant stream as "halloween-flyer_out.tiff"
            using (FileStream st = File.OpenWrite(dataDir + "halloween-flyer_out.tiff"))
            {
                ConvertToStream(doc, PubExportFormats.Tiff, st);
            }
            //ExEnd: ConvertPUBtoDifferentFormats
        }

        private static void ConvertToFile(Document doc, PubExportFormats exportFormat, string outFileName)
        {
            PubFactory.CreatePubConverter().ConvertToFormat(doc, outFileName, exportFormat);
        }

        private static void ConvertToStream(Document doc, PubExportFormats exportFormat, Stream outStream)
        {
            PubFactory.CreatePubConverter().ConvertToFormat(doc, outStream, exportFormat);
        }
    }
}
