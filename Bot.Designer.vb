<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.Add = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Link = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Home)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(705, 387)
        Me.TabControl.TabIndex = 2
        '
        'Home
        '
        Me.Home.Controls.Add(Me.Add)
        Me.Home.Controls.Add(Me.Label3)
        Me.Home.Controls.Add(Me.Link)
        Me.Home.Controls.Add(Me.Label2)
        Me.Home.Controls.Add(Me.Username)
        Me.Home.Controls.Add(Me.Label1)
        Me.Home.Location = New System.Drawing.Point(4, 34)
        Me.Home.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Home.Size = New System.Drawing.Size(697, 349)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(20, 139)
        Me.Add.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(356, 39)
        Me.Add.TabIndex = 5
        Me.Add.Text = "Add Account"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Link"
        '
        'Link
        '
        Me.Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link.Location = New System.Drawing.Point(203, 94)
        Me.Link.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(174, 38)
        Me.Link.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(20, 94)
        Me.Username.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(174, 38)
        Me.Username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bot By Chaos Terminal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Bot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 387)
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Bot"
        Me.ShowIcon = False
        Me.Text = "Land of Bitcoin Faucet Bot"
        Me.TabControl.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Home As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Link As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button

End Class
