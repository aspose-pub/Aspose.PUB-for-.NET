using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GettingStarted
{
    class GetBuildVersionInfo
    {
        public static void Run()
        {
            //ExStart: GetBuildVersionInfo
            Console.WriteLine("Assembly Version: {0}", Aspose.Pub.BuildVersionInfo.AssemblyVersion);
            Console.WriteLine("File Version: {0}", Aspose.Pub.BuildVersionInfo.FileVersion);
            Console.WriteLine("Product: {0}", Aspose.Pub.BuildVersionInfo.Product);
            //ExEnd: GetBuildVersionInfo
        }
    }
}
