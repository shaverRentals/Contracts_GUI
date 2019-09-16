<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Version
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
        Dim Desc_VersionLabel As System.Windows.Forms.Label
        Dim Date_VersionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Version))
        Dim Number_VersionLabel As System.Windows.Forms.Label
        Dim KY_VersionLabel As System.Windows.Forms.Label
        Me.VersionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel_AddVersion = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Desc_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.Date_VersionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Number_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.KY_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel_SaveVersion = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_DeleteVersion = New System.Windows.Forms.LinkLabel()
        Desc_VersionLabel = New System.Windows.Forms.Label()
        Date_VersionLabel = New System.Windows.Forms.Label()
        Number_VersionLabel = New System.Windows.Forms.Label()
        KY_VersionLabel = New System.Windows.Forms.Label()
        CType(Me.VersionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VersionsBindingSource
        '
        Me.VersionsBindingSource.DataSource = GetType(Contracts.Version)
        '
        'LinkLabel_AddVersion
        '
        Me.LinkLabel_AddVersion.AutoSize = True
        Me.LinkLabel_AddVersion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_AddVersion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_AddVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_AddVersion.Location = New System.Drawing.Point(12, 269)
        Me.LinkLabel_AddVersion.Name = "LinkLabel_AddVersion"
        Me.LinkLabel_AddVersion.Size = New System.Drawing.Size(85, 15)
        Me.LinkLabel_AddVersion.TabIndex = 11
        Me.LinkLabel_AddVersion.TabStop = True
        Me.LinkLabel_AddVersion.Text = "Add Version"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(0, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 88)
        Me.Label2.TabIndex = 10
        '
        'Desc_VersionLabel
        '
        Desc_VersionLabel.AutoSize = True
        Desc_VersionLabel.BackColor = System.Drawing.SystemColors.Control
        Desc_VersionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Desc_VersionLabel.Location = New System.Drawing.Point(44, 127)
        Desc_VersionLabel.Name = "Desc_VersionLabel"
        Desc_VersionLabel.Size = New System.Drawing.Size(87, 15)
        Desc_VersionLabel.TabIndex = 8
        Desc_VersionLabel.Text = "Description:"
        '
        'Desc_VersionTextBox
        '
        Me.Desc_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VersionsBindingSource, "Desc_Version", True))
        Me.Desc_VersionTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_VersionTextBox.Location = New System.Drawing.Point(137, 127)
        Me.Desc_VersionTextBox.Multiline = True
        Me.Desc_VersionTextBox.Name = "Desc_VersionTextBox"
        Me.Desc_VersionTextBox.Size = New System.Drawing.Size(306, 114)
        Me.Desc_VersionTextBox.TabIndex = 9
        '
        'Date_VersionLabel
        '
        Date_VersionLabel.AutoSize = True
        Date_VersionLabel.BackColor = System.Drawing.SystemColors.Control
        Date_VersionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_VersionLabel.Location = New System.Drawing.Point(36, 98)
        Date_VersionLabel.Name = "Date_VersionLabel"
        Date_VersionLabel.Size = New System.Drawing.Size(95, 15)
        Date_VersionLabel.TabIndex = 6
        Date_VersionLabel.Text = "Version Date:"
        '
        'Date_VersionDateTimePicker
        '
        Me.Date_VersionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VersionsBindingSource, "Date_Version", True))
        Me.Date_VersionDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_VersionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_VersionDateTimePicker.Location = New System.Drawing.Point(137, 98)
        Me.Date_VersionDateTimePicker.Name = "Date_VersionDateTimePicker"
        Me.Date_VersionDateTimePicker.Size = New System.Drawing.Size(306, 23)
        Me.Date_VersionDateTimePicker.TabIndex = 7
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.VersionsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(456, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'Number_VersionLabel
        '
        Number_VersionLabel.AutoSize = True
        Number_VersionLabel.BackColor = System.Drawing.SystemColors.Control
        Number_VersionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_VersionLabel.Location = New System.Drawing.Point(15, 72)
        Number_VersionLabel.Name = "Number_VersionLabel"
        Number_VersionLabel.Size = New System.Drawing.Size(116, 15)
        Number_VersionLabel.TabIndex = 3
        Number_VersionLabel.Text = "Version Number:"
        '
        'Number_VersionTextBox
        '
        Me.Number_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VersionsBindingSource, "Number_Version", True))
        Me.Number_VersionTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_VersionTextBox.Location = New System.Drawing.Point(137, 69)
        Me.Number_VersionTextBox.Name = "Number_VersionTextBox"
        Me.Number_VersionTextBox.Size = New System.Drawing.Size(306, 23)
        Me.Number_VersionTextBox.TabIndex = 4
        '
        'KY_VersionLabel
        '
        KY_VersionLabel.AutoSize = True
        KY_VersionLabel.BackColor = System.Drawing.SystemColors.Control
        KY_VersionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KY_VersionLabel.Location = New System.Drawing.Point(50, 43)
        KY_VersionLabel.Name = "KY_VersionLabel"
        KY_VersionLabel.Size = New System.Drawing.Size(81, 15)
        KY_VersionLabel.TabIndex = 1
        KY_VersionLabel.Text = "Version ID :"
        '
        'KY_VersionTextBox
        '
        Me.KY_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VersionsBindingSource, "KY_Version", True))
        Me.KY_VersionTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY_VersionTextBox.Location = New System.Drawing.Point(137, 40)
        Me.KY_VersionTextBox.Name = "KY_VersionTextBox"
        Me.KY_VersionTextBox.Size = New System.Drawing.Size(306, 23)
        Me.KY_VersionTextBox.TabIndex = 2
        '
        'LinkLabel_SaveVersion
        '
        Me.LinkLabel_SaveVersion.AutoSize = True
        Me.LinkLabel_SaveVersion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_SaveVersion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_SaveVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_SaveVersion.Location = New System.Drawing.Point(12, 295)
        Me.LinkLabel_SaveVersion.Name = "LinkLabel_SaveVersion"
        Me.LinkLabel_SaveVersion.Size = New System.Drawing.Size(92, 15)
        Me.LinkLabel_SaveVersion.TabIndex = 12
        Me.LinkLabel_SaveVersion.TabStop = True
        Me.LinkLabel_SaveVersion.Text = "Save Version"
        '
        'LinkLabel_DeleteVersion
        '
        Me.LinkLabel_DeleteVersion.AutoSize = True
        Me.LinkLabel_DeleteVersion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel_DeleteVersion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_DeleteVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_DeleteVersion.Location = New System.Drawing.Point(12, 323)
        Me.LinkLabel_DeleteVersion.Name = "LinkLabel_DeleteVersion"
        Me.LinkLabel_DeleteVersion.Size = New System.Drawing.Size(103, 15)
        Me.LinkLabel_DeleteVersion.TabIndex = 13
        Me.LinkLabel_DeleteVersion.TabStop = True
        Me.LinkLabel_DeleteVersion.Text = "Delete Version"
        '
        'frm_Version
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 347)
        Me.Controls.Add(Me.LinkLabel_DeleteVersion)
        Me.Controls.Add(Me.LinkLabel_SaveVersion)
        Me.Controls.Add(Me.LinkLabel_AddVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Desc_VersionLabel)
        Me.Controls.Add(Me.Desc_VersionTextBox)
        Me.Controls.Add(Date_VersionLabel)
        Me.Controls.Add(Me.Date_VersionDateTimePicker)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Number_VersionLabel)
        Me.Controls.Add(Me.Number_VersionTextBox)
        Me.Controls.Add(KY_VersionLabel)
        Me.Controls.Add(Me.KY_VersionTextBox)
        Me.Name = "frm_Version"
        Me.Text = "Versions"
        CType(Me.VersionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VersionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KY_VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Number_VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Date_VersionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desc_VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_AddVersion As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_SaveVersion As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_DeleteVersion As System.Windows.Forms.LinkLabel
End Class
