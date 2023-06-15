Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
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

    Public Partial Class MergeSimpleDataForm
        Inherits Form

        Private startIndexField As Integer = 0

        Private endIndexField As Integer = -1

        Private mergeRecordsField As MergeRecords

        Private mergeModeField As MergeMode

        Private mergeDestinationField As MergeDestination

        Public ReadOnly Property StartIndex As Integer
            Get
                Return Math.Min(startIndexField, endIndexField)
            End Get
        End Property

        Public ReadOnly Property EndIndex As Integer
            Get
                Return Math.Max(startIndexField, endIndexField)
            End Get
        End Property

        Public Property MergeDestination As MergeDestination
            Get
                Return mergeDestinationField
            End Get

            Set(ByVal value As MergeDestination)
                mergeDestinationField = value
            End Set
        End Property

        Public Property MergeMode As MergeMode
            Get
                Return mergeModeField
            End Get

            Set(ByVal value As MergeMode)
                mergeModeField = value
            End Set
        End Property

        Public Property MergeRecords As MergeRecords
            Get
                Return mergeRecordsField
            End Get

            Set(ByVal value As MergeRecords)
                mergeRecordsField = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function GetMergeRecords() As MergeRecords
            Select Case rgMergeRecords.SelectedIndex
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

        Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs)
            MergeDestination = CType(rgMergeTo.SelectedIndex, MergeDestination)
            MergeMode = CType(rgMergeMode.SelectedIndex, MergeMode)
            MergeRecords = GetMergeRecords()
            If Not Integer.TryParse(txtFrom.Text, startIndexField) Then startIndexField = 0
            If Not Integer.TryParse(txtTo.Text, endIndexField) Then endIndexField = -1
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub rgMergeRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim isIntervalSelected As Boolean = rgMergeRecords.SelectedIndex = 2
            txtFrom.Enabled = isIntervalSelected
            txtTo.Enabled = isIntervalSelected
        End Sub
    End Class
End Namespace
