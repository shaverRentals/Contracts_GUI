Public Class frm_ManageDBConn
    '===============================================================================================================
    'Form enables user to set/add/delete database name and server names for connection string
    'Database names are stored in user setting specialized string collection named: Coll_DB_Name
    'Server names are stored in user settings specialized string collection named: Coll_Server_Name
    '===============================================================================================================
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
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn :  Constructor ")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_ManageDBConn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '============================================================================================================
        'Form Load: displays current connection in the label and loads the comboboxes with settings values
        '============================================================================================================
        Try
            Call DisplayCurrentConnectionSettings()
            Call LoadComboBoxes()
            Call Hide_swithboard_Form()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : frm_ManageDBConn_Load  ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub LoadComboBoxes()
        '============================================================================================================
        'Loads the comboboxes with the values from the user settings
       
        '============================================================================================================
        Try

            cbo_database_Name.Items.Clear()
            cbo_Server_Name.Items.Clear()

            '------------------------------------------------------adds values to settings string collection
            For Each V As String In My.Settings.Coll_DB_Name
                Me.cbo_database_Name.Items.Add(V)
            Next
            For Each X As String In My.Settings.Coll_Server_Name
                Me.cbo_Server_Name.Items.Add(X)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : LoadComboBoxes  ")
            Exit Sub
        End Try

    End Sub
    Private Sub DisplayCurrentConnectionSettings()
        '============================================================================================================
        'Displays Server and db connection information in the label on the form 
        '============================================================================================================
        Try
            Label_CurrentDatabaseName.Text = "You are currently Connected to Server\Database  " & My.Settings.strServerName & "\" & My.Settings.strDatabaseName
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn :DisplayCurrentConnectionSettings ")
            Exit Sub
        End Try

    End Sub
    Private Sub QuickHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickHelpToolStripMenuItem.Click
        '============================================================================================================
        'Loads quick help form
        '============================================================================================================
        Try
            LoadQuickHelpForm("Use this form to configure the server and database name for the application" & vbCrLf & vbCrLf _
            & "You can add frequently used values to the comboboxes by typing in the value and clicking the Add database/Server Name buttons" & vbCrLf & vbCrLf _
            & "To configure the database and server click the Set Database and Server to Selected Values button")
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : QuickHelpToolStripMenuItem_Click ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Add_Database_Name_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Database_Name.LinkClicked
        '============================================================================================================
        'Adds the database name selected/entered in the database combobox to the user settings collection
        '============================================================================================================
        Try
            If My.Settings.Coll_DB_Name Is Nothing Then
                My.Settings.Coll_DB_Name = New Specialized.StringCollection
            End If

            If Me.cbo_database_Name.Text = "" Then
                MsgBox("Please Enter a Database Name")
                Exit Sub
            Else
                My.Settings.Coll_DB_Name.Add(Me.cbo_database_Name.Text)
                My.Settings.Save()
            End If

            Call LoadComboBoxes()
            Call DisplayCurrentConnectionSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : LinkLabel_Add_Database_Name_LinkClicked ")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Add_Server_Name_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Server_Name.LinkClicked
        '============================================================================================================
        'Adds the server name selected/entered in the database combobox to the user settings collection
        '============================================================================================================
        Try

            If My.Settings.Coll_Server_Name Is Nothing Then
                My.Settings.Coll_Server_Name = New Specialized.StringCollection
            End If
            If Me.cbo_Server_Name.Text = "" Then
                MsgBox("Please Enter a Server Name")
                Exit Sub
            Else
                My.Settings.Coll_Server_Name.Add(Me.cbo_Server_Name.Text)
                My.Settings.Save()
            End If
            Call LoadComboBoxes()
            Call DisplayCurrentConnectionSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn :  LinkLabel_Add_Server_Name_LinkClicked ")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Removed_Selected_Values_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Removed_Selected_Values.LinkClicked
        '============================================================================================================
        'Removes the values from the settings collection for the values in the database name or server name comboboxes
        '============================================================================================================
        Try

            My.Settings.Coll_Server_Name.Remove(Me.cbo_Server_Name.Text)
            My.Settings.Coll_DB_Name.Remove(Me.cbo_database_Name.Text)
            My.Settings.Save()

            Call LoadComboBoxes()
            Call DisplayCurrentConnectionSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : LinkLabel_Removed_Selected_Values_LinkClicked  ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Set_Server_and_DB_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Set_Server_and_DB.LinkClicked
        '============================================================================================================
        'Sets the values in the settings collection to the values in the db name and server name comboboxes
        '============================================================================================================
        Try

            My.Settings.strDatabaseName = cbo_database_Name.Text
            My.Settings.strServerName = cbo_Server_Name.Text
            My.Settings.Save()
            Call DisplayCurrentConnectionSettings()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : LinkLabel_Set_Server_and_DB_LinkClicked  ")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_ManageDBConn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '---------------------------------------------------------------------------------------
        'Shows switchboard form
        '---------------------------------------------------------------------------------------
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_ManageDBConn : frm_ManageDBConn_FormClosing  ")
            Exit Sub
        End Try

    End Sub
End Class