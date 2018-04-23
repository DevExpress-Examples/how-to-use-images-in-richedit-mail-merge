using System.Data;
using System.Data.SqlClient;

namespace RichEditImageMailMerge {
    public static class NorthwindDataProvider {
        private static string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI";

        static NorthwindDataProvider() {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Categories", connection);
                SqlDataAdapter da = new SqlDataAdapter(selectCommand);

                categories = new DataTable("Categories");

                da.Fill(categories);

                categories.Constraints.Add("IDPK", categories.Columns["CategoryID"], true);
 
                selectCommand.Dispose();
            }
        }

        private static DataTable categories;

        public static DataTable Categories {
            get {
                return categories;
            }
        }
    }
}