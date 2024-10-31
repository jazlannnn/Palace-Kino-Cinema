Imports System.Data.SqlClient
Public Class frmSelectionSeat
    Private Sub frmSelectionPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCon As SqlConnection = Nothing
        objCon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Palace-Kino-Cinema-System\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")
        objCon.Open()

        MsgBox(frmBookingPage.lst1.SelectedItem + " " + frmMainPage.lstMovie.SelectedItem)
        Dim stmt As String = "SELECT * FROM Booking WHERE MovieDateTime = '" + frmBookingPage.lst1.SelectedItem + "' AND Title = '" + frmMainPage.lstMovie.SelectedItem + "'"
        Dim objcmd As New SqlCommand(stmt, objCon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader

        Dim seatBooked As String
        While reader.Read
            seatBooked += reader("Seats")
        End While

        MsgBox(seatBooked)
        Dim booked() As String = seatBooked.Split(" ")

        If seatBooked IsNot Nothing Then
            For x = 0 To booked.Length - 2
                seatBook(booked(x))
            Next
        End If
        objCon.close()
    End Sub

    Dim totalSeatAmount As Integer = CInt(frmBookingPage.txtBoxChildren.Text) + CInt(frmBookingPage.txtBoxAdult.Text) + CInt(frmBookingPage.txtBoxSenior.Text) + CInt(frmBookingPage.txtBoxDisable.Text)
    Dim quantityOfSeat As Integer = 0
    Dim seatString As String = ""

    Private Sub picBoxSeatA1_Click(sender As Object, e As EventArgs) Handles picBoxSeatA1.Click
        Click(picBoxSeatA1)
    End Sub

    Private Sub picBoxSeatA2_Click(sender As Object, e As EventArgs) Handles picBoxSeatA2.Click
        Click(picBoxSeatA2)
    End Sub

    Private Sub picBoxSeatA3_Click(sender As Object, e As EventArgs) Handles picBoxSeatA3.Click
        Click(picBoxSeatA3)
    End Sub

    Private Sub picBoxSeatA4_Click(sender As Object, e As EventArgs) Handles picBoxSeatA4.Click
        Click(picBoxSeatA4)
    End Sub

    Private Sub picBoxSeatA5_Click(sender As Object, e As EventArgs) Handles picBoxSeatA5.Click
        Click(picBoxSeatA5)
    End Sub

    Private Sub picBoxSeatA6_Click(sender As Object, e As EventArgs) Handles picBoxSeatA6.Click
        Click(picBoxSeatA6)
    End Sub

    Private Sub picBoxSeatA7_Click(sender As Object, e As EventArgs) Handles picBoxSeatA7.Click
        Click(picBoxSeatA7)
    End Sub

    Private Sub picBoxSeatA8_Click(sender As Object, e As EventArgs) Handles picBoxSeatA8.Click
        Click(picBoxSeatA8)
    End Sub

    Private Sub picBoxSeatB1_Click(sender As Object, e As EventArgs) Handles picBoxSeatB1.Click
        Click(picBoxSeatB1)
    End Sub

    Private Sub picBoxSeatB2_Click(sender As Object, e As EventArgs) Handles picBoxSeatB2.Click
        Click(picBoxSeatB2)
    End Sub

    Private Sub picBoxSeatB3_Click(sender As Object, e As EventArgs) Handles picBoxSeatB3.Click
        Click(picBoxSeatB3)
    End Sub

    Private Sub picBoxSeatB4_Click(sender As Object, e As EventArgs) Handles picBoxSeatB4.Click
        Click(picBoxSeatB4)
    End Sub

    Private Sub picBoxSeatB5_Click(sender As Object, e As EventArgs) Handles picBoxSeatB5.Click
        Click(picBoxSeatB5)
    End Sub

    Private Sub picBoxSeatB6_Click(sender As Object, e As EventArgs) Handles picBoxSeatB6.Click
        Click(picBoxSeatB6)
    End Sub

    Private Sub picBoxSeatB7_Click(sender As Object, e As EventArgs) Handles picBoxSeatB7.Click
        Click(picBoxSeatB7)
    End Sub

    Private Sub picBoxSeatB8_Click(sender As Object, e As EventArgs) Handles picBoxSeatB8.Click
        Click(picBoxSeatB8)
    End Sub

    Private Sub picBoxSeatC1_Click(sender As Object, e As EventArgs) Handles picBoxSeatC1.Click
        Click(picBoxSeatC1)
    End Sub

    Private Sub picBoxSeatC2_Click(sender As Object, e As EventArgs) Handles picBoxSeatC2.Click
        Click(picBoxSeatC2)
    End Sub

    Private Sub picBoxSeatC3_Click(sender As Object, e As EventArgs) Handles picBoxSeatC3.Click
        Click(picBoxSeatC3)
    End Sub

    Private Sub picBoxSeatC4_Click(sender As Object, e As EventArgs) Handles picBoxSeatC4.Click
        Click(picBoxSeatC4)
    End Sub

    Private Sub picBoxSeatC5_Click(sender As Object, e As EventArgs) Handles picBoxSeatC5.Click
        Click(picBoxSeatC5)
    End Sub

    Private Sub picBoxSeatC6_Click(sender As Object, e As EventArgs) Handles picBoxSeatC6.Click
        Click(picBoxSeatC6)
    End Sub

    Private Sub picBoxSeatC7_Click(sender As Object, e As EventArgs) Handles picBoxSeatC7.Click
        Click(picBoxSeatC7)
    End Sub

    Private Sub picBoxSeatC8_Click(sender As Object, e As EventArgs) Handles picBoxSeatC8.Click
        Click(picBoxSeatC8)
    End Sub

    Private Sub picBoxSeatD1_Click(sender As Object, e As EventArgs) Handles picBoxSeatD1.Click
        Click(picBoxSeatD1)
    End Sub

    Private Sub picBoxSeatD2_Click(sender As Object, e As EventArgs) Handles picBoxSeatD2.Click
        Click(picBoxSeatD2)
    End Sub

    Private Sub picBoxSeatD3_Click(sender As Object, e As EventArgs) Handles picBoxSeatD3.Click
        Click(picBoxSeatD3)
    End Sub

    Private Sub picBoxSeatD4_Click(sender As Object, e As EventArgs) Handles picBoxSeatD4.Click
        Click(picBoxSeatD4)
    End Sub

    Private Sub picBoxSeatD5_Click(sender As Object, e As EventArgs) Handles picBoxSeatD5.Click
        Click(picBoxSeatD5)
    End Sub

    Private Sub picBoxSeatD6_Click(sender As Object, e As EventArgs) Handles picBoxSeatD6.Click
        Click(picBoxSeatD6)
    End Sub

    Private Sub picBoxSeatD7_Click(sender As Object, e As EventArgs) Handles picBoxSeatD7.Click
        Click(picBoxSeatD7)
    End Sub

    Private Sub picBoxSeatD8_Click(sender As Object, e As EventArgs) Handles picBoxSeatD8.Click
        Click(picBoxSeatD8)
    End Sub

    Private Sub picBoxSeatE1_Click(sender As Object, e As EventArgs) Handles picBoxSeatE1.Click
        Click(picBoxSeatE1)
    End Sub

    Private Sub picBoxSeatE2_Click(sender As Object, e As EventArgs) Handles picBoxSeatE2.Click
        Click(picBoxSeatE2)
    End Sub

    Private Sub picBoxSeatE3_Click(sender As Object, e As EventArgs) Handles picBoxSeatE3.Click
        Click(picBoxSeatE3)
    End Sub

    Private Sub picBoxSeatE4_Click(sender As Object, e As EventArgs) Handles picBoxSeatE4.Click
        Click(picBoxSeatE4)
    End Sub

    Private Sub picBoxSeatE5_Click(sender As Object, e As EventArgs) Handles picBoxSeatE5.Click
        Click(picBoxSeatE5)
    End Sub

    Private Sub picBoxSeatE6_Click(sender As Object, e As EventArgs) Handles picBoxSeatE6.Click
        Click(picBoxSeatE6)
    End Sub

    Private Sub picBoxSeatE7_Click(sender As Object, e As EventArgs) Handles picBoxSeatE7.Click
        Click(picBoxSeatE7)
    End Sub

    Private Sub picBoxSeatE8_Click(sender As Object, e As EventArgs) Handles picBoxSeatE8.Click
        Click(picBoxSeatE8)
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMainPage.Show()
        Me.Close()
    End Sub
    Sub Click(ByVal pic As PictureBox)
        If quantityOfSeat < totalSeatAmount Then
            If pic.Tag = 0 Then
                pic.Image = My.Resources.user_yellow
                pic.Tag = 1
                quantityOfSeat += 1
                seatString += pic.Name.Substring(10) + " "
            Else
                pic.Image = My.Resources.user_green
                pic.Tag = 0
                quantityOfSeat -= 1
                seatString = seatString.Replace(pic.Name.Substring(10) + " ", "")
            End If
        Else
            If pic.Tag = 1 Then
                pic.Image = My.Resources.user_green
                pic.Tag = 0
                quantityOfSeat -= 1
                seatString = seatString.Replace(pic.Name.Substring(10) + " ", "")
                Return
            End If
            MsgBox("You've reached your seat limit!")
        End If
    End Sub
    Private Sub btnConfirmSeat_Click(sender As Object, e As EventArgs) Handles btnConfirmSeat.Click
        If Not totalSeatAmount = quantityOfSeat Then
            MsgBox("You still have " + (totalSeatAmount - quantityOfSeat).ToString + " seat(s) to book!", vbExclamation, "Not enough seat!")
            Exit Sub
        End If

        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Palace-Kino-Cinema-System\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")
        objcon.Open()
        MsgBox(seatString)
        Dim stmt As String = "UPDATE Booking SET Seats = '" + seatString + "' WHERE CustomerIC = '" +
                                  frmBookingPage.txtIC.Text + "';"

        objcmd = New SqlCommand(stmt, objcon)

        If objcmd.ExecuteNonQuery Then
            frmPaymentPage.Show()
            Me.Hide()
        End If
    End Sub

    Sub seatBook(ByVal seatNumber As String)
        Dim seats() As PictureBox = {picBoxSeatA1, picBoxSeatA2, picBoxSeatA3, picBoxSeatA4, picBoxSeatA5, picBoxSeatA6, picBoxSeatA7,
                                     picBoxSeatA8, picBoxSeatB1, picBoxSeatB2, picBoxSeatB3, picBoxSeatB4, picBoxSeatB5,
                                     picBoxSeatB6, picBoxSeatB7, picBoxSeatB8, picBoxSeatC1, picBoxSeatC2, picBoxSeatC3,
                                     picBoxSeatC4, picBoxSeatC5, picBoxSeatC6, picBoxSeatC7, picBoxSeatC8, picBoxSeatD1,
                                     picBoxSeatD2, picBoxSeatD3, picBoxSeatD4, picBoxSeatD5, picBoxSeatD6, picBoxSeatD7, picBoxSeatD8,
                                     picBoxSeatE1, picBoxSeatE2, picBoxSeatE3, picBoxSeatE4, picBoxSeatE5, picBoxSeatE6,
                                     picBoxSeatE7, picBoxSeatE8}

        For x = 0 To seats.Length - 1
            If seats(x).Name.Contains(seatNumber) Then
                seats(x).Image = My.Resources.user_red
                seats(x).Enabled = False
            End If
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmBookingPage.Show()
        Me.Close()
    End Sub
End Class