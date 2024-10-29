Imports System.Data.SqlClient
Public Class frmPaymentPage
    Private Sub frmPaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Palace Kino\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")

        objcon.Open()
        Dim query As String = "SELECT * FROM Booking WHERE CustomerIC = '" + frmBookingPage.txtIC.Text + "'"
        objcmd = New SqlCommand(query, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader

        If reader.Read() Then
            lblPaymentDetail.Text = reader("Price")
            lblSeatNumber.Text = reader("Seats")
            lblMovieTitle.Text = reader("Title")
            lblQuantity.Text = reader("Quantity")
        End If
        reader.Close()

        Dim ticketType As String = ""
        lblDate.Text = frmBookingPage.lst1.SelectedItem

        If CInt(frmBookingPage.txtBoxAdult.Text) > 0 Then
            ticketType += "Adult" + ","
        End If
        If CInt(frmBookingPage.txtBoxChildren.Text) > 0 Then
            ticketType += "Children" + ","
        End If
        If CInt(frmBookingPage.txtBoxSenior.Text) > 0 Then
            ticketType += "Senior" + ","
        End If
        If CInt(frmBookingPage.txtBoxDisable.Text) > 0 Then
            ticketType += "Disable"
        End If

        lblTypeTicket.Text = ticketType
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMainPage.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmSelectionSeat.Show()
        Me.Close()
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        MsgBox("Thank you for your purchase ! We will print your receipt soon")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        pdTicketDetails.Print()
    End Sub

    Private Sub pdTicketDetails_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdTicketDetails.PrintPage

    End Sub
End Class