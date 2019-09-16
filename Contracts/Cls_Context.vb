Imports System.Data.EntityClient
Public Class Cls_Context
    Dim objConn As New cls_ManageConnectionStrings()
    Public Function CreateContext() As ContractsEntities
       
        Try
            objConn = New cls_ManageConnectionStrings()
            Dim context = New ContractsEntities
            Dim conn As New EntityConnection(objConn.BuildEntityConnectionString())
            context = New Contracts.ContractsEntities(conn)

            Return context
            objConn = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " Cls_Context: CreateContext")
            Return Nothing
            Exit Function
        End Try
    End Function
End Class
