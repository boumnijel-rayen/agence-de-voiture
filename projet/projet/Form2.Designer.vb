<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(526, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "insecription d'un client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(459, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prenom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(459, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(459, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "mot de passe  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(459, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "verifier le mot de passe :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(459, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "numéro de téléphone :"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(661, 127)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(114, 20)
        Me.t1.TabIndex = 7
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(661, 153)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(114, 20)
        Me.t2.TabIndex = 8
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(661, 179)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(114, 20)
        Me.t3.TabIndex = 9
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(661, 205)
        Me.t4.Name = "t4"
        Me.t4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t4.Size = New System.Drawing.Size(114, 20)
        Me.t4.TabIndex = 10
        '
        't5
        '
        Me.t5.Location = New System.Drawing.Point(661, 236)
        Me.t5.Name = "t5"
        Me.t5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t5.Size = New System.Drawing.Size(114, 20)
        Me.t5.TabIndex = 11
        '
        't6
        '
        Me.t6.Location = New System.Drawing.Point(661, 267)
        Me.t6.Name = "t6"
        Me.t6.Size = New System.Drawing.Size(114, 20)
        Me.t6.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(645, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "inscrire"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(539, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._131479804_2065403586929635_7241927560938887050_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 405)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t6)
        Me.Controls.Add(Me.t5)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "insecription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents t5 As System.Windows.Forms.TextBox
    Friend WithEvents t6 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
