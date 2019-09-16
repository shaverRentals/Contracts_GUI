<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Expense
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
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Description_ExpenseLabel As System.Windows.Forms.Label
        Dim Img_Path_ExpenseLabel As System.Windows.Forms.Label
        Dim Date_ExpenseLabel As System.Windows.Forms.Label
        Dim KY_ExpenseLabel As System.Windows.Forms.Label
        Dim ContracteeLabel As System.Windows.Forms.Label
        Me.LinkLabel_AddExpense = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_LinkReceipt = New System.Windows.Forms.LinkLabel()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KY_Expense_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Description_ExpenseTextBox = New System.Windows.Forms.TextBox()
        Me.Img_Path_ExpenseTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ExpenseDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KY_ExpenseTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Name_Contractee = New System.Windows.Forms.TextBox()
        Me.KY_ContracteeTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox_Contractee = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel_SaveExpense = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_DeleteExpense = New System.Windows.Forms.LinkLabel()
        Me.ListView_Expenses = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel_OpenReceipt = New System.Windows.Forms.LinkLabel()
        AmountLabel = New System.Windows.Forms.Label()
        Description_ExpenseLabel = New System.Windows.Forms.Label()
        Img_Path_ExpenseLabel = New System.Windows.Forms.Label()
        Date_ExpenseLabel = New System.Windows.Forms.Label()
        KY_ExpenseLabel = New System.Windows.Forms.Label()
        ContracteeLabel = New System.Windows.Forms.Label()
        CType(Me.ExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        AmountLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(57, 168)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(61, 15)
        AmountLabel.TabIndex = 49
        AmountLabel.Text = "Amount:"
        '
        'Description_ExpenseLabel
        '
        Description_ExpenseLabel.AutoSize = True
        Description_ExpenseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Description_ExpenseLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Description_ExpenseLabel.Location = New System.Drawing.Point(38, 255)
        Description_ExpenseLabel.Name = "Description_ExpenseLabel"
        Description_ExpenseLabel.Size = New System.Drawing.Size(87, 15)
        Description_ExpenseLabel.TabIndex = 45
        Description_ExpenseLabel.Text = "Description:"
        '
        'Img_Path_ExpenseLabel
        '
        Img_Path_ExpenseLabel.AutoSize = True
        Img_Path_ExpenseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Img_Path_ExpenseLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Img_Path_ExpenseLabel.Location = New System.Drawing.Point(28, 197)
        Img_Path_ExpenseLabel.Name = "Img_Path_ExpenseLabel"
        Img_Path_ExpenseLabel.Size = New System.Drawing.Size(94, 15)
        Img_Path_ExpenseLabel.TabIndex = 43
        Img_Path_ExpenseLabel.Text = "Path Receipt:"
        '
        'Date_ExpenseLabel
        '
        Date_ExpenseLabel.AutoSize = True
        Date_ExpenseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_ExpenseLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ExpenseLabel.Location = New System.Drawing.Point(22, 136)
        Date_ExpenseLabel.Name = "Date_ExpenseLabel"
        Date_ExpenseLabel.Size = New System.Drawing.Size(100, 15)
        Date_ExpenseLabel.TabIndex = 42
        Date_ExpenseLabel.Text = "Date Expense:"
        '
        'KY_ExpenseLabel
        '
        KY_ExpenseLabel.AutoSize = True
        KY_ExpenseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_ExpenseLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_ExpenseLabel.Location = New System.Drawing.Point(36, 107)
        KY_ExpenseLabel.Name = "KY_ExpenseLabel"
        KY_ExpenseLabel.Size = New System.Drawing.Size(86, 15)
        KY_ExpenseLabel.TabIndex = 41
        KY_ExpenseLabel.Text = "Expense ID: "
        '
        'ContracteeLabel
        '
        ContracteeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        ContracteeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContracteeLabel.Location = New System.Drawing.Point(36, 78)
        ContracteeLabel.Name = "ContracteeLabel"
        ContracteeLabel.Size = New System.Drawing.Size(85, 15)
        ContracteeLabel.TabIndex = 2
        ContracteeLabel.Text = "Contractee:"
        '
        'LinkLabel_AddExpense
        '
        Me.LinkLabel_AddExpense.AutoSize = True
        Me.LinkLabel_AddExpense.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel_AddExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_AddExpense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_AddExpense.Location = New System.Drawing.Point(12, 356)
        Me.LinkLabel_AddExpense.Name = "LinkLabel_AddExpense"
        Me.LinkLabel_AddExpense.Size = New System.Drawing.Size(90, 15)
        Me.LinkLabel_AddExpense.TabIndex = 54
        Me.LinkLabel_AddExpense.TabStop = True
        Me.LinkLabel_AddExpense.Text = "Add Expense"
        '
        'LinkLabel_LinkReceipt
        '
        Me.LinkLabel_LinkReceipt.AutoSize = True
        Me.LinkLabel_LinkReceipt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel_LinkReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_LinkReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_LinkReceipt.Location = New System.Drawing.Point(128, 356)
        Me.LinkLabel_LinkReceipt.Name = "LinkLabel_LinkReceipt"
        Me.LinkLabel_LinkReceipt.Size = New System.Drawing.Size(92, 15)
        Me.LinkLabel_LinkReceipt.TabIndex = 53
        Me.LinkLabel_LinkReceipt.TabStop = True
        Me.LinkLabel_LinkReceipt.Text = "Link Expense"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "Amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(131, 165)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(260, 23)
        Me.AmountTextBox.TabIndex = 50
        '
        'ExpensesBindingSource
        '
        Me.ExpensesBindingSource.DataSource = GetType(Contracts.Expenses)
        '
        'KY_Expense_TypeComboBox
        '
        Me.KY_Expense_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "KY_Expense_Type", True))
        Me.KY_Expense_TypeComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Expense_TypeComboBox.FormattingEnabled = True
        Me.KY_Expense_TypeComboBox.Location = New System.Drawing.Point(130, 223)
        Me.KY_Expense_TypeComboBox.Name = "KY_Expense_TypeComboBox"
        Me.KY_Expense_TypeComboBox.Size = New System.Drawing.Size(261, 23)
        Me.KY_Expense_TypeComboBox.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Expense Type:"
        '
        'Description_ExpenseTextBox
        '
        Me.Description_ExpenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "Description_Expense", True))
        Me.Description_ExpenseTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_ExpenseTextBox.Location = New System.Drawing.Point(131, 252)
        Me.Description_ExpenseTextBox.Multiline = True
        Me.Description_ExpenseTextBox.Name = "Description_ExpenseTextBox"
        Me.Description_ExpenseTextBox.Size = New System.Drawing.Size(261, 73)
        Me.Description_ExpenseTextBox.TabIndex = 46
        '
        'Img_Path_ExpenseTextBox
        '
        Me.Img_Path_ExpenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "Img_Path_Expense", True))
        Me.Img_Path_ExpenseTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Img_Path_ExpenseTextBox.Location = New System.Drawing.Point(130, 194)
        Me.Img_Path_ExpenseTextBox.Name = "Img_Path_ExpenseTextBox"
        Me.Img_Path_ExpenseTextBox.Size = New System.Drawing.Size(261, 23)
        Me.Img_Path_ExpenseTextBox.TabIndex = 44
        '
        'Date_ExpenseDateTimePicker
        '
        Me.Date_ExpenseDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExpensesBindingSource, "Date_Expense", True))
        Me.Date_ExpenseDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ExpenseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_ExpenseDateTimePicker.Location = New System.Drawing.Point(129, 136)
        Me.Date_ExpenseDateTimePicker.Name = "Date_ExpenseDateTimePicker"
        Me.Date_ExpenseDateTimePicker.Size = New System.Drawing.Size(261, 23)
        Me.Date_ExpenseDateTimePicker.TabIndex = 43
        '
        'KY_ExpenseTextBox
        '
        Me.KY_ExpenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "KY_Expense", True))
        Me.KY_ExpenseTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ExpenseTextBox.Location = New System.Drawing.Point(129, 107)
        Me.KY_ExpenseTextBox.Name = "KY_ExpenseTextBox"
        Me.KY_ExpenseTextBox.Size = New System.Drawing.Size(261, 23)
        Me.KY_ExpenseTextBox.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Select Contractee:"
        '
        'TextBox_Name_Contractee
        '
        Me.TextBox_Name_Contractee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Contractee.Location = New System.Drawing.Point(128, 78)
        Me.TextBox_Name_Contractee.Name = "TextBox_Name_Contractee"
        Me.TextBox_Name_Contractee.Size = New System.Drawing.Size(194, 23)
        Me.TextBox_Name_Contractee.TabIndex = 40
        '
        'KY_ContracteeTextBox
        '
        Me.KY_ContracteeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "KY_Contractee", True))
        Me.KY_ContracteeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContracteeTextBox.Location = New System.Drawing.Point(329, 78)
        Me.KY_ContracteeTextBox.Name = "KY_ContracteeTextBox"
        Me.KY_ContracteeTextBox.Size = New System.Drawing.Size(61, 23)
        Me.KY_ContracteeTextBox.TabIndex = 39
        '
        'ComboBox_Contractee
        '
        Me.ComboBox_Contractee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contractee.FormattingEnabled = True
        Me.ComboBox_Contractee.Location = New System.Drawing.Point(148, 9)
        Me.ComboBox_Contractee.Name = "ComboBox_Contractee"
        Me.ComboBox_Contractee.Size = New System.Drawing.Size(216, 23)
        Me.ComboBox_Contractee.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1013, 44)
        Me.Label1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(390, 278)
        Me.Label4.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(0, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1010, 110)
        Me.Label5.TabIndex = 52
        '
        'LinkLabel_SaveExpense
        '
        Me.LinkLabel_SaveExpense.AutoSize = True
        Me.LinkLabel_SaveExpense.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel_SaveExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_SaveExpense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_SaveExpense.Location = New System.Drawing.Point(12, 380)
        Me.LinkLabel_SaveExpense.Name = "LinkLabel_SaveExpense"
        Me.LinkLabel_SaveExpense.Size = New System.Drawing.Size(97, 15)
        Me.LinkLabel_SaveExpense.TabIndex = 55
        Me.LinkLabel_SaveExpense.TabStop = True
        Me.LinkLabel_SaveExpense.Text = "Save Expense"
        '
        'LinkLabel_DeleteExpense
        '
        Me.LinkLabel_DeleteExpense.AutoSize = True
        Me.LinkLabel_DeleteExpense.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel_DeleteExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_DeleteExpense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_DeleteExpense.Location = New System.Drawing.Point(10, 404)
        Me.LinkLabel_DeleteExpense.Name = "LinkLabel_DeleteExpense"
        Me.LinkLabel_DeleteExpense.Size = New System.Drawing.Size(108, 15)
        Me.LinkLabel_DeleteExpense.TabIndex = 56
        Me.LinkLabel_DeleteExpense.TabStop = True
        Me.LinkLabel_DeleteExpense.Text = "Delete Expense"
        '
        'ListView_Expenses
        '
        Me.ListView_Expenses.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Expenses.FullRowSelect = True
        Me.ListView_Expenses.GridLines = True
        Me.ListView_Expenses.Location = New System.Drawing.Point(425, 72)
        Me.ListView_Expenses.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Expenses.Name = "ListView_Expenses"
        Me.ListView_Expenses.Size = New System.Drawing.Size(557, 253)
        Me.ListView_Expenses.TabIndex = 57
        Me.ListView_Expenses.UseCompatibleStateImageBehavior = False
        Me.ListView_Expenses.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(407, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(590, 278)
        Me.Label6.TabIndex = 58
        '
        'LinkLabel_OpenReceipt
        '
        Me.LinkLabel_OpenReceipt.AutoSize = True
        Me.LinkLabel_OpenReceipt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel_OpenReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_OpenReceipt.Location = New System.Drawing.Point(128, 380)
        Me.LinkLabel_OpenReceipt.Name = "LinkLabel_OpenReceipt"
        Me.LinkLabel_OpenReceipt.Size = New System.Drawing.Size(99, 15)
        Me.LinkLabel_OpenReceipt.TabIndex = 59
        Me.LinkLabel_OpenReceipt.TabStop = True
        Me.LinkLabel_OpenReceipt.Text = "Open Expense"
        '
        'frm_Expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 455)
        Me.Controls.Add(Me.LinkLabel_OpenReceipt)
        Me.Controls.Add(Me.ListView_Expenses)
        Me.Controls.Add(Me.LinkLabel_DeleteExpense)
        Me.Controls.Add(Me.LinkLabel_SaveExpense)
        Me.Controls.Add(Me.LinkLabel_AddExpense)
        Me.Controls.Add(Me.LinkLabel_LinkReceipt)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.KY_Expense_TypeComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Description_ExpenseLabel)
        Me.Controls.Add(Me.Description_ExpenseTextBox)
        Me.Controls.Add(Img_Path_ExpenseLabel)
        Me.Controls.Add(Me.Img_Path_ExpenseTextBox)
        Me.Controls.Add(Date_ExpenseLabel)
        Me.Controls.Add(Me.Date_ExpenseDateTimePicker)
        Me.Controls.Add(KY_ExpenseLabel)
        Me.Controls.Add(Me.KY_ExpenseTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Name_Contractee)
        Me.Controls.Add(Me.KY_ContracteeTextBox)
        Me.Controls.Add(Me.ComboBox_Contractee)
        Me.Controls.Add(ContracteeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frm_Expense"
        Me.Text = "frm_Expense"
        CType(Me.ExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExpensesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox_Contractee As System.Windows.Forms.ComboBox
    Friend WithEvents KY_ContracteeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name_Contractee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KY_ExpenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ExpenseDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Img_Path_ExpenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Description_ExpenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KY_Expense_TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_LinkReceipt As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_AddExpense As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_SaveExpense As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_DeleteExpense As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView_Expenses As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_OpenReceipt As System.Windows.Forms.LinkLabel
End Class
