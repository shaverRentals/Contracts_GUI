Public Class frm_Invoice
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities
    Public ID_Contract As Integer
    Public filterValue As Integer
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice : Public Sub New")
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoices :ComboBox_Filter_SelectedIndexChanged")
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
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoices :FillComboBoxes")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '==================================
            'Loads
            '====================================
            Call Hide_swithboard_Form()

            Invoice_HeaderBindingSource.DataSource = GetInvoicesForSelectedContract(ID_Contract)

            Me.filterValue = 1

            Call FillComboBoxes()
            Call LoadFilterCombo(Me.ComboBox_Filter)

            If ID_Contract > 0 Then
                Call LoadListView(ID_Contract)
            End If

            ' Call LoadListView(ID_Contract)
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice : frm_Invoice_Load")
            Exit Sub
        End Try
    End Sub
    Private Function GetInvoicesForSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Invoice_Header)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim ContractInvoice = From C In context.Invoice_Header.Include("Contract")
                                Where C.KY_Contracts = ID_Contract

            For Each X In ContractInvoice
                Me.TextBox_Name_Contract.Text = X.Contract.Name_Contract.ToString
            Next

            Return ContractInvoice.ToList
            MsgBox(Err.Description & "frm_Invoices :GetInvoicesForSelectedContract")
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
                Me.TextBox_Name_Contract.Text = GetContractName(context, ID_Contract).ToString
            Else
                Me.TextBox_Name_Contract.Text = GetContractName(context, Me.KY_ContractsTextBox.Text).ToString
            End If


        Catch
            If Err.Number = 91 Then
                Exit Sub
            End If
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: Set_Contract_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Sub ComboBox_Contracts_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contracts_Select.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try

            Invoice_HeaderBindingSource.DataSource = GetInvoicesForSelectedContract(ComboBox_Contracts_Select.SelectedValue)

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)
            Me.TextBox_Name_Contract.Text = ""
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoices: ComboBox_Contracts_Select_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        Try

            ListView_Invoices.Clear()
            ListView_Invoices.Columns.Add("ID", 45, HorizontalAlignment.Left) '0
            ListView_Invoices.Columns.Add("Title", 180, HorizontalAlignment.Left) '1
            ListView_Invoices.Columns.Add("Created", 80, HorizontalAlignment.Left) '2
            ListView_Invoices.Columns.Add("Begin", 80, HorizontalAlignment.Left) '3
            ListView_Invoices.Columns.Add("End", 80, HorizontalAlignment.Left) '4
            ListView_Invoices.Columns.Add("Submitted", 85, HorizontalAlignment.Left) '5
            Dim str(5) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetInvoicesForSelectedContract(_ID_Contract)
                str(0) = Result.KY_Invoice_Header
                str(1) = Result.Desc_Invoice
                str(2) = Result.Date_Invoice_Created
                str(3) = Result.Date_Invoice_Begin
                str(4) = Result.Date_Invoice_End
                str(5) = Result.Invoice_Complete
                itm = New ListViewItem(str)
                ListView_Invoices.Items.Add(itm)
            Next
        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: LoadListView  ")
            Exit Sub
        End Try
    End Sub
    'Private Function GetAllInvoiceRecords() As List(Of Contracts.Invoice_Header)
    '====================================================================================================================================================
    'Returns the All the Invoice records
    '====================================================================================================================================================

    'Try
    'Return context.Invoice_Header.OrderBy(Function(a) a.KY_Invoice_Header).ToList()
    ' Catch
    'MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: GetAllInvoiceRecords")
    'Return Nothing
    'Exit Function
    'End Try
    'Return Nothing

    'End Function
    Private Sub ListView_Invoices_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_Invoices.ItemActivate
        '===============================================================
        'Sets form to hour record selected in listview
        '===============================================================

        Try

            If ListView_Invoices.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Invoice As String

            ID_Invoice = ListView_Invoices.SelectedItems.Item(0).SubItems(0).Text

            Invoice_HeaderBindingSource.DataSource = GetSelectedInvoice(ID_Invoice)
            Invoice_HeaderBindingSource.Position = GetCurrentRecordPosition(ID_Invoice) - 1

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: ListView_Invoices_ItemActivate")
            Exit Sub
        End Try
    End Sub
    Private Function GetSelectedInvoice(ByVal ID_Invoice As Integer) As List(Of Contracts.Invoice_Header)
        '============================================================================================
        'Gets hour records for contract ID
        '============================================================================================
        Try
            Dim Task = From C In context.Invoice_Header
                                Where C.KY_Invoice_Header = ID_Invoice
            Return Task.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice:  GetSelectedInvoice")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function

    Private Sub LinkLabel_Add_Invoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Invoice.LinkClicked
        '==================
        'Add Record
        '==================

        Try

            Call add_Record()
            Me.TextBox_Name_Contract.Text = ""


            Save_Context_Changes(context)


            Invoice_HeaderBindingSource.DataSource = Get_Max_Invoice_Record()
            Call Set_Contract_Name_Textbox()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice : LinkLabel_Add_Record_LinkClicked")
            Exit Sub
        End Try
    End Sub

    Private Function Get_Max_Invoice_Record() As List(Of Contracts.Invoice_Header)
        '===========================================================================================================================
        'Returns the max record from the Tasks table
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Invoice_Header
                              Select r.KY_Invoice_Header).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxInvoiceID = From C In context.Invoice_Header
            Where C.KY_Invoice_Header = MaxRecord
            Select C
            Return GetMaxInvoiceID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: Get_Max_Invoice_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Shadows Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Invoice_Header
            C.Date_Invoice_Created = Date.Today()
            C.Desc_Invoice = ""
            C.KY_Contracts = Me.ComboBox_Contracts_Select.SelectedValue
            context.AddToInvoice_Header(C)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_Invoice_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: frm_Invoice_FormClosing ")
        End Try
    End Sub
    Private Sub LinkLabel_Save_Invoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Invoice.LinkClicked

        Try

            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_Invoice_HeaderTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            Invoice_HeaderBindingSource.DataSource = GetAllInvoiceRecords(context)

            'Sets the position to the record just created using proc in this form
            Invoice_HeaderBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView(CInt(KY_ContractsTextBox.Text))


            Me.TextBox_Name_Contract.Text = ""
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Invoice: LinkLabel_Save_Invoice_LinkClicked")
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

            Dim CurrRecPos = From c In context.Invoice_Header

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Invoice_Header = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function
    Private Sub Desc_InvoiceTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desc_InvoiceTextBox.KeyDown
        'e.SuppressKeyPress = True
    End Sub
    Private Sub LinkLabel_Formatted_Title_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Formatted_Title.LinkClicked
        Try
            Me.Desc_InvoiceTextBox.Focus()
            Me.Desc_InvoiceTextBox.Text = Me.TextBox_Name_Contract.Text & ": " & Me.Date_Invoice_BeginDateTimePicker.Text & ": " & Me.Date_Invoice_EndDateTimePicker.Text & ": " & Me.Date_Invoice_CreatedDateTimePicker.Text
            Call Save_Context_Changes(context)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: LinkLabel_Formatted_Title_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Delete_invoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_invoice.LinkClicked

        Try
            Dim response As Integer
            response = MsgBox("You are about the delete the current record.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                Call LoadListView(CInt(KY_ContractsTextBox.Text))

            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Description & "frm_Invoice: LinkLabel_Delete_invoice_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Invoice_Header
                    Where (C.KY_Invoice_Header = CInt(KY_Invoice_HeaderTextBox.Text))
                        Select C
            For Each result As Invoice_Header In d
                context.Invoice_Header.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: Delete_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Create_Invoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Create_Invoice.LinkClicked
        Try
            Dim F As Frm_Reports
            F = New Frm_Reports(context, ReportGroup_Invoice)
            F.Show()
            F = Nothing
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Invoice: LinkLabel_Create_Invoice_LinkClicked ")
            Exit Sub
        End Try
    End Sub
End Class

