Imports System.Math
Imports System.IO
Public Class frm_Base_Code
    '=====================================================================================================
    'Base code for methods for all data entry forms
    '=====================================================================================================
    Public Overridable Sub LoadComboBoxes()
        '--------------------------Generic sub for loading combobox controls
    End Sub
    Public Sub LoadQuickHelpForm(ByVal QuickHelp_Description As String)
        '================================================================================================================
        'Loads the generic quick help form with string from call proc
        '================================================================================================================
        Try
            Dim F As frm_QuickHelp
            F = New frm_QuickHelp(QuickHelp_Description)
            F.Show()
            F = Nothing

        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Base_Code : LoadQuickHelpForm  ")
            Exit Sub
        End Try

    End Sub
    Public Sub Save_Context_Changes(ByVal context As Contracts.ContractsEntities)
        '========================================================================================
        'Saves EF Context changes back to the DB
        '========================================================================================
        Try
            context.SaveChanges()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Base_Code :  Save_Context_Changes ")
            Exit Sub
        End Try

    End Sub
    Public Overridable Function GetCurrentRecordPosition(ByVal CurrentID As Integer) As Integer
        '------------------------------------------OVerridable for getting the current record position 
        Return Nothing
    End Function
    Public Overridable Sub Add_Record()
        '-------------------------------------------Overridable sub for adding records 
    End Sub
    Public Overridable Sub Delete_Record()
        '-------------------------------------------Overridable sub for deleting  records 
    End Sub
    Public Sub Hide_swithboard_Form()
        '=====================================================
        'Hides the Swithboard form
        '=====================================================
        Try
            frm_SwitchBoard.Hide()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Base_Code :  Hide_swithboard_Form ")
            Exit Sub
        End Try
    End Sub
    Public Sub Show_swithcboard_form()
        '=====================================================
        'Shows Switchboard Form
        '=====================================================
        Try
            frm_SwitchBoard.Show()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Base_Code :  Show_swithboard_Form ")
            Exit Sub
        End Try
    End Sub
    Public Function CheckInList(ByVal TextEntered As String, ByVal CboList As Array, ByVal flListType As String) As Boolean
        '====================================================================================================================================================
        'Checks to see if the value entered in a combobox is already a value in the table by comparing the count of the number of records in the 
        'list with the sum of the absolute values returned by function StrComp. StrComp returns absolute value of 1 if the value being passed in is not the same
        'as a record in the list. If the sum of the values for strComp for all the items in the list compared to the passed value is the same as the number
        'of records in the list that means that the passed value is not the same as any record in the list and the function  returns TRUE.
        '====================================================================================================================================================
        Try

            If TextEntered <> "" Then

                Dim arrCount As Integer
                arrCount = CboList.Length
                Dim result As Integer
                Dim counter = 0
                result = 0

                If flListType = "Contract_Rate" Then

                    For Each F In CboList
                        result = StrComp(TextEntered, F.Amount_rate)
                        result = Abs(result)

                        If result = 1 Then
                            counter = counter + 1
                        End If
                    Next

                    If counter = arrCount Then
                        Return True
                    End If

                End If
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & " frm_Base_Code : CheckInList")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Public Enum FilterType As Integer
        '====================================================================================================================================================
        'PURPOSE: Defines Combobox and filter values
        '====================================================================================================================================================
        Open = 1
        Completed = 2
        Terminated = 3
        All = 4
    End Enum
    Public Function GetContractsForContractsComboBox(ByVal filter As Integer, ByVal context As Contracts.ContractsEntities) As List(Of Contracts.Contract)
        '====================================================================================================================================================
        'Returns the contract record based on the value selected in the combobox
        '====================================================================================================================================================
        Try
            If filter = 1 Then
                Dim OpenContracts1 = From P In context.Contracts
                             Where P.Contract_Status_LU.Desc_Contract_Status = "Open"
                              Order By P.Name_Contract
                Return OpenContracts1.ToList

            End If

            If filter = 2 Then
                Dim CompletedContracts2 = From P In context.Contracts
                             Where P.Contract_Status_LU.Desc_Contract_Status = "Completed"
                              Order By P.Name_Contract
                Return CompletedContracts2.ToList
            End If

            If filter = 3 Then
                Dim TerminatedContracts3 = From P In context.Contracts
                             Where P.Contract_Status_LU.Desc_Contract_Status = "Terminated"
                              Order By P.Name_Contract
                Return TerminatedContracts3.ToList
            End If

            If filter = 4 Then
                Dim AllContracts4 = From P In context.Contracts
                              Order By P.Name_Contract
                Return AllContracts4.ToList
            End If

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: GetContractsForContractsComboBox ")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
    Public Sub LoadFilterCombo(ByVal cbox As ComboBox)
        '====================================================================================================================================================
        'PURPOSE: Loads the Filter Combobox with values from the filter enumeration
        '====================================================================================================================================================
        Try
            Dim enumType As Type = GetType(FilterType)
            Dim names() As String = [Enum].GetNames(enumType)

            Dim i As Integer
            For i = 0 To names.Length - 1
                cbox.Items.Add(names(i))
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:LoadFilterCombo")
            Exit Sub
        End Try
    End Sub
    Public Function SetComtractFiterValue(ByVal FilterValue As String) As Integer
        '=================================================
        'Gets the enum value from the combobox
        '=================================================

        Try
            Dim enumType As Type = GetType(FilterType)
            Dim selection As String = DirectCast(FilterValue, String)
            Dim value As FilterType = DirectCast([Enum].Parse(enumType, selection), FilterType)

            Return value

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: SetComtractFiterValue")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Public Function GetContractName(ByVal context As Contracts.ContractsEntities, ByVal ID_Contract As String) As String
        '====================================================================================================================================================
        'Reuturs the name of the contract for current contract FK
        '====================================================================================================================================================
        Try
            If ID_Contract = "" Then
                Return Nothing
                Exit Function
            End If

            Dim ContractName = From C In context.Contracts
                                 Where C.KY_Contracts = CInt(ID_Contract)
            For Each N In ContractName
                Return N.Name_Contract.ToString
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:GetContractName")
            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Public Sub CreateFolder(ByVal New_Folder As String, ByVal FolderType As String)
        Try
            Dim NewFolder = FolderType & New_Folder

            If (Not System.IO.Directory.Exists(NewFolder)) Then
                System.IO.Directory.CreateDirectory(NewFolder)
                MsgBox("Folder: " & NewFolder & " Created")
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:CreateFolder")
        End Try
    End Sub
    Public Function FormatsID(ByVal ID As String) As String
        Try
            If Len(ID) = 1 Then
                Return "00" & ID
            Else
                Return ID
            End If
        Catch
            Return Nothing
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: FormatsID ")
            Exit Function
        End Try

    End Function
    Public Function CheckFolders(ByVal ID_folder As String, ByVal Base_Folder As String) As Boolean
        '====================================================================================================================================================
        'PURPOSE: Checks if there is a folder with the current ID
        '//If folder with a current ID Returns TRUE

        'CREATED:CSHAVE: 10.17.2012

        'MODIFIED:
        '12.7.2012: Added variable to hold folder based on whether it is a WYCAPS project or a regular project
        '====================================================================================================================================================

        Try

            Dim BaseFolder As New IO.DirectoryInfo(Base_Folder)

            For Each f As IO.DirectoryInfo In BaseFolder.GetDirectories()

                Dim strFolder As String = f.ToString
                Dim StrID As String
                Dim strCurrentID As String = FormatsID(ID_folder)

                StrID = strFolder.Split("_"c)(0)


                If StrID = strCurrentID Then
                    Return True
                    Exit Function
                End If
            Next

            Return False
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: CheckFolders ")
            Return Nothing
            Exit Function
        End Try
    End Function
    Public Overridable Function GetContractFolder(ByVal ID_Contract As String) As String
        '====================================================================================================================================================
        'PURPOSE: Returns the Folder Path for the ID passed from the folder

        'CREATED:CSHAVE: 10.18.2012

        'MODIFIED:
        '====================================================================================================================================================

        Try

            Dim BaseFolder As New IO.DirectoryInfo(ContractFolder)

            For Each f As IO.DirectoryInfo In BaseFolder.GetDirectories()

                Dim strFolder As String = f.ToString
                Dim StrID As String
                Dim strCurrentID As String = FormatsID(ID_Contract)

                StrID = strFolder.Split("_"c)(0)

                If StrID = strCurrentID Then

                    Return strFolder
                    Exit Function

                End If
            Next

        Catch

            Return Nothing
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:  GetContractFolder ")
            Exit Function
        End Try
        Return Nothing
    End Function
    Public Sub OpenContractFolder(ByVal Folder As String, ByVal ID As String)
        Try
            Process.Start("explorer.exe", Folder & GetContractFolder(ID))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:  OpenContractFolder ")
            Exit Sub
        End Try
    End Sub
    Public Function GetContractTaskFolder(ByVal ID_Contract As String, ByVal ID_Task As String) As String
        '====================================================================================================================================================
        'PURPOSE: Returns the Folder Path for the ID passed from the folder

        'CREATED:CSHAVE: 10.18.2012

        'MODIFIED:
        '====================================================================================================================================================

        Try

            Dim BaseFolder As New IO.DirectoryInfo(ContractFolder & "\" & GetContractFolder(ID_Contract) & "\Tasks")

            For Each f As IO.DirectoryInfo In BaseFolder.GetDirectories()

                Dim strFolder As String = f.ToString
                Dim StrID As String
                Dim strCurrentID As String = FormatsID(ID_Task)

                StrID = strFolder.Split("_"c)(0)

                If StrID = strCurrentID Then

                    Return ContractFolder & "\" & GetContractFolder(ID_Contract) & "\Tasks\" & strFolder
                    Exit Function

                End If
            Next

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: GetContractTaskFolder  ")

            Return Nothing
            Exit Function
        End Try
        Return Nothing
    End Function
    Public Sub OpenContractTaskFolder(ByVal ID_Contract As String, ByVal ID_Task As String)
        Try
            Process.Start("explorer.exe", GetContractTaskFolder(ID_Contract, ID_Task))
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: OpenContractTaskFolder  ")
        End Try
    End Sub
    Public Function OpenDialog_Base() As String

        Try
            If (OpenFileDialog_Base.ShowDialog() = DialogResult.OK) Then
                Return OpenFileDialog_Base.FileName
            Else
                MsgBox("No File Selected")
                Return Nothing
                Exit Function
            End If
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: OpenDialog_Base  ")
        End Try
        Return Nothing
    End Function
    Public Sub OpenFile_Base(ByVal File_Path As String)
        Try
            Process.Start(File_Path)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code:  OpenFile_Base")
        End Try
    End Sub
    Public Function GetAllInvoiceRecords(ByVal context As Contracts.ContractsEntities) As List(Of Contracts.Invoice_Header)
        '====================================================================================================================================================
        'Returns the All the Invoice records
        '====================================================================================================================================================

        Try
            Return context.Invoice_Header.OrderBy(Function(a) a.KY_Invoice_Header).ToList()
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_Base_Code: GetAllInvoiceRecords")
            Return Nothing
            Exit Function
        End Try
        Return Nothing

    End Function
End Class
