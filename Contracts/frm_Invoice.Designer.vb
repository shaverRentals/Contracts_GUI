<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Invoice
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
        Dim Invoice_CompleteLabel As System.Windows.Forms.Label
        Dim Desc_InvoiceLabel As System.Windows.Forms.Label
        Dim Date_Invoice_EndLabel As System.Windows.Forms.Label
        Dim Date_Invoice_BeginLabel As System.Windows.Forms.Label
        Dim Date_Invoice_CreatedLabel As System.Windows.Forms.Label
        Dim KY_Invoice_HeaderLabel As System.Windows.Forms.Label
        Me.Invoice_HeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView_Invoices = New System.Windows.Forms.ListView()
        Me.TextBox_Name_Contract = New System.Windows.Forms.TextBox()
        Me.Invoice_CompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.Desc_InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Invoice_EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_Invoice_BeginDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_Invoice_CreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KY_ContractsLabel = New System.Windows.Forms.Label()
        Me.KY_ContractsTextBox = New System.Windows.Forms.TextBox()
        Me.KY_Invoice_HeaderTextBox = New System.Windows.Forms.TextBox()
        Me.Label_Select_Contract = New System.Windows.Forms.Label()
        Me.ComboBox_Contracts_Select = New System.Windows.Forms.ComboBox()
        Me.Label_FilterBy = New System.Windows.Forms.Label()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.Label_Contract_Hours_BG = New System.Windows.Forms.Label()
        Me.Label_Invoice_BG = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Controls_BG = New System.Windows.Forms.Label()
        Me.LinkLabel_Add_Invoice = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Save_Invoice = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Formatted_Title = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_invoice = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Create_Invoice = New System.Windows.Forms.LinkLabel()
        Invoice_CompleteLabel = New System.Windows.Forms.Label()
        Desc_InvoiceLabel = New System.Windows.Forms.Label()
        Date_Invoice_EndLabel = New System.Windows.Forms.Label()
        Date_Invoice_BeginLabel = New System.Windows.Forms.Label()
        Date_Invoice_CreatedLabel = New System.Windows.Forms.Label()
        KY_Invoice_HeaderLabel = New System.Windows.Forms.Label()
        CType(Me.Invoice_HeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Invoice_CompleteLabel
        '
        Invoice_CompleteLabel.AutoSize = True
        Invoice_CompleteLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Invoice_CompleteLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_CompleteLabel.Location = New System.Drawing.Point(45, 252)
        Invoice_CompleteLabel.Name = "Invoice_CompleteLabel"
        Invoice_CompleteLabel.Size = New System.Drawing.Size(128, 15)
        Invoice_CompleteLabel.TabIndex = 31
        Invoice_CompleteLabel.Text = "Invoice Submitted:"
        '
        'Desc_InvoiceLabel
        '
        Desc_InvoiceLabel.AutoSize = True
        Desc_InvoiceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Desc_InvoiceLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_InvoiceLabel.Location = New System.Drawing.Point(87, 227)
        Desc_InvoiceLabel.Name = "Desc_InvoiceLabel"
        Desc_InvoiceLabel.Size = New System.Drawing.Size(90, 15)
        Desc_InvoiceLabel.TabIndex = 30
        Desc_InvoiceLabel.Text = "Invoice Title:"
        '
        'Date_Invoice_EndLabel
        '
        Date_Invoice_EndLabel.AutoSize = True
        Date_Invoice_EndLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_Invoice_EndLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Invoice_EndLabel.Location = New System.Drawing.Point(57, 198)
        Date_Invoice_EndLabel.Name = "Date_Invoice_EndLabel"
        Date_Invoice_EndLabel.Size = New System.Drawing.Size(120, 15)
        Date_Invoice_EndLabel.TabIndex = 29
        Date_Invoice_EndLabel.Text = "Date Invoice End:"
        '
        'Date_Invoice_BeginLabel
        '
        Date_Invoice_BeginLabel.AutoSize = True
        Date_Invoice_BeginLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_Invoice_BeginLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Invoice_BeginLabel.Location = New System.Drawing.Point(45, 167)
        Date_Invoice_BeginLabel.Name = "Date_Invoice_BeginLabel"
        Date_Invoice_BeginLabel.Size = New System.Drawing.Size(132, 15)
        Date_Invoice_BeginLabel.TabIndex = 28
        Date_Invoice_BeginLabel.Text = "Date Invoice Begin:"
        '
        'Date_Invoice_CreatedLabel
        '
        Date_Invoice_CreatedLabel.AutoSize = True
        Date_Invoice_CreatedLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_Invoice_CreatedLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Invoice_CreatedLabel.Location = New System.Drawing.Point(29, 138)
        Date_Invoice_CreatedLabel.Name = "Date_Invoice_CreatedLabel"
        Date_Invoice_CreatedLabel.Size = New System.Drawing.Size(148, 15)
        Date_Invoice_CreatedLabel.TabIndex = 27
        Date_Invoice_CreatedLabel.Text = "Date Invoice Created:"
        '
        'KY_Invoice_HeaderLabel
        '
        KY_Invoice_HeaderLabel.AutoSize = True
        KY_Invoice_HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_Invoice_HeaderLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_Invoice_HeaderLabel.Location = New System.Drawing.Point(102, 77)
        KY_Invoice_HeaderLabel.Name = "KY_Invoice_HeaderLabel"
        KY_Invoice_HeaderLabel.Size = New System.Drawing.Size(75, 15)
        KY_Invoice_HeaderLabel.TabIndex = 25
        KY_Invoice_HeaderLabel.Text = "Invoice ID:"
        '
        'Invoice_HeaderBindingSource
        '
        Me.Invoice_HeaderBindingSource.DataSource = GetType(Contracts.Invoice_Header)
        '
        'ListView_Invoices
        '
        Me.ListView_Invoices.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Invoices.FullRowSelect = True
        Me.ListView_Invoices.GridLines = True
        Me.ListView_Invoices.Location = New System.Drawing.Point(519, 74)
        Me.ListView_Invoices.Name = "ListView_Invoices"
        Me.ListView_Invoices.Size = New System.Drawing.Size(576, 198)
        Me.ListView_Invoices.TabIndex = 35
        Me.ListView_Invoices.UseCompatibleStateImageBehavior = False
        Me.ListView_Invoices.View = System.Windows.Forms.View.Details
        '
        'TextBox_Name_Contract
        '
        Me.TextBox_Name_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Contract.Location = New System.Drawing.Point(183, 103)
        Me.TextBox_Name_Contract.Name = "TextBox_Name_Contract"
        Me.TextBox_Name_Contract.Size = New System.Drawing.Size(250, 23)
        Me.TextBox_Name_Contract.TabIndex = 33
        '
        'Invoice_CompleteCheckBox
        '
        Me.Invoice_CompleteCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Invoice_CompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Invoice_HeaderBindingSource, "Invoice_Complete", True))
        Me.Invoice_CompleteCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_CompleteCheckBox.Location = New System.Drawing.Point(183, 248)
        Me.Invoice_CompleteCheckBox.Name = "Invoice_CompleteCheckBox"
        Me.Invoice_CompleteCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Invoice_CompleteCheckBox.TabIndex = 32
        Me.Invoice_CompleteCheckBox.UseVisualStyleBackColor = False
        '
        'Desc_InvoiceTextBox
        '
        Me.Desc_InvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Invoice_HeaderBindingSource, "Desc_Invoice", True))
        Me.Desc_InvoiceTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_InvoiceTextBox.Location = New System.Drawing.Point(183, 219)
        Me.Desc_InvoiceTextBox.Name = "Desc_InvoiceTextBox"
        Me.Desc_InvoiceTextBox.Size = New System.Drawing.Size(306, 23)
        Me.Desc_InvoiceTextBox.TabIndex = 31
        '
        'Date_Invoice_EndDateTimePicker
        '
        Me.Date_Invoice_EndDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Invoice_HeaderBindingSource, "Date_Invoice_End", True))
        Me.Date_Invoice_EndDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Invoice_EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Invoice_EndDateTimePicker.Location = New System.Drawing.Point(183, 190)
        Me.Date_Invoice_EndDateTimePicker.Name = "Date_Invoice_EndDateTimePicker"
        Me.Date_Invoice_EndDateTimePicker.Size = New System.Drawing.Size(306, 23)
        Me.Date_Invoice_EndDateTimePicker.TabIndex = 30
        '
        'Date_Invoice_BeginDateTimePicker
        '
        Me.Date_Invoice_BeginDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Invoice_HeaderBindingSource, "Date_Invoice_Begin", True))
        Me.Date_Invoice_BeginDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Invoice_BeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Invoice_BeginDateTimePicker.Location = New System.Drawing.Point(183, 161)
        Me.Date_Invoice_BeginDateTimePicker.Name = "Date_Invoice_BeginDateTimePicker"
        Me.Date_Invoice_BeginDateTimePicker.Size = New System.Drawing.Size(306, 23)
        Me.Date_Invoice_BeginDateTimePicker.TabIndex = 29
        '
        'Date_Invoice_CreatedDateTimePicker
        '
        Me.Date_Invoice_CreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Invoice_HeaderBindingSource, "Date_Invoice_Created", True))
        Me.Date_Invoice_CreatedDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Invoice_CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Invoice_CreatedDateTimePicker.Location = New System.Drawing.Point(183, 132)
        Me.Date_Invoice_CreatedDateTimePicker.Name = "Date_Invoice_CreatedDateTimePicker"
        Me.Date_Invoice_CreatedDateTimePicker.Size = New System.Drawing.Size(306, 23)
        Me.Date_Invoice_CreatedDateTimePicker.TabIndex = 28
        '
        'KY_ContractsLabel
        '
        Me.KY_ContractsLabel.AutoSize = True
        Me.KY_ContractsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KY_ContractsLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsLabel.Location = New System.Drawing.Point(67, 106)
        Me.KY_ContractsLabel.Name = "KY_ContractsLabel"
        Me.KY_ContractsLabel.Size = New System.Drawing.Size(110, 15)
        Me.KY_ContractsLabel.TabIndex = 26
        Me.KY_ContractsLabel.Text = "Contract Name:"
        '
        'KY_ContractsTextBox
        '
        Me.KY_ContractsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Invoice_HeaderBindingSource, "KY_Contracts", True))
        Me.KY_ContractsTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsTextBox.Location = New System.Drawing.Point(439, 103)
        Me.KY_ContractsTextBox.Name = "KY_ContractsTextBox"
        Me.KY_ContractsTextBox.Size = New System.Drawing.Size(50, 23)
        Me.KY_ContractsTextBox.TabIndex = 27
        '
        'KY_Invoice_HeaderTextBox
        '
        Me.KY_Invoice_HeaderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Invoice_HeaderBindingSource, "KY_Invoice_Header", True))
        Me.KY_Invoice_HeaderTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Invoice_HeaderTextBox.Location = New System.Drawing.Point(183, 74)
        Me.KY_Invoice_HeaderTextBox.Name = "KY_Invoice_HeaderTextBox"
        Me.KY_Invoice_HeaderTextBox.Size = New System.Drawing.Size(306, 23)
        Me.KY_Invoice_HeaderTextBox.TabIndex = 26
        '
        'Label_Select_Contract
        '
        Me.Label_Select_Contract.AutoSize = True
        Me.Label_Select_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contract.Location = New System.Drawing.Point(384, 9)
        Me.Label_Select_Contract.Name = "Label_Select_Contract"
        Me.Label_Select_Contract.Size = New System.Drawing.Size(114, 15)
        Me.Label_Select_Contract.TabIndex = 24
        Me.Label_Select_Contract.Text = "Select Contract:"
        '
        'ComboBox_Contracts_Select
        '
        Me.ComboBox_Contracts_Select.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contracts_Select.FormattingEnabled = True
        Me.ComboBox_Contracts_Select.Location = New System.Drawing.Point(505, 6)
        Me.ComboBox_Contracts_Select.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Contracts_Select.Name = "ComboBox_Contracts_Select"
        Me.ComboBox_Contracts_Select.Size = New System.Drawing.Size(267, 23)
        Me.ComboBox_Contracts_Select.TabIndex = 23
        '
        'Label_FilterBy
        '
        Me.Label_FilterBy.AutoSize = True
        Me.Label_FilterBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_FilterBy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FilterBy.Location = New System.Drawing.Point(29, 15)
        Me.Label_FilterBy.Name = "Label_FilterBy"
        Me.Label_FilterBy.Size = New System.Drawing.Size(68, 15)
        Me.Label_FilterBy.TabIndex = 22
        Me.Label_FilterBy.Text = "Filter By: "
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(105, 12)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(162, 23)
        Me.ComboBox_Filter.TabIndex = 9
        '
        'Label_Contract_Hours_BG
        '
        Me.Label_Contract_Hours_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Contract_Hours_BG.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contract_Hours_BG.Location = New System.Drawing.Point(-3, -1)
        Me.Label_Contract_Hours_BG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Contract_Hours_BG.Name = "Label_Contract_Hours_BG"
        Me.Label_Contract_Hours_BG.Size = New System.Drawing.Size(1119, 49)
        Me.Label_Contract_Hours_BG.TabIndex = 1
        '
        'Label_Invoice_BG
        '
        Me.Label_Invoice_BG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Invoice_BG.Location = New System.Drawing.Point(8, 60)
        Me.Label_Invoice_BG.Name = "Label_Invoice_BG"
        Me.Label_Invoice_BG.Size = New System.Drawing.Size(490, 229)
        Me.Label_Invoice_BG.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(504, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 229)
        Me.Label1.TabIndex = 36
        '
        'Label_Controls_BG
        '
        Me.Label_Controls_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Controls_BG.Location = New System.Drawing.Point(8, 300)
        Me.Label_Controls_BG.Name = "Label_Controls_BG"
        Me.Label_Controls_BG.Size = New System.Drawing.Size(1096, 97)
        Me.Label_Controls_BG.TabIndex = 37
        '
        'LinkLabel_Add_Invoice
        '
        Me.LinkLabel_Add_Invoice.AutoSize = True
        Me.LinkLabel_Add_Invoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Invoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Invoice.Location = New System.Drawing.Point(12, 312)
        Me.LinkLabel_Add_Invoice.Name = "LinkLabel_Add_Invoice"
        Me.LinkLabel_Add_Invoice.Size = New System.Drawing.Size(82, 15)
        Me.LinkLabel_Add_Invoice.TabIndex = 38
        Me.LinkLabel_Add_Invoice.TabStop = True
        Me.LinkLabel_Add_Invoice.Text = "Add Invoice"
        '
        'LinkLabel_Save_Invoice
        '
        Me.LinkLabel_Save_Invoice.AutoSize = True
        Me.LinkLabel_Save_Invoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Invoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Invoice.Location = New System.Drawing.Point(12, 336)
        Me.LinkLabel_Save_Invoice.Name = "LinkLabel_Save_Invoice"
        Me.LinkLabel_Save_Invoice.Size = New System.Drawing.Size(89, 15)
        Me.LinkLabel_Save_Invoice.TabIndex = 39
        Me.LinkLabel_Save_Invoice.TabStop = True
        Me.LinkLabel_Save_Invoice.Text = "Save Invoice"
        '
        'LinkLabel_Formatted_Title
        '
        Me.LinkLabel_Formatted_Title.AutoSize = True
        Me.LinkLabel_Formatted_Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Formatted_Title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Formatted_Title.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Formatted_Title.Location = New System.Drawing.Point(114, 314)
        Me.LinkLabel_Formatted_Title.Name = "LinkLabel_Formatted_Title"
        Me.LinkLabel_Formatted_Title.Size = New System.Drawing.Size(163, 15)
        Me.LinkLabel_Formatted_Title.TabIndex = 41
        Me.LinkLabel_Formatted_Title.TabStop = True
        Me.LinkLabel_Formatted_Title.Text = "Created Formatted Title"
        '
        'LinkLabel_Delete_invoice
        '
        Me.LinkLabel_Delete_invoice.AutoSize = True
        Me.LinkLabel_Delete_invoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_invoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_invoice.Location = New System.Drawing.Point(12, 367)
        Me.LinkLabel_Delete_invoice.Name = "LinkLabel_Delete_invoice"
        Me.LinkLabel_Delete_invoice.Size = New System.Drawing.Size(100, 15)
        Me.LinkLabel_Delete_invoice.TabIndex = 42
        Me.LinkLabel_Delete_invoice.TabStop = True
        Me.LinkLabel_Delete_invoice.Text = "Delete Invoice"
        '
        'LinkLabel_Create_Invoice
        '
        Me.LinkLabel_Create_Invoice.AutoSize = True
        Me.LinkLabel_Create_Invoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Create_Invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Create_Invoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Create_Invoice.Location = New System.Drawing.Point(118, 338)
        Me.LinkLabel_Create_Invoice.Name = "LinkLabel_Create_Invoice"
        Me.LinkLabel_Create_Invoice.Size = New System.Drawing.Size(102, 15)
        Me.LinkLabel_Create_Invoice.TabIndex = 43
        Me.LinkLabel_Create_Invoice.TabStop = True
        Me.LinkLabel_Create_Invoice.Text = "Create Invoice"
        '
        'frm_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 398)
        Me.Controls.Add(Me.LinkLabel_Create_Invoice)
        Me.Controls.Add(Me.LinkLabel_Delete_invoice)
        Me.Controls.Add(Me.LinkLabel_Formatted_Title)
        Me.Controls.Add(Me.LinkLabel_Save_Invoice)
        Me.Controls.Add(Me.LinkLabel_Add_Invoice)
        Me.Controls.Add(Me.Label_Controls_BG)
        Me.Controls.Add(Me.ListView_Invoices)
        Me.Controls.Add(Me.TextBox_Name_Contract)
        Me.Controls.Add(Invoice_CompleteLabel)
        Me.Controls.Add(Me.Invoice_CompleteCheckBox)
        Me.Controls.Add(Desc_InvoiceLabel)
        Me.Controls.Add(Me.Desc_InvoiceTextBox)
        Me.Controls.Add(Date_Invoice_EndLabel)
        Me.Controls.Add(Me.Date_Invoice_EndDateTimePicker)
        Me.Controls.Add(Date_Invoice_BeginLabel)
        Me.Controls.Add(Me.Date_Invoice_BeginDateTimePicker)
        Me.Controls.Add(Date_Invoice_CreatedLabel)
        Me.Controls.Add(Me.Date_Invoice_CreatedDateTimePicker)
        Me.Controls.Add(Me.KY_ContractsLabel)
        Me.Controls.Add(Me.KY_ContractsTextBox)
        Me.Controls.Add(KY_Invoice_HeaderLabel)
        Me.Controls.Add(Me.KY_Invoice_HeaderTextBox)
        Me.Controls.Add(Me.Label_Select_Contract)
        Me.Controls.Add(Me.ComboBox_Contracts_Select)
        Me.Controls.Add(Me.Label_FilterBy)
        Me.Controls.Add(Me.ComboBox_Filter)
        Me.Controls.Add(Me.Label_Contract_Hours_BG)
        Me.Controls.Add(Me.Label_Invoice_BG)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Invoice"
        Me.Text = "frm_Invoice"
        CType(Me.Invoice_HeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Contract_Hours_BG As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label_FilterBy As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Contracts_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Select_Contract As System.Windows.Forms.Label
    Friend WithEvents Invoice_HeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_Invoice_HeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Invoice_CreatedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_Invoice_BeginDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desc_InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoice_CompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_Name_Contract As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractsLabel As System.Windows.Forms.Label
    Friend WithEvents Date_Invoice_EndDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Invoice_BG As System.Windows.Forms.Label
    Friend WithEvents ListView_Invoices As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_Controls_BG As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Invoice As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Invoice As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Formatted_Title As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_invoice As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Create_Invoice As System.Windows.Forms.LinkLabel
End Class
