Public Class frm_HoursToday
    Public context As New Contracts.ContractsEntities
    Public Sub New(ByVal _context As Contracts.ContractsEntities, Optional ByVal _ID_Contractor As Integer = 0, Optional ByVal _Bln_Add_From_frm_Contractor As Boolean = False)
        '====================================================================================================================================================
        'Constructor. Sets EF Context to Public Var in form
        '====================================================================================================================================================
        MyBase.New()
        Try
            InitializeComponent()
            context = _context

        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday : Public Sub New")
            Exit Sub
        End Try

    End Sub
    Private Sub frm_HoursToday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Me.Label_WkBeg.Text = "WORK WEEK BEGAN = " & GetStartOfWeek(Today)
            Me.Label_Hrs.Text = "HOURS WORKED TODAY = " & GetHoursToday()
            Me.Label_Week.Text = "HOURS WORKED THIS WEEK = " & GetHoursThisWeek()
            Me.Label_Hours_This_Month.Text = "HOURS WORKED THIS MONTH = " & GetHoursThisMonth()
        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: frm_HoursToday_Load")
            Exit Sub
        End Try

    End Sub
    Private Function GetHoursToday() As Double

        Try
            Dim Balance = (From X In context.Contracts_Hours
                           Where X.Date_Hours_Workd >= Today And X.Date_Hours_Workd <= Today
                         Select X.Contracts_Hours1).Sum
            Return Balance
        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetHoursToday")
            Exit Function
        End Try
    End Function
    Public Function GetStartOfWeek(ByVal xDate As Date) As Date
        Try
            Return xDate.AddDays(-xDate.DayOfWeek)
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetHoursToday")
        End Try
    End Function
    Private Function GetHoursThisWeek() As Double

        Try
            Dim BeginOfWeek As Date = GetStartOfWeek(Today)
            Dim Balance = (From X In context.Contracts_Hours
                           Where X.Date_Hours_Workd >= BeginOfWeek And X.Date_Hours_Workd <= Today
                         Select X.Contracts_Hours1).Sum
            Return Balance
        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetHoursThisWeek")
            Exit Function
        End Try
    End Function
    Public Function GetStartOfMonth() As Date
        Try
            Dim FirstDayOfMonth As Date
            FirstDayOfMonth = DateSerial(Today.Year, Today.Month, 1)
            Return FirstDayOfMonth
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetStartOfMonth")
        End Try
    End Function
    Public Function GetEndOfMonth() As Date
        Try
            Dim EndDayOfMonth As Date
            EndDayOfMonth = DateSerial(Today.Year, Today.Month + 1, 0)
            Return EndDayOfMonth
        Catch
            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetStartOfMonth")
        End Try
    End Function
    Private Function GetHoursThisMonth() As Double

        Try
            Dim BeginOfMonth As Date = GetStartOfMonth()
            Dim EndOfMonth As Date = GetEndOfMonth()
            Dim Balance = (From X In context.Contracts_Hours
                           Where X.Date_Hours_Workd >= BeginOfMonth And X.Date_Hours_Workd <= EndOfMonth
                         Select X.Contracts_Hours1).Sum
            Return Balance
        Catch

            MsgBox(Err.Number & ": " & Err.Description & "frm_HoursToday: GetHoursThisMonth")
            Exit Function
        End Try
    End Function
End Class