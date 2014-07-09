Imports Microsoft.VisualBasic.FileIO
Imports System.Runtime.InteropServices

Public Class Bot
#Region "Using Proxy"
    <Runtime.InteropServices.DllImport("wininet.dll", SetLastError:=True)> _
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    End Function

    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure

    Private Sub UseProxy(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3

        Dim struct_IPI As Struct_INTERNET_PROXY_INFO

        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local")

        Dim intptrStruct As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI))

        Marshal.StructureToPtr(struct_IPI, intptrStruct, True)

        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub
#End Region
    Dim last_tab As System.Windows.Forms.TabPage
    Private Sub Bot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.SelectedTab = Home
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

            TabControl.TabPages.Add(tabpage)
        Next
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
