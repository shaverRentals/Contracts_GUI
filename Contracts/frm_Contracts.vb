Public Class frm_Contracts
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities 'Sets Context for EF Model
    Public ID_Contractor As Integer
    Public Bln_Add_From_frm_Contractor As Boolean
    Public filterValue As Integer
    Public TextPrevious As String
    Public Rate_Current_Contract As Double
    Public Rate_Freq As String
    Public Sub New(ByVal _context As Contracts.ContractsEntities, Optional ByVal _ID_Contractor As Integer = 0, Optional ByVal _Bln_Add_From_frm_Contractor As Boolean = False)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
            ID_Contractor = _ID_Contractor
            Bln_Add_From_frm_Contractor = _Bln_Add_From_frm_Contractor

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Contracts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '====================================================================================================================================================
        'Loads
        '====================================================================================================================================================
        Try


            Call Hide_swithboard_Form()

            ContractsBindingSource.DataSource = GetAllContractsRecords()

            Me.filterValue = 1

            Call FillComboBoxes()

            Call LoadListView(CInt(KY_ContractsTextBox.Text))
            Call LoadListView_01(CInt(KY_ContractsTextBox.Text))
            Call LoadFilterCombo(Me.ComboBox_Filter)
            Call Add_Contract_From_Contractor_Form(Bln_Add_From_frm_Contractor, ID_Contractor)
            Call Set_Contractor_Name_Textbox()
            Call Set_Contractee_Name_Textbox()
            Call FormatCurrency()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts : frm_Contracts_Load")
            Exit Sub
        End Try

    End Sub
    Private Sub FillComboBoxes()
        '====================================================================================================================================================
        'Fills Comboboxes
        '====================================================================================================================================================
        Try
            Dim F As New frm_Contractors(context) '------uses method from Contractors form

            'Loads Contractor Combobox
            ComboBox_Contractors.DisplayMember = "Name_Contractor"
            ComboBox_Contractors.ValueMember = "KY_Contractor"
            ComboBox_Contractors.DataSource = F.GetAllContractorsRecords

            'Loads Contracts Select Combobox
            ComboBox_Contracts_Select.DisplayMember = "Name_Contract"
            ComboBox_Contracts_Select.ValueMember = "KY_Contracts"
            ComboBox_Contracts_Select.DataSource = GetContractsForContractsComboBox(Me.filterValue, context)

            'Loads Contracts Status Combobox
            KY_Status_ContractComboBox.DisplayMember = "Desc_Contract_Status"
            KY_Status_ContractComboBox.ValueMember = "KY_Status_Contract"
            KY_Status_ContractComboBox.DataSource = GetContractsStatus()
            KY_Status_ContractComboBox.DataBindings.Clear()
            KY_Status_ContractComboBox.DataBindings.Add(New Binding("SelectedItem", ContractsBindingSource, "Contract_Status_LU", True))

            'Loads Contract Rate Combobox
            ComboBox_Contract_Rate.DisplayMember = "Amount_rate"
            ComboBox_Contract_Rate.ValueMember = "KY_Rate"
            ComboBox_Contract_Rate.DataSource = GetContractsRate()
            ComboBox_Contract_Rate.DataBindings.Clear()
            ComboBox_Contract_Rate.DataBindings.Add(New Binding("SelectedItem", ContractsBindingSource, "Contracts_Rate", True))

            'Loads Contractor Frequency Combobox
            ComboBox_Rate_Freq.DisplayMember = "Desc_Rate_Freq"
            ComboBox_Rate_Freq.ValueMember = "KY_Rate_Freq"
            ComboBox_Rate_Freq.DataSource = GetContractsRateFreq()
            ComboBox_Rate_Freq.DataBindings.Clear()
            ComboBox_Rate_Freq.DataBindings.Add(New Binding("SelectedItem", ContractsBindingSource, "Contract_Rate_Freq_LU", True))

            'Loads the Contractee Combobox
            ComboBox_Contractee.DisplayMember = "Name_Contractee"
            ComboBox_Contractee.ValueMember = "KY_Contractee"
            ComboBox_Contractee.DataSource = GetContractee()


            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: FillComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Function GetAllContractsRecords() As List(Of Contracts.Contract)
        '====================================================================================================================================================
        'Returns the All the Contracts records
        '====================================================================================================================================================

        Try
            Return context.Contracts.OrderBy(Function(a) a.KY_Contracts).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetAllContractsRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetContractorName() As String
        '====================================================================================================================================================
        'Reuturs the name of the contractor for the FK on the contractor table for the current Contract Record
        '====================================================================================================================================================
        Try

            Dim ContractorName = From C In context.Contractors
                                 Where C.KY_Contractor = CInt(Me.KY_ContractorTextBox.Text)
            For Each N In ContractorName
                Return N.Name_Contractor.ToString
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetContractorName")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub Set_Contractor_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contractor Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try

            Me.TextBox_Contractor_Name.Text = GetContractorName().ToString

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: Set_Contractor_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Sub ComboBox_Filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Filter.SelectedIndexChanged
        '======================================================================================
        'Sets Filter value for enumeration
        '======================================================================================
        Try
            RemoveHandler ComboBox_Contractors.SelectedIndexChanged, AddressOf ComboBox_Contractors_SelectedIndexChanged

            Me.filterValue = SetComtractFiterValue(ComboBox_Filter.SelectedItem)

            Call FillComboBoxes()
        Catch
            MsgBox(Err.Number & ":" & Err.Description & " frm_Contracts:Cbo_Filter_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_Contracts_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '================================================
        'Opens Swithcboard form when contracts closes
        '=================================================
        Try
            Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ":" & Err.Description & "frm_Contracts: frm_Contracts_FormClosing")
            Exit Sub
        End Try
    End Sub
    Private Sub ComboBox_Contracts_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contracts_Select.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try
            ContractsBindingSource.DataSource = GetSelectedContract(ComboBox_Contracts_Select.SelectedValue)
            Call Set_Contractor_Name_Textbox()
            Call LoadListView(CInt(KY_ContractsTextBox.Text))
            Call LoadListView_01(CInt(KY_ContractsTextBox.Text))
        Catch
            MsgBox(Err.Number & ":" & Err.Description & "frm_Contracts_Hours: ComboBox_Contracts_Select_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Function GetContractsStatus() As List(Of Contracts.Contract_Status_LU)
        '====================================================================================================================================================
        'Returns contract status
        '====================================================================================================================================================
        Try
            Return context.Contract_Status_LU.OrderBy(Function(a) a.KY_Status_Contract).ToList()
        Catch
            Return Nothing
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetContractsStatus")
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub ComboBox_Contracts_Select_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Contracts_Select.KeyDown
        '--------------locks combobox
        e.SuppressKeyPress = True
    End Sub
    Private Sub ComboBox_Filter_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Filter.KeyDown
        '--------------locks combobox
        e.SuppressKeyPress = True
    End Sub
    Private Sub ComboBox_Contractors_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Contractors.KeyDown
        '--------------locks combobox
        e.SuppressKeyPress = True
    End Sub
    Private Function GetSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Contract)
        '==============================================================================================
        'Gets the contract record passed as paramater
        '==============================================================================================
        Try
            Dim GetSelectedContractRecord = From C In context.Contracts
                                      Where C.KY_Contracts = ID_Contract

            Return GetSelectedContractRecord.ToList
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetSelectedContract")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub LinkLabel_Add_Contracts_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Contracts.LinkClicked
        '====================================================================================================================================================
        'Adds new record and binds the controls to the record just added 
        '====================================================================================================================================================
        Try

            Me.KY_Status_ContractComboBox.SelectedIndex = -1

            Call add_Record()

            'Calls save record sub in base code form
            Save_Context_Changes(context)

            Me.TextBox_Contractor_Name.Text = ""
            Call FormatCurrency()
            'Sets the current record to the max record which is the record just added
            ContractsBindingSource.DataSource = Get_Max_Contract_Record()
            Call LoadListView(CInt(KY_ContractsTextBox.Text))
            Call LoadListView_01(CInt(KY_ContractsTextBox.Text))

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_Add_Contracts_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Contract
            C.Name_Contract = ""
            C.Money_Contract_Total = 0.0
            C.Hours_Contract_Total = 0.0
            C.Date_Contract_Begin = Now()
            C.Date_Contract_End = Now()
            C.Contract_Notes = ""
            C.Desc_Contract_Services = ""
            C.KY_Status_Contract = 1
            C.KY_Contractor = 1
            C.KY_Rate = 1
            C.KY_Contractee = 1
            C.KY_Rate_Freq = 1
            context.AddToContracts(C)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Contract_Record() As List(Of Contracts.Contract)
        '===========================================================================================================================
        'Returns the max record from the Contracts Table. Used for getting back to an added record. 
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Contracts
                              Select r.KY_Contracts).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxConractID = From C In context.Contracts
            Where C.KY_Contracts = MaxRecord
            Select C
            Return GetMaxConractID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: Get_Max_Contract_Record")
            Return Nothing
            Exit Function
        End Try
    End Function
    Private Sub Add_Contract_From_Contractor_Form(ByVal Bln_Add_From_frm_Contractor As Boolean, ByVal ID_Contractor As Integer)
        '----------------------------------------------------------------------------------------------------------------------
        'Adds Record if adding from contractor form
        '-----------------------------------------------------------------------------------------------------------------------
        Try
            If Bln_Add_From_frm_Contractor = False Then
                Exit Sub
            Else
                Dim C As New Contract
                C.Name_Contract = ""
                C.Money_Contract_Total = 0.0
                C.Hours_Contract_Total = 0.0
                C.Date_Contract_Begin = Now()
                C.Date_Contract_End = Now()
                C.Contract_Notes = ""
                C.KY_Status_Contract = 1
                C.KY_Contractor = ID_Contractor
                C.KY_Contractor = 1
                C.KY_Rate = 1
                C.KY_Contractee = 1
                C.KY_Rate_Freq = 1
                context.AddToContracts(C)
                ContractsBindingSource.DataSource = Get_Max_Contract_Record()
                Call Set_Contractor_Name_Textbox()
            End If
        Catch
            MsgBox(Err.Description & "frm_Contracts: Add_Contract_From_Contractor_Form")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Save_Contract_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Contract.LinkClicked
        '==================================================================================================================
        'Adds New Contracts Record
        '==================================================================================================================
        Try
            RemoveHandler ComboBox_Contracts_Select.SelectedIndexChanged, AddressOf ComboBox_Contracts_Select_SelectedIndexChanged
            RemoveHandler ComboBox_Contractors.SelectedIndexChanged, AddressOf ComboBox_Contractors_SelectedIndexChanged
            RemoveHandler ComboBox_Contractee.SelectedIndexChanged, AddressOf ComboBox_Contractee_SelectedIndexChanged
            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_ContractsTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            ContractsBindingSource.DataSource = GetAllContractsRecords()

            'Sets the position to the record just created using proc in this form
            ContractsBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call FillComboBoxes()
            Call LoadListView(CInt(KY_ContractsTextBox.Text))
            Call LoadListView_01(CInt(KY_ContractsTextBox.Text))

            AddHandler ComboBox_Contracts_Select.SelectedIndexChanged, AddressOf ComboBox_Contracts_Select_SelectedIndexChanged
            AddHandler ComboBox_Contractors.SelectedIndexChanged, AddressOf ComboBox_Contractors_SelectedIndexChanged
            RemoveHandler ComboBox_Contractee.SelectedIndexChanged, AddressOf ComboBox_Contractee_SelectedIndexChanged

            Call Set_Contractee_Name_Textbox()
            Call Set_Contractor_Name_Textbox()
            Call FormatCurrency()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Contracts: LinkLabel_Save_Contract_LinkClicked")
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

            Dim CurrRecPos = From c In context.Contracts

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Contracts = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetCurrentRecordPosition")
            Return 0
            Exit Function
        End Try

    End Function
    Private Sub ComboBox_Contractors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contractors.SelectedIndexChanged
        '====================================================================================================================================================
        'Sets Contractror ID to value selected in the contractor combobox
        '==================================================================================================================================================== 
        Try
            Me.KY_ContractorTextBox.Text = Me.ComboBox_Contractors.SelectedValue
            Me.KY_ContractorTextBox.Focus()
            Me.TextBox_Contractor_Name.Focus()

            Call Set_Contractee_Name_Textbox()
            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)
            Call LoadListView_01(ComboBox_Contracts_Select.SelectedValue)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts : ComboBox_Contractors_SelectedIndexChanged ")
            Exit Sub
        End Try
    End Sub
    Private Sub Set_Contractee_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contractor Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try

            Me.TextBox_Name_Contractee.Text = GetContracteeName().ToString

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: Set_Contractee_Name_Textbox")
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetContracteeName")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetContractsRate() As List(Of Contracts.Contracts_Rate)
        '====================================================================================================================================================
        'Returns contract rate
        '====================================================================================================================================================
        Try
            Return context.Contracts_Rate.OrderBy(Function(a) a.KY_Rate).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetContractsRate")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetContractsRateFreq() As List(Of Contracts.Contract_Rate_Freq_LU)
        '====================================================================================================================================================
        'Returns contract rate frequency
        '====================================================================================================================================================
        Try
            Return context.Contract_Rate_Freq_LU.OrderBy(Function(a) a.KY_Rate_Freq).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts:  GetContractsRateFreq")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetContractee() As List(Of Contracts.Contractee)
        '====================================================================================================================================================
        'Returns contractee records
        '====================================================================================================================================================
        Try
            Return context.Contractees.OrderBy(Function(a) a.KY_Contractee).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetContractee")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub ComboBox_Contractee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contractee.SelectedIndexChanged
        '====================================================================================================================================================
        'Sets Contractee ID to value selected in the contractee combobox
        '==================================================================================================================================================== 
        Try

            Me.KY_ContracteeTextBox.Text = Me.ComboBox_Contractee.SelectedValue
            Me.KY_ContracteeTextBox.Focus()
            Me.TextBox_Name_Contractee.Focus()

            Call Set_Contractee_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: ComboBox_Contractee_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub

    Private Sub KY_ContractsTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KY_ContractsTextBox.KeyDown
        '----Locks Contract ID textbox
        e.SuppressKeyPress = True
    End Sub
    Private Sub TextBox_Contractor_Name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Contractor_Name.KeyDown
        '------Locks contractor Name Textbox
        e.SuppressKeyPress = True
    End Sub
    Private Sub KY_ContractorTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KY_ContractorTextBox.KeyDown
        '------Locks Contractor ID textbox
        e.SuppressKeyPress = True
    End Sub
    Private Sub TextBox_Name_Contractee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Name_Contractee.KeyDown
        '----------Locks Contractee Name Textbox
        e.SuppressKeyPress = True
    End Sub
    Private Sub KY_ContracteeTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KY_ContracteeTextBox.KeyDown
        '---locks the conttractee ID textbox
        e.SuppressKeyPress = True
    End Sub
    Private Sub ComboBox_Rate_Freq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Rate_Freq.KeyDown
        ''---locks the conttract rate frequency combobox
        e.SuppressKeyPress = True
    End Sub
    Private Sub ComboBox_Contract_Rate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contract_Rate.Leave
        '==============================================================================
        'Checks to see if new value in combobox is already in the db. if not allows add)
        '===============================================================================

        If CheckInList(CheckFormatCurr(ComboBox_Contract_Rate.Text), GetContractsRate.ToArray, "Contract_Rate") = True Then

            TextPrevious = ComboBox_Contract_Rate.Text.ToString

            MsgBox("You have Entered an Item that is not on the list. Do you want to Add this to the list?", vbYesNoCancel, "ADD TO LIST")

            If vbYes Then
                Dim Rate As New Contracts_Rate()
                Rate.Amount_rate = ComboBox_Contract_Rate.Text
                context.AddToContracts_Rate(Rate)
                context.SaveChanges()
                ComboBox_Contract_Rate.DataSource = GetContractsRate.ToList
                ComboBox_Contract_Rate.Text = TextPrevious
            Else

                Resume Next

            End If

        End If

    End Sub
    Private Sub FormatCurrency()
        '==============================================================================
        'Formats Controls that have currency displayed
        '===============================================================================
        Try
            Me.ComboBox_Contract_Rate.Text = "$" & (Format(CDec(Me.ComboBox_Contract_Rate.Text), "0.00"))
            Me.Money_Contract_TotalTextBox.Text = "$" & (Format(CDec(Me.Money_Contract_TotalTextBox.Text), "0.00"))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts:FormatCurrency")
            Exit Sub
        End Try
    End Sub
    Private Function CheckFormatCurr(ByVal strCurrency As String) As String
        '==============================================================================
        'Checks to see if the string from the currency checkbox is formatted for currency 
        'if it is, then it formats it in Money format so that the check in list sub can
        'check it against the db records to see if it already exists. 
        '===============================================================================
        Try
            If strCurrency.Substring(0, 1) = "$" Then

                Dim strUnformat As String

                strUnformat = strCurrency.Remove(0, 1) & "00"

                Return strUnformat

            Else
                Return strCurrency

            End If

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: CheckFormatCurr")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub Money_Contract_TotalTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Money_Contract_TotalTextBox.Enter
        Call FormatCurrency()
    End Sub
    Private Sub Contract_NotesTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call FormatCurrency()
    End Sub
    Private Sub TextBox_Name_Contractee_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Name_Contractee.Enter
        Call FormatCurrency()
    End Sub
    Private Sub Name_ContractTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_ContractTextBox.Enter
        Call FormatCurrency()
    End Sub
    Private Sub Hours_Contract_TotalTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hours_Contract_TotalTextBox.Enter
        Call FormatCurrency()
    End Sub
    Private Sub KY_Status_ContractComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KY_Status_ContractComboBox.Enter
        Call FormatCurrency()
    End Sub
    Private Sub LinkLabel_Manage_Contract_Hours_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Manage_Contract_Hours.LinkClicked
        '=============================================================================================================================
        'Opens Contracts Hours Form
        '==============================================================================================================================

        Try

            Dim F As frm_Contracts_Hours
            F = New frm_Contracts_Hours(context, CInt(Me.KY_ContractsTextBox.Text))
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_Manage_Contract_Hours_LinkClicked ")
            Exit Sub
        End Try
    End Sub

    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================
        Try
            ListView_Contract_Hours.Clear()
            ListView_Contract_Hours.Columns.Add("ID", 80, HorizontalAlignment.Left) '0
            ListView_Contract_Hours.Columns.Add("Date", 85, HorizontalAlignment.Left) '1
            ListView_Contract_Hours.Columns.Add("Hours", 90, HorizontalAlignment.Left) '2
            ListView_Contract_Hours.Columns.Add("Desc", 300, HorizontalAlignment.Left) '3
            Dim str(3) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetHoursForSelectedContract(_ID_Contract)
                str(0) = Result.KY_Contracts_Hours
                str(1) = Result.Date_Hours_Workd
                str(2) = Result.Contracts_Hours1
                str(3) = Result.Desc_Contracts_Hours
                itm = New ListViewItem(str)
                ListView_Contract_Hours.Items.Add(itm)
            Next


            Dim TotalHours As Decimal = 0

            Dim t As ListViewItem
            For Each t In ListView_Contract_Hours.Items
                TotalHours += CDec(t.SubItems.Item(2).Text)
            Next
            str(0) = "TOTAL Hrs"
            str(1) = ""
            str(3) = ""
            str(2) = TotalHours
            itm = New ListViewItem(str)
            ListView_Contract_Hours.Items.Add(itm)


            Dim TotalMoney As Decimal = 0


            str(0) = "TOTAL $$"
            str(1) = ""
            str(3) = ""
            If Me.Rate_Freq = "Hour" Then
                str(2) = "$" & Format(CDec(TotalHours * Rate_Current_Contract), "0.00")
            Else
                str(2) = "$" & Format(CDec(Rate_Current_Contract), "0.00")
            End If
            itm = New ListViewItem(str)
            ListView_Contract_Hours.Items.Add(itm)

            Dim lastRow As Integer
            Dim NextToLastRow As Integer
            lastRow = ListView_Contract_Hours.Items.Count - 1
            NextToLastRow = ListView_Contract_Hours.Items.Count - 2
            ListView_Contract_Hours.Items(lastRow).BackColor = Color.Chartreuse
            ListView_Contract_Hours.Items(NextToLastRow).BackColor = Color.DarkSeaGreen

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LoadListView")
            Exit Sub
        End Try
    End Sub
    Private Function GetHoursForSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Contracts_Hours)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim ContractHours = From C In context.Contracts_Hours.Include("Contract.Contracts_Rate").Include("Contract.Contract_Rate_Freq_LU")
                                Where C.KY_Contracts = ID_Contract
            For Each X In ContractHours
                
                Me.Rate_Current_Contract = X.Contract.Contracts_Rate.Amount_rate
                Me.Rate_Freq = X.Contract.Contract_Rate_Freq_LU.Desc_Rate_Freq
               
            Next
            Return ContractHours.ToList
            MsgBox(Err.Description & "frm_Contracts: GetHoursForSelectedContract")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function
    Private Sub LoadListView_01(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================
        Try
            ListView_Contract_Tasks.Clear()
            ListView_Contract_Tasks.Columns.Add("ID", 80, HorizontalAlignment.Left) '0
            ListView_Contract_Tasks.Columns.Add("Date", 80, HorizontalAlignment.Left) '1
            ListView_Contract_Tasks.Columns.Add("Description", 205, HorizontalAlignment.Left) '2
            ListView_Contract_Tasks.Columns.Add("status", 75, HorizontalAlignment.Left) '2

            Dim str(3) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetTasksForSelectedContract(_ID_Contract)
                str(0) = Result.KY_Tasks
                str(1) = Result.Date_Due_task
                str(2) = Result.Desc_Tasks
                str(3) = Result.Task_Status_LU.Desc_Task_Status

                itm = New ListViewItem(str)
                ListView_Contract_Tasks.Items.Add(itm)
            Next


            Dim TotalOpen As Integer = 0

            Dim t As ListViewItem
            For Each t In ListView_Contract_Tasks.Items
                If t.SubItems.Item(3).Text = "Open" Then

                    TotalOpen += 1
                End If
            Next
            str(0) = "Open"
            str(1) = ""
            str(3) = ""
            str(2) = TotalOpen
            itm = New ListViewItem(str)
            ListView_Contract_Tasks.Items.Add(itm)


            Dim TotalCompleted As Integer = 0

            str(0) = "Completed"
            str(1) = ""
            str(3) = ""
            For Each t In ListView_Contract_Tasks.Items
                If t.SubItems.Item(3).Text = "Completed" Then
                    TotalCompleted += 1
                End If
            Next
            str(0) = "Completed"
            str(1) = ""
            str(3) = ""
            str(2) = TotalCompleted
            itm = New ListViewItem(str)
            ListView_Contract_Tasks.Items.Add(itm)

            Dim lastRow As Integer
            Dim NextToLastRow As Integer

            lastRow = ListView_Contract_Tasks.Items.Count - 1
            NextToLastRow = ListView_Contract_Tasks.Items.Count - 2
            ListView_Contract_Tasks.Items(lastRow).BackColor = Color.Chartreuse
            ListView_Contract_Tasks.Items(NextToLastRow).BackColor = Color.DarkSeaGreen

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LoadListView01")
            Exit Sub
        End Try
    End Sub
    Private Function GetTasksForSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Task)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim ContractTasks = From C In context.Tasks.Include("Contract")
                                Where C.KY_Contracts = ID_Contract

            Return ContractTasks.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: GetTasksForSelectedContract")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Private Sub LinkLabel_Mamage_Tasks_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Mamage_Tasks.LinkClicked
        '=============================================================
        'Opens Tasks Form
        '=============================================================
        Try

            Dim F As frm_Contract_Tasks
            F = New frm_Contract_Tasks(context, CInt(Me.KY_ContractsTextBox.Text))
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_Manage_Contract_Tasks_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Delete_Contract_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Contract.LinkClicked
        '============================================================
        'Deletes Contracts and contracts child records
        '============================================================
        Try

            Dim response As Integer
            response = MsgBox("You are about the delete the current record and child records.Press OK to delete", vbOKCancel, "Delete Request")
            If response = vbOK Then

                Delete_Record()

                Save_Context_Changes(context)

                Call LoadListView(CInt(KY_ContractsTextBox.Text))
                Call LoadListView_01(CInt(KY_ContractsTextBox.Text))

            Else
                MsgBox("Record not Deleted")
                Exit Sub
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_Delete_Record_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            'Deletes Hours
            Dim a = From C In context.Contracts_Hours
                    Where (C.KY_Contracts = CInt(KY_ContractsTextBox.Text))
                        Select C
            For Each result As Contracts_Hours In a
                context.Contracts_Hours.DeleteObject(result)
            Next

            'Deletes tasks
            Dim b = From C In context.Tasks
                    Where (C.KY_Contracts = CInt(KY_ContractsTextBox.Text))
                        Select C
            For Each result As Task In b
                context.Tasks.DeleteObject(result)
            Next

            'Deletes Contract
            Dim d = From C In context.Contracts
                    Where (C.KY_Contracts = CInt(KY_ContractsTextBox.Text))
                        Select C
            For Each result As Contract In d
                context.Contracts.DeleteObject(result)
            Next

            Call Save_Context_Changes(context)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: Delete_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Create_Contract_Folder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Create_Contract_Folder.LinkClicked
        '==========================================================
        'Creates a folder for the current contract
        '===========================================================
        Try
            If CheckFolders(Me.KY_ContractsTextBox.Text, ContractFolder) = True Then
                MsgBox("Folder with that ID already exists")
                Exit Sub
            End If

            Dim NewFolder As String = "\" & FormatsID(Me.KY_ContractsTextBox.Text) & "_" & Me.Name_ContractTextBox.Text & "_" & Format(Now, "MM-dd-yyyy")

            CreateFolder(NewFolder, ContractFolder)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_Create_Contract_Folder_LinkClicked ")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_OpenContractsFolder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenContractsFolder.LinkClicked
        Try
            OpenContractFolder(ContractFolder & "\", FormatsID(Me.KY_ContractsTextBox.Text))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts: LinkLabel_OpenContractsFolder_LinkClicked ")
        End Try
    End Sub
End Class
