<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contract_Tasks
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
        Dim Notes_TaskLabel As System.Windows.Forms.Label
        Dim Desc_TasksLabel As System.Windows.Forms.Label
        Dim Date_Due_taskLabel As System.Windows.Forms.Label
        Dim KY_TasksLabel As System.Windows.Forms.Label
        Me.TasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel_Save_Task = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Add_Task = New System.Windows.Forms.LinkLabel()
        Me.Label_Links_BG = New System.Windows.Forms.Label()
        Me.Label_Task_Status = New System.Windows.Forms.Label()
        Me.Label_Name_Contract = New System.Windows.Forms.Label()
        Me.ListView_Contract_Tasks = New System.Windows.Forms.ListView()
        Me.TextBox_Name_Contract = New System.Windows.Forms.TextBox()
        Me.ComboBox_Task_Status = New System.Windows.Forms.ComboBox()
        Me.Notes_TaskTextBox = New System.Windows.Forms.TextBox()
        Me.KY_ContractsTextBox = New System.Windows.Forms.TextBox()
        Me.Desc_TasksTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Due_taskDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KY_TasksTextBox = New System.Windows.Forms.TextBox()
        Me.Label_Select_Contract = New System.Windows.Forms.Label()
        Me.ComboBox_Contracts_Select = New System.Windows.Forms.ComboBox()
        Me.Label_FilterBy = New System.Windows.Forms.Label()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.Label_Contract_Hours_BG = New System.Windows.Forms.Label()
        Me.Label_Tasks_BG = New System.Windows.Forms.Label()
        Me.Label_ListView_BG = New System.Windows.Forms.Label()
        Me.LinkLabel_Delete_Task = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Create_Contract_Task_Folder = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_OpenTasksFolder = New System.Windows.Forms.LinkLabel()
        Notes_TaskLabel = New System.Windows.Forms.Label()
        Desc_TasksLabel = New System.Windows.Forms.Label()
        Date_Due_taskLabel = New System.Windows.Forms.Label()
        KY_TasksLabel = New System.Windows.Forms.Label()
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Notes_TaskLabel
        '
        Notes_TaskLabel.AutoSize = True
        Notes_TaskLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Notes_TaskLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Notes_TaskLabel.Location = New System.Drawing.Point(25, 231)
        Notes_TaskLabel.Name = "Notes_TaskLabel"
        Notes_TaskLabel.Size = New System.Drawing.Size(82, 15)
        Notes_TaskLabel.TabIndex = 29
        Notes_TaskLabel.Text = "Notes Task:"
        '
        'Desc_TasksLabel
        '
        Desc_TasksLabel.AutoSize = True
        Desc_TasksLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Desc_TasksLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_TasksLabel.Location = New System.Drawing.Point(39, 137)
        Desc_TasksLabel.Name = "Desc_TasksLabel"
        Desc_TasksLabel.Size = New System.Drawing.Size(87, 15)
        Desc_TasksLabel.TabIndex = 27
        Desc_TasksLabel.Text = "Description:"
        '
        'Date_Due_taskLabel
        '
        Date_Due_taskLabel.AutoSize = True
        Date_Due_taskLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Date_Due_taskLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Due_taskLabel.Location = New System.Drawing.Point(25, 170)
        Date_Due_taskLabel.Name = "Date_Due_taskLabel"
        Date_Due_taskLabel.Size = New System.Drawing.Size(101, 15)
        Date_Due_taskLabel.TabIndex = 26
        Date_Due_taskLabel.Text = "Date Due task:"
        '
        'KY_TasksLabel
        '
        KY_TasksLabel.AutoSize = True
        KY_TasksLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        KY_TasksLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_TasksLabel.Location = New System.Drawing.Point(68, 111)
        KY_TasksLabel.Name = "KY_TasksLabel"
        KY_TasksLabel.Size = New System.Drawing.Size(58, 15)
        KY_TasksLabel.TabIndex = 25
        KY_TasksLabel.Text = "Task ID:"
        '
        'TasksBindingSource
        '
        Me.TasksBindingSource.DataSource = GetType(System.Data.Objects.DataClasses.EntityCollection(Of Contracts.Task))
        '
        'LinkLabel_Save_Task
        '
        Me.LinkLabel_Save_Task.AutoSize = True
        Me.LinkLabel_Save_Task.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Save_Task.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Save_Task.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Save_Task.Location = New System.Drawing.Point(4, 417)
        Me.LinkLabel_Save_Task.Name = "LinkLabel_Save_Task"
        Me.LinkLabel_Save_Task.Size = New System.Drawing.Size(72, 15)
        Me.LinkLabel_Save_Task.TabIndex = 40
        Me.LinkLabel_Save_Task.TabStop = True
        Me.LinkLabel_Save_Task.Text = "Save Task"
        '
        'LinkLabel_Add_Task
        '
        Me.LinkLabel_Add_Task.AutoSize = True
        Me.LinkLabel_Add_Task.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Task.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Task.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Task.Location = New System.Drawing.Point(4, 391)
        Me.LinkLabel_Add_Task.Name = "LinkLabel_Add_Task"
        Me.LinkLabel_Add_Task.Size = New System.Drawing.Size(65, 15)
        Me.LinkLabel_Add_Task.TabIndex = 39
        Me.LinkLabel_Add_Task.TabStop = True
        Me.LinkLabel_Add_Task.Text = "Add Task"
        '
        'Label_Links_BG
        '
        Me.Label_Links_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Links_BG.Location = New System.Drawing.Point(-3, 378)
        Me.Label_Links_BG.Name = "Label_Links_BG"
        Me.Label_Links_BG.Size = New System.Drawing.Size(976, 89)
        Me.Label_Links_BG.TabIndex = 37
        '
        'Label_Task_Status
        '
        Me.Label_Task_Status.AutoSize = True
        Me.Label_Task_Status.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Task_Status.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Task_Status.Location = New System.Drawing.Point(77, 201)
        Me.Label_Task_Status.Name = "Label_Task_Status"
        Me.Label_Task_Status.Size = New System.Drawing.Size(49, 15)
        Me.Label_Task_Status.TabIndex = 35
        Me.Label_Task_Status.Text = "Status"
        '
        'Label_Name_Contract
        '
        Me.Label_Name_Contract.AutoSize = True
        Me.Label_Name_Contract.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Name_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name_Contract.Location = New System.Drawing.Point(16, 82)
        Me.Label_Name_Contract.Name = "Label_Name_Contract"
        Me.Label_Name_Contract.Size = New System.Drawing.Size(110, 15)
        Me.Label_Name_Contract.TabIndex = 34
        Me.Label_Name_Contract.Text = "Contract Name:"
        '
        'ListView_Contract_Tasks
        '
        Me.ListView_Contract_Tasks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Contract_Tasks.FullRowSelect = True
        Me.ListView_Contract_Tasks.GridLines = True
        Me.ListView_Contract_Tasks.Location = New System.Drawing.Point(364, 69)
        Me.ListView_Contract_Tasks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView_Contract_Tasks.Name = "ListView_Contract_Tasks"
        Me.ListView_Contract_Tasks.Size = New System.Drawing.Size(581, 284)
        Me.ListView_Contract_Tasks.TabIndex = 33
        Me.ListView_Contract_Tasks.UseCompatibleStateImageBehavior = False
        Me.ListView_Contract_Tasks.View = System.Windows.Forms.View.Details
        '
        'TextBox_Name_Contract
        '
        Me.TextBox_Name_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name_Contract.Location = New System.Drawing.Point(132, 79)
        Me.TextBox_Name_Contract.Name = "TextBox_Name_Contract"
        Me.TextBox_Name_Contract.Size = New System.Drawing.Size(114, 23)
        Me.TextBox_Name_Contract.TabIndex = 32
        '
        'ComboBox_Task_Status
        '
        Me.ComboBox_Task_Status.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Task_Status.FormattingEnabled = True
        Me.ComboBox_Task_Status.Location = New System.Drawing.Point(132, 193)
        Me.ComboBox_Task_Status.Name = "ComboBox_Task_Status"
        Me.ComboBox_Task_Status.Size = New System.Drawing.Size(186, 23)
        Me.ComboBox_Task_Status.TabIndex = 31
        '
        'Notes_TaskTextBox
        '
        Me.Notes_TaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "Notes_Task", True))
        Me.Notes_TaskTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes_TaskTextBox.Location = New System.Drawing.Point(28, 249)
        Me.Notes_TaskTextBox.Multiline = True
        Me.Notes_TaskTextBox.Name = "Notes_TaskTextBox"
        Me.Notes_TaskTextBox.Size = New System.Drawing.Size(290, 104)
        Me.Notes_TaskTextBox.TabIndex = 30
        '
        'KY_ContractsTextBox
        '
        Me.KY_ContractsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "KY_Contracts", True))
        Me.KY_ContractsTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_ContractsTextBox.Location = New System.Drawing.Point(252, 79)
        Me.KY_ContractsTextBox.Name = "KY_ContractsTextBox"
        Me.KY_ContractsTextBox.Size = New System.Drawing.Size(66, 23)
        Me.KY_ContractsTextBox.TabIndex = 29
        '
        'Desc_TasksTextBox
        '
        Me.Desc_TasksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "Desc_Tasks", True))
        Me.Desc_TasksTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_TasksTextBox.Location = New System.Drawing.Point(132, 135)
        Me.Desc_TasksTextBox.Name = "Desc_TasksTextBox"
        Me.Desc_TasksTextBox.Size = New System.Drawing.Size(186, 23)
        Me.Desc_TasksTextBox.TabIndex = 28
        '
        'Date_Due_taskDateTimePicker
        '
        Me.Date_Due_taskDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TasksBindingSource, "Date_Due_task", True))
        Me.Date_Due_taskDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Due_taskDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Due_taskDateTimePicker.Location = New System.Drawing.Point(132, 164)
        Me.Date_Due_taskDateTimePicker.Name = "Date_Due_taskDateTimePicker"
        Me.Date_Due_taskDateTimePicker.Size = New System.Drawing.Size(186, 23)
        Me.Date_Due_taskDateTimePicker.TabIndex = 27
        '
        'KY_TasksTextBox
        '
        Me.KY_TasksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "KY_Tasks", True))
        Me.KY_TasksTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_TasksTextBox.Location = New System.Drawing.Point(132, 109)
        Me.KY_TasksTextBox.Name = "KY_TasksTextBox"
        Me.KY_TasksTextBox.Size = New System.Drawing.Size(186, 23)
        Me.KY_TasksTextBox.TabIndex = 26
        '
        'Label_Select_Contract
        '
        Me.Label_Select_Contract.AutoSize = True
        Me.Label_Select_Contract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Select_Contract.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Select_Contract.Location = New System.Drawing.Point(322, 12)
        Me.Label_Select_Contract.Name = "Label_Select_Contract"
        Me.Label_Select_Contract.Size = New System.Drawing.Size(114, 15)
        Me.Label_Select_Contract.TabIndex = 24
        Me.Label_Select_Contract.Text = "Select Contract:"
        '
        'ComboBox_Contracts_Select
        '
        Me.ComboBox_Contracts_Select.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Contracts_Select.FormattingEnabled = True
        Me.ComboBox_Contracts_Select.Location = New System.Drawing.Point(443, 9)
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
        Me.Label_FilterBy.Location = New System.Drawing.Point(4, 9)
        Me.Label_FilterBy.Name = "Label_FilterBy"
        Me.Label_FilterBy.Size = New System.Drawing.Size(68, 15)
        Me.Label_FilterBy.TabIndex = 22
        Me.Label_FilterBy.Text = "Filter By: "
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(74, 9)
        Me.ComboBox_Filter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(215, 23)
        Me.ComboBox_Filter.TabIndex = 10
        '
        'Label_Contract_Hours_BG
        '
        Me.Label_Contract_Hours_BG.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_Contract_Hours_BG.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contract_Hours_BG.Location = New System.Drawing.Point(-3, -2)
        Me.Label_Contract_Hours_BG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Contract_Hours_BG.Name = "Label_Contract_Hours_BG"
        Me.Label_Contract_Hours_BG.Size = New System.Drawing.Size(976, 46)
        Me.Label_Contract_Hours_BG.TabIndex = 1
        '
        'Label_Tasks_BG
        '
        Me.Label_Tasks_BG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Tasks_BG.Location = New System.Drawing.Point(12, 59)
        Me.Label_Tasks_BG.Name = "Label_Tasks_BG"
        Me.Label_Tasks_BG.Size = New System.Drawing.Size(322, 306)
        Me.Label_Tasks_BG.TabIndex = 36
        '
        'Label_ListView_BG
        '
        Me.Label_ListView_BG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_ListView_BG.Location = New System.Drawing.Point(351, 59)
        Me.Label_ListView_BG.Name = "Label_ListView_BG"
        Me.Label_ListView_BG.Size = New System.Drawing.Size(609, 306)
        Me.Label_ListView_BG.TabIndex = 38
        '
        'LinkLabel_Delete_Task
        '
        Me.LinkLabel_Delete_Task.AutoSize = True
        Me.LinkLabel_Delete_Task.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Delete_Task.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Delete_Task.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Delete_Task.Location = New System.Drawing.Point(4, 443)
        Me.LinkLabel_Delete_Task.Name = "LinkLabel_Delete_Task"
        Me.LinkLabel_Delete_Task.Size = New System.Drawing.Size(83, 15)
        Me.LinkLabel_Delete_Task.TabIndex = 41
        Me.LinkLabel_Delete_Task.TabStop = True
        Me.LinkLabel_Delete_Task.Text = "Delete Task"
        '
        'LinkLabel_Create_Contract_Task_Folder
        '
        Me.LinkLabel_Create_Contract_Task_Folder.AutoSize = True
        Me.LinkLabel_Create_Contract_Task_Folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Create_Contract_Task_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Create_Contract_Task_Folder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Create_Contract_Task_Folder.Location = New System.Drawing.Point(98, 393)
        Me.LinkLabel_Create_Contract_Task_Folder.Name = "LinkLabel_Create_Contract_Task_Folder"
        Me.LinkLabel_Create_Contract_Task_Folder.Size = New System.Drawing.Size(130, 15)
        Me.LinkLabel_Create_Contract_Task_Folder.TabIndex = 42
        Me.LinkLabel_Create_Contract_Task_Folder.TabStop = True
        Me.LinkLabel_Create_Contract_Task_Folder.Text = "Create Task Folder"
        '
        'LinkLabel_OpenTasksFolder
        '
        Me.LinkLabel_OpenTasksFolder.AutoSize = True
        Me.LinkLabel_OpenTasksFolder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_OpenTasksFolder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenTasksFolder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_OpenTasksFolder.Location = New System.Drawing.Point(98, 417)
        Me.LinkLabel_OpenTasksFolder.Name = "LinkLabel_OpenTasksFolder"
        Me.LinkLabel_OpenTasksFolder.Size = New System.Drawing.Size(119, 15)
        Me.LinkLabel_OpenTasksFolder.TabIndex = 43
        Me.LinkLabel_OpenTasksFolder.TabStop = True
        Me.LinkLabel_OpenTasksFolder.Text = "Open Task Folder"
        '
        'frm_Contract_Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 465)
        Me.Controls.Add(Me.LinkLabel_OpenTasksFolder)
        Me.Controls.Add(Me.LinkLabel_Create_Contract_Task_Folder)
        Me.Controls.Add(Me.LinkLabel_Delete_Task)
        Me.Controls.Add(Me.LinkLabel_Save_Task)
        Me.Controls.Add(Me.LinkLabel_Add_Task)
        Me.Controls.Add(Me.Label_Links_BG)
        Me.Controls.Add(Me.Label_Task_Status)
        Me.Controls.Add(Me.Label_Name_Contract)
        Me.Controls.Add(Me.ListView_Contract_Tasks)
        Me.Controls.Add(Me.TextBox_Name_Contract)
        Me.Controls.Add(Me.ComboBox_Task_Status)
        Me.Controls.Add(Notes_TaskLabel)
        Me.Controls.Add(Me.Notes_TaskTextBox)
        Me.Controls.Add(Me.KY_ContractsTextBox)
        Me.Controls.Add(Desc_TasksLabel)
        Me.Controls.Add(Me.Desc_TasksTextBox)
        Me.Controls.Add(Date_Due_taskLabel)
        Me.Controls.Add(Me.Date_Due_taskDateTimePicker)
        Me.Controls.Add(KY_TasksLabel)
        Me.Controls.Add(Me.KY_TasksTextBox)
        Me.Controls.Add(Me.Label_Select_Contract)
        Me.Controls.Add(Me.ComboBox_Contracts_Select)
        Me.Controls.Add(Me.Label_FilterBy)
        Me.Controls.Add(Me.ComboBox_Filter)
        Me.Controls.Add(Me.Label_Contract_Hours_BG)
        Me.Controls.Add(Me.Label_Tasks_BG)
        Me.Controls.Add(Me.Label_ListView_BG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Contract_Tasks"
        Me.Text = "frm_Contract_Tasks"
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Contract_Hours_BG As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label_FilterBy As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Contracts_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Select_Contract As System.Windows.Forms.Label
    Friend WithEvents TasksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_TasksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Due_taskDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desc_TasksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KY_ContractsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Notes_TaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Task_Status As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Name_Contract As System.Windows.Forms.TextBox
    Friend WithEvents ListView_Contract_Tasks As System.Windows.Forms.ListView
    Friend WithEvents Label_Name_Contract As System.Windows.Forms.Label
    Friend WithEvents Label_Task_Status As System.Windows.Forms.Label
    Friend WithEvents Label_Tasks_BG As System.Windows.Forms.Label
    Friend WithEvents Label_Links_BG As System.Windows.Forms.Label
    Friend WithEvents Label_ListView_BG As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_Task As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Save_Task As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Delete_Task As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Create_Contract_Task_Folder As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_OpenTasksFolder As System.Windows.Forms.LinkLabel
End Class
