<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageDBConn
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
        Me.Lbl_Database_Name = New System.Windows.Forms.Label()
        Me.Label_Server_Name = New System.Windows.Forms.Label()
        Me.Label_CurrentDatabaseName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuickHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbo_database_Name = New System.Windows.Forms.ComboBox()
        Me.LinkLabel_Add_Database_Name = New System.Windows.Forms.LinkLabel()
        Me.lbl_Background = New System.Windows.Forms.Label()
        Me.cbo_Server_Name = New System.Windows.Forms.ComboBox()
        Me.LinkLabel_Add_Server_Name = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Removed_Selected_Values = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Set_Server_and_DB = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Database_Name
        '
        Me.Lbl_Database_Name.AutoSize = True
        Me.Lbl_Database_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Database_Name.Location = New System.Drawing.Point(10, 60)
        Me.Lbl_Database_Name.Name = "Lbl_Database_Name"
        Me.Lbl_Database_Name.Size = New System.Drawing.Size(215, 15)
        Me.Lbl_Database_Name.TabIndex = 1
        Me.Lbl_Database_Name.Text = "Select or Enter Database Name:"
        '
        'Label_Server_Name
        '
        Me.Label_Server_Name.AutoSize = True
        Me.Label_Server_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Server_Name.Location = New System.Drawing.Point(30, 92)
        Me.Label_Server_Name.Name = "Label_Server_Name"
        Me.Label_Server_Name.Size = New System.Drawing.Size(195, 15)
        Me.Label_Server_Name.TabIndex = 3
        Me.Label_Server_Name.Text = "Select or Enter Server name:"
        '
        'Label_CurrentDatabaseName
        '
        Me.Label_CurrentDatabaseName.AutoSize = True
        Me.Label_CurrentDatabaseName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CurrentDatabaseName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label_CurrentDatabaseName.Location = New System.Drawing.Point(12, 34)
        Me.Label_CurrentDatabaseName.Name = "Label_CurrentDatabaseName"
        Me.Label_CurrentDatabaseName.Size = New System.Drawing.Size(31, 15)
        Me.Label_CurrentDatabaseName.TabIndex = 7
        Me.Label_CurrentDatabaseName.Text = "XXX"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickHelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuickHelpToolStripMenuItem
        '
        Me.QuickHelpToolStripMenuItem.Name = "QuickHelpToolStripMenuItem"
        Me.QuickHelpToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.QuickHelpToolStripMenuItem.Text = "Quick Help"
        '
        'cbo_database_Name
        '
        Me.cbo_database_Name.FormattingEnabled = True
        Me.cbo_database_Name.Location = New System.Drawing.Point(231, 60)
        Me.cbo_database_Name.Name = "cbo_database_Name"
        Me.cbo_database_Name.Size = New System.Drawing.Size(294, 21)
        Me.cbo_database_Name.TabIndex = 10
        '
        'LinkLabel_Add_Database_Name
        '
        Me.LinkLabel_Add_Database_Name.AutoSize = True
        Me.LinkLabel_Add_Database_Name.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Database_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Database_Name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Database_Name.Location = New System.Drawing.Point(10, 133)
        Me.LinkLabel_Add_Database_Name.Name = "LinkLabel_Add_Database_Name"
        Me.LinkLabel_Add_Database_Name.Size = New System.Drawing.Size(235, 15)
        Me.LinkLabel_Add_Database_Name.TabIndex = 11
        Me.LinkLabel_Add_Database_Name.TabStop = True
        Me.LinkLabel_Add_Database_Name.Text = "Add Entered Database Value to List"
        '
        'lbl_Background
        '
        Me.lbl_Background.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Background.Location = New System.Drawing.Point(-3, 120)
        Me.lbl_Background.Name = "lbl_Background"
        Me.lbl_Background.Size = New System.Drawing.Size(585, 116)
        Me.lbl_Background.TabIndex = 12
        '
        'cbo_Server_Name
        '
        Me.cbo_Server_Name.FormattingEnabled = True
        Me.cbo_Server_Name.Location = New System.Drawing.Point(231, 86)
        Me.cbo_Server_Name.Name = "cbo_Server_Name"
        Me.cbo_Server_Name.Size = New System.Drawing.Size(294, 21)
        Me.cbo_Server_Name.TabIndex = 13
        '
        'LinkLabel_Add_Server_Name
        '
        Me.LinkLabel_Add_Server_Name.AutoSize = True
        Me.LinkLabel_Add_Server_Name.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Add_Server_Name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Add_Server_Name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Add_Server_Name.Location = New System.Drawing.Point(10, 157)
        Me.LinkLabel_Add_Server_Name.Name = "LinkLabel_Add_Server_Name"
        Me.LinkLabel_Add_Server_Name.Size = New System.Drawing.Size(258, 15)
        Me.LinkLabel_Add_Server_Name.TabIndex = 14
        Me.LinkLabel_Add_Server_Name.TabStop = True
        Me.LinkLabel_Add_Server_Name.Text = "Add Entered Server Name Value to List"
        '
        'LinkLabel_Removed_Selected_Values
        '
        Me.LinkLabel_Removed_Selected_Values.AutoSize = True
        Me.LinkLabel_Removed_Selected_Values.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Removed_Selected_Values.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Removed_Selected_Values.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Removed_Selected_Values.Location = New System.Drawing.Point(10, 181)
        Me.LinkLabel_Removed_Selected_Values.Name = "LinkLabel_Removed_Selected_Values"
        Me.LinkLabel_Removed_Selected_Values.Size = New System.Drawing.Size(167, 15)
        Me.LinkLabel_Removed_Selected_Values.TabIndex = 15
        Me.LinkLabel_Removed_Selected_Values.TabStop = True
        Me.LinkLabel_Removed_Selected_Values.Text = "Remove Selected Values"
        '
        'LinkLabel_Set_Server_and_DB
        '
        Me.LinkLabel_Set_Server_and_DB.AutoSize = True
        Me.LinkLabel_Set_Server_and_DB.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_Set_Server_and_DB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Set_Server_and_DB.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_Set_Server_and_DB.Location = New System.Drawing.Point(10, 206)
        Me.LinkLabel_Set_Server_and_DB.Name = "LinkLabel_Set_Server_and_DB"
        Me.LinkLabel_Set_Server_and_DB.Size = New System.Drawing.Size(292, 15)
        Me.LinkLabel_Set_Server_and_DB.TabIndex = 16
        Me.LinkLabel_Set_Server_and_DB.TabStop = True
        Me.LinkLabel_Set_Server_and_DB.Text = "Set Database and Server to Selected Values"
        '
        'frm_ManageDBConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 230)
        Me.Controls.Add(Me.LinkLabel_Set_Server_and_DB)
        Me.Controls.Add(Me.LinkLabel_Removed_Selected_Values)
        Me.Controls.Add(Me.LinkLabel_Add_Server_Name)
        Me.Controls.Add(Me.cbo_Server_Name)
        Me.Controls.Add(Me.LinkLabel_Add_Database_Name)
        Me.Controls.Add(Me.cbo_database_Name)
        Me.Controls.Add(Me.Label_CurrentDatabaseName)
        Me.Controls.Add(Me.Label_Server_Name)
        Me.Controls.Add(Me.Lbl_Database_Name)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_ManageDBConn"
        Me.Text = ""
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Database_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Server_Name As System.Windows.Forms.Label
    Friend WithEvents Label_CurrentDatabaseName As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuickHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbo_database_Name As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel_Add_Database_Name As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Background As System.Windows.Forms.Label
    Friend WithEvents cbo_Server_Name As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel_Add_Server_Name As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Removed_Selected_Values As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Set_Server_and_DB As System.Windows.Forms.LinkLabel
End Class
