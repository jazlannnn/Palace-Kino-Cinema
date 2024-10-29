Imports System.Data.SqlClient
Public Class frmBookingPage
    Dim movieTitle As String

    Private Sub frmBookingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTypes.SelectedIndex = 0

        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Palace Kino\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")

        objcon.Open()

        Dim showtimeDate As String = ""
        Dim showtimeTime As String = ""
        Dim stmt As String = "SELECT * FROM Information WHERE Title = '" + frmMainPage.lstMovie.SelectedItem + "'"

        objcmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader
        If reader.Read Then
            movieTitle = reader("Title")
            showtimeDate = reader("Date")
            showtimeTime = reader("Time")
            reader.Close()
            objcon.Close()
        End If

        Dim dateArray() As String = showtimeDate.Split(",")
        Dim timeArray() As String = showtimeTime.Split(",")

        Dim dateTimeArray(dateArray.Length * timeArray.Length) As String

        Dim z As Integer = 0

        For x = 0 To dateArray.Length - 1
            For y = 0 To timeArray.Length - 1
                dateTimeArray(z) = dateArray(x).ToString() + " " + timeArray(y).ToString()
                lst1.Items.Add(dateTimeArray(z).ToString())
                z = z + 1
            Next
        Next
        lst1.SelectedIndex = 0

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Palace Kino\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")

        Dim typeValue As String = ""
        Dim totalTicketPrice As Decimal = 0.0
        Select Case cmbTypes.SelectedIndex
            Case 0
                typeValue = "Indulge"
            Case 1
                typeValue = "Imax"
            Case 2
                typeValue = "Luxe"
            Case 3
                typeValue = "Deluxe"
        End Select

        objcon.Open()
        Dim stmt As String = "SELECT ticketPrice, ticketCategory FROM Ticket WHERE ticketAddOn ='" + typeValue + "'"
        objcmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader

        While reader.Read()
            If reader("ticketCategory") = "Adult" Then
                totalTicketPrice += CInt(txtBoxAdult.Text) * reader("ticketPrice")
            End If
            If reader("ticketCategory") = "Children" Then
                totalTicketPrice += CInt(txtBoxChildren.Text) * reader("ticketPrice")
            End If
            If reader("ticketCategory") = "Senior" Then
                totalTicketPrice += CInt(txtBoxSenior.Text) * reader("ticketPrice")
            End If
            If reader("ticketCategory") = "Disable" Then
                totalTicketPrice += CInt(txtBoxDisable.Text) * reader("ticketPrice")
            End If
        End While
        reader.Close()
        Dim totalTicketQuantity As Integer = CInt(txtBoxAdult.Text) + CInt(txtBoxChildren.Text) + CInt(txtBoxDisable.Text) + CInt(txtBoxSenior.Text)
        stmt = "INSERT INTO Customer VALUES('" + txtIC.Text + "','" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "');"

        objcmd = New SqlCommand(stmt, objcon)


        If objcmd.ExecuteNonQuery Then
            stmt = "INSERT INTO Booking VALUES('" + totalTicketPrice.ToString + "','" + totalTicketQuantity.ToString + "','" + movieTitle + "','" + txtIC.Text + "','" + lst1.SelectedItem + "','" + "NULL" + "');"

            objcmd = New SqlCommand(stmt, objcon)
            If objcmd.ExecuteNonQuery Then
                MsgBox("Going to Seat Selection Page.")
                frmSelectionSeat.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        frmMainPage.Show()
        Me.Close()
    End Sub
End Class