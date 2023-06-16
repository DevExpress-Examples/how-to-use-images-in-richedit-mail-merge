Namespace RichEditImageMailMerge

    Partial Class MergeSimpleDataForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.rgMergeRecords = New DevExpress.XtraEditors.RadioGroup()
            Me.txtFrom = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.txtTo = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.rgMergeTo = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.rgMergeMode = New DevExpress.XtraEditors.RadioGroup()
            CType((Me.rgMergeRecords.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtFrom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtTo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgMergeTo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgMergeMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' rgMergeRecords
            ' 
            Me.rgMergeRecords.Location = New System.Drawing.Point(17, 38)
            Me.rgMergeRecords.Margin = New System.Windows.Forms.Padding(4)
            Me.rgMergeRecords.Name = "rgMergeRecords"
            Me.rgMergeRecords.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMergeRecords.Properties.Appearance.Options.UseBackColor = True
            Me.rgMergeRecords.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMergeRecords.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Current record"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "From:")})
            Me.rgMergeRecords.Size = New System.Drawing.Size(273, 89)
            Me.rgMergeRecords.TabIndex = 0
            AddHandler Me.rgMergeRecords.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgMergeRecords_SelectedIndexChanged)
            ' 
            ' txtFrom
            ' 
            Me.txtFrom.EditValue = "1"
            Me.txtFrom.Enabled = False
            Me.txtFrom.Location = New System.Drawing.Point(89, 97)
            Me.txtFrom.Margin = New System.Windows.Forms.Padding(4)
            Me.txtFrom.Name = "txtFrom"
            Me.txtFrom.Size = New System.Drawing.Size(75, 22)
            Me.txtFrom.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(187, 101)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(20, 16)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "To:"
            ' 
            ' txtTo
            ' 
            Me.txtTo.EditValue = "10"
            Me.txtTo.Enabled = False
            Me.txtTo.Location = New System.Drawing.Point(216, 97)
            Me.txtTo.Margin = New System.Windows.Forms.Padding(4)
            Me.txtTo.Name = "txtTo"
            Me.txtTo.Size = New System.Drawing.Size(75, 22)
            Me.txtTo.TabIndex = 2
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.LineVisible = True
            Me.labelControl2.Location = New System.Drawing.Point(17, 15)
            Me.labelControl2.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(273, 16)
            Me.labelControl2.TabIndex = 4
            Me.labelControl2.Text = "Merge records"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(191, 273)
            Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 28)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
            ' 
            ' btnOk
            ' 
            Me.btnOk.Location = New System.Drawing.Point(83, 273)
            Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(100, 28)
            Me.btnOk.TabIndex = 4
            Me.btnOk.Text = "OK"
            AddHandler Me.btnOk.Click, New System.EventHandler(AddressOf Me.btnOk_Click)
            ' 
            ' rgMergeTo
            ' 
            Me.rgMergeTo.Location = New System.Drawing.Point(17, 231)
            Me.rgMergeTo.Margin = New System.Windows.Forms.Padding(4)
            Me.rgMergeTo.Name = "rgMergeTo"
            Me.rgMergeTo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMergeTo.Properties.Appearance.Options.UseBackColor = True
            Me.rgMergeTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMergeTo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Window"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "File")})
            Me.rgMergeTo.Size = New System.Drawing.Size(273, 27)
            Me.rgMergeTo.TabIndex = 3
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl3.LineVisible = True
            Me.labelControl3.Location = New System.Drawing.Point(17, 205)
            Me.labelControl3.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(273, 16)
            Me.labelControl3.TabIndex = 9
            Me.labelControl3.Text = "Merge to"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl4.LineVisible = True
            Me.labelControl4.Location = New System.Drawing.Point(17, 135)
            Me.labelControl4.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(273, 16)
            Me.labelControl4.TabIndex = 10
            Me.labelControl4.Text = "Merge mode"
            ' 
            ' rgMergeMode
            ' 
            Me.rgMergeMode.Location = New System.Drawing.Point(17, 164)
            Me.rgMergeMode.Margin = New System.Windows.Forms.Padding(4)
            Me.rgMergeMode.Name = "rgMergeMode"
            Me.rgMergeMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMergeMode.Properties.Appearance.Options.UseBackColor = True
            Me.rgMergeMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMergeMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Paragraph"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Section"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "JoinTables")})
            Me.rgMergeMode.Size = New System.Drawing.Size(273, 27)
            Me.rgMergeMode.TabIndex = 11
            ' 
            ' MergeSimpleDataForm
            ' 
            Me.AcceptButton = Me.btnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(317, 313)
            Me.Controls.Add(Me.rgMergeMode)
            Me.Controls.Add(Me.labelControl4)
            Me.Controls.Add(Me.txtTo)
            Me.Controls.Add(Me.txtFrom)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.rgMergeTo)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.rgMergeRecords)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MergeSimpleDataForm"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Merge Options"
            CType((Me.rgMergeRecords.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtFrom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtTo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgMergeTo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgMergeMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private rgMergeRecords As DevExpress.XtraEditors.RadioGroup

        Private txtFrom As DevExpress.XtraEditors.TextEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private txtTo As DevExpress.XtraEditors.TextEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private btnOk As DevExpress.XtraEditors.SimpleButton

        Private rgMergeTo As DevExpress.XtraEditors.RadioGroup

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private rgMergeMode As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace
