﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bot))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Accounts = New System.Windows.Forms.TabPage()
        Me.FileBrowser = New System.Windows.Forms.WebBrowser()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.Change_Folder = New System.Windows.Forms.Button()
        Me.Folder_Label = New System.Windows.Forms.Label()
        Me.Folder = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Proxy_Link_Label = New System.Windows.Forms.Label()
        Me.Link = New System.Windows.Forms.TextBox()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Bot_designed_by_Chaos_Terminal = New System.Windows.Forms.Label()
        Me.Path = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Accounts)
        Me.TabControl.Controls.Add(Me.Home)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(705, 510)
        Me.TabControl.TabIndex = 2
        '
        'Accounts
        '
        Me.Accounts.Controls.Add(Me.Path)
        Me.Accounts.Controls.Add(Me.FileBrowser)
        Me.Accounts.Location = New System.Drawing.Point(4, 27)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(697, 479)
        Me.Accounts.TabIndex = 1
        Me.Accounts.Text = " Accounts "
        Me.Accounts.UseVisualStyleBackColor = True
        '
        'FileBrowser
        '
        Me.FileBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileBrowser.Location = New System.Drawing.Point(0, 0)
        Me.FileBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.FileBrowser.Name = "FileBrowser"
        Me.FileBrowser.Size = New System.Drawing.Size(697, 479)
        Me.FileBrowser.TabIndex = 0
        '
        'Home
        '
        Me.Home.Controls.Add(Me.Change_Folder)
        Me.Home.Controls.Add(Me.Folder_Label)
        Me.Home.Controls.Add(Me.Folder)
        Me.Home.Controls.Add(Me.Add)
        Me.Home.Controls.Add(Me.Proxy_Link_Label)
        Me.Home.Controls.Add(Me.Link)
        Me.Home.Controls.Add(Me.Username_Label)
        Me.Home.Controls.Add(Me.Username)
        Me.Home.Controls.Add(Me.Bot_designed_by_Chaos_Terminal)
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(4, 27)
        Me.Home.Margin = New System.Windows.Forms.Padding(2)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(2)
        Me.Home.Size = New System.Drawing.Size(697, 479)
        Me.Home.TabIndex = 0
        Me.Home.Text = " Home "
        Me.Home.UseVisualStyleBackColor = True
        '
        'Change_Folder
        '
        Me.Change_Folder.Location = New System.Drawing.Point(7, 298)
        Me.Change_Folder.Margin = New System.Windows.Forms.Padding(2)
        Me.Change_Folder.Name = "Change_Folder"
        Me.Change_Folder.Size = New System.Drawing.Size(683, 45)
        Me.Change_Folder.TabIndex = 8
        Me.Change_Folder.Text = "Change Folder"
        Me.Change_Folder.UseVisualStyleBackColor = True
        '
        'Folder_Label
        '
        Me.Folder_Label.AutoSize = True
        Me.Folder_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folder_Label.Location = New System.Drawing.Point(18, 242)
        Me.Folder_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Folder_Label.Name = "Folder_Label"
        Me.Folder_Label.Size = New System.Drawing.Size(149, 24)
        Me.Folder_Label.TabIndex = 7
        Me.Folder_Label.Text = "Accounts Folder"
        '
        'Folder
        '
        Me.Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folder.Location = New System.Drawing.Point(7, 268)
        Me.Folder.Margin = New System.Windows.Forms.Padding(2)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(683, 26)
        Me.Folder.TabIndex = 6
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(7, 195)
        Me.Add.Margin = New System.Windows.Forms.Padding(2)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(683, 45)
        Me.Add.TabIndex = 5
        Me.Add.Text = "Add Account"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Proxy_Link_Label
        '
        Me.Proxy_Link_Label.AutoSize = True
        Me.Proxy_Link_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proxy_Link_Label.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Proxy_Link_Label.Location = New System.Drawing.Point(18, 134)
        Me.Proxy_Link_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Proxy_Link_Label.Name = "Proxy_Link_Label"
        Me.Proxy_Link_Label.Size = New System.Drawing.Size(97, 24)
        Me.Proxy_Link_Label.TabIndex = 4
        Me.Proxy_Link_Label.Text = "Proxy Link"
        '
        'Link
        '
        Me.Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link.Location = New System.Drawing.Point(7, 160)
        Me.Link.Margin = New System.Windows.Forms.Padding(2)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(683, 31)
        Me.Link.TabIndex = 3
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.Location = New System.Drawing.Point(18, 68)
        Me.Username_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(97, 24)
        Me.Username_Label.TabIndex = 2
        Me.Username_Label.Text = "Username"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(7, 94)
        Me.Username.Margin = New System.Windows.Forms.Padding(2)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(683, 31)
        Me.Username.TabIndex = 1
        '
        'Bot_designed_by_Chaos_Terminal
        '
        Me.Bot_designed_by_Chaos_Terminal.AutoSize = True
        Me.Bot_designed_by_Chaos_Terminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_designed_by_Chaos_Terminal.Location = New System.Drawing.Point(15, 14)
        Me.Bot_designed_by_Chaos_Terminal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Bot_designed_by_Chaos_Terminal.Name = "Bot_designed_by_Chaos_Terminal"
        Me.Bot_designed_by_Chaos_Terminal.Size = New System.Drawing.Size(481, 37)
        Me.Bot_designed_by_Chaos_Terminal.TabIndex = 0
        Me.Bot_designed_by_Chaos_Terminal.Text = "Bot designed by Chaos Terminal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Path
        '
        Me.Path.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Path.Dock = System.Windows.Forms.DockStyle.Top
        Me.Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Path.Location = New System.Drawing.Point(0, 0)
        Me.Path.Name = "Path"
        Me.Path.ReadOnly = True
        Me.Path.Size = New System.Drawing.Size(697, 22)
        Me.Path.TabIndex = 1
        '
        'Bot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 510)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Bot"
        Me.ShowIcon = False
        Me.Text = "Land of Bitcoin Faucet Bot"
        Me.TabControl.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.Accounts.PerformLayout()
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Home As System.Windows.Forms.TabPage
    Friend WithEvents Proxy_Link_Label As System.Windows.Forms.Label
    Friend WithEvents Link As System.Windows.Forms.TextBox
    Friend WithEvents Username_Label As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Bot_designed_by_Chaos_Terminal As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Accounts As System.Windows.Forms.TabPage
    Friend WithEvents FileBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Folder As System.Windows.Forms.TextBox
    Friend WithEvents Folder_Label As System.Windows.Forms.Label
    Friend WithEvents Change_Folder As System.Windows.Forms.Button
    Friend WithEvents Path As System.Windows.Forms.TextBox

End Class
