Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditImageMailMerge
	Public Enum MergeDestination
		NewTab
		File
	End Enum
	Public Enum MergeRecords
		All
		Current
		Selected
		FromInterval
	End Enum

	Partial Public Class MergeSimpleDataForm
		Inherits Form
		Private startIndex_Renamed As Integer = 0
		Private endIndex_Renamed As Integer = -1

		Private mergeRecords_Renamed As MergeRecords
		Private mergeMode_Renamed As MergeMode
		Private mergeDestination_Renamed As MergeDestination

		Public ReadOnly Property StartIndex() As Integer
			Get
				Return Math.Min(startIndex_Renamed, endIndex_Renamed)
			End Get
		End Property
		Public ReadOnly Property EndIndex() As Integer
			Get
				Return Math.Max(startIndex_Renamed, endIndex_Renamed)
			End Get
		End Property

		Public Property MergeDestination() As MergeDestination
			Get
				Return mergeDestination_Renamed
			End Get
			Set(ByVal value As MergeDestination)
				mergeDestination_Renamed = value
			End Set
		End Property
		Public Property MergeMode() As MergeMode
			Get
				Return mergeMode_Renamed
			End Get
			Set(ByVal value As MergeMode)
				mergeMode_Renamed = value
			End Set
		End Property
		Public Property MergeRecords() As MergeRecords
			Get
				Return mergeRecords_Renamed
			End Get
			Set(ByVal value As MergeRecords)
				mergeRecords_Renamed = value
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function GetMergeRecords() As MergeRecords
			Select Case Me.rgMergeRecords.SelectedIndex
				Case 0
					Return MergeRecords.All
				Case 1
					Return MergeRecords.Current
				Case 2
					Return MergeRecords.FromInterval
				Case Else
					Return MergeRecords.All

			End Select
		End Function
		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
			MergeDestination = CType(Me.rgMergeTo.SelectedIndex, MergeDestination)
			MergeMode = CType(Me.rgMergeMode.SelectedIndex, MergeMode)
			MergeRecords = GetMergeRecords()
			If (Not Int32.TryParse(Me.txtFrom.Text, Me.startIndex_Renamed)) Then
				Me.startIndex_Renamed = 0
			End If
			If (Not Int32.TryParse(Me.txtTo.Text, Me.endIndex_Renamed)) Then
				Me.endIndex_Renamed = -1
			End If
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub
		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			Me.Close()
		End Sub
		Private Sub rgMergeRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgMergeRecords.SelectedIndexChanged
			Dim isIntervalSelected As Boolean = rgMergeRecords.SelectedIndex = 2
			txtFrom.Enabled = isIntervalSelected
			txtTo.Enabled = isIntervalSelected
		End Sub
	End Class
End Namespace
