Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Namespace RichEditImageMailMerge
	Public NotInheritable Class NorthwindDataProvider
		Private Shared connectionString As String = "Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI"

		Private Sub New()
		End Sub
		Shared Sub New()
			Using connection As New SqlConnection(connectionString)
				Dim selectCommand As New SqlCommand("SELECT * FROM Categories", connection)
				Dim da As New SqlDataAdapter(selectCommand)

				categories_Renamed = New DataTable("Categories")

				da.Fill(categories_Renamed)

				categories_Renamed.Constraints.Add("IDPK", categories_Renamed.Columns("CategoryID"), True)

				selectCommand.Dispose()
			End Using
		End Sub

		Private Shared categories_Renamed As DataTable

		Public Shared ReadOnly Property Categories() As DataTable
			Get
				Return categories_Renamed
			End Get
		End Property
	End Class
End Namespace