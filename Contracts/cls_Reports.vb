Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class cls_Reports
    Public context As New Contracts.ContractsEntities

    Private ReportName As String
    Private ReportPath As String
    Private ReportEmailSubjectLine As String
    Private ReportEmailBody As String
    Private ReportFileName As String
    Private ReportType As String
    'Dim obCardUser As cls_CardUsers

    Public Sub New(ByVal _context As Contracts.ContractsEntities)
        '============================================================================================================================================
        'Purpose: Constructor

        'Created: 4.18.2012 by Chad Shaver

        'Modified:

        '============================================================================================================================================

        context = _context
    End Sub

    Public ReadOnly Property _ReportName() As String
        Get
            Return ReportName
        End Get
    End Property
    Public ReadOnly Property _Reportpath() As String
        Get
            Return ReportPath
        End Get
    End Property
    Public ReadOnly Property _ReportEmailSubjectLine() As String
        Get
            Return ReportEmailSubjectLine
        End Get
    End Property
    Public ReadOnly Property _ReportEmailBody() As String
        Get
            Return ReportEmailBody
        End Get
    End Property
    Public ReadOnly Property _ReportFileName() As String
        Get
            Return ReportFileName
        End Get
    End Property
    Public Property _ReportType() As String
        Get
            Return ReportType
        End Get
        Set(ByVal value As String)
            ReportType = value
        End Set
    End Property
    Public Sub GetReportFields(ByVal ReportID As Integer)
        '========================================================================================================================================
        'PURPOSE: Returns the Report fields and sets the class propteries for the reports

        'DATE: 4.17.2012

        'AUTHOR: CSHAVE

        'DATE MODIFIED:
        '=====================================================================================================================================
        Try

            Dim ReportQuery = From C In context.Reports
                             Where C.KY_Report = ReportID
                             Select C
            For Each result In ReportQuery
                Me.ReportName = result.Name_Report
                Me.ReportPath = result.Path_Report
                Me.ReportEmailSubjectLine = result.Email_Subject
                Me.ReportEmailBody = result.Email_Body
                Me.ReportFileName = result.FileName_Report
            Next

        Catch ex As Exception
            MsgBox(Err.Description & "CLS_Reports:GetReportFields")
            Exit Sub
        End Try

    End Sub
    Public Sub SavetoPDF(ByVal viewer As ReportViewer, ByVal savePath As String)
        '========================================================================================================================================
        'PURPOSE: Renders and saves the report to .PDF format in local Temp folder

        'DATE: 4.18.2012

        'AUTHOR: CSHAVE

        'DATE MODIFIED:
        '=====================================================================================================================================
        Try
            Dim Bytes() As Byte = viewer.ServerReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim Stream As New FileStream(savePath, FileMode.Create, FileAccess.Write)
            Stream.Write(Bytes, 0, Bytes.Length)
            Stream.Close()
            Stream.Dispose()
            GC.Collect()
        Catch
            MsgBox("SavetoPDF: " & Err.Number & ":" & Err.Description)
            Exit Sub
        End Try

    End Sub
    Public Function GetReportFileLocation() As String
        '========================================================================================================================================
        'PURPOSE: Creates the file file location for the current report and creates a the name of the report based on the current users Login Domain
        'Name and the name of the report. 

        'DATE: 4.18.2012

        'AUTHOR: CSHAVE

        'DATE MODIFIED:
        '=====================================================================================================================================

        Try
            
            Dim ReporFileLocation As String

            ReporFileLocation = Application.StartupPath() & "\Reports\" & System.Environment.UserName & "_" & Me.ReportFileName

            Return ReporFileLocation


        Catch
            MsgBox("GetReportFileLocation: " & Err.Number & ":" & Err.Description)
            Return Nothing
            Exit Function
        End Try

        Return Nothing

    End Function
    Public Function GetReportList(ByVal ReportType As String) As List(Of Contracts.Report)
        '========================================================================================================================================
        'PURPOSE: Returns a list of reports based on the report type provided. Creates dynamic dropdown list in frm reports

        'DATE: 4.18.2012

        'AUTHOR: CSHAVE

        'DATE MODIFIED:
        '=====================================================================================================================================

        Try
            Dim ID As Integer

            Dim GetReportID = From R In context.Report_Types
            Where R.DS_Report_Type = ReportType

            For Each result In GetReportID
                ID = result.KY_Report_Type
            Next

            Dim GetReportLists = From R In context.Reports
                                 Where R.KY_Report_Type = ID
                                 Order By R.Name_report

            Return GetReportLists.ToList

        Catch
            MsgBox("GetReportList: " & Err.Number & ":" & Err.Description)
            Return Nothing
            Exit Function
        End Try

        Return Nothing


    End Function
End Class


