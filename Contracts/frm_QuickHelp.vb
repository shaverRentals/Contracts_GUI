Public Class frm_QuickHelp
    Inherits Contracts.frm_Base_Code
    Public QuickHelpDescription As String
    Public Sub New(ByVal _QuickHelpDescription As String)
        '====================================================================================================================================================
        'PURPOSE: Constructor for Form. Initiaslized EF Context and Report Group Passed from SwitchBoard Form 



        'MODIFIED:
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            QuickHelpDescription = _QuickHelpDescription

            Me.Label1.Text = QuickHelpDescription
        Catch
            MsgBox(Err.Description & " frm_Projects: Public Sub New")
            Exit Sub
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class