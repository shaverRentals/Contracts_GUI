<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contracts
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
        Dim Desc_Contract_ServicesLabel As System.Windows.Forms.Label
        Dim Contract_NotesLabel As System.Windows.Forms.Label
        Dim KY_Status_ContractLabel As System.Windows.Forms.Label
        Dim Label_Money_Contract_Total As System.Windows.Forms.Label
        Dim Label_Hours_Contract_Total As System.Windows.Forms.Label
        Dim Label_Date_Contract_End As System.Windows.Forms.Label
        Dim Label_Date_Contract_Begin As System.Windows.Forms.Label
        Dim Name_ContractLabel As System.Windows.Forms.Label
        Me.ContractsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contract_Status_LUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel_OpenContractsFolder = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Create_Contract_Folder = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Mamage_Tasks = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Contract = New System.Windows.Forms.LinkLabel()
        Me.ListView_Contract_Tasks = New System.Windows.Forms.ListView()
        Me.ListView_Contract_Hours = New System.Windows.Forms.ListView()
        Me.LinkLabel_Manage_Contract_Hours = New System.Windows.Forms.LinkLabel()
        Me.Label_Select_Contractee = New System.Windows.Forms.Label()
        Me.ComboBox_Contractee = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Rate_Freq = New System.Windows.Forms.ComboBox()
        Me.Label_Contract_Rate = New System.Windows.Forms.Label()
        Me.ComboBox_Contract_Rate = New System.Windows.Forms.ComboBox()
        Me.KY_ContracteeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Name_Contractee = New System.Windows.Forms.TextBox()
        Me.LinkLabel_Save_Contract = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Add_Contracts = New System.Windows.Forms.LinkLabel()
        Me.Label_Contracts_BG = New System.Windows.Forms.Label()
        Me.Label_KY_Contracts = New System.Windows.Forms.Label()
        Me.KY_Status_ContractComboBox = New System.Windows.Forms.ComboBox()
        Me.Money_Contract_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Hours_Contract_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Contract_EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_Contract_BeginDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Name_ContractTextBox = New System.Windows.Forms.TextBox()
        Me.Label_Name_Contractor = New System.Windows.Forms.Label()
        Me.Label_Select_Comtractor = New System.Windows.Forms.Label()
        Me.Label_FIlter_By = New System.Windows.Forms.Label()
        Me.Label_Select_Contract = New System.Windows.Forms.Label()
        Me.ComboBox_Contracts_Select = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.TextBox_Contractor_Name = New System.Windows.Forms.TextBox()
        Me.KY_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.KY_ContractsTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox_Contractors = New System.Windows.Forms.ComboBox()
        Me.Label_Filters_Background = New System.Windows.Forms.Label()
        Me.Label_BG_RecCounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Desc_Contract_ServicesTextBox = New System.Windows.Forms.TextBox()
        Me.Contract_NotesTextBox = New System.Windows.Forms.TextBox()
        Desc_Contract_ServicesLabel = New System.Windows.Forms.Label()
        Contract_NotesLabel = New System.Windows.Forms.Label()
        KY_Status_ContractLabel = New System.Windows.Forms.Label()
        Label_Money_Contract_Total = New System.Windows.Forms.Label()
        Label_Hours_Contract_Total = New System.Windows.Forms.Label()
        Label_Date_Contract_End = New System.Windows.Forms.Label()
        Label_Date_Contract_Begin = New System.Windows.Forms.Label()
        Name_ContractLabel = New System.Windows.Forms.Label()
        CType(Me.ContractsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contract_Status_LUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Desc_Contract_ServicesLabel
        '
        Desc_Contract_ServicesLabel.AutoSize = True
        Desc_Contract_ServicesLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Desc_Contract_ServicesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_Contract_ServicesLabel.Location = New System.Drawing.Point(35, 373)
        Desc_Contract_ServicesLabel.Name = "Desc_Contract_ServicesLabel"
        Desc_Contract_ServicesLabel.Size = New System.Drawing.Size(109, 15)
        Desc_Contract_ServicesLabel.TabIndex = 49
        Desc_Contract_ServicesLabel.Text = "Inv Description:"
        '
        'Contract_NotesLabel
        '
        Contract_NotesLabel.AutoSize = True
        Contract_NotesLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Contract_NotesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contract_NotesLabel.Location = New System.Drawing.Point(34, 399)
        Contract_NotesLabel.Name = "Contract_NotesLabel"
        Contract_NotesLabel.Size = New System.Drawing.Size(110, 15)
        Contract_NotesLabel.TabIndex = 23
        Contract_NotesLabel.Text = "Contract Notes:"
        '
        'KY_Status_ContractLabel
        '
        KY_Status_ContractLabel.AutoSize = True
        KY_Status_ContractLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        KY_Status_ContractLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_Status_ContractLabel.Location = New System.Drawing.Point(31, 344)
        KY_Status_ContractLabel.Name = "KY_Status_ContractLabel"
        KY_Status_ContractLabel.Size = New System.Drawing.Size(114, 15)
        KY_Status_ContractLabel.TabIndex = 21
        KY_Status_ContractLabel.Text = "Contract Status:"
        '
        'Label_Money_Contract_Total
        '
        Label_Money_Contract_Total.AutoSize = True
        Label_Money_Contract_Total.BackColor = System.Drawing.SystemColors.InactiveCaption
        Label_Money_Contract_Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Money_Contract_Total.Location = New System.Drawing.Point(49, 315)
        Label_Money_Contract_Total.Name = "Label_Money_Contract_Total"
        Label_Money_Contract_Total.Size = New System.Drawing.Size(97, 15)
        Label_Money_Contract_Total.TabIndex = 19
        Label_Money_Contract_Total.Text = "Total Amount:"
        '
        'Label_Hours_Contract_Total
        '
        Label_Hours_Contract_Total.AutoSize = True
        Label_Hours_Contract_Total.BackColor = System.Drawing.SystemColors.InactiveCaption
        Label_Hours_Contract_Total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Hours_Contract_Total.Location = New System.Drawing.Point(58, 283)
        Label_Hours_Contract_Total.Name = "Label_Hours_Contract_Total"
        Label_Hours_Contract_Total.Size = New System.Drawing.Size(86, 15)
        Label_Hours_Contract_Total.TabIndex = 17
        Label_Hours_Contract_Total.Text = "Total Hours:"
        '
        'Label_Date_Contract_End
        '
        Label_Date_Contract_End.AutoSize = True
        Label_Date_Contract_End.BackColor = System.Drawing.SystemColors.InactiveCaption
        Label_Date_Contract_End.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Date_Contract_End.Location = New System.Drawing.Point(48, 256)
        Label_Date_Contract_End.Name = "Label_Date_Contract_End"
        Label_Date_Contract_End.Size = New System.Drawing.Size(97, 15)
        Label_Date_Contract_End.TabIndex = 15
        Label_Date_Contract_End.Text = "Contract End:"
        '
        'Label_Date_Contract_Begin
        '
        Label_Date_Contract_Begin.AutoSize = True
        Label_Date_Contract_Begin.BackColor = System.Drawing.SystemColors.InactiveCaption
        Label_Date_Contract_Begin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Date_Contract_Begin.Location = New System.Drawing.Point(36, 227)
        Label_Date_Contract_Begin.Name = "Label_Date_Contract_Begin"
        Label_Date_Contract_Begin.Size = New System.Drawing.Size(109, 15)
        Label_Date_Contract_Begin.TabIndex = 14
        Label_Date_Contract_Begin.Text = "Contract Begin:"
        '
        'Name_ContractLabel
        '
        Name_ContractLabel.AutoSize = True
        Name_ContractLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Name_ContractLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_ContractLabel.Location = New System.Drawing.Point(36, 199)
        Name_ContractLabel.Name = "Name_ContractLabel"
        Name_ContractLabel.Size = New System.Drawing.Size(110, 15)
        Name_ContractLabel.TabIndex = 13
        Name_ContractLabel.Text = "Name Contract:"
        '
        'ContractsBindingSource
        '
        Me.ContractsBindingSource.DataSource = GetType(System.Data.Objects.DataClasses.EntityCollection(Of Contracts.Contract))
        '
        'ContractBindingSource
        '
        Me.ContractBindingSource.DataSource = GetType(Contracts.Contract)
        '
        'Contract_Status_LUBindingSource
        '
        Me.Contract_Status_LUBindingSource.DataSource = GetType(Contracts.Contract_Status_LU)
        '
        'LinkLabel_OpenContractsFolder
        '
        Me.LinkLabel_OpenContractsFolder.AutoSize = True
        Me.LinkLabel_OpenContractsFolder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_OpenContractsFolder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenContractsFolder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_OpenContractsFolder.Location = New System.Drawing.Point(272, 565)
        Me.LinkLabel_OpenContractsFolder.Name = "LinkLabel_OpenContractsFolder"
        Me.LinkLabel_OpenContractsFolder.Size = New System.Drawing.Size(154, 15)
        Me.LinkLabel_OpenContractsFolder.TabIndex = 49
        Me.LinkLabel_OpenContractsFolder.TabStop = True
        Me.LinkLabel_OpenContractsFolder.Text = "Open Contracts Folder"
        '
        'LinkLabel_Create_Contract_Folder
        '
        Me.LinkLabel_Create_Contract_Folder.AutoSize = True
        Me.LinkLabel_Create_Contract_Folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Create_Contract_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Create_Contract_Folder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Create_Contract_Folder.Location = New System.Drawing.Point(272, 545)
        Me.LinkLabel_Create_Contract_Folder.Name = "LinkLabel_Create_Contract_Folder"
        Me.LinkLabel_Create_Contract_Folder.Size = New System.Drawing.Size(158, 15)
        Me.LinkLabel_Create_Contract_Folder.TabIndex = 48
        Me.LinkLabel_Create_Contract_Folder.TabStop = True
        Me.LinkLabel_Create_Contract_Folder.Text = "Create Contract Folder"
        '
        'LinkLabel_Mamage_Tasks
        '
        Me.LinkLabel_Mamage_Tasks.AutoSize = True
        Me.LinkLabel_Mamage_Tasks.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Mamage_Tasks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Mamage_Tasks.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Mamage_Tasks.Location = New System.Drawing.Point(147, 565)
        Me.LinkLabel_Mamage_Tasks.Name = "LinkLabel_Mamage_Tasks"
        Me.LinkLabel_Mamage_Tasks.Size = New System.Drawing.Size(98, 15)
        Me.LinkLabel_Mamage_Tasks.TabIndex = 47
        Me.LinkLabel_Mamage_Tasks.TabStop = True
        Me.LinkLabel_Mamage_Tasks.Text = "Manage Tasks"
        '
        'LinkLabel_Delete_Contract
        '
        Me.LinkLabel_Delete_Contract.AutoSize = True
        Me.LinkLabel_Delete_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Contract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Contract.Location = New System.Drawing.Point(21, 589)
        Me.LinkLabel_Delete_Contract.Name = "LinkLabel_Delete_Contract"
        Me.LinkLabel_Delete_Contract.Size = New System.Drawing.Size(111, 15)
        Me.LinkLabel_Delete_Contract.TabIndex = 46
        Me.LinkLabel_Delete_Contract.TabStop = True
        Me.LinkLabel_Delete_Contract.Text = "Delete Contract"
        '
        'ListView_Contract_Tasks
        '
        Me.ListView_Contract_Tasks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Contract_Tasks.Location = New System.Drawing.Point(945, 72)
        Me.ListView_Contract_Tasks.MultiSelect = False
        Me.ListView_Contract_Tasks.Name = "ListView_Contract_Tasks"
        Me.ListView_Contract_Tasks.Size = New System.Drawing.Size(440, 545)
        Me.ListView_Contract_Tasks.TabIndex = 43
        Me.ListView_Contract_Tasks.UseCompatibleStateImageBehavior = False
        Me.ListView_Contract_Tasks.View = System.Windows.Forms.View.Details
        '
        'ListView_Contract_Hours
        '
        Me.ListView_Contract_Hours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Contract_Hours.Location = New System.Drawing.Point(460, 72)
        Me.ListView_Contract_Hours.Name = "ListView_Contract_Hours"
        Me.ListView_Contract_Hours.Size = New System.Drawing.Size(436, 545)
        Me.ListView_Contract_Hours.TabIndex = 42
        Me.ListView_Contract_Hours.UseCompatibleStateImageBehavior = False
        Me.ListView_Contract_Hours.View = System.Windows.Forms.View.Details
        '
        'LinkLabel_Manage_Contract_Hours
        '
        Me.LinkLabel_Manage_Contract_Hours.AutoSize = True
        Me.LinkLabel_Manage_Contract_Hours.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Manage_Contract_Hours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Manage_Contract_Hours.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Manage_Contract_Hours.Location = New System.Drawing.Point(147, 545)
        Me.LinkLabel_Manage_Contract_Hours.Name = "LinkLabel_Manage_Contract_Hours"
        Me.LinkLabel_Manage_Contract_Hours.Size = New System.Drawing.Size(100, 15)
        Me.LinkLabel_Manage_Contract_Hours.TabIndex = 41
        Me.LinkLabel_Manage_Contract_Hours.TabStop = True
        Me.LinkLabel_Manage_Contract_Hours.Text = "Manage Hours"
        '
        'Label_Select_Contractee
        '
        Me.Label_Select_Contractee.AutoSize = True
        Me.Label_Select_Contractee.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contractee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contractee.Location = New System.Drawing.Point(1070, 12)
        Me.Label_Select_Contractee.Name = "Label_Select_Contractee"
        Me.Label_Select_Contractee.Size = New System.Drawing.Size(130, 15)
        Me.Label_Select_Contractee.TabIndex = 38
        Me.Label_Select_Contractee.Text = "Select Contractee:"
        '
        'ComboBox_Contractee
        '
        Me.ComboBox_Contractee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contractee.FormattingEnabled = True
        Me.ComboBox_Contractee.Location = New System.Drawing.Point(1206, 7)
        Me.ComboBox_Contractee.Name = "ComboBox_Contractee"
        Me.ComboBox_Contractee.Size = New System.Drawing.Size(191, 23)
        Me.ComboBox_Contractee.TabIndex = 37
        '
        'ComboBox_Rate_Freq
        '
        Me.ComboBox_Rate_Freq.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Rate_Freq.FormattingEnabled = True
        Me.ComboBox_Rate_Freq.Location = New System.Drawing.Point(374, 169)
        Me.ComboBox_Rate_Freq.Name = "ComboBox_Rate_Freq"
        Me.ComboBox_Rate_Freq.Size = New System.Drawing.Size(56, 23)
        Me.ComboBox_Rate_Freq.TabIndex = 36
        '
        'Label_Contract_Rate
        '
        Me.Label_Contract_Rate.AutoSize = True
        Me.Label_Contract_Rate.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label_Contract_Rate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contract_Rate.Location = New System.Drawing.Point(42, 171)
        Me.Label_Contract_Rate.Name = "Label_Contract_Rate"
        Me.Label_Contract_Rate.Size = New System.Drawing.Size(102, 15)
        Me.Label_Contract_Rate.TabIndex = 35
        Me.Label_Contract_Rate.Text = "Contract Rate:"
        '
        'ComboBox_Contract_Rate
        '
        Me.ComboBox_Contract_Rate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contract_Rate.FormattingEnabled = True
        Me.ComboBox_Contract_Rate.Location = New System.Drawing.Point(150, 169)
        Me.ComboBox_Contract_Rate.Name = "ComboBox_Contract_Rate"
        Me.ComboBox_Contract_Rate.Size = New System.Drawing.Size(218, 23)
        Me.ComboBox_Contract_Rate.TabIndex = 34
        '
        'KY_ContracteeTextBox
        '
        Me.KY_ContracteeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "KY_Contractee", True))
        Me.KY_ContracteeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContracteeTextBox.Location = New System.Drawing.Point(374, 140)
        Me.KY_ContracteeTextBox.Name = "KY_ContracteeTextBox"
        Me.KY_ContracteeTextBox.Size = New System.Drawing.Size(56, 23)
        Me.KY_ContracteeTextBox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Name Contractee:"
        '
        'TextBox_Name_Contractee
        '
        Me.TextBox_Name_Contractee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Contractee.Location = New System.Drawing.Point(150, 140)
        Me.TextBox_Name_Contractee.Name = "TextBox_Name_Contractee"
        Me.TextBox_Name_Contractee.Size = New System.Drawing.Size(218, 23)
        Me.TextBox_Name_Contractee.TabIndex = 31
        '
        'LinkLabel_Save_Contract
        '
        Me.LinkLabel_Save_Contract.AutoSize = True
        Me.LinkLabel_Save_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Contract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Contract.Location = New System.Drawing.Point(21, 565)
        Me.LinkLabel_Save_Contract.Name = "LinkLabel_Save_Contract"
        Me.LinkLabel_Save_Contract.Size = New System.Drawing.Size(100, 15)
        Me.LinkLabel_Save_Contract.TabIndex = 30
        Me.LinkLabel_Save_Contract.TabStop = True
        Me.LinkLabel_Save_Contract.Text = "Save Contract"
        '
        'LinkLabel_Add_Contracts
        '
        Me.LinkLabel_Add_Contracts.AutoSize = True
        Me.LinkLabel_Add_Contracts.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Contracts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Contracts.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Contracts.Location = New System.Drawing.Point(21, 545)
        Me.LinkLabel_Add_Contracts.Name = "LinkLabel_Add_Contracts"
        Me.LinkLabel_Add_Contracts.Size = New System.Drawing.Size(93, 15)
        Me.LinkLabel_Add_Contracts.TabIndex = 29
        Me.LinkLabel_Add_Contracts.TabStop = True
        Me.LinkLabel_Add_Contracts.Text = "Add Contract"
        '
        'Label_Contracts_BG
        '
        Me.Label_Contracts_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Contracts_BG.Location = New System.Drawing.Point(12, 535)
        Me.Label_Contracts_BG.Name = "Label_Contracts_BG"
        Me.Label_Contracts_BG.Size = New System.Drawing.Size(427, 95)
        Me.Label_Contracts_BG.TabIndex = 28
        '
        'Label_KY_Contracts
        '
        Me.Label_KY_Contracts.AutoSize = True
        Me.Label_KY_Contracts.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label_KY_Contracts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KY_Contracts.Location = New System.Drawing.Point(55, 82)
        Me.Label_KY_Contracts.Name = "Label_KY_Contracts"
        Me.Label_KY_Contracts.Size = New System.Drawing.Size(89, 15)
        Me.Label_KY_Contracts.TabIndex = 25
        Me.Label_KY_Contracts.Text = "Contract ID: "
        '
        'KY_Status_ContractComboBox
        '
        Me.KY_Status_ContractComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "KY_Status_Contract", True))
        Me.KY_Status_ContractComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Status_ContractComboBox.FormattingEnabled = True
        Me.KY_Status_ContractComboBox.Location = New System.Drawing.Point(150, 341)
        Me.KY_Status_ContractComboBox.Name = "KY_Status_ContractComboBox"
        Me.KY_Status_ContractComboBox.Size = New System.Drawing.Size(280, 23)
        Me.KY_Status_ContractComboBox.TabIndex = 9
        '
        'Money_Contract_TotalTextBox
        '
        Me.Money_Contract_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "Money_Contract_Total", True))
        Me.Money_Contract_TotalTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_Contract_TotalTextBox.Location = New System.Drawing.Point(150, 312)
        Me.Money_Contract_TotalTextBox.Name = "Money_Contract_TotalTextBox"
        Me.Money_Contract_TotalTextBox.Size = New System.Drawing.Size(280, 23)
        Me.Money_Contract_TotalTextBox.TabIndex = 8
        '
        'Hours_Contract_TotalTextBox
        '
        Me.Hours_Contract_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "Hours_Contract_Total", True))
        Me.Hours_Contract_TotalTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours_Contract_TotalTextBox.Location = New System.Drawing.Point(150, 283)
        Me.Hours_Contract_TotalTextBox.Name = "Hours_Contract_TotalTextBox"
        Me.Hours_Contract_TotalTextBox.Size = New System.Drawing.Size(280, 23)
        Me.Hours_Contract_TotalTextBox.TabIndex = 7
        '
        'Date_Contract_EndDateTimePicker
        '
        Me.Date_Contract_EndDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContractsBindingSource, "Date_Contract_End", True))
        Me.Date_Contract_EndDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Contract_EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Contract_EndDateTimePicker.Location = New System.Drawing.Point(150, 254)
        Me.Date_Contract_EndDateTimePicker.Name = "Date_Contract_EndDateTimePicker"
        Me.Date_Contract_EndDateTimePicker.Size = New System.Drawing.Size(280, 23)
        Me.Date_Contract_EndDateTimePicker.TabIndex = 6
        '
        'Date_Contract_BeginDateTimePicker
        '
        Me.Date_Contract_BeginDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContractsBindingSource, "Date_Contract_Begin", True))
        Me.Date_Contract_BeginDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Contract_BeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Contract_BeginDateTimePicker.Location = New System.Drawing.Point(150, 225)
        Me.Date_Contract_BeginDateTimePicker.Name = "Date_Contract_BeginDateTimePicker"
        Me.Date_Contract_BeginDateTimePicker.Size = New System.Drawing.Size(280, 23)
        Me.Date_Contract_BeginDateTimePicker.TabIndex = 5
        '
        'Name_ContractTextBox
        '
        Me.Name_ContractTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "Name_Contract", True))
        Me.Name_ContractTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_ContractTextBox.Location = New System.Drawing.Point(150, 196)
        Me.Name_ContractTextBox.Name = "Name_ContractTextBox"
        Me.Name_ContractTextBox.Size = New System.Drawing.Size(280, 23)
        Me.Name_ContractTextBox.TabIndex = 4
        '
        'Label_Name_Contractor
        '
        Me.Label_Name_Contractor.AutoSize = True
        Me.Label_Name_Contractor.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label_Name_Contractor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name_Contractor.Location = New System.Drawing.Point(20, 114)
        Me.Label_Name_Contractor.Name = "Label_Name_Contractor"
        Me.Label_Name_Contractor.Size = New System.Drawing.Size(124, 15)
        Me.Label_Name_Contractor.TabIndex = 13
        Me.Label_Name_Contractor.Text = "Name Contractor:"
        '
        'Label_Select_Comtractor
        '
        Me.Label_Select_Comtractor.AutoSize = True
        Me.Label_Select_Comtractor.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Comtractor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Comtractor.Location = New System.Drawing.Point(645, 15)
        Me.Label_Select_Comtractor.Name = "Label_Select_Comtractor"
        Me.Label_Select_Comtractor.Size = New System.Drawing.Size(128, 15)
        Me.Label_Select_Comtractor.TabIndex = 13
        Me.Label_Select_Comtractor.Text = "Select Contractor:"
        '
        'Label_FIlter_By
        '
        Me.Label_FIlter_By.AutoSize = True
        Me.Label_FIlter_By.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_FIlter_By.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FIlter_By.Location = New System.Drawing.Point(0, 12)
        Me.Label_FIlter_By.Name = "Label_FIlter_By"
        Me.Label_FIlter_By.Size = New System.Drawing.Size(68, 15)
        Me.Label_FIlter_By.TabIndex = 12
        Me.Label_FIlter_By.Text = "Filter By: "
        '
        'Label_Select_Contract
        '
        Me.Label_Select_Contract.AutoSize = True
        Me.Label_Select_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contract.Location = New System.Drawing.Point(242, 11)
        Me.Label_Select_Contract.Name = "Label_Select_Contract"
        Me.Label_Select_Contract.Size = New System.Drawing.Size(114, 15)
        Me.Label_Select_Contract.TabIndex = 10
        Me.Label_Select_Contract.Text = "Select Contract:"
        '
        'ComboBox_Contracts_Select
        '
        Me.ComboBox_Contracts_Select.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contracts_Select.FormattingEnabled = True
        Me.ComboBox_Contracts_Select.Location = New System.Drawing.Point(362, 8)
        Me.ComboBox_Contracts_Select.Name = "ComboBox_Contracts_Select"
        Me.ComboBox_Contracts_Select.Size = New System.Drawing.Size(277, 23)
        Me.ComboBox_Contracts_Select.TabIndex = 0
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(74, 9)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(162, 23)
        Me.ComboBox_Filter.TabIndex = 8
        '
        'TextBox_Contractor_Name
        '
        Me.TextBox_Contractor_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Contractor_Name.Location = New System.Drawing.Point(150, 111)
        Me.TextBox_Contractor_Name.Name = "TextBox_Contractor_Name"
        Me.TextBox_Contractor_Name.Size = New System.Drawing.Size(218, 23)
        Me.TextBox_Contractor_Name.TabIndex = 3
        '
        'KY_ContractorTextBox
        '
        Me.KY_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "KY_Contractor", True))
        Me.KY_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractorTextBox.Location = New System.Drawing.Point(374, 111)
        Me.KY_ContractorTextBox.Name = "KY_ContractorTextBox"
        Me.KY_ContractorTextBox.Size = New System.Drawing.Size(56, 23)
        Me.KY_ContractorTextBox.TabIndex = 2
        '
        'KY_ContractsTextBox
        '
        Me.KY_ContractsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "KY_Contracts", True))
        Me.KY_ContractsTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsTextBox.Location = New System.Drawing.Point(150, 82)
        Me.KY_ContractsTextBox.Name = "KY_ContractsTextBox"
        Me.KY_ContractsTextBox.Size = New System.Drawing.Size(280, 23)
        Me.KY_ContractsTextBox.TabIndex = 1
        '
        'ComboBox_Contractors
        '
        Me.ComboBox_Contractors.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contractors.FormattingEnabled = True
        Me.ComboBox_Contractors.Location = New System.Drawing.Point(779, 8)
        Me.ComboBox_Contractors.Name = "ComboBox_Contractors"
        Me.ComboBox_Contractors.Size = New System.Drawing.Size(285, 23)
        Me.ComboBox_Contractors.TabIndex = 26
        '
        'Label_Filters_Background
        '
        Me.Label_Filters_Background.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Filters_Background.Location = New System.Drawing.Point(-5, -1)
        Me.Label_Filters_Background.Name = "Label_Filters_Background"
        Me.Label_Filters_Background.Size = New System.Drawing.Size(1416, 44)
        Me.Label_Filters_Background.TabIndex = 27
        '
        'Label_BG_RecCounter
        '
        Me.Label_BG_RecCounter.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label_BG_RecCounter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BG_RecCounter.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label_BG_RecCounter.Location = New System.Drawing.Point(12, 54)
        Me.Label_BG_RecCounter.Name = "Label_BG_RecCounter"
        Me.Label_BG_RecCounter.Size = New System.Drawing.Size(427, 475)
        Me.Label_BG_RecCounter.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 576)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(932, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 576)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Tasks"
        '
        'Desc_Contract_ServicesTextBox
        '
        Me.Desc_Contract_ServicesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "Desc_Contract_Services", True))
        Me.Desc_Contract_ServicesTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_Contract_ServicesTextBox.Location = New System.Drawing.Point(150, 371)
        Me.Desc_Contract_ServicesTextBox.Multiline = True
        Me.Desc_Contract_ServicesTextBox.Name = "Desc_Contract_ServicesTextBox"
        Me.Desc_Contract_ServicesTextBox.Size = New System.Drawing.Size(280, 40)
        Me.Desc_Contract_ServicesTextBox.TabIndex = 50
        '
        'Contract_NotesTextBox
        '
        Me.Contract_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractsBindingSource, "Contract_Notes", True))
        Me.Contract_NotesTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contract_NotesTextBox.Location = New System.Drawing.Point(24, 417)
        Me.Contract_NotesTextBox.Multiline = True
        Me.Contract_NotesTextBox.Name = "Contract_NotesTextBox"
        Me.Contract_NotesTextBox.Size = New System.Drawing.Size(406, 104)
        Me.Contract_NotesTextBox.TabIndex = 51
        '
        'frm_Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 639)
        Me.Controls.Add(Me.Contract_NotesTextBox)
        Me.Controls.Add(Me.Desc_Contract_ServicesTextBox)
        Me.Controls.Add(Desc_Contract_ServicesLabel)
        Me.Controls.Add(Me.LinkLabel_OpenContractsFolder)
        Me.Controls.Add(Me.LinkLabel_Create_Contract_Folder)
        Me.Controls.Add(Me.LinkLabel_Mamage_Tasks)
        Me.Controls.Add(Me.LinkLabel_Delete_Contract)
        Me.Controls.Add(Me.ListView_Contract_Tasks)
        Me.Controls.Add(Me.ListView_Contract_Hours)
        Me.Controls.Add(Me.LinkLabel_Manage_Contract_Hours)
        Me.Controls.Add(Me.Label_Select_Contractee)
        Me.Controls.Add(Me.ComboBox_Contractee)
        Me.Controls.Add(Me.ComboBox_Rate_Freq)
        Me.Controls.Add(Me.Label_Contract_Rate)
        Me.Controls.Add(Me.ComboBox_Contract_Rate)
        Me.Controls.Add(Me.KY_ContracteeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Name_Contractee)
        Me.Controls.Add(Me.LinkLabel_Save_Contract)
        Me.Controls.Add(Me.LinkLabel_Add_Contracts)
        Me.Controls.Add(Me.Label_Contracts_BG)
        Me.Controls.Add(Me.Label_KY_Contracts)
        Me.Controls.Add(Contract_NotesLabel)
        Me.Controls.Add(KY_Status_ContractLabel)
        Me.Controls.Add(Me.KY_Status_ContractComboBox)
        Me.Controls.Add(Label_Money_Contract_Total)
        Me.Controls.Add(Me.Money_Contract_TotalTextBox)
        Me.Controls.Add(Label_Hours_Contract_Total)
        Me.Controls.Add(Me.Hours_Contract_TotalTextBox)
        Me.Controls.Add(Label_Date_Contract_End)
        Me.Controls.Add(Me.Date_Contract_EndDateTimePicker)
        Me.Controls.Add(Label_Date_Contract_Begin)
        Me.Controls.Add(Me.Date_Contract_BeginDateTimePicker)
        Me.Controls.Add(Name_ContractLabel)
        Me.Controls.Add(Me.Name_ContractTextBox)
        Me.Controls.Add(Me.Label_Name_Contractor)
        Me.Controls.Add(Me.Label_Select_Comtractor)
        Me.Controls.Add(Me.Label_FIlter_By)
        Me.Controls.Add(Me.Label_Select_Contract)
        Me.Controls.Add(Me.ComboBox_Contracts_Select)
        Me.Controls.Add(Me.ComboBox_Filter)
        Me.Controls.Add(Me.TextBox_Contractor_Name)
        Me.Controls.Add(Me.KY_ContractorTextBox)
        Me.Controls.Add(Me.KY_ContractsTextBox)
        Me.Controls.Add(Me.ComboBox_Contractors)
        Me.Controls.Add(Me.Label_Filters_Background)
        Me.Controls.Add(Me.Label_BG_RecCounter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_Contracts"
        Me.Text = "Contracts"
        CType(Me.ContractsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contract_Status_LUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_Contractors As System.Windows.Forms.ComboBox
    Friend WithEvents ContractsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_ContractsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Contractor_Name As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Contracts_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Select_Contract As System.Windows.Forms.Label
    Friend WithEvents Label_FIlter_By As System.Windows.Forms.Label
    Friend WithEvents Label_Select_Comtractor As System.Windows.Forms.Label
    Friend WithEvents Label_Name_Contractor As System.Windows.Forms.Label
    Friend WithEvents Name_ContractTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Contract_BeginDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_Contract_EndDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hours_Contract_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Money_Contract_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_Status_ContractComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label_KY_Contracts As System.Windows.Forms.Label
    Friend WithEvents Label_Contracts_BG As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Contracts As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Contract As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox_Name_Contractee As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KY_ContracteeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Contract_Rate As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Contract_Rate As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Rate_Freq As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Contractee As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Select_Contractee As System.Windows.Forms.Label
    Friend WithEvents Label_Filters_Background As System.Windows.Forms.Label
    Friend WithEvents Label_BG_RecCounter As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Manage_Contract_Hours As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView_Contract_Hours As System.Windows.Forms.ListView
    Friend WithEvents ListView_Contract_Tasks As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Delete_Contract As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Mamage_Tasks As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Create_Contract_Folder As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_OpenContractsFolder As System.Windows.Forms.LinkLabel
    Friend WithEvents ContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Contract_Status_LUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Desc_Contract_ServicesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contract_NotesTextBox As System.Windows.Forms.TextBox
End Class
