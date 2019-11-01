﻿using Aspose.Pub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GettingStarted
{
    class LoadLicense
    {
        public static void Run()
        {
            //LoadLicenseFromFile();

            //LoadLicenseFromStream();
        }

        public static void LoadLicenseFromFile()
        {
            //ExStart: LoadLicenseFromFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Data();

            string fileName = dataDir + "Aspose.PUB.Lic";

            License pubLicense = new License();

            pubLicense.SetLicense(fileName);
            //ExEnd: LoadLicenseFromFile
        }

        public static void LoadLicenseFromStream()
        {
            //ExStart: LoadLicenseFromStream
            // Initialize license object
            License pubLicense = new License();
            // Load license in FileStream
            FileStream myStream = new FileStream("Aspose.PUB.lic", FileMode.Open);
            // Set license
            pubLicense.SetLicense(myStream);
            //ExEnd: LoadLicenseFromStream
        }
    }
}
