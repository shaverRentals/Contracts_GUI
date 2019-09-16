Public Class frm_Contract_Tasks
    Inherits Contracts.frm_Base_Code
    Public context As New Contracts.ContractsEntities
    Public filterValue As Integer
    Public ID_Contract As Integer
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks : Public Sub New")
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: ComboBox_Filter_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub ComboBox_Contracts_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Contracts_Select.SelectedIndexChanged
        '===========================================================================================
        'Opens Sets record on form to contract selected in Contracts select combobox
        '============================================================================================
        Try

            TasksBindingSource.DataSource = GetTasksForSelectedContract(ComboBox_Contracts_Select.SelectedValue)

            Call LoadListView(ComboBox_Contracts_Select.SelectedValue)
            Me.TextBox_Name_Contract.Text = ""
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: ComboBox_Contracts_Select_SelectedIndexChanged")
            Exit Sub
        End Try
    End Sub
    Private Sub FillComboBoxes()
        '===================================
        'Fills ComboBox Controls
        '===================================
        Try
            'Loads Contracts Select Combobox
            ComboBox_Contracts_Select.DisplayMember = "Name_Contract"
            ComboBox_Contracts_Select.ValueMember = "KY_Contracts"
            ComboBox_Contracts_Select.DataSource = GetContractsForContractsComboBox(Me.filterValue, context)

            ComboBox_Task_Status.DisplayMember = "Desc_Task_Status"
            ComboBox_Task_Status.ValueMember = "KY_Task_Status"
            ComboBox_Task_Status.DataSource = GetTasksStatus()
            ComboBox_Task_Status.DataBindings.Clear()
            ComboBox_Task_Status.DataBindings.Add(New Binding("SelectedItem", TasksBindingSource, "Task_Status_LU", True))

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks :FillComboBoxes")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_Contract_Tasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '====================
        'Form Load
        '=====================
        Try

            Call Hide_swithboard_Form()

            TasksBindingSource.DataSource = GetTasksForSelectedContract(ID_Contract)

            Me.filterValue = 1

            Call FillComboBoxes()
            Call LoadFilterCombo(Me.ComboBox_Filter)

            If ID_Contract > 0 Then
                Call LoadListView(ID_Contract)
                TasksBindingSource.DataSource = GetTasksForSelectedContract(ID_Contract)
            End If

            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks :frm_Contract_Tasks_Load ")
            Exit Sub
        End Try
    End Sub
    Private Sub frm_Contract_Tasks_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '====================================
        'opens switchboard on form close
        '===================================
        Try
            Call Show_swithcboard_form()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks :  frm_Contract_Tasks_FormClosing")
            Exit Sub
        End Try
    End Sub
    Private Function GetTasksStatus() As List(Of Contracts.Task_Status_LU)
        '====================================================================================================================================================
        'Returns contract status
        '====================================================================================================================================================
        Try
            Return context.Task_Status_LU.OrderBy(Function(a) a.KY_Task_Status).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks:GetTasksStatus")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Function GetTasksForSelectedContract(ByVal ID_Contract As Integer) As List(Of Contracts.Task)
        '==========================================================================
        'Returns Hours for selected contract
        '==========================================================================

        Try
            Dim ContractTasks = From C In context.Tasks.Include("Contract")
                                Where C.KY_Contracts = ID_Contract

            For Each X In ContractTasks
                Me.TextBox_Name_Contract.Text = X.Contract.Name_Contract.ToString
            Next

            Return ContractTasks.ToList
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks :GetTasksForSelectedContract")
            Exit Function
        Catch
        End Try
        Return Nothing
    End Function
    Private Sub LoadListView(ByVal _ID_Contract As Integer)
        '==================================================================
        'Loads the listview control and calulates and formats totals
        '==================================================================
        Try
            ListView_Contract_Tasks.Clear()
            ListView_Contract_Tasks.Columns.Add("ID", 75, HorizontalAlignment.Left) '0
            ListView_Contract_Tasks.Columns.Add("Date", 75, HorizontalAlignment.Left) '1
            ListView_Contract_Tasks.Columns.Add("Description", 350, HorizontalAlignment.Left) '1
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: LoadListView")
            Exit Sub
        End Try
    End Sub
    Private Sub ListView_Contract_Tasks_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_Contract_Tasks.ItemActivate
        '===============================================================
        'Sets form to hour record selected in listview
        '===============================================================

        Try

            If ListView_Contract_Tasks.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim ID_Tasks As String

            ID_Tasks = ListView_Contract_Tasks.SelectedItems.Item(0).SubItems(0).Text

            TasksBindingSource.DataSource = GetSelectedTasks(ID_Tasks)
            TasksBindingSource.Position = GetCurrentRecordPosition(ID_Tasks) - 1

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: ListView_Contracts_ItemActivate")
            Exit Sub
        End Try
    End Sub
    Private Function GetSelectedTasks(ByVal ID_Task As Integer) As List(Of Contracts.Task)
        '============================================================================================
        'Gets hour records for contract ID
        '============================================================================================
        Try
            Dim Task = From C In context.Tasks
                                Where C.KY_Tasks = ID_Task

            Return Task.ToList

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks:  GetSelectedTasks")
            Return Nothing
            Exit Function
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: Set_Contract_Name_Textbox")
            Exit Sub
        End Try

    End Sub
    Private Sub LinkLabel_Add_Task_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Add_Task.LinkClicked
        '==================
        'Add Record
        '==================

        Try

            Call add_Record()
            Me.TextBox_Name_Contract.Text = ""


            Save_Context_Changes(context)


            TasksBindingSource.DataSource = Get_Max_Tasks_Record()
            Call Set_Contract_Name_Textbox()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks : LinkLabel_Add_Record_LinkClicked")
            Exit Sub
        End Try
    End Sub
    Private Function Get_Max_Tasks_Record() As List(Of Contracts.Task)
        '===========================================================================================================================
        'Returns the max record from the Tasks table
        '===========================================================================================================================

        Try

            Dim MaxRecID = (From r In context.Tasks
                              Select r.KY_Tasks).Max

            Dim MaxRecord As Integer
            MaxRecord = MaxRecID

            Dim GetMaxTaskID = From C In context.Tasks
            Where C.KY_Tasks = MaxRecord
            Select C
            Return GetMaxTaskID.ToList()

        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: Get_Max_Tasks_Record ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overrides Sub add_Record()
        '===========================================================================================================================
        'Adds records to the DB
        '===========================================================================================================================
        Try
            Dim C As New Task
            C.Date_Due_task = Date.Today()
            C.Desc_Tasks = ""
            C.KY_Contracts = Me.ComboBox_Contracts_Select.SelectedValue
            C.KY_Task_Status = 1
            context.AddToTasks(C)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: add_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Save_Task_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Save_Task.LinkClicked
        Try

            Save_Context_Changes(context)

            'Gets the Current ID for the newly added record
            Dim Current_ID As Integer
            Current_ID = CInt(KY_TasksTextBox.Text)

            'Binds the form to all records and sets record position to current ID
            TasksBindingSource.DataSource = GetAllTasksRecords()

            'Sets the position to the record just created using proc in this form
            TasksBindingSource.Position = GetCurrentRecordPosition(Current_ID) - 1

            Call LoadListView(CInt(KY_ContractsTextBox.Text))


            Me.TextBox_Name_Contract.Text = ""
            Call Set_Contract_Name_Textbox()

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Contracts_Tasks: LinkLabel_Save_Contract_LinkClicked")
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

            Dim CurrRecPos = From c In context.Tasks

            'Loops through the IDS and increments the counter. Exits when hits passed  ID
            'Incremented counter = the position of the record
            For Each result In CurrRecPos
                intCurrID = intCurrID + 1
                If result.KY_Tasks = CurrentID Then
                    Return intCurrID
                    Exit Function
                    Return intCurrID
                End If
            Next
            Return CurrentID
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: GetCurrentRecordPosition ")
            Return 0
        End Try

    End Function
    Private Function GetAllTasksRecords() As List(Of Contracts.Task)
        '====================================================================================================================================================
        'Returns the All the Tasks records
        '====================================================================================================================================================

        Try
            Return context.Tasks.OrderBy(Function(a) a.KY_Tasks).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: GetAllTasksRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Private Sub LinkLabel_Delete_Task_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Delete_Task.LinkClicked
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
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: LinkLabel_Delete_Record_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub Delete_Record()
        '===========================================================================================================================
        'Deletes records from the DB
        '===========================================================================================================================
        Try
            Dim d = From C In context.Tasks
                    Where (C.KY_Tasks = CInt(KY_TasksTextBox.Text))
                        Select C
            For Each result As Task In d
                context.Tasks.DeleteObject(result)
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: Delete_Record ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_Create_Contract_Task_Folder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Create_Contract_Task_Folder.LinkClicked
        Try
            If CheckFolders(Me.KY_TasksTextBox.Text, ContractFolder & "\" & GetContractFolder(Me.KY_ContractsTextBox.Text) & "\Tasks") = True Then
                MsgBox("Folder with that ID already exists")
                Exit Sub
            End If

            Dim NewFolder As String = "\" & FormatsID(Me.KY_TasksTextBox.Text) & "_" & Me.Desc_TasksTextBox.Text & "_" & Format(Now, "MM-dd-yyyy")

            CreateFolder(NewFolder, ContractFolder & "\" & GetContractFolder(Me.KY_ContractsTextBox.Text) & "\Tasks")

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks:  LinkLabel_Create_Contract_Task_Folder_LinkClicked ")
            Exit Sub
        End Try
    End Sub
    Private Sub LinkLabel_OpenTasksFolder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenTasksFolder.LinkClicked
        Try


            OpenContractTaskFolder(Me.KY_ContractsTextBox.Text, Me.KY_TasksTextBox.Text)

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Contracts_Tasks: LinkLabel_OpenTasksFolder_LinkClicked")
            Exit Sub
        End Try

    End Sub
   
End Class
