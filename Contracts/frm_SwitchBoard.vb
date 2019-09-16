'Imports System.Data.EntityClient
Imports System.IO
Imports System.Math
Public Class frm_SwitchBoard
    
    Dim objConn As New cls_ManageConnectionStrings()
    Dim objContext As New Cls_Context
    Public context As New Contracts.ContractsEntities
    Private Sub frm_SwitchBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===============================================================================================================================
        'Calle proc that creates EF context and then checks to see if there are setting values for the database name and the server name
        '===============================================================================================================================
        Try
            Me.Text = "Connected to: " & My.Settings.strServerName & " : " & My.Settings.strDatabaseName

            objContext = New Cls_Context
            context = objContext.CreateContext
            Call CheckServerandDbConfigured()
            objContext = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: frm_SwitchBoard_Load")
            Exit Sub
        End Try

    End Sub
    Private Sub CheckServerandDbConfigured()
        '=============================================================================================================================
        'Checks to make sure there are values for the server name and the database name stores in my settings. 
        '==============================================================================================================================

        Try

            Dim objConn As New cls_ManageConnectionStrings()

            If objConn.CheckforServerAndDbConn(My.Settings.strDatabaseName, My.Settings.strServerName) = False Then
                Dim response As Integer
                response = MsgBox("No Server or Database Identified: Click OK to go to Main Screen and Configure Connection. Click Cancel to Exit Application", vbOKCancel, "Delete Request")
                If response = vbOK Then
                Else
                    MsgBox("Goodbye")
                    Application.Exit()
                End If
            End If

            objConn = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard:  CheckServerandDbConfigured")
            Exit Sub
        End Try

    End Sub

    Private Sub PictureBox_Contractors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Contractors.Click
        '=============================================================================================================================
        'Opens Contractors Form
        '==============================================================================================================================
        Try

            Dim F As frm_Contractors
            F = New frm_Contractors(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: PictureBox_Contractors_Click ")
            Exit Sub
        End Try

    End Sub

    Private Sub PictureBox_Contracts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Contracts.Click
        '=============================================================================================================================
        'Opens Contracts Form
        '==============================================================================================================================

        Try

            Dim F As frm_Contracts
            F = New frm_Contracts(context, , )
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: PictureBox_Contracts_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Contracts_Hours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Contracts_Hours.Click
        Try

            Dim F As frm_Contracts_Hours
            F = New frm_Contracts_Hours(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: PictureBox_Contracts_Hours_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Contracts_Tasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Contracts_Tasks.Click
        Try

            Dim F As frm_Contract_Tasks
            F = New frm_Contract_Tasks(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: PictureBox_Contracts_Tasks_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Invoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Invoices.Click
        Try

            Dim F As frm_Invoice
            F = New frm_Invoice(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Switchboard: PictureBox_Invoices_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Expenses_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Expenses.Click
        Try
            Dim F As frm_Expense
            F = New frm_Expense(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: PictureBox_Expenses_Click  ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Income_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Income.Click
        Try
            Dim F As frm_income
            F = New frm_income(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: PictureBox_Income_Click  ")
            Exit Sub
        End Try
    End Sub
    Private Sub DBConnectionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        Try
            Dim F As frm_ManageDBConn
            F = New frm_ManageDBConn(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :DBConnectionsToolStripMenuItem_Click")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Taxes_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Taxes.Click

        Try
            Dim F As Frm_Reports
            F = New Frm_Reports(context, ReportGroup_Taxes)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: PictureBox_Monitoring_Click  ")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Contract_Reports_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Contract_Reports.Click
        Try
            Dim F As Frm_Reports
            F = New Frm_Reports(context, ReportGroup_Contracts)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:  PictureBox_Contract_Reports_Click")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_TimeAndMoney_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_TimeAndMoney.Click
        Try
            Dim F As Frm_Reports
            F = New Frm_Reports(context, ReportGroup_TimeAndMoney)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:PictureBox_TimeAndMoney_Click")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_TasksReport_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_TasksReport.Click
        Try
            Dim F As Frm_Reports
            F = New Frm_Reports(context, ReportGroup_Tasks)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: PictureBox_TasksReport_Click")
            Exit Sub
        End Try
    End Sub

    Private Sub PictureBox_HrsToday_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_HrsToday.Click
        Try
            Dim F As frm_HoursToday
            F = New frm_HoursToday(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:PictureBox_HrsToday_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub Delete_Backups_Over_Three()

        Try

            Dim CountOfFiles As Integer
            CountOfFiles = New IO.DirectoryInfo("G:\").GetFiles("*.bak", SearchOption.TopDirectoryOnly).Count
            If CountOfFiles <= NumberBackupToKeep Then
                Exit Sub
            End If

            Dim BackupFolder = New IO.DirectoryInfo("G:\").GetFiles("*.bak", SearchOption.TopDirectoryOnly).OrderBy(Function(x) x.CreationTime)

            Dim counter As Integer
            For Each Fi In BackupFolder
                If counter = (CountOfFiles - NumberBackupToKeep) Then
                    Exit Sub
                End If
                Fi.Delete()
                counter = counter + 1
            Next


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:Delete_Backups_Over_Three")
            Exit Sub
        End Try
    End Sub
    Private Sub PictureBox_Retirement_Click(sender As Object, e As EventArgs) Handles PictureBox_Retirement.Click
        Try
            Dim F As frm_Retirement
            F = New frm_Retirement(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:PictureBox_Retirement_Click")
            Exit Sub
        End Try
    End Sub
    Private Sub PicBox_Quarterly_Taxes_Click(sender As Object, e As EventArgs) Handles PicBox_Quarterly_Taxes.Click
        Try
            Dim F As frm_Estimated_Tax
            F = New frm_Estimated_Tax(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "PicBox_Quarterly_Taxes_Click")
            Exit Sub
        End Try
    End Sub
    Private Sub VersionsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VersionsToolStripMenuItem.Click
        Try
            Dim F As frm_Version
            F = New frm_Version(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: VersionsToolStripMenuItem_Click")
            Exit Sub
        End Try
    End Sub

    Private Sub RestoreProdToDevToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RestoreProdToDevToolStripMenuItem.Click
        Try
            Dim response As Integer
            response = MsgBox("You are about Restore Current Production Data to the Development Database****CHECK SP's YOU DUMMY!!!!!", vbOKCancel, "Delete Request")
            If response = vbOK Then

                File.Delete("C:\Contracts_BU\Contracts.bak")

                Dim obj As New cls_Stored_Procedures
                obj = New cls_Stored_Procedures
                obj.RunSQLScript(SQLScript_RestoreProd2Dev)
                obj = Nothing
                MsgBox("Done")
            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard: RestoreProdToDevToolStripMenuItem_Click ")
            Exit Sub
        End Try
    End Sub

    Private Sub BackupProductionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BackupProductionToolStripMenuItem.Click
        Try
            Dim response As Integer
            response = MsgBox("You are about backup the production database to the external drive", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Dim obj As New cls_Stored_Procedures
                obj = New cls_Stored_Procedures
                obj.RunSQLScript(SQLScript_BackupProdToExternal)
                obj = Nothing
                Call Delete_Backups_Over_Three()
                MsgBox("Current Db has been backed up to external drive: Backups > 3 have been deleted")
            Else
                MsgBox("Mission Aborted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:BackupProductionToolStripMenuItem_Click")
            Exit Sub
        End Try
    End Sub

    Private Sub ManageBackupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBackupsToolStripMenuItem.Click
        Try
            Dim F As frm_Manage_BU_Folder
            F = New frm_Manage_BU_Folder(context)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Switchboard:ManageBackupsToolStripMenuItem_Click")
            Exit Sub
        End Try
    End Sub

    Private Sub ManageConnectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageConnectionsToolStripMenuItem.Click


        Try
            Dim F As frm_ManageDBConn
            F = New frm_ManageDBConn(context)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :DBConnectionsToolStripMenuItem_Click")
            Exit Sub
        End Try
    End Sub
End Class