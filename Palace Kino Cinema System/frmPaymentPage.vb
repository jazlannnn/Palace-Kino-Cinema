Imports System.Data.SqlClient
Public Class frmPaymentPage
    Private Sub frmPaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Palace-Kino-Cinema-System\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")

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
        Dim titleFont As New Font("Arial", 22, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 18, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim offset As Integer = 40

        Dim movieTitle As String = lblMovieTitle.Text
        Dim movieTime As String = lblDate.Text
        Dim seatNumbers As String = lblSeatNumber.Text
        Dim ticketPrice As Decimal = Convert.ToDecimal(lblPaymentDetail.Text)
        Dim totalTickets As Integer = Convert.ToInt32(lblQuantity.Text)
        Dim ticketTypes As String = lblTypeTicket.Text
        Dim totalAmount As Decimal = totalTickets * ticketPrice

        ' Print Header
        e.Graphics.DrawString("PALACE KINO CINEMA", titleFont, brush, startX, startY)
        startY += offset + 15
        e.Graphics.DrawString("BOOKING CONFIRMATION", bodyFont, brush, startX, startY)
        startY += offset

        ' Print Movie Details
        e.Graphics.DrawString("Movie Title:", bodyFont, brush, startX, startY)
        e.Graphics.DrawString(movieTitle, bodyFont, brush, startX + 200, startY)
        startY += offset

        e.Graphics.DrawString("Movie Showtime:", bodyFont, brush, startX, startY)
        e.Graphics.DrawString(movieTime, bodyFont, brush, startX + 220, startY)
        startY += offset

        e.Graphics.DrawString("Seat Number:", bodyFont, brush, startX, startY)
        e.Graphics.DrawString(seatNumbers, bodyFont, brush, startX + 200, startY)
        startY += offset

        e.Graphics.DrawString("Total Tickets:", bodyFont, brush, startX, startY)
        e.Graphics.DrawString(totalTickets.ToString(), bodyFont, brush, startX + 200, startY)
        startY += offset

        ' Print Ticket Price Details
        e.Graphics.DrawString("Amount Paid:", bodyFont, brush, startX, startY)
        e.Graphics.DrawString("RM" & ticketPrice.ToString("F2"), bodyFont, brush, startX + 200, startY)
        startY += offset
    End Sub
End Class