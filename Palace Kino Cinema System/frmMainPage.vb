Imports System.Data.SqlClient
Public Class frmMainPage

    Private Sub btnDisplayMovieInfo_Click(sender As Object, e As EventArgs) Handles btnDisplayMovieInfo.Click
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Palace Kino\Palace Kino Cinema System\PalceKinoSystemDb.mdf;Integrated Security=True")
        objcon.Open()

        Dim showtimeDate As String = ""
        Dim stmt As String = "SELECT date,time FROM Information WHERE title = '" + lstMovie.SelectedItem + "'"

        objcmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader
        If reader.Read Then
            showtimeDate = reader("date")
        End If


        reader.Close()

        stmt = "SELECT title, genre, length, rated, language, subtitle, release, casts, director, synopsis from Movie WHERE title = '" & lstMovie.SelectedItem & "'"

        objcmd = New SqlCommand(stmt, objcon)

        reader = objcmd.ExecuteReader


        If reader.Read Then
            MsgBox("Opening Movie Information")
            If (lstMovie.SelectedIndex = 0) Then
                frmBubble.lblTitle.Text = lstMovie.SelectedItem
                frmBubble.lblGenre.Text = reader("genre")
                frmBubble.lblLength.Text = reader("length")
                frmBubble.lblRate.Text = reader("rated")
                frmBubble.lblLanguage.Text = reader("language")
                frmBubble.lblSubtitle.Text = reader("subtitle")
                frmBubble.lblReleaseDate.Text = reader("release")
                frmBubble.lblCasts.Text = reader("casts")
                frmBubble.lblDirector.Text = reader("director")
                frmBubble.lblSynopsis.Text = reader("synopsis")
                frmBubble.lblDate.Text = showtimeDate
                frmBubble.ShowDialog()
            End If

            If (lstMovie.SelectedIndex = 1) Then
                frmMatKilau.lblTitle.Text = lstMovie.SelectedItem
                frmMatKilau.lblGenre.Text = reader("genre")
                frmMatKilau.lblLength.Text = reader("length")
                frmMatKilau.lblRate.Text = reader("rated")
                frmMatKilau.lblLanguage.Text = reader("language")
                frmMatKilau.lblSubtitle.Text = reader("subtitle")
                frmMatKilau.lblReleaseDate.Text = reader("release")
                frmMatKilau.lblCasts.Text = reader("casts")
                frmMatKilau.lblDirector.Text = reader("director")
                frmMatKilau.lblSynopsis.Text = reader("synopsis")
                frmMatKilau.lblDate.Text = showtimeDate
                frmMatKilau.ShowDialog()
            End If

            If (lstMovie.SelectedIndex = 2) Then
                frmTopGun.lblTitle.Text = lstMovie.SelectedItem
                frmTopGun.lblGenre.Text = reader("genre")
                frmTopGun.lblLength.Text = reader("length")
                frmTopGun.lblRate.Text = reader("rated")
                frmTopGun.lblLanguage.Text = reader("language")
                frmTopGun.lblSubtitle.Text = reader("subtitle")
                frmTopGun.lblReleaseDate.Text = reader("release")
                frmTopGun.lblCasts.Text = reader("casts")
                frmTopGun.lblDirector.Text = reader("director")
                frmTopGun.lblSynopsis.Text = reader("synopsis")
                frmTopGun.lblDate.Text = showtimeDate
                frmTopGun.ShowDialog()
            End If

            If (lstMovie.SelectedIndex = 3) Then
                frmSonic.lblTitle.Text = lstMovie.SelectedItem
                frmSonic.lblGenre.Text = reader("genre")
                frmSonic.lblLength.Text = reader("length")
                frmSonic.lblRate.Text = reader("rated")
                frmSonic.lblLanguage.Text = reader("language")
                frmSonic.lblSubtitle.Text = reader("subtitle")
                frmSonic.lblReleaseDate.Text = reader("release")
                frmSonic.lblCasts.Text = reader("casts")
                frmSonic.lblDirector.Text = reader("director")
                frmSonic.lblSynopsis.Text = reader("synopsis")
                frmSonic.lblDate.Text = showtimeDate
                frmSonic.ShowDialog()
            End If

            If (lstMovie.SelectedIndex = 4) Then
                frmMinion.lblTitle.Text = lstMovie.SelectedItem
                frmMinion.lblGenre.Text = reader("genre")
                frmMinion.lblLength.Text = reader("length")
                frmMinion.lblRate.Text = reader("rated")
                frmMinion.lblLanguage.Text = reader("language")
                frmMinion.lblSubtitle.Text = reader("subtitle")
                frmMinion.lblReleaseDate.Text = reader("release")
                frmMinion.lblCasts.Text = reader("casts")
                frmMinion.lblDirector.Text = reader("director")
                frmMinion.lblSynopsis.Text = reader("synopsis")
                frmMinion.lblDate.Text = showtimeDate
                frmMinion.ShowDialog()
            End If
        Else
            MsgBox("Please select the movie to see the information detail more")
        End If
    End Sub

    Private Sub btnBookBubble_Click(sender As Object, e As EventArgs) Handles btnBookBubble.Click
        lstMovie.SelectedIndex = 0
        frmBookingPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookMat_Click(sender As Object, e As EventArgs) Handles btnBookMat.Click
        lstMovie.SelectedIndex = 1
        frmBookingPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookTop_Click(sender As Object, e As EventArgs) Handles btnBookTop.Click
        lstMovie.SelectedIndex = 2
        frmBookingPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookSonic_Click(sender As Object, e As EventArgs) Handles btnBookSonic.Click
        lstMovie.SelectedIndex = 3
        frmBookingPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookMinion_Click(sender As Object, e As EventArgs) Handles btnBookMinion.Click
        lstMovie.SelectedIndex = 4
        frmBookingPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class