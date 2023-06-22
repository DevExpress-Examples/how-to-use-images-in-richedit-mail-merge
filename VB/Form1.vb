Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Office.Services

Namespace RichEditImageMailMerge
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            RegisterUriStreamService(richEditControl1)
            richEditControl1.LoadDocument(Application.StartupPath & "\..\..\" & "MailMergeTemplate.rtf")
        End Sub

        Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.DocumentLoaded
            richEditControl1.Options.MailMerge.DataSource = NorthwindDataProvider.Categories
            richEditControl1.Options.MailMerge.ViewMergedData = True
            dataNavigator1.DataSource = NorthwindDataProvider.Categories
        End Sub

        Private Sub RegisterUriStreamService(ByVal richEditControl As RichEditControl)
            Dim uriStreamService As IUriStreamService = richEditControl.GetService(Of IUriStreamService)()
            uriStreamService.RegisterProvider(New ImageStreamProvider(NorthwindDataProvider.Categories, "Picture"))
        End Sub

        Private Sub mergeToNewDocumentItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeToNewDocumentItem.ItemClick
            MergeToNewDocument()
        End Sub

        Private Sub MergeToNewDocument()
            Dim options As MailMergeOptions = richEditControl1.Document.CreateMailMergeOptions()
            options.MergeMode = MergeMode.NewSection
            Dim fileName As String = System.IO.Directory.GetCurrentDirectory() & "\..\..\MailMergeResult.rtf"
            richEditControl1.Document.MailMerge(options, fileName, DocumentFormat.Rtf)
            Process.Start(fileName)
        End Sub
    End Class
End Namespace
