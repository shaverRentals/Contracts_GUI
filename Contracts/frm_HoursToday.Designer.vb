<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HoursToday
    Inherits System.Windows.Forms.Form

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
        Me.Label_Hrs = New System.Windows.Forms.Label()
        Me.Label_Week = New System.Windows.Forms.Label()
        Me.Label_WkBeg = New System.Windows.Forms.Label()
        Me.Label_Hours_This_Month = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Hrs
        '
        Me.Label_Hrs.AutoSize = True
        Me.Label_Hrs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hrs.ForeColor = System.Drawing.Color.Lime
        Me.Label_Hrs.Location = New System.Drawing.Point(16, 62)
        Me.Label_Hrs.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_Hrs.Name = "Label_Hrs"
        Me.Label_Hrs.Size = New System.Drawing.Size(90, 28)
        Me.Label_Hrs.TabIndex = 0
        Me.Label_Hrs.Text = "Label1"
        '
        'Label_Week
        '
        Me.Label_Week.AutoSize = True
        Me.Label_Week.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Week.ForeColor = System.Drawing.Color.Lime
        Me.Label_Week.Location = New System.Drawing.Point(16, 97)
        Me.Label_Week.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_Week.Name = "Label_Week"
        Me.Label_Week.Size = New System.Drawing.Size(90, 28)
        Me.Label_Week.TabIndex = 1
        Me.Label_Week.Text = "Label1"
        '
        'Label_WkBeg
        '
        Me.Label_WkBeg.AutoSize = True
        Me.Label_WkBeg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_WkBeg.ForeColor = System.Drawing.Color.Lime
        Me.Label_WkBeg.Location = New System.Drawing.Point(15, 24)
        Me.Label_WkBeg.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_WkBeg.Name = "Label_WkBeg"
        Me.Label_WkBeg.Size = New System.Drawing.Size(90, 28)
        Me.Label_WkBeg.TabIndex = 2
        Me.Label_WkBeg.Text = "Label1"
        '
        'Label_Hours_This_Month
        '
        Me.Label_Hours_This_Month.AutoSize = True
        Me.Label_Hours_This_Month.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hours_This_Month.Location = New System.Drawing.Point(17, 135)
        Me.Label_Hours_This_Month.Name = "Label_Hours_This_Month"
        Me.Label_Hours_This_Month.Size = New System.Drawing.Size(90, 28)
        Me.Label_Hours_This_Month.TabIndex = 3
        Me.Label_Hours_This_Month.Text = "Label1"
        '
        'frm_HoursToday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(567, 208)
        Me.Controls.Add(Me.Label_Hours_This_Month)
        Me.Controls.Add(Me.Label_WkBeg)
        Me.Controls.Add(Me.Label_Week)
        Me.Controls.Add(Me.Label_Hrs)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_HoursToday"
        Me.Text = "frm_HoursToday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Hrs As System.Windows.Forms.Label
    Friend WithEvents Label_Week As System.Windows.Forms.Label
    Friend WithEvents Label_WkBeg As System.Windows.Forms.Label
    Friend WithEvents Label_Hours_This_Month As System.Windows.Forms.Label
End Class
