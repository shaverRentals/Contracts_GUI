<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Estimated_Tax
    Inherits Contracts.frm_Base_Code

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim KY_Estimated_TaxesLabel As System.Windows.Forms.Label
        Dim Amount_Estimated_TaxLabel As System.Windows.Forms.Label
        Dim Date_Est_Tax_PaidLabel As System.Windows.Forms.Label
        Dim Tax_YearLabel As System.Windows.Forms.Label
        Dim Img_Path_Est_TaxLabel As System.Windows.Forms.Label
        Me.Estimated_Tax_paymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KY_Estimated_TaxesTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_Estimated_TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Est_Tax_PaidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tax_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Cbo_Quarter = New System.Windows.Forms.ComboBox()
        Me.LinkLabel_Add_Est_Tax = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel_Save_Est_Tax = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Est_Tax_Payment = New System.Windows.Forms.LinkLabel()
        Me.ListView_Est_Tax = New System.Windows.Forms.ListView()
        Me.LinkLabel_Link_Est_Tax = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel_Open_Est_Tax = New System.Windows.Forms.LinkLabel()
        Me.Img_Path_Est_TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        KY_Estimated_TaxesLabel = New System.Windows.Forms.Label()
        Amount_Estimated_TaxLabel = New System.Windows.Forms.Label()
        Date_Est_Tax_PaidLabel = New System.Windows.Forms.Label()
        Tax_YearLabel = New System.Windows.Forms.Label()
        Img_Path_Est_TaxLabel = New System.Windows.Forms.Label()
        CType(Me.Estimated_Tax_paymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KY_Estimated_TaxesLabel
        '
        KY_Estimated_TaxesLabel.AutoSize = True
        KY_Estimated_TaxesLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        KY_Estimated_TaxesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_Estimated_TaxesLabel.Location = New System.Drawing.Point(48, 19)
        KY_Estimated_TaxesLabel.Name = "KY_Estimated_TaxesLabel"
        KY_Estimated_TaxesLabel.Size = New System.Drawing.Size(25, 15)
        KY_Estimated_TaxesLabel.TabIndex = 1
        KY_Estimated_TaxesLabel.Text = "ID:"
        '
        'Amount_Estimated_TaxLabel
        '
        Amount_Estimated_TaxLabel.AutoSize = True
        Amount_Estimated_TaxLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Amount_Estimated_TaxLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_Estimated_TaxLabel.Location = New System.Drawing.Point(12, 53)
        Amount_Estimated_TaxLabel.Name = "Amount_Estimated_TaxLabel"
        Amount_Estimated_TaxLabel.Size = New System.Drawing.Size(61, 15)
        Amount_Estimated_TaxLabel.TabIndex = 3
        Amount_Estimated_TaxLabel.Text = "Amount:"
        '
        'Date_Est_Tax_PaidLabel
        '
        Date_Est_Tax_PaidLabel.AutoSize = True
        Date_Est_Tax_PaidLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Date_Est_Tax_PaidLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Est_Tax_PaidLabel.Location = New System.Drawing.Point(31, 85)
        Date_Est_Tax_PaidLabel.Name = "Date_Est_Tax_PaidLabel"
        Date_Est_Tax_PaidLabel.Size = New System.Drawing.Size(42, 15)
        Date_Est_Tax_PaidLabel.TabIndex = 5
        Date_Est_Tax_PaidLabel.Text = "Date:"
        '
        'Tax_YearLabel
        '
        Tax_YearLabel.AutoSize = True
        Tax_YearLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Tax_YearLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tax_YearLabel.Location = New System.Drawing.Point(12, 111)
        Tax_YearLabel.Name = "Tax_YearLabel"
        Tax_YearLabel.Size = New System.Drawing.Size(67, 15)
        Tax_YearLabel.TabIndex = 7
        Tax_YearLabel.Text = "Tax Year:"
        '
        'Img_Path_Est_TaxLabel
        '
        Img_Path_Est_TaxLabel.AutoSize = True
        Img_Path_Est_TaxLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Img_Path_Est_TaxLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Img_Path_Est_TaxLabel.Location = New System.Drawing.Point(32, 175)
        Img_Path_Est_TaxLabel.Name = "Img_Path_Est_TaxLabel"
        Img_Path_Est_TaxLabel.Size = New System.Drawing.Size(41, 15)
        Img_Path_Est_TaxLabel.TabIndex = 55
        Img_Path_Est_TaxLabel.Text = "Path:"
        '
        'Estimated_Tax_paymentsBindingSource
        '
        Me.Estimated_Tax_paymentsBindingSource.DataSource = GetType(Contracts.Estimated_Tax_payments)
        '
        'KY_Estimated_TaxesTextBox
        '
        Me.KY_Estimated_TaxesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Estimated_Tax_paymentsBindingSource, "KY_Estimated_Taxes", True))
        Me.KY_Estimated_TaxesTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Estimated_TaxesTextBox.Location = New System.Drawing.Point(79, 16)
        Me.KY_Estimated_TaxesTextBox.Name = "KY_Estimated_TaxesTextBox"
        Me.KY_Estimated_TaxesTextBox.Size = New System.Drawing.Size(143, 23)
        Me.KY_Estimated_TaxesTextBox.TabIndex = 2
        '
        'Amount_Estimated_TaxTextBox
        '
        Me.Amount_Estimated_TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Estimated_Tax_paymentsBindingSource, "Amount_Estimated_Tax", True))
        Me.Amount_Estimated_TaxTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_Estimated_TaxTextBox.Location = New System.Drawing.Point(79, 45)
        Me.Amount_Estimated_TaxTextBox.Name = "Amount_Estimated_TaxTextBox"
        Me.Amount_Estimated_TaxTextBox.Size = New System.Drawing.Size(143, 23)
        Me.Amount_Estimated_TaxTextBox.TabIndex = 4
        '
        'Date_Est_Tax_PaidDateTimePicker
        '
        Me.Date_Est_Tax_PaidDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Estimated_Tax_paymentsBindingSource, "Date_Est_Tax_Paid", True))
        Me.Date_Est_Tax_PaidDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Est_Tax_PaidDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Est_Tax_PaidDateTimePicker.Location = New System.Drawing.Point(79, 79)
        Me.Date_Est_Tax_PaidDateTimePicker.Name = "Date_Est_Tax_PaidDateTimePicker"
        Me.Date_Est_Tax_PaidDateTimePicker.Size = New System.Drawing.Size(143, 23)
        Me.Date_Est_Tax_PaidDateTimePicker.TabIndex = 6
        '
        'Tax_YearTextBox
        '
        Me.Tax_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Estimated_Tax_paymentsBindingSource, "Tax_Year", True))
        Me.Tax_YearTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tax_YearTextBox.Location = New System.Drawing.Point(79, 108)
        Me.Tax_YearTextBox.Name = "Tax_YearTextBox"
        Me.Tax_YearTextBox.Size = New System.Drawing.Size(143, 23)
        Me.Tax_YearTextBox.TabIndex = 8
        '
        'Cbo_Quarter
        '
        Me.Cbo_Quarter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Quarter.FormattingEnabled = True
        Me.Cbo_Quarter.Location = New System.Drawing.Point(79, 138)
        Me.Cbo_Quarter.Name = "Cbo_Quarter"
        Me.Cbo_Quarter.Size = New System.Drawing.Size(143, 23)
        Me.Cbo_Quarter.TabIndex = 10
        '
        'LinkLabel_Add_Est_Tax
        '
        Me.LinkLabel_Add_Est_Tax.AutoSize = True
        Me.LinkLabel_Add_Est_Tax.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Est_Tax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Est_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Est_Tax.Location = New System.Drawing.Point(12, 297)
        Me.LinkLabel_Add_Est_Tax.Name = "LinkLabel_Add_Est_Tax"
        Me.LinkLabel_Add_Est_Tax.Size = New System.Drawing.Size(187, 15)
        Me.LinkLabel_Add_Est_Tax.TabIndex = 29
        Me.LinkLabel_Add_Est_Tax.TabStop = True
        Me.LinkLabel_Add_Est_Tax.Text = "Add Estimated Tax Payment"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(0, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(672, 135)
        Me.Label2.TabIndex = 30
        '
        'LinkLabel_Save_Est_Tax
        '
        Me.LinkLabel_Save_Est_Tax.AutoSize = True
        Me.LinkLabel_Save_Est_Tax.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Est_Tax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Est_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Est_Tax.Location = New System.Drawing.Point(5, 321)
        Me.LinkLabel_Save_Est_Tax.Name = "LinkLabel_Save_Est_Tax"
        Me.LinkLabel_Save_Est_Tax.Size = New System.Drawing.Size(194, 15)
        Me.LinkLabel_Save_Est_Tax.TabIndex = 31
        Me.LinkLabel_Save_Est_Tax.TabStop = True
        Me.LinkLabel_Save_Est_Tax.Text = "Save Estimated Tax Payment"
        '
        'LinkLabel_Delete_Est_Tax_Payment
        '
        Me.LinkLabel_Delete_Est_Tax_Payment.AutoSize = True
        Me.LinkLabel_Delete_Est_Tax_Payment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Est_Tax_Payment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Est_Tax_Payment.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Est_Tax_Payment.Location = New System.Drawing.Point(5, 346)
        Me.LinkLabel_Delete_Est_Tax_Payment.Name = "LinkLabel_Delete_Est_Tax_Payment"
        Me.LinkLabel_Delete_Est_Tax_Payment.Size = New System.Drawing.Size(217, 15)
        Me.LinkLabel_Delete_Est_Tax_Payment.TabIndex = 32
        Me.LinkLabel_Delete_Est_Tax_Payment.TabStop = True
        Me.LinkLabel_Delete_Est_Tax_Payment.Text = "Delete Estimated Tax Paymment"
        '
        'ListView_Est_Tax
        '
        Me.ListView_Est_Tax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Est_Tax.FullRowSelect = True
        Me.ListView_Est_Tax.GridLines = True
        Me.ListView_Est_Tax.Location = New System.Drawing.Point(246, 1)
        Me.ListView_Est_Tax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Est_Tax.Name = "ListView_Est_Tax"
        Me.ListView_Est_Tax.Size = New System.Drawing.Size(426, 270)
        Me.ListView_Est_Tax.TabIndex = 33
        Me.ListView_Est_Tax.UseCompatibleStateImageBehavior = False
        Me.ListView_Est_Tax.View = System.Windows.Forms.View.Details
        '
        'LinkLabel_Link_Est_Tax
        '
        Me.LinkLabel_Link_Est_Tax.AutoSize = True
        Me.LinkLabel_Link_Est_Tax.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Link_Est_Tax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Link_Est_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Link_Est_Tax.Location = New System.Drawing.Point(5, 370)
        Me.LinkLabel_Link_Est_Tax.Name = "LinkLabel_Link_Est_Tax"
        Me.LinkLabel_Link_Est_Tax.Size = New System.Drawing.Size(197, 15)
        Me.LinkLabel_Link_Est_Tax.TabIndex = 55
        Me.LinkLabel_Link_Est_Tax.TabStop = True
        Me.LinkLabel_Link_Est_Tax.Text = "Link Estimated Tax Payement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Quarter:"
        '
        'LinkLabel_Open_Est_Tax
        '
        Me.LinkLabel_Open_Est_Tax.AutoSize = True
        Me.LinkLabel_Open_Est_Tax.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Open_Est_Tax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Open_Est_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Open_Est_Tax.Location = New System.Drawing.Point(9, 394)
        Me.LinkLabel_Open_Est_Tax.Name = "LinkLabel_Open_Est_Tax"
        Me.LinkLabel_Open_Est_Tax.Size = New System.Drawing.Size(196, 15)
        Me.LinkLabel_Open_Est_Tax.TabIndex = 61
        Me.LinkLabel_Open_Est_Tax.TabStop = True
        Me.LinkLabel_Open_Est_Tax.Text = "Open Estimated Tax Payment"
        '
        'Img_Path_Est_TaxTextBox
        '
        Me.Img_Path_Est_TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Estimated_Tax_paymentsBindingSource, "Img_Path_Est_Tax", True))
        Me.Img_Path_Est_TaxTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Img_Path_Est_TaxTextBox.Location = New System.Drawing.Point(79, 172)
        Me.Img_Path_Est_TaxTextBox.Name = "Img_Path_Est_TaxTextBox"
        Me.Img_Path_Est_TaxTextBox.Size = New System.Drawing.Size(143, 23)
        Me.Img_Path_Est_TaxTextBox.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(8, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 270)
        Me.Label1.TabIndex = 63
        '
        'frm_Estimated_Tax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 420)
        Me.Controls.Add(Me.Img_Path_Est_TaxTextBox)
        Me.Controls.Add(Me.LinkLabel_Open_Est_Tax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Img_Path_Est_TaxLabel)
        Me.Controls.Add(Me.LinkLabel_Link_Est_Tax)
        Me.Controls.Add(Me.ListView_Est_Tax)
        Me.Controls.Add(Me.LinkLabel_Delete_Est_Tax_Payment)
        Me.Controls.Add(Me.LinkLabel_Save_Est_Tax)
        Me.Controls.Add(Me.LinkLabel_Add_Est_Tax)
        Me.Controls.Add(Me.Cbo_Quarter)
        Me.Controls.Add(Tax_YearLabel)
        Me.Controls.Add(Me.Tax_YearTextBox)
        Me.Controls.Add(Date_Est_Tax_PaidLabel)
        Me.Controls.Add(Me.Date_Est_Tax_PaidDateTimePicker)
        Me.Controls.Add(Amount_Estimated_TaxLabel)
        Me.Controls.Add(Me.Amount_Estimated_TaxTextBox)
        Me.Controls.Add(KY_Estimated_TaxesLabel)
        Me.Controls.Add(Me.KY_Estimated_TaxesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Estimated_Tax"
        Me.Text = "Estimated Tax Payments"
        CType(Me.Estimated_Tax_paymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Estimated_Tax_paymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_Estimated_TaxesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_Estimated_TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Est_Tax_PaidDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tax_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_Quarter As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel_Add_Est_Tax As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Save_Est_Tax As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Est_Tax_Payment As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView_Est_Tax As System.Windows.Forms.ListView
    Friend WithEvents LinkLabel_Link_Est_Tax As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Open_Est_Tax As System.Windows.Forms.LinkLabel
    Friend WithEvents Img_Path_Est_TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
