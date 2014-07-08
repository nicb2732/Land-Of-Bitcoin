Imports Microsoft.VisualBasic.FileIO

Public Class Bot
    Dim last_tab As System.Windows.Forms.TabPage
    Private Sub Bot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.SelectedTab = Home
        Call Load_Bot_Sub()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/" & Username.Text & ".account", Link.Text, True)
        Dim Restart As Integer = MessageBox.Show("Bot Must Reload", "Refresh", MessageBoxButtons.OKCancel)
        If Restart = DialogResult.OK Then
            Application.Restart()
        End If
    End Sub


    Private Sub Bot_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Username.Width = TabControl.Width - 60
        Link.Width = TabControl.Width - 60
        Add.Width = TabControl.Width - 60
    End Sub
End Class
