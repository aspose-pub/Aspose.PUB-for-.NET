using Aspose.Pub;
using Aspose.Pub.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProgrammingWithDocuments
{
    class EditMetaData
    {
        public static void Run()
        {
            //ExStart: EditMetaData
            string dataDir = RunExamples.GetDataDir_Data();

            string pubFile = dataDir + "document.pub";

            IPubParser parser = PubFactory.CreateParser(pubFile);
            Document document = parser.Parse();

            document.DocumentSummaryInfo.SetCategory("category");
            document.DocumentSummaryInfo.SetCompany("company");
            document.DocumentSummaryInfo.SetLanguage("language");

            document.SummaryInfo.SetComments("comments");
            document.SummaryInfo.SetKeywords("keywords");
            document.SummaryInfo.SetLastAuthor("last author");
            document.SummaryInfo.SetTitle("title");
            document.SummaryInfo.SetSubject("subject");
            //ExEnd: EditMetaData
        }
    }
}
