Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports DevExpress.XtraRichEdit.Services

Namespace RichEditImageMailMerge
	Public Class ImageStreamProvider
		Implements IUriStreamProvider
		Private Shared ReadOnly prefix As String = "dbimg://"
		Private table As DataTable
		Private columnName As String

		Public Sub New(ByVal sourceTable As DataTable, ByVal imageColumn As String)
			Me.table = sourceTable
			Me.columnName = imageColumn
		End Sub

		#Region "IUriStreamProvider Members"
		Public Function GetStream(ByVal uri As String) As Stream Implements IUriStreamProvider.GetStream
			uri = uri.Trim()
			If (Not uri.StartsWith(prefix)) Then
				Return Nothing
			End If
			Dim strId As String = uri.Substring(prefix.Length).Trim()
			Dim id As Integer
			If (Not Integer.TryParse(strId, id)) Then
				Return Nothing
			End If
			Dim row As DataRow = table.Rows.Find(id)
			If row Is Nothing Then
				Return Nothing
			End If
			Dim bytes() As Byte = TryCast(row(columnName), Byte())
			If bytes Is Nothing Then
				Return Nothing
			End If

			' Use this approach to trim the OLE header off the image
			' See also: http://www.devexpress.com/issue=Q233460, 
			' http://social.msdn.microsoft.com/Forums/en-US/sqldataaccess/thread/c37289c7-3ca5-458e-8eda-286ffa2ff966/
			Dim memoryStream As New MemoryStream()
			Dim oleHeaderOffset As Integer = 78
			memoryStream.Write(bytes, oleHeaderOffset, bytes.Length - oleHeaderOffset)

			Return memoryStream
		End Function
		#End Region
	End Class
End Namespace