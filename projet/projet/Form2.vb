Imports System.IO
Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        Form1.t1.Clear()
        Form1.t2.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As Boolean = True
        If (t1.Text = "") Then
            MessageBox.Show("donner votre prenom")
            r = False
        elseIf(t2.Text = "") Then
                MessageBox.Show("donner votre nom")
                r = False
            elseIf(t3.Text = "") Then
                MessageBox.Show("donner votre email")
                r = False
            elseIf(t4.Text = "") Then
                MessageBox.Show("donner votre mot de passe")
                r = False
            elseIf(t5.Text <> t4.Text) Then
                MessageBox.Show("verifier votre mot de passe !!")
                r = False
            elseIf(t6.Text = "") Then
                MessageBox.Show("donner votre numero")
                r = False
            End If

            If (r = True) Then
                Dim fs As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\clientdata.txt", FileMode.Open, FileAccess.Read)
                Dim sr As New StreamReader(fs)
                Dim c As String
                Dim email As String
                Dim mdp As String
                Dim p As Boolean = True



                While (sr.Peek() > -1)

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




                        If ((t3.Text.CompareTo(email) = 0) And (t4.Text.CompareTo(mdp) <> 0)) Then
                            p = False
                            MessageBox.Show("email existe !!!")
                        End If

                        If ((t3.Text.CompareTo(email) = 0) And (t4.Text.CompareTo(mdp)) = 0) Then
                            p = False
                            MessageBox.Show("client existe !!!")
                        End If

                    End If

                End While

                sr.Close()
                fs.Close()

                If (p = True) Then

                    Dim fsw As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\clientdata.txt", FileMode.Append, FileAccess.Write)
                    Dim sw As New StreamWriter(fsw)
                    sw.WriteLine(t3.Text & ";" & t4.Text & ";" & t6.Text & ";" & t1.Text & ";" & t2.Text)
                    sw.Close()
                    fsw.Close()

                    t1.Clear()
                    t2.Clear()
                    t3.Clear()
                    t4.Clear()
                    t5.Clear()
                    t6.Clear()


                    Me.Hide()
                    Form1.Show()



                End If
            End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fs1 As New FileStream("C:\Users\asus\OneDrive\Documents\Visual Studio 2010\Projects\projet\clientdata.txt", FileMode.Append, FileAccess.Write)
        Dim sw1 As New StreamWriter(fs1)
        sw1.Close()
        fs1.Close()
    End Sub
End Class