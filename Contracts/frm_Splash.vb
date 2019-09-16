Imports System.Data.EntityClient

Public Class frm_Splash
    Dim objContext As New Cls_Context
    Public context As New Contracts.ContractsEntities
    Private Sub frm_Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '=======================================================================================================
        'Creates animated banner specific to logged in user
        '========================================================================================================
        Try
            Me.lbl_login.Text = "Hello: " & System.Environment.UserName & " Welcome To:"

            Me.lbl_Ver.Text = "Version Number: " & GetMaxVersion().ToString

            Dim AppName() As String = {"C", "O", "N", "T", "R", "A", "C", "T", "S"}

            For counter As Integer = 0 To 8

                For Each objcontrol As Control In Me.Controls
                    Me.Show()
                    If objcontrol.GetType.ToString = "System.Windows.Forms.Label" And objcontrol.Name.Contains(AppName(counter)) _
                    Then objcontrol.Text = AppName(counter)
                    Threading.Thread.Sleep(20)
                    Me.Refresh()

                Next

            Next


            objContext = New Cls_Context
            context = objContext.CreateContext
            objContext = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Splash:frm_Splash_Load ")
            Exit Sub
        End Try

    End Sub
    Private Function GetMaxVersion() As String


        Dim MaxVersion = (From r In context.Versions
         Select r.KY_Version).Max

        Dim MaxRecord As Integer
        MaxRecord = MaxVersion

        Dim GetMaxversionNumber = From C In context.Versions
            Where C.KY_Version = MaxRecord
            Select C.Number_Version

        For Each C In GetMaxversionNumber
            Return C.ToString

        Next




    End Function
End Class
