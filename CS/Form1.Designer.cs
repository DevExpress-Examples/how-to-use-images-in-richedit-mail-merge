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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.mailMergeBar1 = new DevExpress.XtraRichEdit.UI.MailMergeBar();
            this.insertMergeFieldItem1 = new DevExpress.XtraRichEdit.UI.InsertMergeFieldItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleViewMergedDataItem1 = new DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem();
            this.mergeToNewDocumentItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mailMergeBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.insertMergeFieldItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleViewMergedDataItem1,
            this.mergeToNewDocumentItem});
            this.barManager1.MaxItemId = 7;
            // 
            // mailMergeBar1
            // 
            this.mailMergeBar1.DockCol = 0;
            this.mailMergeBar1.DockRow = 0;
            this.mailMergeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mailMergeBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertMergeFieldItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showAllFieldCodesItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showAllFieldResultsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleViewMergedDataItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mergeToNewDocumentItem)});
            this.mailMergeBar1.OptionsBar.MultiLine = true;
            this.mailMergeBar1.OptionsBar.UseWholeRow = true;
            // 
            // insertMergeFieldItem1
            // 
            this.insertMergeFieldItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertMergeFieldItem1.Glyph")));
            this.insertMergeFieldItem1.Id = 0;
            this.insertMergeFieldItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertMergeFieldItem1.LargeGlyph")));
            this.insertMergeFieldItem1.Name = "insertMergeFieldItem1";
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showAllFieldCodesItem1.Glyph")));
            this.showAllFieldCodesItem1.Id = 1;
            this.showAllFieldCodesItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showAllFieldCodesItem1.LargeGlyph")));
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showAllFieldResultsItem1.Glyph")));
            this.showAllFieldResultsItem1.Id = 2;
            this.showAllFieldResultsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showAllFieldResultsItem1.LargeGlyph")));
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleViewMergedDataItem1
            // 
            this.toggleViewMergedDataItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleViewMergedDataItem1.Glyph")));
            this.toggleViewMergedDataItem1.Id = 3;
            this.toggleViewMergedDataItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph")));
            this.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1";
            // 
            // mergeToNewDocumentItem
            // 
            this.mergeToNewDocumentItem.Caption = "Merge to New Document";
            this.mergeToNewDocumentItem.Glyph = ((System.Drawing.Image)(resources.GetObject("mergeToNewDocumentItem.Glyph")));
            this.mergeToNewDocumentItem.Id = 6;
            this.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem";
            toolTipTitleItem1.Text = "Merge to New Document";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.mergeToNewDocumentItem.SuperTip = superToolTip1;
            this.mergeToNewDocumentItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mergeToNewDocumentItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 35);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.insertMergeFieldItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.richEditBarController1.BarItems.Add(this.toggleViewMergedDataItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl1;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(15, 38);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richEditControl1.MenuManager = this.barManager1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(1105, 405);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            this.richEditControl1.DocumentLoaded += new System.EventHandler(this.richEditControl1_DocumentLoaded);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.Location = new System.Drawing.Point(15, 449);
            this.dataNavigator1.Margin = new System.Windows.Forms.Padding(4);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(1104, 30);
            this.dataNavigator1.TabIndex = 4;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 489);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraRichEdit.UI.MailMergeBar mailMergeBar1;
        private DevExpress.XtraRichEdit.UI.InsertMergeFieldItem insertMergeFieldItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem toggleViewMergedDataItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraBars.BarButtonItem mergeToNewDocumentItem;
    }
}

