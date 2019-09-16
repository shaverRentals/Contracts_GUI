Public Class frm_Retirement
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities

    Public Sub New(ByVal _context As Contracts.ContractsEntities, Optional ByVal _ID_Contract As Integer = 0)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: Public Sub New")
            Exit Sub
        End Try

    End Sub

    Private Sub frm_Retirement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Call Hide_swithboard_Form()

            RetirementsBindingSource.DataSource = GetAllRetirementRecords()

            Call FillComboBoxes()

            Call LoadListView()

            Call FormatCurrency()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: frm_Retirement_Load")
            Exit Sub
        End Try

    End Sub
    Private Sub FillComboBoxes()
        '====================================================================================================================================================
        'Fills Comboboxes
        '====================================================================================================================================================
        Try
            'Loads Contractor Combobox
            cboRetirementAccount.DisplayMember = "Desc_Retirement_Account"
            cboRetirementAccount.ValueMember = "KY_Retirement_Account"
            cboRetirementAccount.DataSource = GetAllRetirementAccount()
            cboRetirementAccount.DataBindings.Add(New Binding("SelectedItem", RetirementsBindingSource, "Retirement_Account_LU", True))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: FillComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Function GetAllRetirementAccount() As List(Of Contracts.Retirement_Account_LU)
        '====================================================================================================================================================
        'Returns the All Retirements records
        '====================================================================================================================================================

        Try
            Return context.Retirement_Account_LU.OrderBy(Function(a) a.KY_Retirement_Account).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: GetAllRetirementAccount")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetAllRetirementRecords() As List(Of Contracts.Retirement)
        '====================================================================================================================================================
        'Returns the All the Retirements records
        '====================================================================================================================================================

        Try
            Return context.Retirements.OrderBy(Function(a) a.KY_Retirement).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: GetAllRetirementRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub LinkLabel_Add_Retirement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Retirement.LinkClicked
        Try

            Call Add_Record()
            'Calls save record sub in base code form
            Save_Context_Changes(context)


            'Sets the current record to the max record which is the record just added
            RetirementsBindingSource.DataSource = Get_Max_Retirement_Record()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: LinkLabel_Add_Retirement_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Retirement_Record() As List(Of Contracts.Retirement)
        '===========================================================================================================================
        'Returns the max record from the Retirement Table. Used for getting back to an added record. 
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Retirements
                              Select r.KY_Retirement).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxHourID = From C In context.Retirements
            Where C.KY_Retirement = MaxRecord
            Select C
            Return GetMaxHourID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: Get_Max_Retirement_Record")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Retirement
            C.Date_Contribution = Date.Today()
            context.AddToRetirements(C)

        Catch
            MsgBox(Err.Description & "frm_Retirement: add_Record ")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Save_Retirement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Retirement.LinkClicked
        Try

            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_RetirementTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            RetirementsBindingSource.DataSource = GetAllRetirementRecords()

            'Sets the position to the record just created using proc in this form
            RetirementsBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView()

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Retirement:LinkLabel_Save_Retirement_LinkClicked")
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

            Dim CurrRecPos = From c In context.Retirements

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Retirement = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function

    Private Sub LinkLabel_Delete_Retirement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Retirement.LinkClicked
        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                Call LoadListView()

            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: LinkLabel_Delete_Retirement_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Retirements
                    Where (C.KY_Retirement = CInt(KY_RetirementTextBox.Text))
                        Select C
            For Each result As Retirement In d
                context.Retirements.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: Delete_Record ")
            Exit Sub
        End Try
    End Sub

    Private Sub LoadListView()
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================

        Try
            ListView_Retirement.Clear()
            ListView_Retirement.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Retirement.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
            ListView_Retirement.Columns.Add("Amount", 90, HorizontalAlignment.Left) '2
            ListView_Retirement.Columns.Add("Account", 90, HorizontalAlignment.Left) '3
            ListView_Retirement.Columns.Add("Year", 90, HorizontalAlignment.Left) '4
            Dim str(4) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetAllRetirementRecords()
                str(0) = Result.KY_Retirement
                str(1) = Result.Date_Contribution
                str(2) = "$" & Format(CDec(Result.Amount_Contribution), "0.00")
                str(3) = Result.Retirement_Account_LU.Desc_Retirement_Account
                str(4) = Result.Tax_Year
                itm = New ListViewItem(str)
                ListView_Retirement.Items.Add(itm)
            Next


            Dim TotalAmount As Decimal = 0

            Dim t As ListViewItem
            For Each t In ListView_Retirement.Items
                TotalAmount += CDec(t.SubItems.Item(2).Text)
            Next
            str(0) = "TOTAL$$"
            str(1) = ""
            str(3) = ""
            str(4) = ""
            str(2) = "$" & Format(CDec(TotalAmount), "0.00")
            itm = New ListViewItem(str)
            ListView_Retirement.Items.Add(itm)




            Dim lastRow As Integer


            lastRow = ListView_Retirement.Items.Count - 1

            ListView_Retirement.Items(lastRow).BackColor = Color.Chartreuse

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: LoadListView")
            Exit Sub
        End Try
    End Sub

    Private Sub ListView_Retirement_ItemActivate(sender As Object, e As EventArgs) Handles ListView_Retirement.ItemActivate
        Try

            If ListView_Retirement.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Retirement As String

            ID_Retirement = ListView_Retirement.SelectedItems.Item(0).SubItems(0).Text

            RetirementsBindingSource.DataSource = GetSelectedRetirement(ID_Retirement)
            RetirementsBindingSource.Position = GetCurrentRecordPosition(ID_Retirement) - 1

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: ListView_Retirement_ItemActivate")
            Exit Sub
        End Try
    End Sub

    Private Function GetSelectedRetirement(ByVal ID_Retirement As Integer) As List(Of Contracts.Retirement)
        '============================================================================================
        'Gets hour records for retirment ID
        '============================================================================================
        Try
            Dim Retirement = From C In context.Retirements
                                Where C.KY_Retirement = ID_Retirement

            Return Retirement.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: GetSelectedRetirement")
            Return Nothing
            Exit Function

        End Try
        Return Nothing
    End Function
    Private Sub FormatCurrency()
        '==============================================================================
        'Formats Controls that have currency displayed
        '===============================================================================
        Try
            Me.Amount_ContributionTextBox.Text = "$" & (Format(CDec(Me.Amount_ContributionTextBox.Text), "0.00"))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement:FormatCurrency")
            Exit Sub
        End Try
    End Sub

    Private Sub frm_Retirement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '============================================
        'Opens Switchboard form when this form closes
        '============================================
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Retirement: frm_Retirement_FormClosing")
        End Try

    End Sub

    Private Sub cboRetirementAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRetirementAccount.KeyDown
        e.SuppressKeyPress = True
    End Sub
End Class
