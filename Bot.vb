Public Class Bot
    Dim last_tab As System.Windows.Forms.TabPage
    Private Sub Bot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.SelectedTab = Home
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.Account")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            Dim Noconfig As String = Replace(fi.Name, ".Account", "")
            Dim URL As String

            Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "/" & Noconfig & ".Account")

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
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "/" & Username.Text & ".Account", Link.Text, True)
        MsgBox("Restart Required")
    End Sub


End Class
