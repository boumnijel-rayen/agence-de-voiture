Imports System.IO
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim r As Boolean = True

        If (t1.Text = "") Then
            MessageBox.Show("donner votre email")
            r = False
        ElseIf (t2.Text = "") Then
            MessageBox.Show("donner votre mot de passe")
            r = False
        End If

        If (r = True) Then
            Dim fs As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\clientdata.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs)
            Dim c As String
            Dim email As String
            Dim mdp As String
            Dim p As Boolean = True


            While ((sr.Peek > -1) And (p = True))
                Dim i As Integer = 0

                c = sr.ReadLine
                If (c.CompareTo("") <> 0) Then
                    Do Until (c.Chars(i) = ";")
                        i = i + 1
                    Loop
                    email = c.Substring(0, i)



                    Dim j As Integer = i + 1

                    Do Until (c.Chars(j) = ";")
                        j = j + 1
                    Loop
                    mdp = c.Substring(i + 1, j - i - 1)

                    If ((t1.Text = email) And (t2.Text = mdp)) Then
                        p = False
                    End If

                End If
            End While

            If (p = True) Then
                MessageBox.Show("mot de passe incorrecte !!")
            Else
                Me.Hide()
                Form3.Show()
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form7.Show()
    End Sub
End Class
