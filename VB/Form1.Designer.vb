Imports Microsoft.VisualBasic
Imports System
Namespace RichEditImageMailMerge
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.mailMergeBar1 = New DevExpress.XtraRichEdit.UI.MailMergeBar()
			Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
			Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
			Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
			Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
			Me.mergeToNewDocumentItem = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.mailMergeBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.mergeToNewDocumentItem})
			Me.barManager1.MaxItemId = 7
			' 
			' mailMergeBar1
			' 
			Me.mailMergeBar1.DockCol = 0
			Me.mailMergeBar1.DockRow = 0
			Me.mailMergeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.mailMergeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertMergeFieldItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showAllFieldCodesItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showAllFieldResultsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleViewMergedDataItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.mergeToNewDocumentItem)})
			Me.mailMergeBar1.OptionsBar.MultiLine = True
			Me.mailMergeBar1.OptionsBar.UseWholeRow = True
			' 
			' insertMergeFieldItem1
			' 
			Me.insertMergeFieldItem1.Glyph = (CType(resources.GetObject("insertMergeFieldItem1.Glyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Id = 0
			Me.insertMergeFieldItem1.LargeGlyph = (CType(resources.GetObject("insertMergeFieldItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
			' 
			' showAllFieldCodesItem1
			' 
			Me.showAllFieldCodesItem1.Glyph = (CType(resources.GetObject("showAllFieldCodesItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Id = 1
			Me.showAllFieldCodesItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldCodesItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
			' 
			' showAllFieldResultsItem1
			' 
			Me.showAllFieldResultsItem1.Glyph = (CType(resources.GetObject("showAllFieldResultsItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Id = 2
			Me.showAllFieldResultsItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldResultsItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
			' 
			' toggleViewMergedDataItem1
			' 
			Me.toggleViewMergedDataItem1.Glyph = (CType(resources.GetObject("toggleViewMergedDataItem1.Glyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Id = 3
			Me.toggleViewMergedDataItem1.LargeGlyph = (CType(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
			' 
			' mergeToNewDocumentItem
			' 
			Me.mergeToNewDocumentItem.Caption = "Merge to New Document"
			Me.mergeToNewDocumentItem.Glyph = (CType(resources.GetObject("mergeToNewDocumentItem.Glyph"), System.Drawing.Image))
			Me.mergeToNewDocumentItem.Id = 6
			Me.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem"
			toolTipTitleItem1.Text = "Merge to New Document"
			superToolTip1.Items.Add(toolTipTitleItem1)
			Me.mergeToNewDocumentItem.SuperTip = superToolTip1
'			Me.mergeToNewDocumentItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.mergeToNewDocumentItem_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
			Me.barDockControlTop.Size = New System.Drawing.Size(1134, 35)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 489)
			Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1134, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
			Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1134, 35)
			Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl1
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(15, 38)
			Me.richEditControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.richEditControl1.MenuManager = Me.barManager1
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(1105, 405)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.DocumentLoaded += New System.EventHandler(Me.richEditControl1_DocumentLoaded);
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataNavigator1.Buttons.Append.Visible = False
			Me.dataNavigator1.Buttons.CancelEdit.Visible = False
			Me.dataNavigator1.Buttons.EndEdit.Visible = False
			Me.dataNavigator1.Buttons.NextPage.Visible = False
			Me.dataNavigator1.Buttons.PrevPage.Visible = False
			Me.dataNavigator1.Buttons.Remove.Visible = False
			Me.dataNavigator1.Location = New System.Drawing.Point(15, 449)
			Me.dataNavigator1.Margin = New System.Windows.Forms.Padding(4)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(1104, 30)
			Me.dataNavigator1.TabIndex = 4
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1134, 489)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private mailMergeBar1 As DevExpress.XtraRichEdit.UI.MailMergeBar
		Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private WithEvents mergeToNewDocumentItem As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

