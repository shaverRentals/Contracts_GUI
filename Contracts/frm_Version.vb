Public Class frm_Version
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities 'Sets Context for EF Model
    Public Sub New(ByVal _context As Contracts.ContractsEntities)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Version_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            VersionsBindingSource.DataSource = GetAllVersionRecords()

            Call Hide_swithboard_Form()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: frm_Version_Load")
        End Try

    End Sub
    Private Function GetAllVersionRecords() As List(Of Contracts.Version)
        
        Try
            Return context.Versions.OrderBy(Function(a) a.KY_Version).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Version: GetAllVersionRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub LinkLabel_AddVersion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AddVersion.LinkClicked
      
        Try
            Call Add_Record()

            'Calls save record sub in base code form
            Save_Context_Changes(context)

            'Sets the current record to the max record which is the record just added
            VersionsBindingSource.DataSource = Get_Max_Version_Record()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: LinkLabel_AddVersion_LinkClicked")
            Exit Sub
        End Try

    End Sub

    Private Function Get_Max_Version_Record() As List(Of Contracts.Version)
        

        Try

            Dim MaxRecID = (From r In context.Versions
                              Select r.KY_Version).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxversionID = From C In context.Versions
            Where C.KY_Version = MaxRecord
            Select C
            Return GetMaxversionID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: Get_Max_Version_Record")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overrides Sub add_Record()
        Try
            Dim V As New Version
            V.Desc_Version = ""
            V.Date_Version = Now()
            V.Number_Version = ""
            context.AddToVersions(V)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_Version_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: frm_Version_FormClosing")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_SaveVersion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_SaveVersion.LinkClicked

        Try

            'Saves the context to the DB with inherited proc in basecode form
            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_VersionTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            VersionsBindingSource.DataSource = GetAllVersionRecords()

            'Sets the position to the record just created using proc in this form
            VersionsBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: LinkLabel_SaveVersion_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Public Overrides Function GetCurrentRecordPosition(ByVal CurrentID As Integer) As Integer
        '====================================================================================================================================================
        'Gets the current record position for the record ID passed
        '====================================================================================================================================================
        Try
            Dim intCurrID As Integer
            intCurrID = 0

            Dim CurrRecPos = From c In context.Versions

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Version = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function
    Private Sub LinkLabel_DeleteVersion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_DeleteVersion.LinkClicked
        '====================================================================================================================================================
        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                'binds the records to all the records.
                VersionsBindingSource.DataSource = GetAllVersionRecords()

            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: LinkLabel_DeleteVersion_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
       
        Try
            Dim d = From C In context.Versions
                    Where (C.KY_Version = CInt(KY_VersionTextBox.Text))
                        Select C
            For Each result As Version In d
                context.Versions.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Version: Delete_Record ")
            Exit Sub
        End Try

    End Sub
End Class