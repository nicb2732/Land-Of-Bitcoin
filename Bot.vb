Imports Microsoft.VisualBasic.FileIO

Public Class Bot
    Dim last_tab As System.Windows.Forms.TabPage
    Private Sub Bot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.SelectedTab = Home
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "/accounts") Then
        Else
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/accounts")
        End If
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "/accounts")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.account")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            Dim Noconfig As String = Replace(fi.Name, ".account", "")
            Dim URL As String

            Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "/accounts/" & Noconfig & ".account")

            URL = reader.ReadLine()

            reader.Close()

            Dim tabpage As New TabPage

            tabpage.Text = Noconfig

            Dim WebBrowser As New WebBrowser

            WebBrowser.Parent = tabpage

            WebBrowser.Navigate(URL)
            WebBrowser.Location = New Point(10, 10)
            WebBrowser.Dock = DockStyle.Fill

            TabControl.TabPages.Add(tabpage)
        Next
        FileBrowser.Navigate("file:///" & My.Application.Info.DirectoryPath & "/accounts")
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/accounts/" & Username.Text & ".account", Link.Text, True)
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

    Private Sub Proxy_Link_Label_Click(sender As Object, e As EventArgs) Handles Proxy_Link_Label.Click
        Process.Start("https://www.zend2.com/")
    End Sub
End Class
