<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Staff_NameLabel As System.Windows.Forms.Label
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Staff_NameLabel = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.White
        PasswordLabel.Location = New System.Drawing.Point(436, 181)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(113, 25)
        PasswordLabel.TabIndex = 64
        PasswordLabel.Text = "Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.White
        UsernameLabel.Location = New System.Drawing.Point(436, 136)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(117, 25)
        UsernameLabel.TabIndex = 62
        UsernameLabel.Text = "Username:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.BackColor = System.Drawing.Color.Transparent
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.ForeColor = System.Drawing.Color.White
        Phone_NumberLabel.Location = New System.Drawing.Point(63, 225)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(94, 50)
        Phone_NumberLabel.TabIndex = 60
        Phone_NumberLabel.Text = "Phone " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number:"
        '
        'Staff_NameLabel
        '
        Staff_NameLabel.AutoSize = True
        Staff_NameLabel.BackColor = System.Drawing.Color.Transparent
        Staff_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_NameLabel.ForeColor = System.Drawing.Color.White
        Staff_NameLabel.Location = New System.Drawing.Point(63, 136)
        Staff_NameLabel.Name = "Staff_NameLabel"
        Staff_NameLabel.Size = New System.Drawing.Size(75, 25)
        Staff_NameLabel.TabIndex = 58
        Staff_NameLabel.Text = "Name:"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffIDLabel.ForeColor = System.Drawing.Color.White
        StaffIDLabel.Location = New System.Drawing.Point(64, 184)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(91, 25)
        StaffIDLabel.TabIndex = 57
        StaffIDLabel.Text = "Staff ID:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(345, 327)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(162, 34)
        Me.btnSubmit.TabIndex = 56
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 48)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Register"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(565, 184)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(210, 22)
        Me.txtPassword.TabIndex = 66
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(565, 140)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(210, 22)
        Me.txtUsername.TabIndex = 65
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(169, 239)
        Me.txtPhoneNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(234, 22)
        Me.txtPhoneNum.TabIndex = 63
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(170, 140)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(234, 22)
        Me.txtStaffName.TabIndex = 61
        '
        'txtStaffId
        '
        Me.txtStaffId.Location = New System.Drawing.Point(169, 184)
        Me.txtStaffId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.Size = New System.Drawing.Size(235, 22)
        Me.txtStaffId.TabIndex = 59
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(850, 443)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Staff_NameLabel)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtStaffId)
        Me.Name = "frmRegister"
        Me.Text = "frmRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffId As TextBox
End Class
