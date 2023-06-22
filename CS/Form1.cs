using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Office.Services;

namespace RichEditImageMailMerge
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            RegisterUriStreamService(richEditControl1);
            richEditControl1.LoadDocument(Application.StartupPath + @"\..\..\" + "MailMergeTemplate.rtf");
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            richEditControl1.Options.MailMerge.DataSource = NorthwindDataProvider.Categories;
            richEditControl1.Options.MailMerge.ViewMergedData = true;

            dataNavigator1.DataSource = NorthwindDataProvider.Categories;
        }
        #region #registerprovider
        private void RegisterUriStreamService(RichEditControl richEditControl)
        {
            IUriStreamService uriStreamService = richEditControl.GetService<IUriStreamService>();
            uriStreamService.RegisterProvider(new ImageStreamProvider(NorthwindDataProvider.Categories, "Picture"));
        }
        #endregion #registerprovider
        #region Mail-merge the document
        private void mergeToNewDocumentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MergeToNewDocument();
        }

        private void MergeToNewDocument()
        {
            MailMergeOptions options = richEditControl1.Document.CreateMailMergeOptions();
            options.MergeMode = MergeMode.NewSection;
            string fileName = System.IO.Directory.GetCurrentDirectory() + @"\..\..\MailMergeResult.rtf";

            richEditControl1.Document.MailMerge(options, fileName, DocumentFormat.Rtf);

            Process.Start(fileName);
        }
        #endregion Mail-merge the document
    }

}