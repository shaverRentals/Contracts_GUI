<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reports
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
        Me.Label_reports_menu = New System.Windows.Forms.Label()
        Me.cbo_Select_Reports = New System.Windows.Forms.ComboBox()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_reports_menu
        '
        Me.Label_reports_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label_reports_menu.Location = New System.Drawing.Point(-3, 0)
        Me.Label_reports_menu.Name = "Label_reports_menu"
        Me.Label_reports_menu.Size = New System.Drawing.Size(1719, 45)
        Me.Label_reports_menu.TabIndex = 0
        '
        'cbo_Select_Reports
        '
        Me.cbo_Select_Reports.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Select_Reports.FormattingEnabled = True
        Me.cbo_Select_Reports.Location = New System.Drawing.Point(129, 12)
        Me.cbo_Select_Reports.Name = "cbo_Select_Reports"
        Me.cbo_Select_Reports.Size = New System.Drawing.Size(264, 23)
        Me.cbo_Select_Reports.TabIndex = 1
        '
        'ReportViewer
        '
        Me.ReportViewer.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1349, 636)
        Me.ReportViewer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Report:"
        '
        'Frm_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 685)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.cbo_Select_Reports)
        Me.Controls.Add(Me.Label_reports_menu)
        Me.Name = "Frm_Reports"
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_reports_menu As System.Windows.Forms.Label
    Friend WithEvents cbo_Select_Reports As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
