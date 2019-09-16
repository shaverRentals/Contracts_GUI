<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_income
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
        Dim KY_Invoice_HeaderLabel As System.Windows.Forms.Label
        Dim Img_Path_CheckLabel As System.Windows.Forms.Label
        Dim Check_Number_IncomeLabel As System.Windows.Forms.Label
        Dim Date_IncomeLabel As System.Windows.Forms.Label
        Dim Amount_IncomeLabel As System.Windows.Forms.Label
        Dim KY_ContractsLabel1 As System.Windows.Forms.Label
        Dim KY_IncomeLabel As System.Windows.Forms.Label
        Me.IncomesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel_Set_Invoice = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_OpenReceipt = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_LinkReceipt = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Income = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Save_Income = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_AddIncome = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KY_Invoice_HeaderTextBox = New System.Windows.Forms.TextBox()
        Me.Img_Path_CheckTextBox = New System.Windows.Forms.TextBox()
        Me.Check_Number_IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.Date_IncomeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Amount_IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.KY_ContractsTextBox = New System.Windows.Forms.TextBox()
        Me.KY_IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox_Name_Invoice_Header = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_InvoiceHeader = New System.Windows.Forms.ComboBox()
        Me.ListView_Income = New System.Windows.Forms.ListView()
        Me.Label_Select_Contract = New System.Windows.Forms.Label()
        Me.ComboBox_Contracts_Select = New System.Windows.Forms.ComboBox()
        Me.Label_FilterBy = New System.Windows.Forms.Label()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.TextBox_ContractName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        KY_Invoice_HeaderLabel = New System.Windows.Forms.Label()
        Img_Path_CheckLabel = New System.Windows.Forms.Label()
        Check_Number_IncomeLabel = New System.Windows.Forms.Label()
        Date_IncomeLabel = New System.Windows.Forms.Label()
        Amount_IncomeLabel = New System.Windows.Forms.Label()
        KY_ContractsLabel1 = New System.Windows.Forms.Label()
        KY_IncomeLabel = New System.Windows.Forms.Label()
        CType(Me.IncomesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IncomesBindingSource
        '
        Me.IncomesBindingSource.DataSource = GetType(Contracts.Income)
        '
        'LinkLabel_Set_Invoice
        '
        Me.LinkLabel_Set_Invoice.AutoSize = True
        Me.LinkLabel_Set_Invoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Set_Invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Set_Invoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Set_Invoice.Location = New System.Drawing.Point(138, 379)
        Me.LinkLabel_Set_Invoice.Name = "LinkLabel_Set_Invoice"
        Me.LinkLabel_Set_Invoice.Size = New System.Drawing.Size(84, 15)
        Me.LinkLabel_Set_Invoice.TabIndex = 61
        Me.LinkLabel_Set_Invoice.TabStop = True
        Me.LinkLabel_Set_Invoice.Text = "Link Invoice"
        '
        'LinkLabel_OpenReceipt
        '
        Me.LinkLabel_OpenReceipt.AutoSize = True
        Me.LinkLabel_OpenReceipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_OpenReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_OpenReceipt.Location = New System.Drawing.Point(138, 353)
        Me.LinkLabel_OpenReceipt.Name = "LinkLabel_OpenReceipt"
        Me.LinkLabel_OpenReceipt.Size = New System.Drawing.Size(101, 15)
        Me.LinkLabel_OpenReceipt.TabIndex = 60
        Me.LinkLabel_OpenReceipt.TabStop = True
        Me.LinkLabel_OpenReceipt.Text = "Open Payment"
        '
        'LinkLabel_LinkReceipt
        '
        Me.LinkLabel_LinkReceipt.AutoSize = True
        Me.LinkLabel_LinkReceipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_LinkReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_LinkReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_LinkReceipt.Location = New System.Drawing.Point(138, 329)
        Me.LinkLabel_LinkReceipt.Name = "LinkLabel_LinkReceipt"
        Me.LinkLabel_LinkReceipt.Size = New System.Drawing.Size(102, 15)
        Me.LinkLabel_LinkReceipt.TabIndex = 54
        Me.LinkLabel_LinkReceipt.TabStop = True
        Me.LinkLabel_LinkReceipt.Text = "Link Payement"
        '
        'LinkLabel_Delete_Income
        '
        Me.LinkLabel_Delete_Income.AutoSize = True
        Me.LinkLabel_Delete_Income.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Income.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Income.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Income.Location = New System.Drawing.Point(12, 379)
        Me.LinkLabel_Delete_Income.Name = "LinkLabel_Delete_Income"
        Me.LinkLabel_Delete_Income.Size = New System.Drawing.Size(101, 15)
        Me.LinkLabel_Delete_Income.TabIndex = 43
        Me.LinkLabel_Delete_Income.TabStop = True
        Me.LinkLabel_Delete_Income.Text = "Delete Income"
        '
        'LinkLabel_Save_Income
        '
        Me.LinkLabel_Save_Income.AutoSize = True
        Me.LinkLabel_Save_Income.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Income.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Income.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Income.Location = New System.Drawing.Point(12, 353)
        Me.LinkLabel_Save_Income.Name = "LinkLabel_Save_Income"
        Me.LinkLabel_Save_Income.Size = New System.Drawing.Size(90, 15)
        Me.LinkLabel_Save_Income.TabIndex = 42
        Me.LinkLabel_Save_Income.TabStop = True
        Me.LinkLabel_Save_Income.Text = "Save Income"
        '
        'LinkLabel_AddIncome
        '
        Me.LinkLabel_AddIncome.AutoSize = True
        Me.LinkLabel_AddIncome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_AddIncome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_AddIncome.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_AddIncome.Location = New System.Drawing.Point(12, 329)
        Me.LinkLabel_AddIncome.Name = "LinkLabel_AddIncome"
        Me.LinkLabel_AddIncome.Size = New System.Drawing.Size(83, 15)
        Me.LinkLabel_AddIncome.TabIndex = 41
        Me.LinkLabel_AddIncome.TabStop = True
        Me.LinkLabel_AddIncome.Text = "Add Income"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(1, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1182, 110)
        Me.Label4.TabIndex = 40
        '
        'KY_Invoice_HeaderTextBox
        '
        Me.KY_Invoice_HeaderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "KY_Invoice_Header", True))
        Me.KY_Invoice_HeaderTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Invoice_HeaderTextBox.Location = New System.Drawing.Point(540, 236)
        Me.KY_Invoice_HeaderTextBox.Name = "KY_Invoice_HeaderTextBox"
        Me.KY_Invoice_HeaderTextBox.Size = New System.Drawing.Size(49, 23)
        Me.KY_Invoice_HeaderTextBox.TabIndex = 39
        '
        'Img_Path_CheckTextBox
        '
        Me.Img_Path_CheckTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "Img_Path_Check", True))
        Me.Img_Path_CheckTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Img_Path_CheckTextBox.Location = New System.Drawing.Point(118, 207)
        Me.Img_Path_CheckTextBox.Name = "Img_Path_CheckTextBox"
        Me.Img_Path_CheckTextBox.Size = New System.Drawing.Size(471, 23)
        Me.Img_Path_CheckTextBox.TabIndex = 38
        '
        'Check_Number_IncomeTextBox
        '
        Me.Check_Number_IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "Check_Number_Income", True))
        Me.Check_Number_IncomeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Number_IncomeTextBox.Location = New System.Drawing.Point(118, 178)
        Me.Check_Number_IncomeTextBox.Name = "Check_Number_IncomeTextBox"
        Me.Check_Number_IncomeTextBox.Size = New System.Drawing.Size(471, 23)
        Me.Check_Number_IncomeTextBox.TabIndex = 37
        '
        'Date_IncomeDateTimePicker
        '
        Me.Date_IncomeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IncomesBindingSource, "Date_Income", True))
        Me.Date_IncomeDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_IncomeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_IncomeDateTimePicker.Location = New System.Drawing.Point(118, 149)
        Me.Date_IncomeDateTimePicker.Name = "Date_IncomeDateTimePicker"
        Me.Date_IncomeDateTimePicker.Size = New System.Drawing.Size(471, 23)
        Me.Date_IncomeDateTimePicker.TabIndex = 36
        '
        'Amount_IncomeTextBox
        '
        Me.Amount_IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "Amount_Income", True))
        Me.Amount_IncomeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_IncomeTextBox.Location = New System.Drawing.Point(118, 119)
        Me.Amount_IncomeTextBox.Name = "Amount_IncomeTextBox"
        Me.Amount_IncomeTextBox.Size = New System.Drawing.Size(471, 23)
        Me.Amount_IncomeTextBox.TabIndex = 35
        '
        'KY_ContractsTextBox
        '
        Me.KY_ContractsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "KY_Contracts", True))
        Me.KY_ContractsTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsTextBox.Location = New System.Drawing.Point(540, 61)
        Me.KY_ContractsTextBox.Name = "KY_ContractsTextBox"
        Me.KY_ContractsTextBox.Size = New System.Drawing.Size(49, 23)
        Me.KY_ContractsTextBox.TabIndex = 34
        '
        'KY_IncomeTextBox
        '
        Me.KY_IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomesBindingSource, "KY_Income", True))
        Me.KY_IncomeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_IncomeTextBox.Location = New System.Drawing.Point(117, 90)
        Me.KY_IncomeTextBox.Name = "KY_IncomeTextBox"
        Me.KY_IncomeTextBox.Size = New System.Drawing.Size(472, 23)
        Me.KY_IncomeTextBox.TabIndex = 33
        '
        'TextBox_Name_Invoice_Header
        '
        Me.TextBox_Name_Invoice_Header.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Invoice_Header.Location = New System.Drawing.Point(118, 236)
        Me.TextBox_Name_Invoice_Header.Name = "TextBox_Name_Invoice_Header"
        Me.TextBox_Name_Invoice_Header.Size = New System.Drawing.Size(416, 23)
        Me.TextBox_Name_Invoice_Header.TabIndex = 30
        '
        'KY_Invoice_HeaderLabel
        '
        KY_Invoice_HeaderLabel.AutoSize = True
        KY_Invoice_HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_Invoice_HeaderLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_Invoice_HeaderLabel.Location = New System.Drawing.Point(51, 250)
        KY_Invoice_HeaderLabel.Name = "KY_Invoice_HeaderLabel"
        KY_Invoice_HeaderLabel.Size = New System.Drawing.Size(58, 15)
        KY_Invoice_HeaderLabel.TabIndex = 28
        KY_Invoice_HeaderLabel.Text = "Invoice:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(537, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Select Invoice:"
        '
        'ComboBox_InvoiceHeader
        '
        Me.ComboBox_InvoiceHeader.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_InvoiceHeader.FormattingEnabled = True
        Me.ComboBox_InvoiceHeader.Location = New System.Drawing.Point(646, 8)
        Me.ComboBox_InvoiceHeader.Name = "ComboBox_InvoiceHeader"
        Me.ComboBox_InvoiceHeader.Size = New System.Drawing.Size(520, 23)
        Me.ComboBox_InvoiceHeader.TabIndex = 27
        '
        'ListView_Income
        '
        Me.ListView_Income.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Income.FullRowSelect = True
        Me.ListView_Income.GridLines = True
        Me.ListView_Income.Location = New System.Drawing.Point(611, 53)
        Me.ListView_Income.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Income.Name = "ListView_Income"
        Me.ListView_Income.Size = New System.Drawing.Size(555, 246)
        Me.ListView_Income.TabIndex = 25
        Me.ListView_Income.UseCompatibleStateImageBehavior = False
        Me.ListView_Income.View = System.Windows.Forms.View.Details
        '
        'Label_Select_Contract
        '
        Me.Label_Select_Contract.AutoSize = True
        Me.Label_Select_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contract.Location = New System.Drawing.Point(214, 9)
        Me.Label_Select_Contract.Name = "Label_Select_Contract"
        Me.Label_Select_Contract.Size = New System.Drawing.Size(114, 15)
        Me.Label_Select_Contract.TabIndex = 24
        Me.Label_Select_Contract.Text = "Select Contract:"
        '
        'ComboBox_Contracts_Select
        '
        Me.ComboBox_Contracts_Select.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contracts_Select.FormattingEnabled = True
        Me.ComboBox_Contracts_Select.Location = New System.Drawing.Point(335, 6)
        Me.ComboBox_Contracts_Select.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Contracts_Select.Name = "ComboBox_Contracts_Select"
        Me.ComboBox_Contracts_Select.Size = New System.Drawing.Size(195, 23)
        Me.ComboBox_Contracts_Select.TabIndex = 23
        '
        'Label_FilterBy
        '
        Me.Label_FilterBy.AutoSize = True
        Me.Label_FilterBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_FilterBy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FilterBy.Location = New System.Drawing.Point(-2, 9)
        Me.Label_FilterBy.Name = "Label_FilterBy"
        Me.Label_FilterBy.Size = New System.Drawing.Size(68, 15)
        Me.Label_FilterBy.TabIndex = 22
        Me.Label_FilterBy.Text = "Filter By: "
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(73, 6)
        Me.ComboBox_Filter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(134, 23)
        Me.ComboBox_Filter.TabIndex = 14
        '
        'Img_Path_CheckLabel
        '
        Img_Path_CheckLabel.AutoSize = True
        Img_Path_CheckLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Img_Path_CheckLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Img_Path_CheckLabel.Location = New System.Drawing.Point(27, 223)
        Img_Path_CheckLabel.Name = "Img_Path_CheckLabel"
        Img_Path_CheckLabel.Size = New System.Drawing.Size(85, 15)
        Img_Path_CheckLabel.TabIndex = 12
        Img_Path_CheckLabel.Text = "Check Path:"
        '
        'Check_Number_IncomeLabel
        '
        Check_Number_IncomeLabel.AutoSize = True
        Check_Number_IncomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Check_Number_IncomeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Check_Number_IncomeLabel.Location = New System.Drawing.Point(10, 190)
        Check_Number_IncomeLabel.Name = "Check_Number_IncomeLabel"
        Check_Number_IncomeLabel.Size = New System.Drawing.Size(107, 15)
        Check_Number_IncomeLabel.TabIndex = 10
        Check_Number_IncomeLabel.Text = "Check Number:"
        '
        'Date_IncomeLabel
        '
        Date_IncomeLabel.AutoSize = True
        Date_IncomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_IncomeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_IncomeLabel.Location = New System.Drawing.Point(19, 155)
        Date_IncomeLabel.Name = "Date_IncomeLabel"
        Date_IncomeLabel.Size = New System.Drawing.Size(93, 15)
        Date_IncomeLabel.TabIndex = 8
        Date_IncomeLabel.Text = "Date Income:"
        '
        'Amount_IncomeLabel
        '
        Amount_IncomeLabel.AutoSize = True
        Amount_IncomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Amount_IncomeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_IncomeLabel.Location = New System.Drawing.Point(51, 122)
        Amount_IncomeLabel.Name = "Amount_IncomeLabel"
        Amount_IncomeLabel.Size = New System.Drawing.Size(61, 15)
        Amount_IncomeLabel.TabIndex = 6
        Amount_IncomeLabel.Text = "Amount:"
        '
        'TextBox_ContractName
        '
        Me.TextBox_ContractName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ContractName.Location = New System.Drawing.Point(118, 61)
        Me.TextBox_ContractName.Name = "TextBox_ContractName"
        Me.TextBox_ContractName.Size = New System.Drawing.Size(416, 23)
        Me.TextBox_ContractName.TabIndex = 6
        '
        'KY_ContractsLabel1
        '
        KY_ContractsLabel1.AutoSize = True
        KY_ContractsLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_ContractsLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_ContractsLabel1.Location = New System.Drawing.Point(10, 64)
        KY_ContractsLabel1.Name = "KY_ContractsLabel1"
        KY_ContractsLabel1.Size = New System.Drawing.Size(110, 15)
        KY_ContractsLabel1.TabIndex = 4
        KY_ContractsLabel1.Text = "Contract Name:"
        '
        'KY_IncomeLabel
        '
        KY_IncomeLabel.AutoSize = True
        KY_IncomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_IncomeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_IncomeLabel.Location = New System.Drawing.Point(36, 91)
        KY_IncomeLabel.Name = "KY_IncomeLabel"
        KY_IncomeLabel.Size = New System.Drawing.Size(76, 15)
        KY_IncomeLabel.TabIndex = 2
        KY_IncomeLabel.Text = "Income ID:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(-13, -12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1196, 52)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(594, 246)
        Me.Label2.TabIndex = 26
        '
        'frm_income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 427)
        Me.Controls.Add(Me.LinkLabel_Set_Invoice)
        Me.Controls.Add(Me.LinkLabel_OpenReceipt)
        Me.Controls.Add(Me.LinkLabel_LinkReceipt)
        Me.Controls.Add(Me.LinkLabel_Delete_Income)
        Me.Controls.Add(Me.LinkLabel_Save_Income)
        Me.Controls.Add(Me.LinkLabel_AddIncome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.KY_Invoice_HeaderTextBox)
        Me.Controls.Add(Me.Img_Path_CheckTextBox)
        Me.Controls.Add(Me.Check_Number_IncomeTextBox)
        Me.Controls.Add(Me.Date_IncomeDateTimePicker)
        Me.Controls.Add(Me.Amount_IncomeTextBox)
        Me.Controls.Add(Me.KY_ContractsTextBox)
        Me.Controls.Add(Me.KY_IncomeTextBox)
        Me.Controls.Add(Me.TextBox_Name_Invoice_Header)
        Me.Controls.Add(KY_Invoice_HeaderLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_InvoiceHeader)
        Me.Controls.Add(Me.ListView_Income)
        Me.Controls.Add(Me.Label_Select_Contract)
        Me.Controls.Add(Me.ComboBox_Contracts_Select)
        Me.Controls.Add(Me.Label_FilterBy)
        Me.Controls.Add(Me.ComboBox_Filter)
        Me.Controls.Add(Img_Path_CheckLabel)
        Me.Controls.Add(Check_Number_IncomeLabel)
        Me.Controls.Add(Date_IncomeLabel)
        Me.Controls.Add(Amount_IncomeLabel)
        Me.Controls.Add(Me.TextBox_ContractName)
        Me.Controls.Add(KY_ContractsLabel1)
        Me.Controls.Add(KY_IncomeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_income"
        Me.Text = "frm_income"
        CType(Me.IncomesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IncomesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox_ContractName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label_FilterBy As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Contracts_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Select_Contract As System.Windows.Forms.Label
    Friend WithEvents ListView_Income As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_InvoiceHeader As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Name_Invoice_Header As System.Windows.Forms.TextBox
    Friend WithEvents KY_IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_IncomeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Check_Number_IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Img_Path_CheckTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_Invoice_HeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_AddIncome As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Income As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Income As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_LinkReceipt As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_OpenReceipt As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Set_Invoice As System.Windows.Forms.LinkLabel
End Class
