<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGitter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitterV01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitterNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WB = New System.Windows.Forms.WebBrowser()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NTFYCon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GitterToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GitterToolStripMenuItem
        '
        Me.GitterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GitterV01ToolStripMenuItem, Me.GitterNextToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.GitterToolStripMenuItem.Name = "GitterToolStripMenuItem"
        Me.GitterToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.GitterToolStripMenuItem.Text = "Gitter"
        '
        'GitterV01ToolStripMenuItem
        '
        Me.GitterV01ToolStripMenuItem.Name = "GitterV01ToolStripMenuItem"
        Me.GitterV01ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.GitterV01ToolStripMenuItem.Text = "Gitter v0.1"
        '
        'GitterNextToolStripMenuItem
        '
        Me.GitterNextToolStripMenuItem.Name = "GitterNextToolStripMenuItem"
        Me.GitterNextToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.GitterNextToolStripMenuItem.Text = "Gitter Next"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'WB
        '
        Me.WB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WB.Location = New System.Drawing.Point(0, 24)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.Size = New System.Drawing.Size(784, 537)
        Me.WB.TabIndex = 1
        Me.WB.Url = New System.Uri("http://www.gitter.im/", System.UriKind.Absolute)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetSettingsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ResetSettingsToolStripMenuItem
        '
        Me.ResetSettingsToolStripMenuItem.Name = "ResetSettingsToolStripMenuItem"
        Me.ResetSettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetSettingsToolStripMenuItem.Text = "Reset Settings"
        '
        'NTFYCon
        '
        Me.NTFYCon.Text = "Test"
        Me.NTFYCon.Visible = True
        '
        'frmGitter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGitter"
        Me.Text = "Gitter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GitterV01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GitterNextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WB As System.Windows.Forms.WebBrowser
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NTFYCon As System.Windows.Forms.NotifyIcon

End Class
