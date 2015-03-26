Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices

Public Class frmGitter
    Dim GitNext As Boolean
    Dim time As DateTime
    Private Sub GitterNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitterNextToolStripMenuItem.Click
        If GitNext = False Then
            GitNext = True
            My.Settings.GitterNext = True
            Dim cook As New Cookie("gitter_staging=", "staged", "gitter.im", "/")
            InternetSetCookie("https://www.gitter.com", Nothing, cook.ToString() + "; expires = " & time.ToUniversalTime().ToString("ddd, dd-MMM-yyyy HH:mm:ss") & " GMT")
        Else
            GitNext = False
            My.Settings.GitterNext = False
            Dim cook As New Cookie("gitter_staging", "none", "gitter.im", "/")
            InternetSetCookie("https://www.gitter.com", Nothing, cook.ToString() + "; expires = " & time.ToUniversalTime().ToString("ddd, dd-MMM-yyyy HH:mm:ss") & " GMT")
        End If
        My.Settings.Save()
        WB.Url = (New Uri("http://www.gitter.im/"))
        WB.Navigate(WB.Url)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GitterV01ToolStripMenuItem.Enabled = False
        GitterNextToolStripMenuItem.Enabled = False
        NTFYCon.BalloonTipText() = "TEST"
        NTFYCon.BalloonTipIcon = ToolTipIcon.Warning
        NTFYCon.BalloonTipTitle = "TEST TITLE"

        Dim DisableQuirks As RegistryKey
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\", True)
        DisableQuirks.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
        DisableQuirks.SetValue(Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location), 11000, RegistryValueKind.DWord)
        DisableQuirks.SetValue(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), 11000, RegistryValueKind.DWord)
        'QUIRKS DISABLED!
        Me.Height = My.Settings.SizeH
        Me.Width = My.Settings.SizeW
        GitNext = My.Settings.GitterNext
        Me.Show()
        NTFYCon.Visible = True
        NTFYCon.ShowBalloonTip(900)
    End Sub

    Private Sub frmGitter_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        My.Settings.SizeH = Me.Height
        My.Settings.SizeW = Me.Width
        My.Settings.Save()
    End Sub
    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Shared Function InternetSetCookie(lpszUrlName As String, lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function

    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        My.Settings.Reset()
        Me.Height = My.Settings.SizeH
        Me.Width = My.Settings.SizeW
    End Sub
End Class
