Public Class frm_income
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities
    Public filterValue As Integer
    Public ID_Contract As Integer
    Dim obj As New cls_Stored_Procedures

    Public Sub New(ByVal _context As Contracts.ContractsEntities, Optional ByVal _ID_Contract As Integer = 0)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
            ID_Contract = _ID_Contract
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Expense : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub ComboBox_Filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Filter.SelectedIndexChanged
        '======================================================================================
        'Sets Filter value for enumeration
        '======================================================================================
        Try

            Me.filterValue = SetComtractFiterValue(ComboBox_Filter.SelectedItem)

            Call FillComboBoxes()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: ComboBox_Filter_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub FillComboBoxes()
        '===============================
        'Fills ComboBox Controls
        '===================================
        Try
            'Loads Contracts Select Combobox
            ComboBox_Contracts_Select.DisplayMember = "Name_Contract"
            ComboBox_Contracts_Select.ValueMember = "KY_Contracts"
            ComboBox_Contracts_Select.DataSource = GetContractsForContractsComboBox(Me.filterValue, context)

            'RemoveHandler ComboBox_InvoiceHeader.SelectedIndexChanged, AddressOf ComboBox_InvoiceHeader_SelectedIndexChanged_1
            ComboBox_InvoiceHeader.DisplayMember = "Desc_Invoice"
            ComboBox_InvoiceHeader.ValueMember = "KY_Invoice_Header"
            ComboBox_InvoiceHeader.DataSource = GetAllInvoiceRecords(context)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: FillComboBoxes")
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox_Contracts_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contracts_Select.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try

            IncomesBindingSource.DataSource = GetIncomeForSelectedContract(ComboBox_Contracts_Select.SelectedValue)

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)
            Me.TextBox_ContractName.Text = ""
            Me.TextBox_Name_Invoice_Header.Text = ""
            Call Set_Contract_Name_Textbox()
            Call Set_InvoiceHeader_Name_Textbox()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: ComboBox_Contracts_Select_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Function GetIncomeForSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Income)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim ContractIncome = From C In context.Incomes.Include("Contract")
                                Where C.KY_Contracts = ID_Contract

            For Each X In ContractIncome
                Me.TextBox_ContractName.Text = X.Contract.Name_Contract.ToString


            Next

            Return ContractIncome.ToList
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income :GetIncomeForSelectedContract")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function
    Private Sub Set_Contract_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contract Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try
            If ID_Contract > 0 Then
                Me.TextBox_ContractName.Text = GetContractName(context, ID_Contract).ToString
            Else
                Me.TextBox_ContractName.Text = GetContractName(context, Me.KY_ContractsTextBox.Text).ToString
            End If


        Catch
            If Err.Number = 91 Then
                Exit Sub
            End If
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: Set_Contract_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================
        Try
            ListView_Income.Clear()
            ListView_Income.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Income.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
            ListView_Income.Columns.Add("Amt", 90, HorizontalAlignment.Left) '2
            ListView_Income.Columns.Add("Check#", 300, HorizontalAlignment.Left) '3
            Dim str(3) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetIncomeForSelectedContract(_ID_Contract)
                str(0) = Result.KY_Income
                str(1) = Result.Date_Income
                str(2) = "$" & Format(CDec(Result.Amount_Income), "0.00")
                str(3) = Result.Check_Number_Income
                itm = New ListViewItem(str)
                ListView_Income.Items.Add(itm)
            Next


            Dim TotalIncome As Decimal = 0

            Dim t As ListViewItem
            For Each t In ListView_Income.Items
                TotalIncome += CDec(t.SubItems.Item(2).Text)
            Next
            str(0) = "Total"
            str(1) = ""
            str(3) = ""
            str(2) = "$" & Format(CDec(TotalIncome), "0.00")
            itm = New ListViewItem(str)
            ListView_Income.Items.Add(itm)


            Dim TotalMoney As Decimal = 0


            Dim lastRow As Integer


            lastRow = ListView_Income.Items.Count - 1
            ListView_Income.Items(lastRow).BackColor = Color.Chartreuse

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: LoadListView")
            Exit Sub
        End Try
    End Sub

    Private Sub frm_income_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '==================================
            'Loads
            '====================================
            Call Hide_swithboard_Form()

            IncomesBindingSource.DataSource = GetIncomeForSelectedContract(ID_Contract)

            Me.filterValue = 1

            Call FillComboBoxes()
            Call LoadFilterCombo(Me.ComboBox_Filter)

            If ID_Contract > 0 Then
                Call LoadListView(ID_Contract)
            End If

            Call Set_Contract_Name_Textbox()
            Call Set_InvoiceHeader_Name_Textbox()

            'AddHandler ComboBox_InvoiceHeader.SelectedIndexChanged, AddressOf ComboBox_InvoiceHeader_SelectedIndexChanged_1
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income : frm_Income_Hours_Load")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_income_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ":" & Err.Description & "frm_Income: frm_income_FormClosing")
            Exit Sub
        End Try
    End Sub
    Public Function GetInvoiceHeaderName() As String
        '====================================================================================================================================================
        'Reuturs the name of the contract for current contract FK
        '====================================================================================================================================================
        Try
            If Me.KY_Invoice_HeaderTextBox.Text = "" Then
                Return Nothing
                Exit Function
            End If

            Dim InvoiceHeaderName = From C In context.Invoice_Header
             Where C.KY_Invoice_Header = CInt(Me.KY_Invoice_HeaderTextBox.Text)
            For Each N In InvoiceHeaderName
                Return N.Desc_Invoice.ToString
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income:GetContractName")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub Set_InvoiceHeader_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contract Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try

            Me.TextBox_Name_Invoice_Header.Text = GetInvoiceHeaderName().ToString

        Catch
            If Err.Number = 91 Then
                Exit Sub
            End If
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income:Set_InvoiceHeader_Name_Textbox ")
            Exit Sub
        End Try

    End Sub

    'Private Sub ComboBox_InvoiceHeader_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) 'Handles ComboBox_InvoiceHeader.SelectedIndexChanged

    'IncomesBindingSource.DataSource = GetIncomeForSelectedInvoice(ComboBox_InvoiceHeader.SelectedValue)

    'End Sub
    Private Function GetIncomeForSelectedInvoice(ByVal ID_Invoice As Integer) As List(Of Contracts.Income)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim InvoiceIncome = From C In context.Incomes.Include("Contract")
                                Where C.KY_Invoice_Header = ID_Invoice

            Dim ID As Integer
            For Each X In InvoiceIncome
                Me.TextBox_ContractName.Text = X.Contract.Name_Contract.ToString
                ID = X.KY_Contracts
            Next

            Call Set_Contract_Name_Textbox()
            Call Set_InvoiceHeader_Name_Textbox()
            Call LoadListView(ID)
            Return InvoiceIncome.ToList
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income :GetIncomeForSelectedInvoice")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function

    Private Sub LinkLabel_AddIncome_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AddIncome.LinkClicked
        Try

            Call add_Record()

            Me.TextBox_ContractName.Text = ""

            Call Set_Contract_Name_Textbox()
            Call Set_InvoiceHeader_Name_Textbox()

            Save_Context_Changes(context)

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)

            'Sets the current record to the max record which is the record just added
            IncomesBindingSource.DataSource = Get_Max_Income_Record()

            Call FormatCurrency()


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income : LinkLabel_AddIncome_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim I As New Income
            I.Date_Income = Date.Today()
            I.Amount_Income = 0
            I.KY_Contracts = Me.ComboBox_Contracts_Select.SelectedValue
            I.Check_Number_Income = 0
            I.Img_Path_Check = ""
            I.KY_Invoice_Header = Me.ComboBox_InvoiceHeader.SelectedValue
            context.AddToIncomes(I)

        Catch
            MsgBox(Err.Description & "frm_expenses: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Income_Record() As List(Of Contracts.Income)

        Try

            Dim MaxRecID = (From r In context.Incomes
                              Select r.KY_Income).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxExpenseID = From C In context.Incomes
            Where C.KY_Income = MaxRecord
            Select C
            Return GetMaxExpenseID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_INcome: Get_Max_Income_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Private Sub FormatCurrency()
        '==============================================================================
        'Formats Controls that have currency displayed
        '===============================================================================
        Try
            Me.Amount_IncomeTextBox.Text = "$" & (Format(CDec(Me.Amount_IncomeTextBox.Text), "0.00"))

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income:FormatCurrency")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Save_Income_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Income.LinkClicked
        Try
            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_IncomeTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            IncomesBindingSource.DataSource = GetAllIncomeRecords()

            'Sets the position to the record just created using proc in this form
            IncomesBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)

            Me.TextBox_ContractName.Text = ""
            Call Set_Contract_Name_Textbox()
            'Call Set_InvoiceHeader_Name_Textbox()

            Call FormatCurrency()

            obj = New cls_Stored_Procedures
            obj.RunStoredProcedure_NonQuery(SP_Update_Months_Cats_Income)
            obj = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Expenses: LinkLabel_SaveExpense_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function GetAllIncomeRecords() As List(Of Contracts.Income)
      
        Try

            Return context.Incomes.OrderBy(Function(a) a.KY_Income).ToList()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: GetAllIncomeRecords")
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

            Dim CurrRecPos = From c In context.Incomes

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Income = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function
    ' Private Sub ComboBox_InvoiceHeader_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ComboBox_InvoiceHeader.SelectedIndexChanged


    'Try
    ' Me.KY_Invoice_HeaderTextBox.Text = ComboBox_InvoiceHeader.SelectedValue
    'IncomesBindingSource.DataSource = GetIncomeForSelectedInvoice(Me.ComboBox_InvoiceHeader.SelectedValue)
    'Call Set_Contract_Name_Textbox()
    ' Call Set_InvoiceHeader_Name_Textbox()
    ' Call FormatCurrency()
    ' Catch
    '  MsgBox(Err.Number & ": " & Err.Description & "frm_Income: ComboBox_InvoiceHeader_SelectedIndexChanged_1 ")
    '  End Try
    '  End Sub

    Private Sub LinkLabel_Delete_Income_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Income.LinkClicked
        '===================
        'Deletes
        '===================

        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                Call LoadListView(ComboBox_Contracts_Select.SelectedValue)


                Call FormatCurrency()
            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income:  LinkLabel_Delete_Income_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Incomes
                    Where (C.KY_Income = CInt(KY_IncomeTextBox.Text))
                        Select C
            For Each result As Income In d
                context.Incomes.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: Delete_Record ")
            Exit Sub
        End Try
    End Sub

    Private Sub ListView_Income_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView_Income.ItemActivate

        '===============================================================
        'Sets form to hour record selected in listview
        '===============================================================

        Try

            If ListView_Income.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Income As String

            ID_Income = ListView_Income.SelectedItems.Item(0).SubItems(0).Text

            IncomesBindingSource.DataSource = GetSelectedIncome(ID_Income)
            IncomesBindingSource.Position = GetCurrentRecordPosition(ID_Income) - 1


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: ListView_Expenses_ItemActivate ")
            Exit Sub
        End Try
    End Sub
    Private Function GetSelectedIncome(ByVal ID_Income As Integer) As List(Of Contracts.Income)
        '============================================================================================
        'Gets hour records for Expense ID
        '============================================================================================
        Try
            Dim Expenses = From C In context.Incomes
                                Where C.KY_Income = ID_Income

            Return Expenses.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: GetSelectedIncome ")
            Return Nothing
            Exit Function

        End Try
        Return Nothing
    End Function
    Private Sub LinkLabel_LinkReceipt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_LinkReceipt.LinkClicked
        '===============================================
        'Opens Folder Dialog to get file for receipt
        ''===============================================
        Try

            Me.Img_Path_CheckTextBox.Text = OpenDialog_Base()
            Me.Img_Path_CheckTextBox.Focus()
            Save_Context_Changes(context)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_income: LinkLabel_LinkReceipt_LinkClicked")
        End Try
    End Sub
    Private Sub LinkLabel_OpenReceipt_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenReceipt.LinkClicked
        Try
            OpenFile_Base(Me.Img_Path_CheckTextBox.Text)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income:  LinkLabel_OpenReceipt_LinkClicked")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Set_Invoice_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Set_Invoice.LinkClicked
        Try
            Me.KY_Invoice_HeaderTextBox.Focus()
            Me.KY_Invoice_HeaderTextBox.Text = ComboBox_InvoiceHeader.SelectedValue
            Call Save_Context_Changes(context)
            Call Set_InvoiceHeader_Name_Textbox()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Income: LinkLabel_Set_Invoice_LinkClicked")
        End Try
    End Sub
End Class