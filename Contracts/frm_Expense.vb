Imports System.Windows.Forms
Public Class frm_Expense
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities
    Dim obj As New cls_Stored_Procedures

    Public Sub New(ByVal _context As Contracts.ContractsEntities)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Expense_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Call Hide_swithboard_Form()


            Call FillComboBoxes()


            Call Set_Contractee_Name_Textbox()
            Call FormatCurrency()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense : frm_Expense_Load")
            Exit Sub
        End Try
    End Sub
    Private Sub FillComboBoxes()
        Try
            'Loads the Contractee Combobox
            ComboBox_Contractee.DisplayMember = "Name_Contractee"
            ComboBox_Contractee.ValueMember = "KY_Contractee"
            ComboBox_Contractee.DataSource = GetContractee()

            'Loads Contracts Status Combobox
            KY_Expense_TypeComboBox.DisplayMember = "Expense_Type"
            KY_Expense_TypeComboBox.ValueMember = "KY_Expense_Type"
            KY_Expense_TypeComboBox.DataSource = GetExpenseTypeStatus()
            KY_Expense_TypeComboBox.DataBindings.Clear()
            KY_Expense_TypeComboBox.DataBindings.Add(New Binding("SelectedItem", ExpensesBindingSource, "Expense_Type_LU", True))

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense : FillComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Function GetContractee() As List(Of Contracts.Contractee)
        '====================================================================================================================================================
        'Returns contractee records
        '====================================================================================================================================================
        Try
            Return context.Contractees.OrderBy(Function(a) a.KY_Contractee).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense: GetContractee")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub ComboBox_Contractee_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_Contractee.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try

            ExpensesBindingSource.DataSource = GetExpensesForSelectedContractee(ComboBox_Contractee.SelectedValue)

            Call Set_Contractee_Name_Textbox()
            Call LoadListView(ComboBox_Contractee.SelectedValue)
            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: ComboBox_Contractee_SelectedIndexChanged ")
            Exit Sub
        End Try
    End Sub
    Private Function GetExpensesForSelectedContractee(ByVal ID_Contractee As Integer) As List(Of Contracts.Expenses)
        '==========================================================================
        'Returns Expenses for selected contract
        '==========================================================================

        Try
            Dim Expenses = From C In context.Expenses.Include("Contractee")
                                Where C.KY_Contractee = ID_Contractee
            For Each X In Expenses
                Me.TextBox_Name_Contractee.Text = X.Contractee.Name_Contractee.ToString
            Next

            Return Expenses.ToList

            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses : GetExpensesForSelectedContractee")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function
    Private Sub Set_Contractee_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contractor Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try

            Me.TextBox_Name_Contractee.Text = GetContracteeName().ToString

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense: Set_Contractee_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Function GetContracteeName() As String
        '====================================================================================================================================================
        'Reuturs the name of the contractee for the FK on the contractEE table for the current Contract Record
        '====================================================================================================================================================
        Try

            Dim ContracteeName = From C In context.Contractees
                                 Where C.KY_Contractee = CInt(Me.KY_ContracteeTextBox.Text)
            For Each N In ContracteeName
                Return N.Name_Contractee.ToString
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: GetContracteeName")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub frm_Expense_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '================================================
        'Opens Swithcboard form when contracts closes
        '=================================================
        Try
            Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ":" & Err.Description & "frm_Expenses:  frm_Expense_FormClosing")
            Exit Sub
        End Try
    End Sub
    Private Function GetExpenseTypeStatus() As List(Of Contracts.Expense_Type_LU)
        '====================================================================================================================================================
        'Returns Expense Types
        '====================================================================================================================================================
        Try
            Return context.Expense_Type_LU.OrderBy(Function(a) a.KY_Expense_Type).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: GetExpenseTypeStatus")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub LinkLabel_LinkReceipt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_LinkReceipt.LinkClicked
        '===============================================
        'Opens Folder Dialog to get file for receipt
        '===============================================
        Try

            Me.Img_Path_ExpenseTextBox.Text = OpenDialog_Base()
            Me.Img_Path_ExpenseTextBox.Focus()
            Save_Context_Changes(context)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: LinkLabel_LinkReceipt_LinkClicked")
        End Try
    End Sub
    Private Sub LinkLabel_AddExpense_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AddExpense.LinkClicked

        Try

            Call add_Record()

            Me.TextBox_Name_Contractee.Text = ""

            Call Set_Contractee_Name_Textbox()

            'Calls save record sub in base code form
            Save_Context_Changes(context)

            Call LoadListView(ComboBox_Contractee.SelectedValue)

            'Sets the current record to the max record which is the record just added
            ExpensesBindingSource.DataSource = Get_Max_Expenses_Record()

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses :  LinkLabel_AddExpense_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Expenses
            C.Date_Expense = Date.Today()
            C.Description_Expense = ""
            C.KY_Contractee = Me.ComboBox_Contractee.SelectedValue
            C.KY_Expense_Type = 1
            C.Amount = 0.0
            C.Img_Path_Expense = ""
            context.AddToExpenses(C)

        Catch
            MsgBox(Err.Description & "frm_expenses: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Expenses_Record() As List(Of Contracts.Expenses)
       
        Try

            Dim MaxRecID = (From r In context.Expenses
                              Select r.KY_Expense).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxExpenseID = From C In context.Expenses
            Where C.KY_Expense = MaxRecord
            Select C
            Return GetMaxExpenseID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: Get_Max_Expenses_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Private Sub LinkLabel_SaveExpense_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_SaveExpense.LinkClicked
        Try

            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_ExpenseTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            ExpensesBindingSource.DataSource = GetAllExpensesRecords()

            'Sets the position to the record just created using proc in this form
            ExpensesBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView(ComboBox_Contractee.SelectedValue)

            Me.TextBox_Name_Contractee.Text = ""
            Call Set_Contractee_Name_Textbox()


            Call FormatCurrency()

            obj = New cls_Stored_Procedures
            obj.RunStoredProcedure_NonQuery(SP_Update_Tax_Year)
            obj = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Expenses: LinkLabel_SaveExpense_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function GetAllExpensesRecords() As List(Of Contracts.Expenses)
        '====================================================================================================================================================
        'Returns the All the Expense records
        '====================================================================================================================================================

        Try

            Return context.Expenses.OrderBy(Function(a) a.KY_Expense).ToList()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: GetAllExpensesRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function

    Public Overrides Function GetCurrentRecordPosition(ByVal CurrentID As Integer) As Integer
        '====================================================================================================================================================
        'Gets the current record position for the record ID passed
        '====================================================================================================================================================
        Try
            Dim intCurrID As Integer
            intCurrID = 0

            Dim CurrRecPos = From c In context.Expenses

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Expense = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function

    Private Sub LinkLabel_DeleteExpense_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_DeleteExpense.LinkClicked
        '===================
        'Deletes
        '===================

        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                Call LoadListView(ComboBox_Contractee.SelectedValue)


                Call FormatCurrency()
            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense:  LinkLabel_DeleteExpense_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Expenses
                    Where (C.KY_Expense = CInt(KY_ExpenseTextBox.Text))
                        Select C
            For Each result As Expenses In d
                context.Expenses.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: Delete_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================
        Try
            ListView_Expenses.Clear()
            ListView_Expenses.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Expenses.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
            ListView_Expenses.Columns.Add("Amount", 90, HorizontalAlignment.Left) '2
            ListView_Expenses.Columns.Add("Desc", 300, HorizontalAlignment.Left) '3
            Dim str(3) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetExpensesForSelectedContractee(_ID_Contract)
                str(0) = Result.KY_Expense
                str(1) = Result.Date_Expense
                str(2) = "$" & Format(CDec(Result.Amount), "0.00")
                str(3) = Result.Description_Expense
                itm = New ListViewItem(str)
                ListView_Expenses.Items.Add(itm)
            Next

            Dim TotalExpenses As Decimal = 0

            Dim t As ListViewItem
            For Each t In ListView_Expenses.Items
                TotalExpenses += (CDec(t.SubItems.Item(2).Text))
            Next
            str(0) = "TOTAL"
            str(1) = ""
            str(3) = ""
            str(2) = "$" & Format(CDec(TotalExpenses), "0.00")
            itm = New ListViewItem(str)
            ListView_Expenses.Items.Add(itm)

            Dim lastRow As Integer
           
            lastRow = ListView_Expenses.Items.Count - 1

            ListView_Expenses.Items(lastRow).BackColor = Color.Chartreuse


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: LoadListView")
            Exit Sub
        End Try
    End Sub
    Private Sub FormatCurrency()
        '==============================================================================
        'Formats Controls that have currency displayed
        '===============================================================================
        Try
            Me.AmountTextBox.Text = "$" & (Format(CDec(Me.AmountTextBox.Text), "0.00"))

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses:FormatCurrency")
            Exit Sub
        End Try
    End Sub
    Private Sub ListView_Expenses_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView_Expenses.ItemActivate
        '===============================================================
        'Sets form to hour record selected in listview
        '===============================================================

        Try

            If ListView_Expenses.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Expenses As String

            ID_Expenses = ListView_Expenses.SelectedItems.Item(0).SubItems(0).Text

            ExpensesBindingSource.DataSource = GetSelectedExpenses(ID_Expenses)
            ExpensesBindingSource.Position = GetCurrentRecordPosition(ID_Expenses) - 1


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: ListView_Expenses_ItemActivate ")
            Exit Sub
        End Try
    End Sub
    Private Function GetSelectedExpenses(ByVal ID_Expenses As Integer) As List(Of Contracts.Expenses)
        '============================================================================================
        'Gets hour records for Expense ID
        '============================================================================================
        Try
            Dim Expenses = From C In context.Expenses
                                Where C.KY_Expense = ID_Expenses

            Return Expenses.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses: GetSelectedExpenses ")
            Return Nothing
            Exit Function

        End Try
        Return Nothing
    End Function
    Private Sub LinkLabel_OpenReceipt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenReceipt.LinkClicked
        Try
            OpenFile_Base(Me.Img_Path_ExpenseTextBox.Text)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expenses:  LinkLabel_OpenReceipt_LinkClicked")
            Exit Sub
        End Try
    End Sub
End Class