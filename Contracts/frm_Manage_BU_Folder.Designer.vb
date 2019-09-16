<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Manage_BU_Folder
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
        Me.cbo_BU_Folder = New System.Windows.Forms.ComboBox()
        Me.Lbl_Current_BU_Folder = New System.Windows.Forms.Label()
        Me.LinkLabel_Add_BU_Folder = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Remove_BU_Folder_Location = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_SetBackup_Folder = New System.Windows.Forms.LinkLabel()
        Me.Label_SelectBUFolder = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbo_BU_Folder
        '
        Me.cbo_BU_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BU_Folder.FormattingEnabled = True
        Me.cbo_BU_Folder.Location = New System.Drawing.Point(294, 46)
        Me.cbo_BU_Folder.Name = "cbo_BU_Folder"
        Me.cbo_BU_Folder.Size = New System.Drawing.Size(333, 23)
        Me.cbo_BU_Folder.TabIndex = 0
        '
        'Lbl_Current_BU_Folder
        '
        Me.Lbl_Current_BU_Folder.AutoSize = True
        Me.Lbl_Current_BU_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Current_BU_Folder.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_Current_BU_Folder.Location = New System.Drawing.Point(12, 21)
        Me.Lbl_Current_BU_Folder.Name = "Lbl_Current_BU_Folder"
        Me.Lbl_Current_BU_Folder.Size = New System.Drawing.Size(28, 15)
        Me.Lbl_Current_BU_Folder.TabIndex = 1
        Me.Lbl_Current_BU_Folder.Text = "xxx"
        '
        'LinkLabel_Add_BU_Folder
        '
        Me.LinkLabel_Add_BU_Folder.AutoSize = True
        Me.LinkLabel_Add_BU_Folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_BU_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_BU_Folder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_BU_Folder.Location = New System.Drawing.Point(12, 97)
        Me.LinkLabel_Add_BU_Folder.Name = "LinkLabel_Add_BU_Folder"
        Me.LinkLabel_Add_BU_Folder.Size = New System.Drawing.Size(271, 15)
        Me.LinkLabel_Add_BU_Folder.TabIndex = 2
        Me.LinkLabel_Add_BU_Folder.TabStop = True
        Me.LinkLabel_Add_BU_Folder.Text = "Add Backup Folder Location Value to List"
        '
        'LinkLabel_Remove_BU_Folder_Location
        '
        Me.LinkLabel_Remove_BU_Folder_Location.AutoSize = True
        Me.LinkLabel_Remove_BU_Folder_Location.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Remove_BU_Folder_Location.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Remove_BU_Folder_Location.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Remove_BU_Folder_Location.Location = New System.Drawing.Point(12, 123)
        Me.LinkLabel_Remove_BU_Folder_Location.Name = "LinkLabel_Remove_BU_Folder_Location"
        Me.LinkLabel_Remove_BU_Folder_Location.Size = New System.Drawing.Size(219, 15)
        Me.LinkLabel_Remove_BU_Folder_Location.TabIndex = 3
        Me.LinkLabel_Remove_BU_Folder_Location.TabStop = True
        Me.LinkLabel_Remove_BU_Folder_Location.Text = "Remove Backup Folder From List"
        '
        'LinkLabel_SetBackup_Folder
        '
        Me.LinkLabel_SetBackup_Folder.AutoSize = True
        Me.LinkLabel_SetBackup_Folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_SetBackup_Folder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_SetBackup_Folder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_SetBackup_Folder.Location = New System.Drawing.Point(12, 147)
        Me.LinkLabel_SetBackup_Folder.Name = "LinkLabel_SetBackup_Folder"
        Me.LinkLabel_SetBackup_Folder.Size = New System.Drawing.Size(189, 15)
        Me.LinkLabel_SetBackup_Folder.TabIndex = 4
        Me.LinkLabel_SetBackup_Folder.TabStop = True
        Me.LinkLabel_SetBackup_Folder.Text = "Set Selected Backup Folder "
        '
        'Label_SelectBUFolder
        '
        Me.Label_SelectBUFolder.AutoSize = True
        Me.Label_SelectBUFolder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SelectBUFolder.Location = New System.Drawing.Point(12, 48)
        Me.Label_SelectBUFolder.Name = "Label_SelectBUFolder"
        Me.Label_SelectBUFolder.Size = New System.Drawing.Size(276, 15)
        Me.Label_SelectBUFolder.TabIndex = 5
        Me.Label_SelectBUFolder.Text = "Select Backup Folder Location From List: "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(-2, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 140)
        Me.Label1.TabIndex = 6
        '
        'frm_Manage_BU_Folder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 182)
        Me.Controls.Add(Me.Label_SelectBUFolder)
        Me.Controls.Add(Me.LinkLabel_SetBackup_Folder)
        Me.Controls.Add(Me.LinkLabel_Remove_BU_Folder_Location)
        Me.Controls.Add(Me.LinkLabel_Add_BU_Folder)
        Me.Controls.Add(Me.Lbl_Current_BU_Folder)
        Me.Controls.Add(Me.cbo_BU_Folder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Manage_BU_Folder"
        Me.Text = "Manage Backup Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_BU_Folder As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Current_BU_Folder As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Add_BU_Folder As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Remove_BU_Folder_Location As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_SetBackup_Folder As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_SelectBUFolder As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
