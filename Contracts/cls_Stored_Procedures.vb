
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class cls_Stored_Procedures
    Dim objConStr As New cls_ManageConnectionStrings
    Public Sub RunStoredProcedure_NonQuery(ByVal strCommText As String)

        objConStr = New cls_ManageConnectionStrings

        Dim conn As SqlConnection
        Dim comm As SqlCommand
        Dim connectionString As String = objConStr.BuildSQLConnectionString
        conn = New SqlConnection(connectionString)
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.StoredProcedure

        '----example of how to add a return/output value to a stored procuedure
        'comm.Parameters.Add("@returnvalue", SqlDbType.NVarChar, 2000)
        'comm.Parameters("@returnvalue").Direction = ParameterDirection.Output
        conn.Open()
        comm.CommandText = strCommText

        Try
            comm.ExecuteNonQuery()

        Catch sqlEx As SqlException

            Dim ErrMessage As String = "Stored Procedure: " & sqlEx.Procedure & " " & vbNewLine _
                                       & "Retured Error Number: " & sqlEx.Number & " " & vbNewLine _
                                       & "Message: " & sqlEx.Message
            MsgBox(sqlEx.Message.ToString & sqlEx.Procedure & ErrMessage)

            Exit Sub

        End Try

        conn.Close()
        objConStr = Nothing

        
    End Sub
    Public Sub RunSQLScript(ByVal SQLScript As String)

        objConStr = New cls_ManageConnectionStrings

        Dim conn As SqlConnection
        Dim comm As SqlCommand
        Dim connectionString As String = objConStr.BuildSQLConnectionString
        conn = New SqlConnection(connectionString)
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.Text

        Dim file As New FileInfo(SQLScript)
        Dim script As String = file.OpenText().ReadToEnd()

        conn.Open()
        comm.CommandText = script

        Try
            comm.ExecuteNonQuery()

        Catch sqlEx As SqlException

            Dim ErrMessage As String = "Stored Procedure: " & sqlEx.Procedure & " " & vbNewLine _
            & "Retured Error Number: " & sqlEx.Number & " " & vbNewLine _
             & "Message: " & sqlEx.Message
            MsgBox(sqlEx.Message.ToString & sqlEx.Procedure & ErrMessage)

            Exit Sub

        End Try

        conn.Close()
        objConStr = Nothing

    End Sub



End Class
