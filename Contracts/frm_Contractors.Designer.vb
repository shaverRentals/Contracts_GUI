<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contractors
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
        Dim Adress_Contractor_2Label As System.Windows.Forms.Label
        Dim Notes_ContractorLabel As System.Windows.Forms.Label
        Dim Address_ContractorLabel As System.Windows.Forms.Label
        Dim Email_ContractorLabel As System.Windows.Forms.Label
        Dim Phone_ContractorLabel As System.Windows.Forms.Label
        Dim Primary_Contact_ContractorLabel As System.Windows.Forms.Label
        Dim Name_ContractorLabel As System.Windows.Forms.Label
        Dim KY_ContractorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Contractors))
        Dim City_ContractorLabel As System.Windows.Forms.Label
        Dim State_ContractorLabel As System.Windows.Forms.Label
        Dim Zip_ContractorLabel As System.Windows.Forms.Label
        Me.ContractorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Adress_Contractor_2TextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel_Add_Contract = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Record = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Save_Record = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Add_Record = New System.Windows.Forms.LinkLabel()
        Me.Label_NumberOfRecords = New System.Windows.Forms.Label()
        Me.ListView_Contracts = New System.Windows.Forms.ListView()
        Me.Label_Controls_BackGround = New System.Windows.Forms.Label()
        Me.Notes_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.Address_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.Email_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_ContractorMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Primary_Contact_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.Name_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.KY_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.ContractorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.City_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.State_ContractorTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_ContractorTextBox = New System.Windows.Forms.TextBox()
        Adress_Contractor_2Label = New System.Windows.Forms.Label()
        Notes_ContractorLabel = New System.Windows.Forms.Label()
        Address_ContractorLabel = New System.Windows.Forms.Label()
        Email_ContractorLabel = New System.Windows.Forms.Label()
        Phone_ContractorLabel = New System.Windows.Forms.Label()
        Primary_Contact_ContractorLabel = New System.Windows.Forms.Label()
        Name_ContractorLabel = New System.Windows.Forms.Label()
        KY_ContractorLabel = New System.Windows.Forms.Label()
        City_ContractorLabel = New System.Windows.Forms.Label()
        State_ContractorLabel = New System.Windows.Forms.Label()
        Zip_ContractorLabel = New System.Windows.Forms.Label()
        CType(Me.ContractorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContractorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContractorBindingSource
        '
        Me.ContractorBindingSource.DataSource = GetType(Contracts.Contractor)
        '
        'Adress_Contractor_2Label
        '
        Adress_Contractor_2Label.AutoSize = True
        Adress_Contractor_2Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Adress_Contractor_2Label.Location = New System.Drawing.Point(74, 217)
        Adress_Contractor_2Label.Name = "Adress_Contractor_2Label"
        Adress_Contractor_2Label.Size = New System.Drawing.Size(52, 15)
        Adress_Contractor_2Label.TabIndex = 22
        Adress_Contractor_2Label.Text = "Street:"
        '
        'Adress_Contractor_2TextBox
        '
        Me.Adress_Contractor_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Adress_Contractor_2", True))
        Me.Adress_Contractor_2TextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adress_Contractor_2TextBox.Location = New System.Drawing.Point(132, 214)
        Me.Adress_Contractor_2TextBox.Name = "Adress_Contractor_2TextBox"
        Me.Adress_Contractor_2TextBox.Size = New System.Drawing.Size(337, 23)
        Me.Adress_Contractor_2TextBox.TabIndex = 23
        '
        'LinkLabel_Add_Contract
        '
        Me.LinkLabel_Add_Contract.AutoSize = True
        Me.LinkLabel_Add_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Contract.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Contract.Location = New System.Drawing.Point(8, 577)
        Me.LinkLabel_Add_Contract.Name = "LinkLabel_Add_Contract"
        Me.LinkLabel_Add_Contract.Size = New System.Drawing.Size(286, 15)
        Me.LinkLabel_Add_Contract.TabIndex = 21
        Me.LinkLabel_Add_Contract.TabStop = True
        Me.LinkLabel_Add_Contract.Text = "Add New Contract For Selected Contractor"
        '
        'LinkLabel_Delete_Record
        '
        Me.LinkLabel_Delete_Record.AutoSize = True
        Me.LinkLabel_Delete_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Record.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Record.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Record.Location = New System.Drawing.Point(12, 552)
        Me.LinkLabel_Delete_Record.Name = "LinkLabel_Delete_Record"
        Me.LinkLabel_Delete_Record.Size = New System.Drawing.Size(128, 15)
        Me.LinkLabel_Delete_Record.TabIndex = 20
        Me.LinkLabel_Delete_Record.TabStop = True
        Me.LinkLabel_Delete_Record.Text = "Delete Contractor "
        '
        'LinkLabel_Save_Record
        '
        Me.LinkLabel_Save_Record.AutoSize = True
        Me.LinkLabel_Save_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Record.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Record.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Record.Location = New System.Drawing.Point(12, 528)
        Me.LinkLabel_Save_Record.Name = "LinkLabel_Save_Record"
        Me.LinkLabel_Save_Record.Size = New System.Drawing.Size(117, 15)
        Me.LinkLabel_Save_Record.TabIndex = 19
        Me.LinkLabel_Save_Record.TabStop = True
        Me.LinkLabel_Save_Record.Text = "Save Contractor "
        '
        'LinkLabel_Add_Record
        '
        Me.LinkLabel_Add_Record.AutoSize = True
        Me.LinkLabel_Add_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Record.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Record.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Record.Location = New System.Drawing.Point(16, 504)
        Me.LinkLabel_Add_Record.Name = "LinkLabel_Add_Record"
        Me.LinkLabel_Add_Record.Size = New System.Drawing.Size(110, 15)
        Me.LinkLabel_Add_Record.TabIndex = 18
        Me.LinkLabel_Add_Record.TabStop = True
        Me.LinkLabel_Add_Record.Text = "Add Contractor "
        '
        'Label_NumberOfRecords
        '
        Me.Label_NumberOfRecords.AutoSize = True
        Me.Label_NumberOfRecords.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NumberOfRecords.Location = New System.Drawing.Point(489, 32)
        Me.Label_NumberOfRecords.Name = "Label_NumberOfRecords"
        Me.Label_NumberOfRecords.Size = New System.Drawing.Size(51, 15)
        Me.Label_NumberOfRecords.TabIndex = 17
        Me.Label_NumberOfRecords.Text = "Label1"
        '
        'ListView_Contracts
        '
        Me.ListView_Contracts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Contracts.FullRowSelect = True
        Me.ListView_Contracts.GridLines = True
        Me.ListView_Contracts.Location = New System.Drawing.Point(492, 51)
        Me.ListView_Contracts.MultiSelect = False
        Me.ListView_Contracts.Name = "ListView_Contracts"
        Me.ListView_Contracts.Size = New System.Drawing.Size(288, 428)
        Me.ListView_Contracts.TabIndex = 16
        Me.ListView_Contracts.UseCompatibleStateImageBehavior = False
        Me.ListView_Contracts.View = System.Windows.Forms.View.Details
        '
        'Label_Controls_BackGround
        '
        Me.Label_Controls_BackGround.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Controls_BackGround.Location = New System.Drawing.Point(-3, 493)
        Me.Label_Controls_BackGround.Name = "Label_Controls_BackGround"
        Me.Label_Controls_BackGround.Size = New System.Drawing.Size(792, 109)
        Me.Label_Controls_BackGround.TabIndex = 15
        '
        'Notes_ContractorLabel
        '
        Notes_ContractorLabel.AutoSize = True
        Notes_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Notes_ContractorLabel.Location = New System.Drawing.Point(73, 346)
        Notes_ContractorLabel.Name = "Notes_ContractorLabel"
        Notes_ContractorLabel.Size = New System.Drawing.Size(49, 15)
        Notes_ContractorLabel.TabIndex = 13
        Notes_ContractorLabel.Text = "Notes:"
        '
        'Notes_ContractorTextBox
        '
        Me.Notes_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Notes_Contractor", True))
        Me.Notes_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes_ContractorTextBox.Location = New System.Drawing.Point(128, 333)
        Me.Notes_ContractorTextBox.Multiline = True
        Me.Notes_ContractorTextBox.Name = "Notes_ContractorTextBox"
        Me.Notes_ContractorTextBox.Size = New System.Drawing.Size(341, 146)
        Me.Notes_ContractorTextBox.TabIndex = 14
        '
        'Address_ContractorLabel
        '
        Address_ContractorLabel.AutoSize = True
        Address_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_ContractorLabel.Location = New System.Drawing.Point(62, 191)
        Address_ContractorLabel.Name = "Address_ContractorLabel"
        Address_ContractorLabel.Size = New System.Drawing.Size(64, 15)
        Address_ContractorLabel.TabIndex = 11
        Address_ContractorLabel.Text = "Address:"
        '
        'Address_ContractorTextBox
        '
        Me.Address_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Address_Contractor", True))
        Me.Address_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_ContractorTextBox.Location = New System.Drawing.Point(132, 186)
        Me.Address_ContractorTextBox.Name = "Address_ContractorTextBox"
        Me.Address_ContractorTextBox.Size = New System.Drawing.Size(337, 23)
        Me.Address_ContractorTextBox.TabIndex = 12
        '
        'Email_ContractorLabel
        '
        Email_ContractorLabel.AutoSize = True
        Email_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_ContractorLabel.Location = New System.Drawing.Point(78, 157)
        Email_ContractorLabel.Name = "Email_ContractorLabel"
        Email_ContractorLabel.Size = New System.Drawing.Size(48, 15)
        Email_ContractorLabel.TabIndex = 9
        Email_ContractorLabel.Text = "Email:"
        '
        'Email_ContractorTextBox
        '
        Me.Email_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Email_Contractor", True))
        Me.Email_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_ContractorTextBox.Location = New System.Drawing.Point(132, 157)
        Me.Email_ContractorTextBox.Name = "Email_ContractorTextBox"
        Me.Email_ContractorTextBox.Size = New System.Drawing.Size(337, 23)
        Me.Email_ContractorTextBox.TabIndex = 10
        '
        'Phone_ContractorLabel
        '
        Phone_ContractorLabel.AutoSize = True
        Phone_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_ContractorLabel.Location = New System.Drawing.Point(74, 128)
        Phone_ContractorLabel.Name = "Phone_ContractorLabel"
        Phone_ContractorLabel.Size = New System.Drawing.Size(52, 15)
        Phone_ContractorLabel.TabIndex = 7
        Phone_ContractorLabel.Text = "Phone:"
        '
        'Phone_ContractorMaskedTextBox
        '
        Me.Phone_ContractorMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Phone_Contractor", True))
        Me.Phone_ContractorMaskedTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_ContractorMaskedTextBox.Location = New System.Drawing.Point(132, 128)
        Me.Phone_ContractorMaskedTextBox.Mask = "(999) 000-0000"
        Me.Phone_ContractorMaskedTextBox.Name = "Phone_ContractorMaskedTextBox"
        Me.Phone_ContractorMaskedTextBox.Size = New System.Drawing.Size(337, 23)
        Me.Phone_ContractorMaskedTextBox.TabIndex = 8
        '
        'Primary_Contact_ContractorLabel
        '
        Primary_Contact_ContractorLabel.AutoSize = True
        Primary_Contact_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Primary_Contact_ContractorLabel.Location = New System.Drawing.Point(8, 98)
        Primary_Contact_ContractorLabel.Name = "Primary_Contact_ContractorLabel"
        Primary_Contact_ContractorLabel.Size = New System.Drawing.Size(118, 15)
        Primary_Contact_ContractorLabel.TabIndex = 5
        Primary_Contact_ContractorLabel.Text = "Primary Contact:"
        '
        'Primary_Contact_ContractorTextBox
        '
        Me.Primary_Contact_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Primary_Contact_Contractor", True))
        Me.Primary_Contact_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Primary_Contact_ContractorTextBox.Location = New System.Drawing.Point(132, 96)
        Me.Primary_Contact_ContractorTextBox.Name = "Primary_Contact_ContractorTextBox"
        Me.Primary_Contact_ContractorTextBox.Size = New System.Drawing.Size(337, 23)
        Me.Primary_Contact_ContractorTextBox.TabIndex = 6
        '
        'Name_ContractorLabel
        '
        Name_ContractorLabel.AutoSize = True
        Name_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_ContractorLabel.Location = New System.Drawing.Point(43, 65)
        Name_ContractorLabel.Name = "Name_ContractorLabel"
        Name_ContractorLabel.Size = New System.Drawing.Size(83, 15)
        Name_ContractorLabel.TabIndex = 3
        Name_ContractorLabel.Text = "Contractor:"
        '
        'Name_ContractorTextBox
        '
        Me.Name_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Name_Contractor", True))
        Me.Name_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_ContractorTextBox.Location = New System.Drawing.Point(132, 62)
        Me.Name_ContractorTextBox.Name = "Name_ContractorTextBox"
        Me.Name_ContractorTextBox.Size = New System.Drawing.Size(337, 23)
        Me.Name_ContractorTextBox.TabIndex = 4
        '
        'KY_ContractorLabel
        '
        KY_ContractorLabel.AutoSize = True
        KY_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_ContractorLabel.Location = New System.Drawing.Point(26, 35)
        KY_ContractorLabel.Name = "KY_ContractorLabel"
        KY_ContractorLabel.Size = New System.Drawing.Size(100, 15)
        KY_ContractorLabel.TabIndex = 1
        KY_ContractorLabel.Text = "Contractor ID:"
        '
        'KY_ContractorTextBox
        '
        Me.KY_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "KY_Contractor", True))
        Me.KY_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractorTextBox.Location = New System.Drawing.Point(132, 32)
        Me.KY_ContractorTextBox.Name = "KY_ContractorTextBox"
        Me.KY_ContractorTextBox.Size = New System.Drawing.Size(337, 23)
        Me.KY_ContractorTextBox.TabIndex = 2
        '
        'ContractorBindingNavigator
        '
        Me.ContractorBindingNavigator.AddNewItem = Nothing
        Me.ContractorBindingNavigator.BindingSource = Me.ContractorBindingSource
        Me.ContractorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContractorBindingNavigator.DeleteItem = Nothing
        Me.ContractorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ContractorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContractorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContractorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContractorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContractorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContractorBindingNavigator.Name = "ContractorBindingNavigator"
        Me.ContractorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContractorBindingNavigator.Size = New System.Drawing.Size(786, 25)
        Me.ContractorBindingNavigator.TabIndex = 0
        Me.ContractorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'City_ContractorLabel
        '
        City_ContractorLabel.AutoSize = True
        City_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_ContractorLabel.Location = New System.Drawing.Point(85, 248)
        City_ContractorLabel.Name = "City_ContractorLabel"
        City_ContractorLabel.Size = New System.Drawing.Size(37, 15)
        City_ContractorLabel.TabIndex = 24
        City_ContractorLabel.Text = "City:"
        '
        'City_ContractorTextBox
        '
        Me.City_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "City_Contractor", True))
        Me.City_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_ContractorTextBox.Location = New System.Drawing.Point(128, 245)
        Me.City_ContractorTextBox.Name = "City_ContractorTextBox"
        Me.City_ContractorTextBox.Size = New System.Drawing.Size(341, 23)
        Me.City_ContractorTextBox.TabIndex = 25
        '
        'State_ContractorLabel
        '
        State_ContractorLabel.AutoSize = True
        State_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        State_ContractorLabel.Location = New System.Drawing.Point(74, 277)
        State_ContractorLabel.Name = "State_ContractorLabel"
        State_ContractorLabel.Size = New System.Drawing.Size(46, 15)
        State_ContractorLabel.TabIndex = 26
        State_ContractorLabel.Text = "State:"
        '
        'State_ContractorTextBox
        '
        Me.State_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "State_Contractor", True))
        Me.State_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State_ContractorTextBox.Location = New System.Drawing.Point(128, 274)
        Me.State_ContractorTextBox.Name = "State_ContractorTextBox"
        Me.State_ContractorTextBox.Size = New System.Drawing.Size(341, 23)
        Me.State_ContractorTextBox.TabIndex = 27
        '
        'Zip_ContractorLabel
        '
        Zip_ContractorLabel.AutoSize = True
        Zip_ContractorLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_ContractorLabel.Location = New System.Drawing.Point(85, 307)
        Zip_ContractorLabel.Name = "Zip_ContractorLabel"
        Zip_ContractorLabel.Size = New System.Drawing.Size(31, 15)
        Zip_ContractorLabel.TabIndex = 28
        Zip_ContractorLabel.Text = "Zip:"
        '
        'Zip_ContractorTextBox
        '
        Me.Zip_ContractorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractorBindingSource, "Zip_Contractor", True))
        Me.Zip_ContractorTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_ContractorTextBox.Location = New System.Drawing.Point(128, 304)
        Me.Zip_ContractorTextBox.Name = "Zip_ContractorTextBox"
        Me.Zip_ContractorTextBox.Size = New System.Drawing.Size(341, 23)
        Me.Zip_ContractorTextBox.TabIndex = 29
        '
        'frm_Contractors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 601)
        Me.Controls.Add(Zip_ContractorLabel)
        Me.Controls.Add(Me.Zip_ContractorTextBox)
        Me.Controls.Add(State_ContractorLabel)
        Me.Controls.Add(Me.State_ContractorTextBox)
        Me.Controls.Add(City_ContractorLabel)
        Me.Controls.Add(Me.City_ContractorTextBox)
        Me.Controls.Add(Adress_Contractor_2Label)
        Me.Controls.Add(Me.Adress_Contractor_2TextBox)
        Me.Controls.Add(Me.LinkLabel_Add_Contract)
        Me.Controls.Add(Me.LinkLabel_Delete_Record)
        Me.Controls.Add(Me.LinkLabel_Save_Record)
        Me.Controls.Add(Me.LinkLabel_Add_Record)
        Me.Controls.Add(Me.Label_NumberOfRecords)
        Me.Controls.Add(Me.ListView_Contracts)
        Me.Controls.Add(Me.Label_Controls_BackGround)
        Me.Controls.Add(Notes_ContractorLabel)
        Me.Controls.Add(Me.Notes_ContractorTextBox)
        Me.Controls.Add(Address_ContractorLabel)
        Me.Controls.Add(Me.Address_ContractorTextBox)
        Me.Controls.Add(Email_ContractorLabel)
        Me.Controls.Add(Me.Email_ContractorTextBox)
        Me.Controls.Add(Phone_ContractorLabel)
        Me.Controls.Add(Me.Phone_ContractorMaskedTextBox)
        Me.Controls.Add(Primary_Contact_ContractorLabel)
        Me.Controls.Add(Me.Primary_Contact_ContractorTextBox)
        Me.Controls.Add(Name_ContractorLabel)
        Me.Controls.Add(Me.Name_ContractorTextBox)
        Me.Controls.Add(KY_ContractorLabel)
        Me.Controls.Add(Me.KY_ContractorTextBox)
        Me.Controls.Add(Me.ContractorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Contractors"
        Me.Text = "Manage Contractors"
        CType(Me.ContractorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContractorBindingNavigator.ResumeLayout(False)
        Me.ContractorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContractorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContractorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KY_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Primary_Contact_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_ContractorMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Notes_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label_Controls_BackGround As System.Windows.Forms.Label
    Friend WithEvents ListView_Contracts As System.Windows.Forms.ListView
    Friend WithEvents Label_NumberOfRecords As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Record As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Record As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Record As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Add_Contract As System.Windows.Forms.LinkLabel
    Friend WithEvents Adress_Contractor_2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents State_ContractorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_ContractorTextBox As System.Windows.Forms.TextBox
End Class
