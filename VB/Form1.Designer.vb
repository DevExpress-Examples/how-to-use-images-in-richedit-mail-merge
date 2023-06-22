Namespace RichEditImageMailMerge

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.MailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.MailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.InsertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.ShowAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.ShowAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.ToggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.mergeToNewDocumentItem = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.InsertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleViewMergedDataItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            '
            'richEditControl1
            '
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 158)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControl1.MenuManager = Me.RibbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            Me.richEditControl1.Size = New System.Drawing.Size(973, 439)
            Me.richEditControl1.TabIndex = 0
            '
            'RibbonControl1
            '
            Me.RibbonControl1.ExpandCollapseItem.Id = 0
            Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.InsertMergeFieldItem1, Me.ShowAllFieldCodesItem1, Me.ShowAllFieldResultsItem1, Me.ToggleViewMergedDataItem1, Me.mergeToNewDocumentItem})
            Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl1.MaxItemId = 6
            Me.RibbonControl1.Name = "RibbonControl1"
            Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.MailingsRibbonPage1})
            Me.RibbonControl1.Size = New System.Drawing.Size(973, 158)
            '
            'dataNavigator1
            '
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dataNavigator1.Location = New System.Drawing.Point(0, 573)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(973, 24)
            Me.dataNavigator1.TabIndex = 4
            Me.dataNavigator1.Text = "dataNavigator1"
            '
            'RibbonPage2
            '
            Me.RibbonPage2.Name = "RibbonPage2"
            Me.RibbonPage2.Text = "RibbonPage2"
            '
            'MailMergeRibbonPageGroup1
            '
            Me.MailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.InsertMergeFieldItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldCodesItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldResultsItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ToggleViewMergedDataItem1, "P")
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeToNewDocumentItem)
            Me.MailMergeRibbonPageGroup1.Name = "MailMergeRibbonPageGroup1"
            '
            'MailingsRibbonPage1
            '
            Me.MailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.MailMergeRibbonPageGroup1})
            Me.MailingsRibbonPage1.Name = "MailingsRibbonPage1"
            '
            'InsertMergeFieldItem1
            '
            Me.InsertMergeFieldItem1.Id = 1
            Me.InsertMergeFieldItem1.Name = "InsertMergeFieldItem1"
            '
            'ShowAllFieldCodesItem1
            '
            Me.ShowAllFieldCodesItem1.Id = 2
            Me.ShowAllFieldCodesItem1.Name = "ShowAllFieldCodesItem1"
            '
            'ShowAllFieldResultsItem1
            '
            Me.ShowAllFieldResultsItem1.Id = 3
            Me.ShowAllFieldResultsItem1.Name = "ShowAllFieldResultsItem1"
            '
            'ToggleViewMergedDataItem1
            '
            Me.ToggleViewMergedDataItem1.Id = 4
            Me.ToggleViewMergedDataItem1.Name = "ToggleViewMergedDataItem1"
            '
            'mergeToNewDocumentItem
            '
            Me.mergeToNewDocumentItem.Caption = "Merge to New Document"
            Me.mergeToNewDocumentItem.Id = 5
            Me.mergeToNewDocumentItem.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(973, 597)
            Me.Controls.Add(Me.dataNavigator1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.RibbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Ribbon = Me.RibbonControl1
            Me.Text = "Form1"
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
        Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
        Friend WithEvents InsertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Friend WithEvents ShowAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Friend WithEvents ShowAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Friend WithEvents ToggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Friend WithEvents mergeToNewDocumentItem As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents MailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Friend WithEvents MailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
    End Class
End Namespace
