using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Office.Services;

namespace RichEditImageMailMerge {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
            RegisterUriStreamService(richEditControl1);
            richEditControl1.LoadDocument(Application.StartupPath + @"\..\..\" + "MailMergeTemplate.rtf");
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e) {
            richEditControl1.Options.MailMerge.DataSource = NorthwindDataProvider.Categories;
            richEditControl1.Options.MailMerge.ViewMergedData = true;

            dataNavigator1.DataSource = NorthwindDataProvider.Categories;
        }
#region #registerprovider
        private void RegisterUriStreamService(RichEditControl richEditControl) {
            IUriStreamService uriStreamService = richEditControl.GetService<IUriStreamService>();
            uriStreamService.RegisterProvider(new ImageStreamProvider(NorthwindDataProvider.Categories, "Picture"));
        }
#endregion #registerprovider
        #region Merge Several Records
        private void mergeToNewDocumentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            MergeToNewDocument();
        }

        private void MergeToNewDocument() {
            MergeSimpleDataForm form = new MergeSimpleDataForm();
            
            if (form.ShowDialog(this) == DialogResult.OK) {
                MailMergeOptions options = richEditControl1.Document.CreateMailMergeOptions();
                
                CalculateMailMergeOptions(form, options);
                options.MergeMode = form.MergeMode;
                
                if (form.MergeDestination == MergeDestination.NewTab)
                    MailMergeToNewControl(options);
                else
                    MailMergeToNewFile(options);
            }
        }

        private void CalculateMailMergeOptions(MergeSimpleDataForm form, MailMergeOptions options) {
            if (form.MergeRecords == MergeRecords.FromInterval) {
                options.FirstRecordIndex = Math.Max(0, ((MergeSimpleDataForm)form).StartIndex - 1);
                options.LastRecordIndex = Math.Min(NorthwindDataProvider.Categories.Rows.Count - 1, ((MergeSimpleDataForm)form).EndIndex - 1);
            }
            else if (form.MergeRecords == MergeRecords.Current) {
                options.FirstRecordIndex = dataNavigator1.Position;
                options.LastRecordIndex = dataNavigator1.Position;
            }
        }

        private void MailMergeToNewControl(MailMergeOptions options) {
            Form form = new Form();
            RichEditControl control = new RichEditControl();

            richEditControl1.Document.MailMerge(options, control.Document);
            
            control.Dock = DockStyle.Fill;

            form.Controls.Add(control);
            form.Show(this);
        }

        private void MailMergeToNewFile(MailMergeOptions options) {
            string fileName = System.IO.Directory.GetCurrentDirectory() + @"\..\..\MailMergeResult.rtf";

            richEditControl1.Document.MailMerge(options, fileName, DocumentFormat.Rtf);

            Process process = new Process();

            process.StartInfo.FileName = fileName;
            process.Start();
        }
        #endregion Merge Several Records
    }
}