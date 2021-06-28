Imports System.IO
Public Class Form6

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fs As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\reservedata.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim ch As String

        While (sr.Peek > -1)
            ch = sr.ReadLine
            ListBox1.Items.Add(ch)
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
End Class