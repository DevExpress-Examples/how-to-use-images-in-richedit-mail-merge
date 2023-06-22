namespace RichEditImageMailMerge {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.insertMergeFieldItem2 = new DevExpress.XtraRichEdit.UI.InsertMergeFieldItem();
            this.showAllFieldCodesItem2 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem2 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleViewMergedDataItem2 = new DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem();
            this.mailingsRibbonPage1 = new DevExpress.XtraRichEdit.UI.MailingsRibbonPage();
            this.mailMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.mergeToNewDocumentItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 193);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richEditControl1.MenuManager = this.ribbonControl1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.richEditControl1.Size = new System.Drawing.Size(1223, 558);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.DocumentLoaded += new System.EventHandler(this.richEditControl1_DocumentLoaded);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.insertMergeFieldItem2,
            this.showAllFieldCodesItem2,
            this.showAllFieldResultsItem2,
            this.toggleViewMergedDataItem2,
            this.mergeToNewDocumentItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mailingsRibbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1223, 193);
            // 
            // insertMergeFieldItem2
            // 
            this.insertMergeFieldItem2.Id = 1;
            this.insertMergeFieldItem2.Name = "insertMergeFieldItem2";
            // 
            // showAllFieldCodesItem2
            // 
            this.showAllFieldCodesItem2.Id = 2;
            this.showAllFieldCodesItem2.Name = "showAllFieldCodesItem2";
            // 
            // showAllFieldResultsItem2
            // 
            this.showAllFieldResultsItem2.Id = 3;
            this.showAllFieldResultsItem2.Name = "showAllFieldResultsItem2";
            // 
            // toggleViewMergedDataItem2
            // 
            this.toggleViewMergedDataItem2.Id = 4;
            this.toggleViewMergedDataItem2.Name = "toggleViewMergedDataItem2";
            // 
            // mailingsRibbonPage1
            // 
            this.mailingsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeRibbonPageGroup1});
            this.mailingsRibbonPage1.Name = "mailingsRibbonPage1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.insertMergeFieldItem2);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem2);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem2);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.toggleViewMergedDataItem2, "P");
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.mergeToNewDocumentItem);
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.insertMergeFieldItem2);
            this.richEditBarController1.BarItems.Add(this.showAllFieldCodesItem2);
            this.richEditBarController1.BarItems.Add(this.showAllFieldResultsItem2);
            this.richEditBarController1.BarItems.Add(this.toggleViewMergedDataItem2);
            this.richEditBarController1.Control = this.richEditControl1;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 751);
            this.dataNavigator1.Margin = new System.Windows.Forms.Padding(4);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(1223, 30);
            this.dataNavigator1.TabIndex = 4;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // mergeToNewDocumentItem
            // 
            this.mergeToNewDocumentItem.Caption = "Merge to New Document";
            this.mergeToNewDocumentItem.Id = 5;
            this.mergeToNewDocumentItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mergeToNewDocumentItem.ImageOptions.SvgImage")));
            this.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem";
            this.mergeToNewDocumentItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mergeToNewDocumentItem_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 781);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraRichEdit.UI.InsertMergeFieldItem insertMergeFieldItem2;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem2;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem2;
        private DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem toggleViewMergedDataItem2;
        private DevExpress.XtraRichEdit.UI.MailingsRibbonPage mailingsRibbonPage1;
        private DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraBars.BarButtonItem mergeToNewDocumentItem;
    }
}

