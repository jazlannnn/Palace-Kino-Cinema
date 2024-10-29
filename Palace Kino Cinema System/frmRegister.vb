Imports System.Data.SqlClient
Public Class frmRegister
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cmd As SqlCommand = Nothing

        Dim objcon As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Palace Kino Cinema System\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")
        objcon.Open()

        Dim stmt As String = "SELECT StaffName, staffID, PhoneNumber, Username, Password FROM Staff WHERE staffID = '" & txtStaffId.Text & "' OR Username = '" & txtUsername.Text & "' OR Password = '" & txtPassword.Text & "'"
        cmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If reader.Read Then
            MsgBox("Existing unique data (Staff ID/Username)")
        Else
            stmt = "INSERT INTO Staff VALUES ('" & txtStaffId.Text & "' , '" & txtStaffName.Text & "' , '" & txtPhoneNum.Text & "' , '" & txtUsername.Text & "' , '" & txtPassword.Text & "');"
            cmd = New SqlCommand(stmt, objcon)
            reader.Close()
            If cmd.ExecuteNonQuery() Then
                MsgBox("Registered successfully!")
                Me.Close()
            End If
        End If
        objcon.Close()
    End Sub
End Class