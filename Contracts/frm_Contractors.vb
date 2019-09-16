Public Class frm_Contractors
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Contractors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '====================================================================================================================================================
        'Form Load: Binds the controls on the form to all the contractor records
        '====================================================================================================================================================

        Try

            ContractorBindingSource.DataSource = GetAllContractorsRecords()

            Call LoadListView()

            Call Hide_swithboard_Form()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors : frm_Contractors_Load  ")
            Exit Sub
        End Try

    End Sub
    Public Function GetAllContractorsRecords() As List(Of Contracts.Contractor)
        '===========================================================================================================================
        'Returns all the records from the Contractors table. 
        '===========================================================================================================================
        Try
            Return context.Contractors.OrderBy(Function(a) a.KY_Contractor).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "  :frm_Contractors: GetAllContractorsRecords ")
        End Try
        Return Nothing
    End Function

    Private Sub frm_Contractors_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " :frm_Contractors: frm_Contractors_FormClosing ")
        End Try
    End Sub
    Private Sub LoadListView()
        Try
            ListView_Contracts.Clear()
            ListView_Contracts.Columns.Add("ID", 45, HorizontalAlignment.Left) '0
            ListView_Contracts.Columns.Add("Contractor", 220, HorizontalAlignment.Left) '1
            Dim str(1) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetAllContractorsRecords()
                str(0) = Result.KY_Contractor
                str(1) = Result.Name_Contractor
                itm = New ListViewItem(str)
                ListView_Contracts.Items.Add(itm)
            Next

            Me.Label_NumberOfRecords.Text = GetAllContractorsRecords.Count & "  Records Retured"


        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors: LoadListView  ")

        End Try
    End Sub

    Private Sub ListView_Contracts_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_Contracts.ItemActivate
        Try
           
            If ListView_Contracts.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Contract As String

            ID_Contract = ListView_Contracts.SelectedItems.Item(0).SubItems(0).Text

            ContractorBindingSource.DataSource = GetAllContractorsRecords()
            ContractorBindingSource.Position = GetCurrentRecordPosition(ID_Contract) - 1

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors : ListView_Contracts_ItemActivate")
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

            Dim CurrRecPos = From c In context.Contractors

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Contractor = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors : GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function

    Private Sub LinkLabel_Add_Record_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Record.LinkClicked
        '====================================================================================================================================================
        'Adds new record and binds the controls to the record just added 
        '====================================================================================================================================================
        Try
            Call Add_Record()

            'Calls save record sub in base code form
            Save_Context_Changes(context)

            'Sets the current record to the max record which is the record just added
            ContractorBindingSource.DataSource = Get_MaxContractor_Record()

            Call LoadListView()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors  :  LinkLabel_Add_Record_LinkClicked ")
        End Try
    End Sub
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim H As New Contractor
            H.Name_Contractor = ""
            context.AddToContractors(H)

            Call LoadListView()
        Catch
            MsgBox(Err.Description & "frm_Contractors : add_Record ")
        End Try
    End Sub
    Public Function Get_MaxContractor_Record() As List(Of Contracts.Contractor)
        '===========================================================================================================================
        'Returns the max record from the DFS_Hours Table. Used for getting back to an added record. 
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Contractors
                              Select r.KY_Contractor).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxContractID = From C In context.Contractors
            Where C.KY_Contractor = MaxRecord
            Select C
            Return GetMaxContractID.ToList()

        Catch

            MsgBox(Err.Description & "frm_Contractors : Get_MaxContractor_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function

    Private Sub LinkLabel_Save_Record_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Record.LinkClicked
        '====================================================================================================================================================
        'Saves the record and postions the record to the record just created. Resets the balance based on values from new record. 
        '====================================================================================================================================================
        Try

            'Saves the context to the DB with inherited proc in basecode form
            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_ContractorTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            ContractorBindingSource.DataSource = GetAllContractorsRecords()

            'Sets the position to the record just created using proc in this form
            ContractorBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors  : link_lbl_save_record_LinkClicked  ")
            Exit Sub
        End Try

    End Sub

    Private Sub LinkLabel_Delete_Record_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Record.LinkClicked
        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                'binds the records to all the records.
                ContractorBindingSource.DataSource = GetAllContractorsRecords()

                Call LoadListView()

            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors: LinkLabel_Delete_Record_LinkClicked ")
            Exit Sub
        End Try
    End Sub

    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Contractors
                    Where (C.KY_Contractor = CInt(KY_ContractorTextBox.Text))
                        Select C
            For Each result As Contractor In d
                context.Contractors.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors: Delete_Record ")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Add_Contract_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Contract.LinkClicked
        '===========================================================================================================================
        'Opens Contracts Form and closes Contractors Form
        '===========================================================================================================================
        Try

            Dim F As frm_Contracts
            F = New frm_Contracts(context, CInt(Me.KY_ContractorTextBox.Text), True)
            F.Show()
            F = Nothing
            Save_Context_Changes(context)

            Me.Close()

            Hide_swithboard_Form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contractors: LinkLabel_Add_Contract_LinkClicked ")
            Exit Sub
        End Try
    End Sub
End Class