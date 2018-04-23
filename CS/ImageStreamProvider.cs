using System.IO;
using System.Data;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Office.Services;

namespace RichEditImageMailMerge {
#region #iuristreamprovider
    public class ImageStreamProvider : IUriStreamProvider {
        static readonly string prefix = "dbimg://";
        DataTable table;
        string columnName;

        public ImageStreamProvider(DataTable sourceTable, string imageColumn) {
            this.table = sourceTable;
            this.columnName = imageColumn;
        }


        public Stream GetStream(string uri) {
            uri = uri.Trim();
            if (!uri.StartsWith(prefix))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if (!int.TryParse(strId, out id))
                return null;
            DataRow row = table.Rows.Find(id);
            if (row == null)
                return null;
            byte[] bytes = row[columnName] as byte[];
            if (bytes == null)
                return null;

            // Use this approach to trim the OLE header off the image
            // See also: http://www.devexpress.com/issue=Q233460, 
            // http://social.msdn.microsoft.com/Forums/en-US/sqldataaccess/thread/c37289c7-3ca5-458e-8eda-286ffa2ff966/
            MemoryStream memoryStream = new MemoryStream();
            int oleHeaderOffset = 78;
            memoryStream.Write(bytes, oleHeaderOffset, bytes.Length - oleHeaderOffset);

            return memoryStream;
        }

#endregion #iuristreamprovider
    }
}