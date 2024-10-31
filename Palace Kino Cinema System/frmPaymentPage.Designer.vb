<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentPage))
        Me.radBtnCash = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblTypeTicket = New System.Windows.Forms.Label()
        Me.lblTypeofTicket = New System.Windows.Forms.Label()
        Me.radBtnCreditCard = New System.Windows.Forms.RadioButton()
        Me.radBtnDebitCard = New System.Windows.Forms.RadioButton()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.pdTicketDetails = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPaymentDetail = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSeatNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblCompletePayment = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.lblMovieTotalPay = New System.Windows.Forms.Label()
        Me.lblMovieQuantity = New System.Windows.Forms.Label()
        Me.lblMovieSeat = New System.Windows.Forms.Label()
        Me.lblMovieDate = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPaymentPage = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.txtAmountPay = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radBtnCash
        '
        Me.radBtnCash.AutoSize = True
        Me.radBtnCash.BackColor = System.Drawing.Color.Transparent
        Me.radBtnCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radBtnCash.Location = New System.Drawing.Point(472, 416)
        Me.radBtnCash.Name = "radBtnCash"
        Me.radBtnCash.Size = New System.Drawing.Size(59, 20)
        Me.radBtnCash.TabIndex = 79
        Me.radBtnCash.TabStop = True
        Me.radBtnCash.Text = "Cash"
        Me.radBtnCash.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(639, 478)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(135, 23)
        Me.btnPrint.TabIndex = 78
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblTypeTicket
        '
        Me.lblTypeTicket.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTypeTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTypeTicket.Location = New System.Drawing.Point(212, 207)
        Me.lblTypeTicket.Name = "lblTypeTicket"
        Me.lblTypeTicket.Size = New System.Drawing.Size(289, 29)
        Me.lblTypeTicket.TabIndex = 77
        '
        'lblTypeofTicket
        '
        Me.lblTypeofTicket.AutoSize = True
        Me.lblTypeofTicket.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeofTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeofTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTypeofTicket.Location = New System.Drawing.Point(44, 207)
        Me.lblTypeofTicket.Name = "lblTypeofTicket"
        Me.lblTypeofTicket.Size = New System.Drawing.Size(137, 18)
        Me.lblTypeofTicket.TabIndex = 76
        Me.lblTypeofTicket.Text = " Type of the Ticket :"
        '
        'radBtnCreditCard
        '
        Me.radBtnCreditCard.AutoSize = True
        Me.radBtnCreditCard.BackColor = System.Drawing.Color.Transparent
        Me.radBtnCreditCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radBtnCreditCard.Location = New System.Drawing.Point(346, 416)
        Me.radBtnCreditCard.Name = "radBtnCreditCard"
        Me.radBtnCreditCard.Size = New System.Drawing.Size(95, 20)
        Me.radBtnCreditCard.TabIndex = 75
        Me.radBtnCreditCard.TabStop = True
        Me.radBtnCreditCard.Text = "Crebit Card"
        Me.radBtnCreditCard.UseVisualStyleBackColor = False
        '
        'radBtnDebitCard
        '
        Me.radBtnDebitCard.AutoSize = True
        Me.radBtnDebitCard.BackColor = System.Drawing.Color.Transparent
        Me.radBtnDebitCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radBtnDebitCard.Location = New System.Drawing.Point(212, 416)
        Me.radBtnDebitCard.Name = "radBtnDebitCard"
        Me.radBtnDebitCard.Size = New System.Drawing.Size(92, 20)
        Me.radBtnDebitCard.TabIndex = 74
        Me.radBtnDebitCard.TabStop = True
        Me.radBtnDebitCard.Text = "Debit Card"
        Me.radBtnDebitCard.UseVisualStyleBackColor = False
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPaymentMethod.Location = New System.Drawing.Point(47, 416)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(128, 18)
        Me.lblPaymentMethod.TabIndex = 73
        Me.lblPaymentMethod.Text = "Payment Method :"
        '
        'pdTicketDetails
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'lblPaymentDetail
        '
        Me.lblPaymentDetail.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaymentDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPaymentDetail.Location = New System.Drawing.Point(212, 333)
        Me.lblPaymentDetail.Name = "lblPaymentDetail"
        Me.lblPaymentDetail.Size = New System.Drawing.Size(289, 29)
        Me.lblPaymentDetail.TabIndex = 71
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblQuantity.Location = New System.Drawing.Point(212, 289)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(289, 29)
        Me.lblQuantity.TabIndex = 70
        '
        'lblSeatNumber
        '
        Me.lblSeatNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSeatNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeatNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSeatNumber.Location = New System.Drawing.Point(212, 244)
        Me.lblSeatNumber.Name = "lblSeatNumber"
        Me.lblSeatNumber.Size = New System.Drawing.Size(289, 29)
        Me.lblSeatNumber.TabIndex = 69
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.Location = New System.Drawing.Point(212, 167)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(289, 29)
        Me.lblDate.TabIndex = 67
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMovieTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMovieTitle.Location = New System.Drawing.Point(212, 128)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(289, 29)
        Me.lblMovieTitle.TabIndex = 66
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(49, 478)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(128, 23)
        Me.btnHome.TabIndex = 65
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblCompletePayment
        '
        Me.lblCompletePayment.AutoSize = True
        Me.lblCompletePayment.BackColor = System.Drawing.Color.Transparent
        Me.lblCompletePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletePayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCompletePayment.Location = New System.Drawing.Point(116, 78)
        Me.lblCompletePayment.Name = "lblCompletePayment"
        Me.lblCompletePayment.Size = New System.Drawing.Size(276, 20)
        Me.lblCompletePayment.TabIndex = 64
        Me.lblCompletePayment.Text = "Please complete your payment here"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(237, 478)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 23)
        Me.btnBack.TabIndex = 63
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.Location = New System.Drawing.Point(450, 478)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(135, 23)
        Me.btnConfirmPayment.TabIndex = 62
        Me.btnConfirmPayment.Text = "Confirm"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'lblMovieTotalPay
        '
        Me.lblMovieTotalPay.AutoSize = True
        Me.lblMovieTotalPay.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieTotalPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTotalPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMovieTotalPay.Location = New System.Drawing.Point(43, 334)
        Me.lblMovieTotalPay.Name = "lblMovieTotalPay"
        Me.lblMovieTotalPay.Size = New System.Drawing.Size(138, 18)
        Me.lblMovieTotalPay.TabIndex = 61
        Me.lblMovieTotalPay.Text = " Total Need to Pay :"
        '
        'lblMovieQuantity
        '
        Me.lblMovieQuantity.AutoSize = True
        Me.lblMovieQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMovieQuantity.Location = New System.Drawing.Point(47, 290)
        Me.lblMovieQuantity.Name = "lblMovieQuantity"
        Me.lblMovieQuantity.Size = New System.Drawing.Size(70, 18)
        Me.lblMovieQuantity.TabIndex = 60
        Me.lblMovieQuantity.Text = "Quantity :"
        '
        'lblMovieSeat
        '
        Me.lblMovieSeat.AutoSize = True
        Me.lblMovieSeat.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieSeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMovieSeat.Location = New System.Drawing.Point(47, 245)
        Me.lblMovieSeat.Name = "lblMovieSeat"
        Me.lblMovieSeat.Size = New System.Drawing.Size(103, 18)
        Me.lblMovieSeat.TabIndex = 59
        Me.lblMovieSeat.Text = "Seat Number :"
        '
        'lblMovieDate
        '
        Me.lblMovieDate.AutoSize = True
        Me.lblMovieDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMovieDate.Location = New System.Drawing.Point(47, 168)
        Me.lblMovieDate.Name = "lblMovieDate"
        Me.lblMovieDate.Size = New System.Drawing.Size(47, 18)
        Me.lblMovieDate.TabIndex = 57
        Me.lblMovieDate.Text = "Date :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(46, 128)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(87, 18)
        Me.lblTitle.TabIndex = 56
        Me.lblTitle.Text = "Movie Title :"
        '
        'lblPaymentPage
        '
        Me.lblPaymentPage.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentPage.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPaymentPage.Location = New System.Drawing.Point(111, 24)
        Me.lblPaymentPage.Name = "lblPaymentPage"
        Me.lblPaymentPage.Size = New System.Drawing.Size(340, 50)
        Me.lblPaymentPage.TabIndex = 55
        Me.lblPaymentPage.Text = "Payment Page"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmountPaid.Location = New System.Drawing.Point(43, 376)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(92, 18)
        Me.lblAmountPaid.TabIndex = 80
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'txtAmountPay
        '
        Me.txtAmountPay.Location = New System.Drawing.Point(212, 376)
        Me.txtAmountPay.Name = "txtAmountPay"
        Me.txtAmountPay.Size = New System.Drawing.Size(289, 22)
        Me.txtAmountPay.TabIndex = 81
        '
        'frmPaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(916, 556)
        Me.Controls.Add(Me.txtAmountPay)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.radBtnCash)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTypeTicket)
        Me.Controls.Add(Me.lblTypeofTicket)
        Me.Controls.Add(Me.radBtnCreditCard)
        Me.Controls.Add(Me.radBtnDebitCard)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPaymentDetail)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblSeatNumber)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblCompletePayment)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.lblMovieTotalPay)
        Me.Controls.Add(Me.lblMovieQuantity)
        Me.Controls.Add(Me.lblMovieSeat)
        Me.Controls.Add(Me.lblMovieDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPaymentPage)
        Me.Name = "frmPaymentPage"
        Me.Text = "frmPaymentPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radBtnCash As RadioButton
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblTypeTicket As Label
    Friend WithEvents lblTypeofTicket As Label
    Friend WithEvents radBtnCreditCard As RadioButton
    Friend WithEvents radBtnDebitCard As RadioButton
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents pdTicketDetails As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPaymentDetail As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblSeatNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMovieTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents lblCompletePayment As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents lblMovieTotalPay As Label
    Friend WithEvents lblMovieQuantity As Label
    Friend WithEvents lblMovieSeat As Label
    Friend WithEvents lblMovieDate As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPaymentPage As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents txtAmountPay As TextBox
End Class
