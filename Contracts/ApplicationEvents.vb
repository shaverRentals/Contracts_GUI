Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            ' ----- Display the splash form for at least 3 seconds.
            My.Application.MinimumSplashScreenDisplayTime = 2000
            Dim obj As New cls_Stored_Procedures
            obj = New cls_Stored_Procedures
            obj.RunStoredProcedure_NonQuery(SP_Update_Month_Cats)
            obj.RunStoredProcedure_NonQuery(SP_Update_Tax_Year)
            obj.RunStoredProcedure_NonQuery(SP_Update_Months_Cats_Income)
            obj = Nothing
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
    End Class


End Namespace

