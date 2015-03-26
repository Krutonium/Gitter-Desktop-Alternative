Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices

Public Class frmGitter
    Dim GitNext As Boolean
    Dim time As DateTime
    Private Sub GitterNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitterNextToolStripMenuItem.Click
        WB.Url = (New Uri("javascript:void((function(d){document.cookie='gitter_staging=' + (document.cookie.indexOf('gitter_staging=staged') >= 0 ?  'none' : 'staged') + ';domain=.gitter.im;path=/;expires=' + new Date(Date.now() + 31536000000).toUTCString(); location.reload();})(document));"))
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmGitter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private contextMenu1 As System.Windows.Forms.ContextMenu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GitterV01ToolStripMenuItem.Enabled = False
        Dim DisableQuirks As RegistryKey 'Internet Explorer will default to IE 7 Display Mode unless you tell it not to.
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\", True)
        DisableQuirks.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION")
        DisableQuirks = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
        DisableQuirks.SetValue(Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location), 11000, RegistryValueKind.DWord)
        DisableQuirks.SetValue(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), 11000, RegistryValueKind.DWord)
        'QUIRKS DISABLED!
        Me.Height = My.Settings.SizeH
        Me.Width = My.Settings.SizeW
        'ntfy.Icon = Me.Icon

        Me.contextMenu1 = New System.Windows.Forms.ContextMenu
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
End Class
