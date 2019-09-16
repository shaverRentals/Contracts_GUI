Public Class frm_Contracts_Hours
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities
    Public ID_Contract As Integer
    Public filterValue As Integer
    Public Name_Current_Contract As String
    Public Rate_Current_Contract As Double
    Public Rate_Freq As String
    Dim obj As New cls_Stored_Procedures
    Dim blnOpenForm As boolean
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Contracts_Hours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '==================================
            'Loads
            '====================================
            Call Hide_swithboard_Form()


            Contracts_HoursBindingSource.DataSource = GetHoursForSelectedContract(ID_Contract)


            Me.filterValue = 1

            Call FillComboBoxes()
            Call LoadFilterCombo(Me.ComboBox_Filter)

            If ID_Contract > 0 Then
                Call LoadListView(ID_Contract)
                Contracts_HoursBindingSource.DataSource = GetHoursForSelectedContract(ID_Contract)
            End If

            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours : frm_Contracts_Hours_Load")
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours :FillComboBoxes")
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: ComboBox_Filter_SelectedIndexChanged")
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
                Me.TextBox_Name_Current_Contract.Text = X.Contract.Name_Contract.ToString
                Me.TextBox_Contract_Rate.Text = X.Contract.Contracts_Rate.Amount_rate
                Me.Rate_Current_Contract = X.Contract.Contracts_Rate.Amount_rate
                Me.Rate_Freq = X.Contract.Contract_Rate_Freq_LU.Desc_Rate_Freq
                Me.TextBox_Freq.Text = X.Contract.Contract_Rate_Freq_LU.Desc_Rate_Freq
                Me.KY_ContractsTextBox.Text = X.Contract.KY_Contracts
            Next

            Return ContractHours.ToList
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours :GetHoursForSelectedContract")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function
    Private Sub ComboBox_Contracts_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contracts_Select.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try

            Contracts_HoursBindingSource.DataSource = GetHoursForSelectedContract(ComboBox_Contracts_Select.SelectedValue)

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)
            Me.TextBox_Name_Current_Contract.Text = ""
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: ComboBox_Contracts_Select_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================

        Try
            ListView_Contract_Hours.Clear()
            ListView_Contract_Hours.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Contract_Hours.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: LoadListView")
            Exit Sub
        End Try
    End Sub
    Private Sub ListView_Contract_Hours_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_Contract_Hours.ItemActivate
        '===============================================================
        'Sets form to hour record selected in listview
        '===============================================================

        Try

            If ListView_Contract_Hours.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Hours As String

            ID_Hours = ListView_Contract_Hours.SelectedItems.Item(0).SubItems(0).Text

            Contracts_HoursBindingSource.DataSource = GetSelectedHours(ID_Hours)
            Contracts_HoursBindingSource.Position = GetCurrentRecordPosition(ID_Hours) - 1


        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: ListView_Contracts_ItemActivate")
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

            Dim CurrRecPos = From c In context.Contracts_Hours

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Contracts_Hours = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function
    Private Function GetSelectedHours(ByVal ID_Hours As Integer) As List(Of Contracts.Contracts_Hours)
        '============================================================================================
        'Gets hour records for contract ID
        '============================================================================================
        Try
            Dim Hours = From C In context.Contracts_Hours
                                Where C.KY_Contracts_Hours = ID_Hours

            Return Hours.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours:  GetSelectedHours")
            Return Nothing
            Exit Function

        End Try
        Return Nothing
    End Function
    Private Sub frm_Contracts_Hours_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '============================================
        'Opens Switchboard form when this form closes
        '============================================
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: frm_Contracts_Hours_FormClosing ")
        End Try

    End Sub 
    Private Sub LinkLabel_Add_Contract_Hours_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Contract_Hours.LinkClicked
        Try

            Call add_Record()
            Me.TextBox_Name_Current_Contract.Text = ""
            Call Set_Contract_Name_Textbox()
            'Calls save record sub in base code form
            Save_Context_Changes(context)

          
            'Sets the current record to the max record which is the record just added
            Contracts_HoursBindingSource.DataSource = Get_Max_Hours_Record()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours : LinkLabel_Add_Record_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Hours_Record() As List(Of Contracts.Contracts_Hours)
        '===========================================================================================================================
        'Returns the max record from the Contracts Table. Used for getting back to an added record. 
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Contracts_Hours
                              Select r.KY_Contracts_Hours).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxHourID = From C In context.Contracts_Hours
            Where C.KY_Contracts_Hours = MaxRecord
            Select C
            Return GetMaxHourID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: Get_Max_Hours_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Contracts_Hours
            C.Date_Hours_Workd = Date.Today()
            C.Desc_Contracts_Hours = ""
            C.KY_Contracts = Me.ComboBox_Contracts_Select.SelectedValue
            context.AddToContracts_Hours(C)

        Catch
            MsgBox(Err.Description & "frm_Contracts_Hours: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub Set_Contract_Name_Textbox()
        '====================================================================================================================================================
        'Sets the Contract Name Text Box to the value returned in the Function GetContractorName
        '====================================================================================================================================================
        Try
            If ID_Contract > 0 Then
                Me.TextBox_Name_Current_Contract.Text = GetContractName(context, ID_Contract).ToString
            Else
                Me.TextBox_Name_Current_Contract.Text = GetContractName(context, Me.KY_ContractsTextBox.Text).ToString
            End If
        Catch
            If Err.Number = 91 Then
                Exit Sub
            End If
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: Set_Contract_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Save_Hours_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Hours.LinkClicked
        Try
            
            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_Contracts_HoursTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            Contracts_HoursBindingSource.DataSource = GetAllHoursRecords()

            'Sets the position to the record just created using proc in this form
            Contracts_HoursBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView(CInt(KY_ContractsTextBox.Text))


            Me.TextBox_Name_Current_Contract.Text = ""
            Call Set_Contract_Name_Textbox()


            obj = New cls_Stored_Procedures
            obj.RunStoredProcedure_NonQuery(SP_Update_Month_Cats)
            obj = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Contracts_ours: LinkLabel_Save_Contract_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function GetAllHoursRecords() As List(Of Contracts.Contracts_Hours)
        '====================================================================================================================================================
        'Returns the All the Contracts records
        '====================================================================================================================================================

        Try

            Return context.Contracts_Hours.OrderBy(Function(a) a.KY_Contracts_Hours).ToList()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: GetAllHourRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub LinkLabel_Delete_Hours_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Hours.LinkClicked
        '===================
        'Deletes
        '===================

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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: LinkLabel_Delete_Record_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Contracts_Hours
                    Where (C.KY_Contracts_Hours = CInt(KY_Contracts_HoursTextBox.Text))
                        Select C
            For Each result As Contracts_Hours In d
                context.Contracts_Hours.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Hours: Delete_Record ")
            Exit Sub
        End Try
    End Sub
End Class