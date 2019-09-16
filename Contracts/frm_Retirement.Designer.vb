<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Retirement
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
        Dim KY_RetirementLabel As System.Windows.Forms.Label
        Dim Amount_ContributionLabel As System.Windows.Forms.Label
        Dim Date_ContributionLabel As System.Windows.Forms.Label
        Dim Tax_YearLabel As System.Windows.Forms.Label
        Me.RetirementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KY_RetirementTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_ContributionTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ContributionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tax_YearTextBox = New System.Windows.Forms.TextBox()
        Me.cboRetirementAccount = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel_Add_Retirement = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Save_Retirement = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Retirement = New System.Windows.Forms.LinkLabel()
        Me.ListView_Retirement = New System.Windows.Forms.ListView()
        KY_RetirementLabel = New System.Windows.Forms.Label()
        Amount_ContributionLabel = New System.Windows.Forms.Label()
        Date_ContributionLabel = New System.Windows.Forms.Label()
        Tax_YearLabel = New System.Windows.Forms.Label()
        CType(Me.RetirementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KY_RetirementLabel
        '
        KY_RetirementLabel.AutoSize = True
        KY_RetirementLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        KY_RetirementLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_RetirementLabel.Location = New System.Drawing.Point(6, 9)
        KY_RetirementLabel.Name = "KY_RetirementLabel"
        KY_RetirementLabel.Size = New System.Drawing.Size(104, 15)
        KY_RetirementLabel.TabIndex = 1
        KY_RetirementLabel.Text = "Retirement ID: "
        '
        'Amount_ContributionLabel
        '
        Amount_ContributionLabel.AutoSize = True
        Amount_ContributionLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Amount_ContributionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_ContributionLabel.Location = New System.Drawing.Point(49, 38)
        Amount_ContributionLabel.Name = "Amount_ContributionLabel"
        Amount_ContributionLabel.Size = New System.Drawing.Size(61, 15)
        Amount_ContributionLabel.TabIndex = 3
        Amount_ContributionLabel.Text = "Amount:"
        '
        'Date_ContributionLabel
        '
        Date_ContributionLabel.AutoSize = True
        Date_ContributionLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Date_ContributionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ContributionLabel.Location = New System.Drawing.Point(68, 67)
        Date_ContributionLabel.Name = "Date_ContributionLabel"
        Date_ContributionLabel.Size = New System.Drawing.Size(42, 15)
        Date_ContributionLabel.TabIndex = 5
        Date_ContributionLabel.Text = "Date:"
        '
        'Tax_YearLabel
        '
        Tax_YearLabel.AutoSize = True
        Tax_YearLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Tax_YearLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tax_YearLabel.Location = New System.Drawing.Point(43, 99)
        Tax_YearLabel.Name = "Tax_YearLabel"
        Tax_YearLabel.Size = New System.Drawing.Size(67, 15)
        Tax_YearLabel.TabIndex = 7
        Tax_YearLabel.Text = "Tax Year:"
        '
        'RetirementsBindingSource
        '
        Me.RetirementsBindingSource.DataSource = GetType(Contracts.Retirement)
        '
        'KY_RetirementTextBox
        '
        Me.KY_RetirementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirementsBindingSource, "KY_Retirement", True))
        Me.KY_RetirementTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_RetirementTextBox.Location = New System.Drawing.Point(112, 9)
        Me.KY_RetirementTextBox.Name = "KY_RetirementTextBox"
        Me.KY_RetirementTextBox.Size = New System.Drawing.Size(146, 23)
        Me.KY_RetirementTextBox.TabIndex = 2
        '
        'Amount_ContributionTextBox
        '
        Me.Amount_ContributionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirementsBindingSource, "Amount_Contribution", True))
        Me.Amount_ContributionTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_ContributionTextBox.Location = New System.Drawing.Point(112, 38)
        Me.Amount_ContributionTextBox.Name = "Amount_ContributionTextBox"
        Me.Amount_ContributionTextBox.Size = New System.Drawing.Size(146, 23)
        Me.Amount_ContributionTextBox.TabIndex = 4
        '
        'Date_ContributionDateTimePicker
        '
        Me.Date_ContributionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RetirementsBindingSource, "Date_Contribution", True))
        Me.Date_ContributionDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ContributionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_ContributionDateTimePicker.Location = New System.Drawing.Point(112, 67)
        Me.Date_ContributionDateTimePicker.Name = "Date_ContributionDateTimePicker"
        Me.Date_ContributionDateTimePicker.Size = New System.Drawing.Size(146, 23)
        Me.Date_ContributionDateTimePicker.TabIndex = 6
        '
        'Tax_YearTextBox
        '
        Me.Tax_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirementsBindingSource, "Tax_Year", True))
        Me.Tax_YearTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tax_YearTextBox.Location = New System.Drawing.Point(112, 96)
        Me.Tax_YearTextBox.Name = "Tax_YearTextBox"
        Me.Tax_YearTextBox.Size = New System.Drawing.Size(146, 23)
        Me.Tax_YearTextBox.TabIndex = 8
        '
        'cboRetirementAccount
        '
        Me.cboRetirementAccount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRetirementAccount.FormattingEnabled = True
        Me.cboRetirementAccount.Location = New System.Drawing.Point(112, 125)
        Me.cboRetirementAccount.Name = "cboRetirementAccount"
        Me.cboRetirementAccount.Size = New System.Drawing.Size(146, 23)
        Me.cboRetirementAccount.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Account:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Location = New System.Drawing.Point(2, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 296)
        Me.Label2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(2, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(721, 99)
        Me.Label3.TabIndex = 12
        '
        'LinkLabel_Add_Retirement
        '
        Me.LinkLabel_Add_Retirement.AutoSize = True
        Me.LinkLabel_Add_Retirement.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Retirement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Retirement.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Retirement.Location = New System.Drawing.Point(12, 313)
        Me.LinkLabel_Add_Retirement.Name = "LinkLabel_Add_Retirement"
        Me.LinkLabel_Add_Retirement.Size = New System.Drawing.Size(193, 15)
        Me.LinkLabel_Add_Retirement.TabIndex = 28
        Me.LinkLabel_Add_Retirement.TabStop = True
        Me.LinkLabel_Add_Retirement.Text = "Add Retirement Contribution"
        '
        'LinkLabel_Save_Retirement
        '
        Me.LinkLabel_Save_Retirement.AutoSize = True
        Me.LinkLabel_Save_Retirement.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Retirement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Retirement.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Retirement.Location = New System.Drawing.Point(12, 340)
        Me.LinkLabel_Save_Retirement.Name = "LinkLabel_Save_Retirement"
        Me.LinkLabel_Save_Retirement.Size = New System.Drawing.Size(200, 15)
        Me.LinkLabel_Save_Retirement.TabIndex = 29
        Me.LinkLabel_Save_Retirement.TabStop = True
        Me.LinkLabel_Save_Retirement.Text = "Save Retirement Contribution"
        '
        'LinkLabel_Delete_Retirement
        '
        Me.LinkLabel_Delete_Retirement.AutoSize = True
        Me.LinkLabel_Delete_Retirement.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Retirement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Retirement.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Retirement.Location = New System.Drawing.Point(12, 367)
        Me.LinkLabel_Delete_Retirement.Name = "LinkLabel_Delete_Retirement"
        Me.LinkLabel_Delete_Retirement.Size = New System.Drawing.Size(211, 15)
        Me.LinkLabel_Delete_Retirement.TabIndex = 30
        Me.LinkLabel_Delete_Retirement.TabStop = True
        Me.LinkLabel_Delete_Retirement.Text = "Delete Retirement Contribution"
        '
        'ListView_Retirement
        '
        Me.ListView_Retirement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Retirement.FullRowSelect = True
        Me.ListView_Retirement.GridLines = True
        Me.ListView_Retirement.Location = New System.Drawing.Point(288, 3)
        Me.ListView_Retirement.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Retirement.Name = "ListView_Retirement"
        Me.ListView_Retirement.Size = New System.Drawing.Size(435, 294)
        Me.ListView_Retirement.TabIndex = 31
        Me.ListView_Retirement.UseCompatibleStateImageBehavior = False
        Me.ListView_Retirement.View = System.Windows.Forms.View.Details
        '
        'frm_Retirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(721, 401)
        Me.Controls.Add(Me.ListView_Retirement)
        Me.Controls.Add(Me.LinkLabel_Delete_Retirement)
        Me.Controls.Add(Me.LinkLabel_Save_Retirement)
        Me.Controls.Add(Me.LinkLabel_Add_Retirement)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboRetirementAccount)
        Me.Controls.Add(Tax_YearLabel)
        Me.Controls.Add(Me.Tax_YearTextBox)
        Me.Controls.Add(Date_ContributionLabel)
        Me.Controls.Add(Me.Date_ContributionDateTimePicker)
        Me.Controls.Add(Amount_ContributionLabel)
        Me.Controls.Add(Me.Amount_ContributionTextBox)
        Me.Controls.Add(KY_RetirementLabel)
        Me.Controls.Add(Me.KY_RetirementTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_Retirement"
        Me.Text = "Retirement"
        CType(Me.RetirementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RetirementsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_RetirementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_ContributionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ContributionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tax_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboRetirementAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Retirement As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Retirement As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Retirement As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView_Retirement As System.Windows.Forms.ListView
End Class
