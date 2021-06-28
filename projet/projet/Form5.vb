Imports System.IO
Public Class Form5

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Dim tot As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ch As String
        Dim p As Integer

        If (ListBox1.SelectedItem.ToString() = "marcedes") Then
            p = 14 * CInt(t1.Text)
        ElseIf (ListBox1.SelectedItem.ToString() = "bmw") Then
            p = 13 * CInt(t1.Text)
        ElseIf (ListBox1.SelectedItem.ToString() = "clio") Then
            p = 8 * CInt(t1.Text)
        ElseIf (ListBox1.SelectedItem.ToString() = "citroen") Then
            p = 9 * CInt(t1.Text)
        End If
        tot = tot + p


        ch = ListBox1.SelectedItem.ToString() & " " & ListBox2.SelectedItem.ToString() & " " & ListBox3.SelectedItem.ToString() & " " & t1.Text & " jours" & " va prendre la voiture apres " & t2.Text & " jours"
        ListBox4.Items.Add(ch)
        ListBox5.Items.Add(p & " €")
        totale.Text = tot
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
        ListBox3.SelectedIndex = -1
        t1.Clear()
        t2.Clear()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        totale.Text = "0"
        tot = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fs As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\reservedata.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        Dim ch As String

        ch = "le client " & Form1.t1.Text & " a fait une réservation et payer " & totale.Text & "€"
        sw.WriteLine(ch)
        sw.Close()
        fs.Close()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        totale.Text = "0"

    End Sub
End Class