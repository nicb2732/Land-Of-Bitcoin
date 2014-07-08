Module Load_Bot
    Public Sub Load_Bot_Sub()
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.account")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            Dim Noconfig As String = Replace(fi.Name, ".account", "")
            Dim URL As String

            Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "/" & Noconfig & ".account")

            URL = reader.ReadLine()

            reader.Close()

            Dim tabpage As New TabPage

            tabpage.Text = Noconfig

            Dim WebBrowser As New WebBrowser

            WebBrowser.Parent = tabpage

            WebBrowser.Navigate(URL)
            WebBrowser.Location = New Point(10, 10)
            WebBrowser.Dock = DockStyle.Fill

            Bot.TabControl.TabPages.Add(tabpage)
        Next
    End Sub
End Module
