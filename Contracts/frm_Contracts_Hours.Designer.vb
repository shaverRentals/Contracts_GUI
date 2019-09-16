<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contracts_Hours
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
        Dim KY_Contracts_HoursLabel As System.Windows.Forms.Label
        Dim Date_Hours_WorkdLabel As System.Windows.Forms.Label
        Dim Contracts_Hours1Label As System.Windows.Forms.Label
        Dim Desc_Contracts_HoursLabel As System.Windows.Forms.Label
        Me.Label_Contract_Hours_BG = New System.Windows.Forms.Label()
        Me.ComboBox_Contracts_Select = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.Contracts_HoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KY_Contracts_HoursTextBox = New System.Windows.Forms.TextBox()
        Me.KY_ContractsTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Hours_WorkdDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Contracts_Hours1TextBox = New System.Windows.Forms.TextBox()
        Me.Desc_Contracts_HoursTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox_Name_Current_Contract = New System.Windows.Forms.TextBox()
        Me.ListView_Contract_Hours = New System.Windows.Forms.ListView()
        Me.TextBox_Contract_Rate = New System.Windows.Forms.TextBox()
        Me.TextBox_Freq = New System.Windows.Forms.TextBox()
        Me.Label_Name_Contract = New System.Windows.Forms.Label()
        Me.Label_FilterBy = New System.Windows.Forms.Label()
        Me.Label_Select_Contract = New System.Windows.Forms.Label()
        Me.Label_rate = New System.Windows.Forms.Label()
        Me.Label_Hours_BG = New System.Windows.Forms.Label()
        Me.ListView_BG = New System.Windows.Forms.Label()
        Me.Label_Links_BG = New System.Windows.Forms.Label()
        Me.LinkLabel_Add_Contract_Hours = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Save_Hours = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Delete_Hours = New System.Windows.Forms.LinkLabel()
        KY_Contracts_HoursLabel = New System.Windows.Forms.Label()
        Date_Hours_WorkdLabel = New System.Windows.Forms.Label()
        Contracts_Hours1Label = New System.Windows.Forms.Label()
        Desc_Contracts_HoursLabel = New System.Windows.Forms.Label()
        CType(Me.Contracts_HoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KY_Contracts_HoursLabel
        '
        KY_Contracts_HoursLabel.AutoSize = True
        KY_Contracts_HoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_Contracts_HoursLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_Contracts_HoursLabel.Location = New System.Drawing.Point(65, 102)
        KY_Contracts_HoursLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KY_Contracts_HoursLabel.Name = "KY_Contracts_HoursLabel"
        KY_Contracts_HoursLabel.Size = New System.Drawing.Size(67, 15)
        KY_Contracts_HoursLabel.TabIndex = 10
        KY_Contracts_HoursLabel.Text = "Hours ID:"
        '
        'Date_Hours_WorkdLabel
        '
        Date_Hours_WorkdLabel.AutoSize = True
        Date_Hours_WorkdLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_Hours_WorkdLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Hours_WorkdLabel.Location = New System.Drawing.Point(47, 158)
        Date_Hours_WorkdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_Hours_WorkdLabel.Name = "Date_Hours_WorkdLabel"
        Date_Hours_WorkdLabel.Size = New System.Drawing.Size(84, 15)
        Date_Hours_WorkdLabel.TabIndex = 12
        Date_Hours_WorkdLabel.Text = "Date Hours:"
        '
        'Contracts_Hours1Label
        '
        Contracts_Hours1Label.AutoSize = True
        Contracts_Hours1Label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Contracts_Hours1Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contracts_Hours1Label.Location = New System.Drawing.Point(29, 131)
        Contracts_Hours1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contracts_Hours1Label.Name = "Contracts_Hours1Label"
        Contracts_Hours1Label.Size = New System.Drawing.Size(102, 15)
        Contracts_Hours1Label.TabIndex = 13
        Contracts_Hours1Label.Text = "Hours Worked:"
        '
        'Desc_Contracts_HoursLabel
        '
        Desc_Contracts_HoursLabel.AutoSize = True
        Desc_Contracts_HoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Desc_Contracts_HoursLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_Contracts_HoursLabel.Location = New System.Drawing.Point(22, 214)
        Desc_Contracts_HoursLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Desc_Contracts_HoursLabel.Name = "Desc_Contracts_HoursLabel"
        Desc_Contracts_HoursLabel.Size = New System.Drawing.Size(87, 15)
        Desc_Contracts_HoursLabel.TabIndex = 14
        Desc_Contracts_HoursLabel.Text = "Description:"
        '
        'Label_Contract_Hours_BG
        '
        Me.Label_Contract_Hours_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Contract_Hours_BG.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contract_Hours_BG.Location = New System.Drawing.Point(-1, -2)
        Me.Label_Contract_Hours_BG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Contract_Hours_BG.Name = "Label_Contract_Hours_BG"
        Me.Label_Contract_Hours_BG.Size = New System.Drawing.Size(979, 49)
        Me.Label_Contract_Hours_BG.TabIndex = 0
        '
        'ComboBox_Contracts_Select
        '
        Me.ComboBox_Contracts_Select.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contracts_Select.FormattingEnabled = True
        Me.ComboBox_Contracts_Select.Location = New System.Drawing.Point(467, 6)
        Me.ComboBox_Contracts_Select.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Contracts_Select.Name = "ComboBox_Contracts_Select"
        Me.ComboBox_Contracts_Select.Size = New System.Drawing.Size(267, 23)
        Me.ComboBox_Contracts_Select.TabIndex = 1
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(93, 6)
        Me.ComboBox_Filter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(215, 23)
        Me.ComboBox_Filter.TabIndex = 9
        '
        'Contracts_HoursBindingSource
        '
        Me.Contracts_HoursBindingSource.DataSource = GetType(System.Data.Objects.DataClasses.EntityCollection(Of Contracts.Contracts_Hours))
        '
        'KY_Contracts_HoursTextBox
        '
        Me.KY_Contracts_HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Contracts_HoursBindingSource, "KY_Contracts_Hours", True))
        Me.KY_Contracts_HoursTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_Contracts_HoursTextBox.Location = New System.Drawing.Point(139, 94)
        Me.KY_Contracts_HoursTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.KY_Contracts_HoursTextBox.Name = "KY_Contracts_HoursTextBox"
        Me.KY_Contracts_HoursTextBox.Size = New System.Drawing.Size(205, 23)
        Me.KY_Contracts_HoursTextBox.TabIndex = 11
        '
        'KY_ContractsTextBox
        '
        Me.KY_ContractsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Contracts_HoursBindingSource, "KY_Contracts", True))
        Me.KY_ContractsTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsTextBox.Location = New System.Drawing.Point(301, 65)
        Me.KY_ContractsTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.KY_ContractsTextBox.Name = "KY_ContractsTextBox"
        Me.KY_ContractsTextBox.Size = New System.Drawing.Size(43, 23)
        Me.KY_ContractsTextBox.TabIndex = 12
        '
        'Date_Hours_WorkdDateTimePicker
        '
        Me.Date_Hours_WorkdDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Contracts_HoursBindingSource, "Date_Hours_Workd", True))
        Me.Date_Hours_WorkdDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Hours_WorkdDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Hours_WorkdDateTimePicker.Location = New System.Drawing.Point(139, 152)
        Me.Date_Hours_WorkdDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Hours_WorkdDateTimePicker.Name = "Date_Hours_WorkdDateTimePicker"
        Me.Date_Hours_WorkdDateTimePicker.Size = New System.Drawing.Size(205, 23)
        Me.Date_Hours_WorkdDateTimePicker.TabIndex = 13
        '
        'Contracts_Hours1TextBox
        '
        Me.Contracts_Hours1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Contracts_HoursBindingSource, "Contracts_Hours1", True))
        Me.Contracts_Hours1TextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contracts_Hours1TextBox.Location = New System.Drawing.Point(139, 123)
        Me.Contracts_Hours1TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Contracts_Hours1TextBox.Name = "Contracts_Hours1TextBox"
        Me.Contracts_Hours1TextBox.Size = New System.Drawing.Size(205, 23)
        Me.Contracts_Hours1TextBox.TabIndex = 14
        '
        'Desc_Contracts_HoursTextBox
        '
        Me.Desc_Contracts_HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Contracts_HoursBindingSource, "Desc_Contracts_Hours", True))
        Me.Desc_Contracts_HoursTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_Contracts_HoursTextBox.Location = New System.Drawing.Point(25, 232)
        Me.Desc_Contracts_HoursTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Desc_Contracts_HoursTextBox.Multiline = True
        Me.Desc_Contracts_HoursTextBox.Name = "Desc_Contracts_HoursTextBox"
        Me.Desc_Contracts_HoursTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Desc_Contracts_HoursTextBox.Size = New System.Drawing.Size(319, 267)
        Me.Desc_Contracts_HoursTextBox.TabIndex = 15
        '
        'TextBox_Name_Current_Contract
        '
        Me.TextBox_Name_Current_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Current_Contract.Location = New System.Drawing.Point(139, 65)
        Me.TextBox_Name_Current_Contract.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Name_Current_Contract.Name = "TextBox_Name_Current_Contract"
        Me.TextBox_Name_Current_Contract.Size = New System.Drawing.Size(154, 23)
        Me.TextBox_Name_Current_Contract.TabIndex = 16
        '
        'ListView_Contract_Hours
        '
        Me.ListView_Contract_Hours.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Contract_Hours.FullRowSelect = True
        Me.ListView_Contract_Hours.GridLines = True
        Me.ListView_Contract_Hours.Location = New System.Drawing.Point(386, 65)
        Me.ListView_Contract_Hours.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Contract_Hours.Name = "ListView_Contract_Hours"
        Me.ListView_Contract_Hours.Size = New System.Drawing.Size(565, 434)
        Me.ListView_Contract_Hours.TabIndex = 17
        Me.ListView_Contract_Hours.UseCompatibleStateImageBehavior = False
        Me.ListView_Contract_Hours.View = System.Windows.Forms.View.Details
        '
        'TextBox_Contract_Rate
        '
        Me.TextBox_Contract_Rate.Enabled = False
        Me.TextBox_Contract_Rate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Contract_Rate.Location = New System.Drawing.Point(139, 181)
        Me.TextBox_Contract_Rate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Contract_Rate.Name = "TextBox_Contract_Rate"
        Me.TextBox_Contract_Rate.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_Contract_Rate.TabIndex = 18
        '
        'TextBox_Freq
        '
        Me.TextBox_Freq.Enabled = False
        Me.TextBox_Freq.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Freq.Location = New System.Drawing.Point(249, 181)
        Me.TextBox_Freq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Freq.Name = "TextBox_Freq"
        Me.TextBox_Freq.Size = New System.Drawing.Size(95, 23)
        Me.TextBox_Freq.TabIndex = 19
        '
        'Label_Name_Contract
        '
        Me.Label_Name_Contract.AutoSize = True
        Me.Label_Name_Contract.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Name_Contract.Location = New System.Drawing.Point(22, 73)
        Me.Label_Name_Contract.Name = "Label_Name_Contract"
        Me.Label_Name_Contract.Size = New System.Drawing.Size(110, 15)
        Me.Label_Name_Contract.TabIndex = 20
        Me.Label_Name_Contract.Text = "Contract Name:"
        '
        'Label_FilterBy
        '
        Me.Label_FilterBy.AutoSize = True
        Me.Label_FilterBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_FilterBy.Location = New System.Drawing.Point(18, 9)
        Me.Label_FilterBy.Name = "Label_FilterBy"
        Me.Label_FilterBy.Size = New System.Drawing.Size(68, 15)
        Me.Label_FilterBy.TabIndex = 21
        Me.Label_FilterBy.Text = "Filter By: "
        '
        'Label_Select_Contract
        '
        Me.Label_Select_Contract.AutoSize = True
        Me.Label_Select_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contract.Location = New System.Drawing.Point(346, 9)
        Me.Label_Select_Contract.Name = "Label_Select_Contract"
        Me.Label_Select_Contract.Size = New System.Drawing.Size(114, 15)
        Me.Label_Select_Contract.TabIndex = 22
        Me.Label_Select_Contract.Text = "Select Contract:"
        '
        'Label_rate
        '
        Me.Label_rate.AutoSize = True
        Me.Label_rate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_rate.Location = New System.Drawing.Point(90, 189)
        Me.Label_rate.Name = "Label_rate"
        Me.Label_rate.Size = New System.Drawing.Size(41, 15)
        Me.Label_rate.TabIndex = 23
        Me.Label_rate.Text = "Rate:"
        '
        'Label_Hours_BG
        '
        Me.Label_Hours_BG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Hours_BG.Location = New System.Drawing.Point(12, 55)
        Me.Label_Hours_BG.Name = "Label_Hours_BG"
        Me.Label_Hours_BG.Size = New System.Drawing.Size(355, 460)
        Me.Label_Hours_BG.TabIndex = 24
        '
        'ListView_BG
        '
        Me.ListView_BG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ListView_BG.Location = New System.Drawing.Point(373, 55)
        Me.ListView_BG.Name = "ListView_BG"
        Me.ListView_BG.Size = New System.Drawing.Size(590, 460)
        Me.ListView_BG.TabIndex = 25
        '
        'Label_Links_BG
        '
        Me.Label_Links_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Links_BG.Location = New System.Drawing.Point(-1, 525)
        Me.Label_Links_BG.Name = "Label_Links_BG"
        Me.Label_Links_BG.Size = New System.Drawing.Size(976, 85)
        Me.Label_Links_BG.TabIndex = 26
        '
        'LinkLabel_Add_Contract_Hours
        '
        Me.LinkLabel_Add_Contract_Hours.AutoSize = True
        Me.LinkLabel_Add_Contract_Hours.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Contract_Hours.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Contract_Hours.Location = New System.Drawing.Point(18, 533)
        Me.LinkLabel_Add_Contract_Hours.Name = "LinkLabel_Add_Contract_Hours"
        Me.LinkLabel_Add_Contract_Hours.Size = New System.Drawing.Size(74, 15)
        Me.LinkLabel_Add_Contract_Hours.TabIndex = 27
        Me.LinkLabel_Add_Contract_Hours.TabStop = True
        Me.LinkLabel_Add_Contract_Hours.Text = "Add Hours"
        '
        'LinkLabel_Save_Hours
        '
        Me.LinkLabel_Save_Hours.AutoSize = True
        Me.LinkLabel_Save_Hours.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Hours.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Hours.Location = New System.Drawing.Point(18, 558)
        Me.LinkLabel_Save_Hours.Name = "LinkLabel_Save_Hours"
        Me.LinkLabel_Save_Hours.Size = New System.Drawing.Size(81, 15)
        Me.LinkLabel_Save_Hours.TabIndex = 28
        Me.LinkLabel_Save_Hours.TabStop = True
        Me.LinkLabel_Save_Hours.Text = "Save Hours"
        '
        'LinkLabel_Delete_Hours
        '
        Me.LinkLabel_Delete_Hours.AutoSize = True
        Me.LinkLabel_Delete_Hours.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Hours.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Hours.Location = New System.Drawing.Point(18, 583)
        Me.LinkLabel_Delete_Hours.Name = "LinkLabel_Delete_Hours"
        Me.LinkLabel_Delete_Hours.Size = New System.Drawing.Size(92, 15)
        Me.LinkLabel_Delete_Hours.TabIndex = 29
        Me.LinkLabel_Delete_Hours.TabStop = True
        Me.LinkLabel_Delete_Hours.Text = "Delete Hours"
        '
        'frm_Contracts_Hours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 607)
        Me.Controls.Add(Me.LinkLabel_Delete_Hours)
        Me.Controls.Add(Me.LinkLabel_Save_Hours)
        Me.Controls.Add(Me.LinkLabel_Add_Contract_Hours)
        Me.Controls.Add(Me.ListView_Contract_Hours)
        Me.Controls.Add(Me.Label_rate)
        Me.Controls.Add(Me.Label_Select_Contract)
        Me.Controls.Add(Me.Label_FilterBy)
        Me.Controls.Add(Me.Label_Name_Contract)
        Me.Controls.Add(Me.TextBox_Freq)
        Me.Controls.Add(Me.TextBox_Contract_Rate)
        Me.Controls.Add(Me.TextBox_Name_Current_Contract)
        Me.Controls.Add(Desc_Contracts_HoursLabel)
        Me.Controls.Add(Me.Desc_Contracts_HoursTextBox)
        Me.Controls.Add(Contracts_Hours1Label)
        Me.Controls.Add(Me.Contracts_Hours1TextBox)
        Me.Controls.Add(Date_Hours_WorkdLabel)
        Me.Controls.Add(Me.Date_Hours_WorkdDateTimePicker)
        Me.Controls.Add(Me.KY_ContractsTextBox)
        Me.Controls.Add(KY_Contracts_HoursLabel)
        Me.Controls.Add(Me.KY_Contracts_HoursTextBox)
        Me.Controls.Add(Me.ComboBox_Filter)
        Me.Controls.Add(Me.ComboBox_Contracts_Select)
        Me.Controls.Add(Me.Label_Contract_Hours_BG)
        Me.Controls.Add(Me.Label_Hours_BG)
        Me.Controls.Add(Me.ListView_BG)
        Me.Controls.Add(Me.Label_Links_BG)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_Contracts_Hours"
        Me.Text = "Manage Hours"
        CType(Me.Contracts_HoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Contract_Hours_BG As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Contracts_Select As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents Contracts_HoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_Contracts_HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Hours_WorkdDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Contracts_Hours1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Desc_Contracts_HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name_Current_Contract As System.Windows.Forms.TextBox
    Friend WithEvents ListView_Contract_Hours As System.Windows.Forms.ListView
    Friend WithEvents TextBox_Contract_Rate As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Freq As System.Windows.Forms.TextBox
    Friend WithEvents Label_Name_Contract As System.Windows.Forms.Label
    Friend WithEvents Label_FilterBy As System.Windows.Forms.Label
    Friend WithEvents Label_Select_Contract As System.Windows.Forms.Label
    Friend WithEvents Label_rate As System.Windows.Forms.Label
    Friend WithEvents Label_Hours_BG As System.Windows.Forms.Label
    Friend WithEvents ListView_BG As System.Windows.Forms.Label
    Friend WithEvents Label_Links_BG As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Contract_Hours As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Hours As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Hours As System.Windows.Forms.LinkLabel
End Class
