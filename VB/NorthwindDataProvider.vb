Imports System.Data
Imports System.Data.SqlClient

Namespace RichEditImageMailMerge

    Public Module NorthwindDataProvider

        Private connectionString As String = "Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI"

        Sub New()
            Using connection As SqlConnection = New SqlConnection(connectionString)
                Dim selectCommand As SqlCommand = New SqlCommand("SELECT * FROM Categories", connection)
                Dim da As SqlDataAdapter = New SqlDataAdapter(selectCommand)
                categoriesField = New DataTable("Categories")
                da.Fill(categoriesField)
                categoriesField.Constraints.Add("IDPK", categoriesField.Columns("CategoryID"), True)
                selectCommand.Dispose()
            End Using
        End Sub

        Private categoriesField As DataTable

        Public ReadOnly Property Categories As DataTable
            Get
                Return categoriesField
            End Get
        End Property
    End Module
End Namespace
