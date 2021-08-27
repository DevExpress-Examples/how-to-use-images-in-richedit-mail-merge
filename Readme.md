<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611472/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4164)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [ImageStreamProvider.cs](./CS/ImageStreamProvider.cs) (VB: [ImageStreamProvider.vb](./VB/ImageStreamProvider.vb))
* [MergeSimpleDataForm.cs](./CS/MergeSimpleDataForm.cs) (VB: [MergeSimpleDataForm.vb](./VB/MergeSimpleDataForm.vb))
* [NorthwindDataProvider.cs](./CS/NorthwindDataProvider.cs) (VB: [NorthwindDataProvider.vb](./VB/NorthwindDataProvider.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to use images when implementing the mail-merge functionality


<p>This example illustrates how to embed an image into a merge template item when implementing <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument6901"><u>mail-merge</u></a>. </p><p>Generally, a mail-merge template document consists of static text and several <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9714"><u>MERGEFIELD</u></a> fields. However, these fields allow you to merge only textual content into a resulting document. If you wish to add images that are contained in the datasource, define the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9713"><u>INCLUDEPICTURE</u></a> fields somewhere in the template. Here we face a problem because by default an argument specified in the INCLUDEPICTURE field is treated as an URI of an external file. However, we might need to use this parameter differently. For instance, in this particular example we use it to load an image from a database. To implement this custom image extraction mechanism, we need to create and register a custom <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditServicesIUriStreamServicetopic"><u>IUriStreamService Interface</u></a> before calling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_MailMergetopic"><u>RichEditControl.MailMerge Method</u></a>. The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditServicesIUriStreamService_GetStreamtopic"><u>IUriStreamService.GetStream Method</u></a> of this interface will receive an argument specified in the INCLUDEPICTURE field and return an appropriate image stream (we should prepare it based on the passed argument). The last problem we have is how to define an argument so that each merged template item will receive an appropriate image according to the currently merged record. The solution is to use some unique identifier. We just need to define a nested MERGEFIELD in INCLUDEPICTURE for this purpose:</p><p>{ INCLUDEPICTURE "dbimg://{ MERGEFIELD CategoryID }" }</p><p>So, during the mail-merge operation, the IUriStreamProvider.GetStream() method will receive a parameter in the form "dbimg://<id>", where <id> corresponds to the currently merged record. Thus, we can look up an appropriate image in the datasource (it is passed to the IUriStreamProvider implementor's constructor in this example) by using this value.</p><p>Note that the same approach is illustrated in the "Merge Database Records" demo module (see <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9611"><u>Demos in Installation</u></a>). However, we decided to prepare a separate standalone example because understanding of this concept might be not very easy for some of our customers in the context of a complicated demo application.</p><p>To test this example locally, setup a sample "Northwind" database (you can download it from the <a href="https://www.devexpress.com/Support/Center/p/E3662">Master-Detail Mail Merge essential - The simplest implementation</a> code example) in your SQL Server instance.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E3661">Utility for creating a Mail Merge template</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E4004">How to create nested fields programmatically</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3123">How to import HTML files containing images referenced using custom prefix</a></p>

<br/>


