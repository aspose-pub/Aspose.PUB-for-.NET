# Aspose.PUB for .NET

[Aspose.PUB for .NET](https://products.aspose.com/pub/net) is an API to read and convert PUB files to [PDF](https://wiki.fileformat.com/view/pdf/) file format. It facilitates .NET application developers to work with the electronic publication file format (.pub) without the need of installing it on any server or client application. With Aspose.PUB for .NET, you purely focus on your business logic instead of going into the underlying details of the .pub file format. It lets you save time and effort by allowing you to write short and simple lines of code into your applications quickly and easily.
<p align="center">

  <a title="Download complete Aspose.PUB for .NET source code" href="https://github.com/aspose-pub/Aspose.PUB-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

This repository contains [Examples](Examples) project for [Aspose.PUB for .NET](https://products.aspose.com/pub/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Examples](Examples)  | A collection of .NET examples that help you learn the product features

# Process PUB files via .NET API

[Aspose.PUB for .NET](https://products.aspose.com/pub/net) is a simple API that allows to read & convert Microsoft Publisher® (PUB) files to PDF format. It also provides easy to understand interfaces to edit metadata of PUB files.

## PUB File Processing Features

- Read Microsoft Publisher [(PUB) files for conversion to PDF](https://docs.aspose.com/display/pubnet/PUB+to+PDF) format.
- [Read & write metadata of PUB files](https://docs.aspose.com/display/pubnet/Programming+with+Documents#ProgrammingwithDocuments-EditMetaDataofPUBFiles) via API.

## Read PUB Files

**Microsoft Publisher:** PUB

## Save PUB As

**Fixed Layout:** PDF

## Platform Independence

You can use Aspose.PUB for .NET to develop applications in any development environment that targets the .NET platform including .NET Framework, .NET Core & Mono to develop both 32-bit & 64-bit applications.

## Getting Started with Aspose.PUB for .NET

Are you ready to give Aspose.PUB for .NET a try? Simply execute `Install-Package Aspose.PUB` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.PUB for .NET and want to upgrade the version, please execute `Update-Package Aspose.PUB` to get the latest version.

## Convert a Microsoft Publisher File to PDF using C# Code

You can execute below code snippet to see how Aspose.PDF API performs in your own development environment or check the [GitHub Repository](https://github.com/aspose-pub/Aspose.PUB-for-.NET) for other common usage scenarios.

```csharp
var parser = PubFactory.CreateParser(dir + "template.pub");
var doc = parser.Parse();
PubFactory.CreatePdfConvertor().ConvertToPdf(doc, dir + "output.pdf");
```

## Edit Metadata of Microsoft Publisher Files

Following C# code sample shows how to edit the metadata of a Microsoft Publisher file:

```csharp
IPubParser parser = PubFactory.CreateParser(dir + "template.pub");
Document document = parser.Parse();

document.DocumentSummaryInfo.SetCategory("category");
document.DocumentSummaryInfo.SetCompany("company");
document.DocumentSummaryInfo.SetLanguage("language");

document.SummaryInfo.SetComments("comments");
document.SummaryInfo.SetKeywords("keywords");
document.SummaryInfo.SetLastAuthor("last author");
document.SummaryInfo.SetTitle("title");
document.SummaryInfo.SetSubject("subject");
```

## Limitations

At the moment API lacks the support to convert images of PUB file to PDF file. So such images wont show up in the resultant output PDF file. This feature is in our plan to be released with future release.

[Product Page](https://products.aspose.com/pub/net) | [Docs](https://docs.aspose.com/display/pubnet/Home) | [API Reference](https://apireference.aspose.com/pub/net) | [Examples](https://github.com/aspose-pub/Aspose.PUB-for-.NET) | [Blog](https://blog.aspose.com/category/pub/) | [Free Support](https://forum.aspose.com/c/pub) |  [Temporary License](https://purchase.aspose.com/temporary-license)
