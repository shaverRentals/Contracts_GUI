Public Class frm_Estimated_Tax
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities

    Public Sub New(ByVal _context As Contracts.ContractsEntities, Optional ByVal _ID_Contract As Integer = 0)
        '====================================================================================================================================================
        'Constructor adds contextfssfsfsfsfsf
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: Public Sub New")
            Exit Sub
        End Try

    End Sub

    Private Sub frm_Estimated_Tax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Call Hide_swithboard_Form()

            Estimated_Tax_paymentsBindingSource.DataSource = GetAllEstimatedTaxRecords()

            Call FillComboBoxes()

            Call LoadListView()

            Call FormatCurrency()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: frm_Retirement_Load")
            Exit Sub
        End Try

    End Sub
    Private Sub FillComboBoxes()
        '====================================================================================================================================================
        'Fills Comboboxes
        '====================================================================================================================================================
        Try
            'Loads Contractor Combobox
            Cbo_Quarter.DisplayMember = "Desc_Quarter"
            Cbo_Quarter.ValueMember = "KY_Quarter_LU"
            Cbo_Quarter.DataSource = GetAllQuarters()
            Cbo_Quarter.DataBindings.Add(New Binding("SelectedItem", Estimated_Tax_paymentsBindingSource, "Quarter_LU1", True))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: FillComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Function GetAllQuarters() As List(Of Contracts.Quarter_LU)
        '====================================================================================================================================================
        'Returns the All Retirements records
        '====================================================================================================================================================

        Try
            Return context.Quarter_LU.OrderBy(Function(a) a.KY_Quarter_LU).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: GetAllQuarters")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetAllEstimatedTaxRecords() As List(Of Contracts.Estimated_Tax_payments)
        '====================================================================================================================================================
        'Returns the All the Retirements records
        '====================================================================================================================================================

        Try
            Return context.Estimated_Tax_payments.OrderBy(Function(a) a.KY_Estimated_Taxes).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: GetAllEstimatedTaxRecords")
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
            Me.Amount_Estimated_TaxTextBox.Text = "$" & (Format(CDec(Me.Amount_Estimated_TaxTextBox.Text), "0.00"))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax:FormatCurrency")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Add_Est_Tax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Est_Tax.LinkClicked
        Try

            Call add_Record()
            'Calls save record sub in base code form
            Save_Context_Changes(context)


            'Sets the current record to the max record which is the record just added
            Estimated_Tax_paymentsBindingSource.DataSource = Get_Max_Estimated_Tax_Record()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: LinkLabel_Add_Est_Tax_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Estimated_Tax_Record() As List(Of Contracts.Estimated_Tax_payments)
      
        Try

            Dim MaxRecID = (From r In context.Estimated_Tax_payments
                              Select r.KY_Estimated_Taxes).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxTaxID = From C In context.Estimated_Tax_payments
            Where C.KY_Estimated_Taxes = MaxRecord
            Select C
            Return GetMaxTaxID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: Get_Max_Estimated_Tax_Record")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Estimated_Tax_payments
            C.Date_Est_Tax_Paid = Date.Today()
            context.AddToEstimated_Tax_payments(C)

        Catch
            MsgBox(Err.Description & "frm_Estimated_Tax: add_Record ")
            Exit Sub
        End Try
    End Sub

    Private Sub LinkLabel_Save_Est_Tax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Est_Tax.LinkClicked
        Try

            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_Estimated_TaxesTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            Estimated_Tax_paymentsBindingSource.DataSource = GetAllEstimatedTaxRecords()

            'Sets the position to the record just created using proc in this form
            Estimated_Tax_paymentsBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView()

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: LinkLabel_Save_Est_Tax_LinkClicked")
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

            Dim CurrRecPos = From c In context.Estimated_Tax_payments

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Estimated_Taxes = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: GetCurrentRecordPosition")
            Return 0
        End Try

    End Function
    Private Sub LinkLabel_Delete_Est_Tax_Payment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Est_Tax_Payment.LinkClicked
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: LinkLabel_Delete_Est_Tax_Payment_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Estimated_Tax_payments
                    Where (C.KY_Estimated_Taxes = CInt(KY_Estimated_TaxesTextBox.Text))
                        Select C
            For Each result As Estimated_Tax_payments In d
                context.Estimated_Tax_payments.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: Delete_Record")
            Exit Sub
        End Try
    End Sub
    Private Sub LoadListView()
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================

        Try
            ListView_Est_Tax.Clear()
            ListView_Est_Tax.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Est_Tax.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
            ListView_Est_Tax.Columns.Add("Amount", 90, HorizontalAlignment.Left) '2
            ListView_Est_Tax.Columns.Add("Year", 90, HorizontalAlignment.Left) '3
            ListView_Est_Tax.Columns.Add("Quarter", 90, HorizontalAlignment.Left) '4
            Dim str(4) As String
            Dim itm As ListViewItem
            itm = New ListViewItem(str)

            For Each Result In GetAllEstimatedTaxRecords()
                str(0) = Result.KY_Estimated_Taxes
                str(1) = Result.Date_Est_Tax_Paid
                str(2) = "$" & Format(CDec(Result.Amount_Estimated_Tax), "0.00")
                str(3) = Result.Tax_Year
                str(4) = Result.Quarter_LU1.Desc_quarter
                itm = New ListViewItem(str)
                ListView_Est_Tax.Items.Add(itm)
            Next


            Dim TotalAmount As Decimal = 0

            Dim t As ListViewItem
            For Each t In ListView_Est_Tax.Items
                TotalAmount += CDec(t.SubItems.Item(2).Text)
            Next
            str(0) = "TOTAL$$"
            str(1) = ""
            str(3) = ""
            str(4) = ""
            str(2) = "$" & Format(CDec(TotalAmount), "0.00")
            itm = New ListViewItem(str)
            ListView_Est_Tax.Items.Add(itm)


            Dim lastRow As Integer


            lastRow = ListView_Est_Tax.Items.Count - 1

            ListView_Est_Tax.Items(lastRow).BackColor = Color.Chartreuse

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: LoadListView")
            Exit Sub
        End Try
    End Sub
    Private Sub ListView_est_Tax_ItemActivate(sender As Object, e As EventArgs) Handles ListView_Est_Tax.ItemActivate
        Try

            If ListView_Est_Tax.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_EstTax As String

            ID_EstTax = ListView_Est_Tax.SelectedItems.Item(0).SubItems(0).Text

            Estimated_Tax_paymentsBindingSource.DataSource = GetSelectedEstTax(ID_EstTax)
            Estimated_Tax_paymentsBindingSource.Position = GetCurrentRecordPosition(ID_EstTax) - 1

            Call FormatCurrency()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: ListView_est_Tax_ItemActivate")
            Exit Sub
        End Try
    End Sub

    Private Function GetSelectedEstTax(ByVal ID_Est_Tax As Integer) As List(Of Contracts.Estimated_Tax_payments)
        '============================================================================================
        'Gets hour records for retirment ID
        '============================================================================================
        Try
            Dim EstTax = From C In context.Estimated_Tax_payments
                                Where C.KY_Estimated_Taxes = ID_Est_Tax

            Return EstTax.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Taxes: GetSelectedEstTax")
            Return Nothing
            Exit Function

        End Try
        Return Nothing
    End Function

    Private Sub frm_Estimated_Tax_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        '============================================
        'Opens Switchboard form when this form closes
        '============================================
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: frm_Estimated_Tax_FormClosing")
        End Try

    End Sub
    Private Sub Cbo_Quarter_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_Quarter.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub LinkLabel_Link_Est_Tax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Link_Est_Tax.LinkClicked
        Try

            Me.Img_Path_Est_TaxTextBox.Text = OpenDialog_Base()
            Me.Img_Path_Est_TaxTextBox.Focus()
            Save_Context_Changes(context)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax:: LinkLabel_Link_Est_Tax_LinkClicked")
        End Try
    End Sub
    Private Sub LinkLabel_Open_Est_Tax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Open_Est_Tax.LinkClicked
        Try
            OpenFile_Base(Me.Img_Path_Est_TaxTextBox.Text)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Estimated_Tax: LinkLabel_Open_Est_Tax_LinkClicked")
            Exit Sub
        End Try
    End Sub
End Class