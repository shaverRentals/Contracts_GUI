Imports Microsoft.Reporting.WinForms
Imports WyoSendGmail
Public Class Frm_Reports
    Public context As New Contracts.ContractsEntities 'Sets Context for EF Model
    Public ReportType As String
    Dim objReports As cls_Reports
    Public Sub New(ByVal _context As Contracts.ContractsEntities, ByVal _ReportType As String)
        '====================================================================================================================================================

        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
            ReportType = _ReportType
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_reports: Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub Frm_Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.ReportViewer.Clear()

            RemoveHandler cbo_Select_Reports.SelectedIndexChanged, AddressOf cbo_Select_Reports_SelectedIndexChanged
            Call FillComboBoxes()
            AddHandler cbo_Select_Reports.SelectedIndexChanged, AddressOf cbo_Select_Reports_SelectedIndexChanged

            'Me.Btn_send_Email.Visible = False

            'Me.WindowState = FormWindowState.Maximized


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_reports:  Frm_Reports_Load")
            Exit Sub
        End Try

    End Sub
    Private Sub cbo_Select_Reports_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Select_Reports.SelectedIndexChanged
        '====================================================================================================================================================
        'PURPOSE: Opens the selected report

        'CREATED: CSHAVE: 4/16/2012

        'MODIFIED:
        '====================================================================================================================================================
        Try

            objReports = New cls_Reports(context)

            objReports.GetReportFields(cbo_Select_Reports.SelectedValue)
            Me.ReportViewer.ProcessingMode = ProcessingMode.Remote
            ReportViewer.ServerReport.ReportServerUrl = New Uri(ReportserverURL)
            ReportViewer.ServerReport.ReportPath = objReports._Reportpath
            Me.ReportViewer.RefreshReport()

            ' Me.Btn_send_Email.Visible = True

            objReports = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_reports: cbo_Select_Reports_SelectedIndexChanged ")
            Exit Sub
        End Try
    End Sub
    Private Sub FillComboBoxes()
        Try
            objReports = New cls_Reports(context)
            Me.cbo_Select_Reports.DisplayMember = "Name_Report"
            Me.cbo_Select_Reports.ValueMember = "KY_Report"
            Me.cbo_Select_Reports.DataSource = objReports.GetReportList(ReportType)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_reports: FillComboBoxes ")
            Exit Sub
        End Try
    End Sub
End Class