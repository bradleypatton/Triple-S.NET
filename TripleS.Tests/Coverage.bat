REM Create a 'GeneratedReports' folder if it does not exist-
if not exist "%~dp0GeneratedReports" mkdir "%~dp0GeneratedReports"
 
REM Remove any previous test execution files to prevent issues overwriting
IF EXIST "%~dp0Neptune.UnitTests.trx" del "%~dp0Neptune.UnitTests.trx%"
 
REM Remove any previously created test output directories
CD %~dp0
FOR /D /R %%X IN (%USERNAME%*) DO RD /S /Q "%%X"
 
REM Run the tests against the targeted output
call :RunOpenCoverUnitTestMetrics
 
REM Generate the report output based on the test results
if %errorlevel% equ 0 (
 call :RunReportGeneratorOutput
)
 
REM Launch the report
if %errorlevel% equ 0 (
 call :RunLaunchReport
)
exit /b %errorlevel%
 
:RunOpenCoverUnitTestMetrics
REM https://github.com/opencover/opencover/wiki/Usage for details
"C:\Users\bradp\.nuget\packages\opencover\4.6.519\tools\OpenCover.Console.exe" -oldStyle ^
-register:user ^
-target:"C:\Program Files\dotnet\dotnet.exe" ^
-targetargs:"test /p:DebugType=full " ^
-mergebyhash ^
-excludebyattribute:"System.Diagnostics.DebuggerStepThroughAttribute" ^
-output:"%~dp0GeneratedReports\TripleS.UnitTests.xml"
exit /b %errorlevel%
 
:RunReportGeneratorOutput
"C:\Users\bradp\.nuget\packages\reportgenerator\3.1.2\tools\ReportGenerator.exe" ^
-reports:"%~dp0GeneratedReports\TripleS.UnitTests.xml" ^
-targetdir:"%~dp0GeneratedReports\ReportGenerator Output"
exit /b %errorlevel%
 
:RunLaunchReport
start "report" "%~dp0GeneratedReports\ReportGenerator Output\index.htm"
exit /b %errorlevel%