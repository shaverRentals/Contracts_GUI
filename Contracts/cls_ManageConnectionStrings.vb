Imports System.Data.SqlClient
Imports System.Data.EntityClient

Public Class cls_ManageConnectionStrings
    '===============================================================================
    'Creates connection string and EF context entity using user settings 
    'This enables configuring different servers or dev/prod databases
    '===============================================================================

    Public Function BuildSQLConnectionString() As String
        '=========================================================================================
        'Uses SQL string builder class to create SQL connection string using values in my settings
        '=========================================================================================
        try

        Dim sqlBuilder As New SqlConnectionStringBuilder

        sqlBuilder.DataSource = My.Settings.strServerName
        sqlBuilder.InitialCatalog = My.Settings.strDatabaseName
        sqlBuilder.IntegratedSecurity = True

            Return sqlBuilder.ToString

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " cls_ManageConnectionStrings :  BuildSQLConnectionString  ")
            Return Nothing
            Exit Function
        End Try

        Return Nothing

    End Function
    Public Function BuildEntityConnectionString() As String
        '=================================================================================================================
        'Uses Entity Connection string builder class to create EF connection string uses function BuildSQLConnectionString
        'to create sql string
        '=================================================================================================================
        Try
            Dim entityBuilder As New EntityConnectionStringBuilder

            entityBuilder.Provider = "System.Data.SqlClient"
            entityBuilder.ProviderConnectionString = BuildSQLConnectionString()
            entityBuilder.Metadata = "res://*//EFM_Contracts.csdl|" & _
                                        "res://*//EFM_Contracts.ssdl|" & _
                                        "res://*//EFM_Contracts.msl"

            Return entityBuilder.ToString

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " cls_ManageConnectionStrings : BuildEntityConnectionString ")
            Return Nothing
            Exit Function
        End Try

        Return Nothing
    End Function
    Public Function CheckforServerAndDbConn(ByVal ServerName As String, ByVal DatabaseName As String) As Boolean
        '=================================================================================================================
        'just checks to make sure there are values stored in settings for the db name and server name
        '=================================================================================================================
        Try
            If ServerName = "" Or DatabaseName = "" Then
                Return False
            Else
                Return True
            End If
            Return False

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " cls_ManageConnectionStrings : CheckforServerAndDbConn ")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
End Class
