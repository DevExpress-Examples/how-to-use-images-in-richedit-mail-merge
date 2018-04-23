Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Services

Namespace RichEditImageMailMerge
	Partial Public Class Form1
		Inherits Form
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

		#Region "Merge Several Records"
		Private Sub mergeToNewDocumentItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeToNewDocumentItem.ItemClick
			MergeToNewDocument()
		End Sub

		Private Sub MergeToNewDocument()
			Dim form As New MergeSimpleDataForm()

			If form.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Dim options As MailMergeOptions = richEditControl1.Document.CreateMailMergeOptions()

				CalculateMailMergeOptions(form, options)
				options.MergeMode = form.MergeMode

				If form.MergeDestination = MergeDestination.NewTab Then
					MailMergeToNewControl(options)
				Else
					MailMergeToNewFile(options)
				End If
			End If
		End Sub

		Private Sub CalculateMailMergeOptions(ByVal form As MergeSimpleDataForm, ByVal options As MailMergeOptions)
			If form.MergeRecords = MergeRecords.FromInterval Then
				options.FirstRecordIndex = Math.Max(0, (CType(form, MergeSimpleDataForm)).StartIndex - 1)
				options.LastRecordIndex = Math.Min(NorthwindDataProvider.Categories.Rows.Count - 1, (CType(form, MergeSimpleDataForm)).EndIndex - 1)
			ElseIf form.MergeRecords = MergeRecords.Current Then
				options.FirstRecordIndex = dataNavigator1.Position
				options.LastRecordIndex = dataNavigator1.Position
			End If
		End Sub

		Private Sub MailMergeToNewControl(ByVal options As MailMergeOptions)
			Dim form As New Form()
			Dim control As New RichEditControl()

			richEditControl1.Document.MailMerge(options, control.Document)

			control.Dock = DockStyle.Fill

			form.Controls.Add(control)
			form.Show(Me)
		End Sub

		Private Sub MailMergeToNewFile(ByVal options As MailMergeOptions)
			Dim fileName As String = System.IO.Directory.GetCurrentDirectory() & "\..\..\MailMergeResult.rtf"

			richEditControl1.Document.MailMerge(options, fileName, DocumentFormat.Rtf)

			Dim process As New Process()

			process.StartInfo.FileName = fileName
			process.Start()
		End Sub
		#End Region ' Merge Several Records
	End Class
End Namespace