Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmd As SqlCommand
        Dim con As SqlConnection

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Palace Kino\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")
        con.Open()

        Try
            cmd = New SqlCommand("SELECT Username, Password FROM Staff WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                frmMainPage.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username/Password. Please Try again.")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Connection Error!")
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If (Me.chkShowPassword.Checked = True) Then
            Me.txtPassword.PasswordChar = ""
        Else
            Me.txtPassword.PasswordChar = "*"c
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
    End Sub
End Class