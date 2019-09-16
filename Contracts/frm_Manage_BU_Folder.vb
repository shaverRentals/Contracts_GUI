Public Class frm_Manage_BU_Folder
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities 'Sets Context for EF Model
    Public Sub New(ByVal _context As Contracts.ContractsEntities)
        '===========================================================================
        'Constructor---Loads EF Context
        '===========================================================================

        Try
            context = _context
            InitializeComponent()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:Constructor")
            Exit Sub
        End Try

    End Sub

    Private Sub frm_Mannage_BU_Folder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Call DisplayCurrentBackupSettings()
            Call LoadComboBoxes()
            Call Hide_swithboard_Form()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder: frm_Mannage_BU_Folder_Load")
            Exit Sub
        End Try
    End Sub

    Public Overrides Sub LoadComboBoxes()
        '============================================================================================================
        'Loads the comboboxes with the values from the user settings

        '============================================================================================================
        Try

            cbo_BU_Folder.Items.Clear()

            For Each V As String In My.Settings.Coll_BU_Folder
                Me.cbo_BU_Folder.Items.Add(V)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:LoadComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Sub DisplayCurrentBackupSettings()
        '============================================================================================================
        'Displays Server and db connection information in the label on the form 
        '============================================================================================================
        Try
            Lbl_Current_BU_Folder.Text = "DB Backups are currently being made too: " & My.Settings.strBU_Folder
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder :DisplayCurrentBackupSettings")
            Exit Sub
        End Try

    End Sub

    Private Sub frm_Manage_BU_Folder_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '---------------------------------------------------------------------------------------
        'Shows switchboard form
        '---------------------------------------------------------------------------------------
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:frm_Manage_BU_Folder_FormClosing ")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Add_BU_Folder_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_BU_Folder.LinkClicked
        Try
            If My.Settings.Coll_BU_Folder Is Nothing Then
                My.Settings.Coll_BU_Folder = New Specialized.StringCollection
            End If

            If Me.cbo_BU_Folder.Text = "" Then
                MsgBox("Please Enter a Backup Directory")
                Exit Sub
            Else
                My.Settings.Coll_BU_Folder.Add(Me.cbo_BU_Folder.Text)
                My.Settings.Save()
            End If

            Call LoadComboBoxes()
            Call DisplayCurrentBackupSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:LinkLabel_Add_BU_Folder_LinkClicked")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Remove_BU_Folder_Location_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Remove_BU_Folder_Location.LinkClicked
        Try

            My.Settings.Coll_BU_Folder.Remove(Me.cbo_BU_Folder.Text)
            My.Settings.Save()

            Call LoadComboBoxes()
            Call DisplayCurrentBackupSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:LinkLabel_Remove_BU_Folder_Location_LinkClicked")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_SetBackup_Folder_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_SetBackup_Folder.LinkClicked
        Try

            My.Settings.strBU_Folder = cbo_BU_Folder.Text

            My.Settings.Save()
            Call DisplayCurrentBackupSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Mannage_BU_Folder:LinkLabel_SetBackup_Folder_LinkClicked")
            Exit Sub
        End Try
    End Sub
End Class