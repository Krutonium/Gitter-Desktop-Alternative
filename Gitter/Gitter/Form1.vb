Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices

Public Class frmGitter
    Dim GitNext As Boolean
    Dim time As DateTime
    Dim ActualClose As Boolean = False
    Private Sub GitterNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitterNextToolStripMenuItem.Click
        WB.Url = (New Uri("javascript:void((function(d){document.cookie='gitter_staging=' + (document.cookie.indexOf('gitter_staging=staged') >= 0 ?  'none' : 'staged') + ';domain=.gitter.im;path=/;expires=' + new Date(Date.now() + 31536000000).toUTCString(); location.reload();})(document));"))
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ActualClose = True
        Close()
    End Sub

    Private Sub frmGitter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ActualClose = False Then
            e.Cancel = True
        End If
        HideMe()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.cat_paw
        GitterV01ToolStripMenuItem.Enabled = False
        Dim DisableQuirks As RegistryKey 'Internet Explorer will default to IE 7 Display Mode unless you tell it not to.
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\", True)
        DisableQuirks.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
        DisableQuirks.SetValue(Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location), 11000, RegistryValueKind.DWord)
        DisableQuirks.SetValue(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), 11000, RegistryValueKind.DWord)
        'QUIRKS DISABLED!... Damnit Microsoft...
        'BTW, the reason I did that twice is because if you are running the client from Visual Studio, both of those calls will register a
        'Different executable. So by having both run, we're guaranteed that it will work.
        'There is a chance the app will need to be run more than once.
        Me.Height = My.Settings.SizeH
        Me.Width = My.Settings.SizeW
        ntfy.BalloonTipTitle = ("UnOfficial Gitter Client")
        ntfy.BalloonTipText = "Started!"
        ntfy.Icon = Me.Icon
        ntfy.ShowBalloonTip(500)
        ntfy.Text = GitterV01ToolStripMenuItem.Text
    End Sub

    Private Sub HideMe()
        ntfy.BalloonTipTitle = ("UnOfficial Gitter Client")
        ntfy.BalloonTipText = ("Click this icon to restore the client.")
        ntfy.ShowBalloonTip(500)
        Me.Hide()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Dim min As Boolean = False

        'if minimized button was pressed
        If Me.WindowState = FormWindowState.Minimized = True Then
            min = True

            'undo minimize
            Me.WindowState = FormWindowState.Normal
        End If

        If min Then
            HideMe()
        End If
    End Sub
    Private Sub frmGitter_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        My.Settings.SizeH = Me.Height
        My.Settings.SizeW = Me.Width
        My.Settings.Save()
    End Sub
    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        My.Settings.Reset()
        Me.Height = My.Settings.SizeH
        Me.Width = My.Settings.SizeW
    End Sub

    Private Sub ntfy_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ntfy.MouseDoubleClick
        Me.Show()
    End Sub
End Class
