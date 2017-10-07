<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.cboDentist = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rdoStudent = New System.Windows.Forms.RadioButton()
        Me.rdoTutor = New System.Windows.Forms.RadioButton()
        Me.rdoDentalNurse = New System.Windows.Forms.RadioButton()
        Me.txtDFirstName = New System.Windows.Forms.TextBox()
        Me.txtDSurname = New System.Windows.Forms.TextBox()
        Me.txtDGender = New System.Windows.Forms.TextBox()
        Me.txtDPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblDTitle = New System.Windows.Forms.Label()
        Me.lblDFirstName = New System.Windows.Forms.Label()
        Me.lblDSurname = New System.Windows.Forms.Label()
        Me.lblDDateOfBirth = New System.Windows.Forms.Label()
        Me.lblDGender = New System.Windows.Forms.Label()
        Me.lblDPhoneNumber = New System.Windows.Forms.Label()
        Me.txtDHomeTelephone = New System.Windows.Forms.TextBox()
        Me.lblDTelephone = New System.Windows.Forms.Label()
        Me.txtReTypePassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblDNewPassword = New System.Windows.Forms.Label()
        Me.lblRePassword = New System.Windows.Forms.Label()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.DDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.cboDTitle = New System.Windows.Forms.ComboBox()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDentist
        '
        Me.cboDentist.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDentist.FormattingEnabled = True
        Me.cboDentist.Location = New System.Drawing.Point(224, 14)
        Me.cboDentist.Name = "cboDentist"
        Me.cboDentist.Size = New System.Drawing.Size(204, 21)
        Me.cboDentist.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(149, 52)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(242, 52)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(337, 52)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoStudent
        '
        Me.rdoStudent.AutoSize = True
        Me.rdoStudent.Checked = True
        Me.rdoStudent.Location = New System.Drawing.Point(152, 89)
        Me.rdoStudent.Name = "rdoStudent"
        Me.rdoStudent.Size = New System.Drawing.Size(66, 19)
        Me.rdoStudent.TabIndex = 11
        Me.rdoStudent.TabStop = True
        Me.rdoStudent.Text = "Student"
        Me.rdoStudent.UseVisualStyleBackColor = True
        '
        'rdoTutor
        '
        Me.rdoTutor.AutoSize = True
        Me.rdoTutor.Location = New System.Drawing.Point(224, 89)
        Me.rdoTutor.Name = "rdoTutor"
        Me.rdoTutor.Size = New System.Drawing.Size(53, 19)
        Me.rdoTutor.TabIndex = 12
        Me.rdoTutor.TabStop = True
        Me.rdoTutor.Text = "Tutor"
        Me.rdoTutor.UseVisualStyleBackColor = True
        '
        'rdoDentalNurse
        '
        Me.rdoDentalNurse.AutoSize = True
        Me.rdoDentalNurse.Location = New System.Drawing.Point(283, 89)
        Me.rdoDentalNurse.Name = "rdoDentalNurse"
        Me.rdoDentalNurse.Size = New System.Drawing.Size(96, 19)
        Me.rdoDentalNurse.TabIndex = 13
        Me.rdoDentalNurse.TabStop = True
        Me.rdoDentalNurse.Text = "Dental Nurse"
        Me.rdoDentalNurse.UseVisualStyleBackColor = True
        '
        'txtDFirstName
        '
        Me.txtDFirstName.Location = New System.Drawing.Point(149, 168)
        Me.txtDFirstName.Name = "txtDFirstName"
        Me.txtDFirstName.Size = New System.Drawing.Size(151, 23)
        Me.txtDFirstName.TabIndex = 15
        '
        'txtDSurname
        '
        Me.txtDSurname.Location = New System.Drawing.Point(149, 203)
        Me.txtDSurname.Name = "txtDSurname"
        Me.txtDSurname.Size = New System.Drawing.Size(151, 23)
        Me.txtDSurname.TabIndex = 16
        '
        'txtDGender
        '
        Me.txtDGender.Location = New System.Drawing.Point(149, 267)
        Me.txtDGender.Name = "txtDGender"
        Me.txtDGender.Size = New System.Drawing.Size(151, 23)
        Me.txtDGender.TabIndex = 18
        '
        'txtDPhoneNumber
        '
        Me.txtDPhoneNumber.Location = New System.Drawing.Point(149, 299)
        Me.txtDPhoneNumber.Name = "txtDPhoneNumber"
        Me.txtDPhoneNumber.Size = New System.Drawing.Size(151, 23)
        Me.txtDPhoneNumber.TabIndex = 19
        '
        'lblDTitle
        '
        Me.lblDTitle.AutoSize = True
        Me.lblDTitle.Location = New System.Drawing.Point(96, 136)
        Me.lblDTitle.Name = "lblDTitle"
        Me.lblDTitle.Size = New System.Drawing.Size(34, 15)
        Me.lblDTitle.TabIndex = 20
        Me.lblDTitle.Text = "Title:"
        '
        'lblDFirstName
        '
        Me.lblDFirstName.AutoSize = True
        Me.lblDFirstName.Location = New System.Drawing.Point(61, 171)
        Me.lblDFirstName.Name = "lblDFirstName"
        Me.lblDFirstName.Size = New System.Drawing.Size(69, 15)
        Me.lblDFirstName.TabIndex = 21
        Me.lblDFirstName.Text = "First Name:"
        '
        'lblDSurname
        '
        Me.lblDSurname.AutoSize = True
        Me.lblDSurname.Location = New System.Drawing.Point(72, 206)
        Me.lblDSurname.Name = "lblDSurname"
        Me.lblDSurname.Size = New System.Drawing.Size(58, 15)
        Me.lblDSurname.TabIndex = 22
        Me.lblDSurname.Text = "Surname:"
        '
        'lblDDateOfBirth
        '
        Me.lblDDateOfBirth.AutoSize = True
        Me.lblDDateOfBirth.Location = New System.Drawing.Point(49, 238)
        Me.lblDDateOfBirth.Name = "lblDDateOfBirth"
        Me.lblDDateOfBirth.Size = New System.Drawing.Size(81, 15)
        Me.lblDDateOfBirth.TabIndex = 23
        Me.lblDDateOfBirth.Text = "Date Of Birth:"
        '
        'lblDGender
        '
        Me.lblDGender.AutoSize = True
        Me.lblDGender.Location = New System.Drawing.Point(49, 270)
        Me.lblDGender.Name = "lblDGender"
        Me.lblDGender.Size = New System.Drawing.Size(80, 15)
        Me.lblDGender.TabIndex = 24
        Me.lblDGender.Text = "Gender M / F:"
        '
        'lblDPhoneNumber
        '
        Me.lblDPhoneNumber.AutoSize = True
        Me.lblDPhoneNumber.Location = New System.Drawing.Point(41, 302)
        Me.lblDPhoneNumber.Name = "lblDPhoneNumber"
        Me.lblDPhoneNumber.Size = New System.Drawing.Size(90, 15)
        Me.lblDPhoneNumber.TabIndex = 25
        Me.lblDPhoneNumber.Text = "Phone Number:"
        '
        'txtDHomeTelephone
        '
        Me.txtDHomeTelephone.Location = New System.Drawing.Point(149, 332)
        Me.txtDHomeTelephone.Name = "txtDHomeTelephone"
        Me.txtDHomeTelephone.Size = New System.Drawing.Size(151, 23)
        Me.txtDHomeTelephone.TabIndex = 26
        '
        'lblDTelephone
        '
        Me.lblDTelephone.AutoSize = True
        Me.lblDTelephone.Location = New System.Drawing.Point(32, 335)
        Me.lblDTelephone.Name = "lblDTelephone"
        Me.lblDTelephone.Size = New System.Drawing.Size(99, 15)
        Me.lblDTelephone.TabIndex = 27
        Me.lblDTelephone.Text = "Home Telephone:"
        '
        'txtReTypePassword
        '
        Me.txtReTypePassword.Location = New System.Drawing.Point(437, 165)
        Me.txtReTypePassword.Name = "txtReTypePassword"
        Me.txtReTypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReTypePassword.Size = New System.Drawing.Size(151, 23)
        Me.txtReTypePassword.TabIndex = 34
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(436, 131)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(151, 23)
        Me.txtNewPassword.TabIndex = 33
        '
        'lblDNewPassword
        '
        Me.lblDNewPassword.AutoSize = True
        Me.lblDNewPassword.Location = New System.Drawing.Point(340, 137)
        Me.lblDNewPassword.Name = "lblDNewPassword"
        Me.lblDNewPassword.Size = New System.Drawing.Size(90, 15)
        Me.lblDNewPassword.TabIndex = 40
        Me.lblDNewPassword.Text = "New Password:"
        '
        'lblRePassword
        '
        Me.lblRePassword.AutoSize = True
        Me.lblRePassword.Location = New System.Drawing.Point(328, 169)
        Me.lblRePassword.Name = "lblRePassword"
        Me.lblRePassword.Size = New System.Drawing.Size(103, 15)
        Me.lblRePassword.TabIndex = 41
        Me.lblRePassword.Text = "Retype Password:"
        '
        'btnLogOff
        '
        Me.btnLogOff.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOff.Location = New System.Drawing.Point(12, 367)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(111, 23)
        Me.btnLogOff.TabIndex = 43
        Me.btnLogOff.Text = "Log Off"
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(418, 301)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 89)
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(447, 52)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 23)
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(573, 22)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(38, 39)
        Me.btnHelp.TabIndex = 14
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'picStaff
        '
        Me.picStaff.Image = Global.Dental_Academy_Booking_System.My.Resources.Resources.picDentalNurse
        Me.picStaff.Location = New System.Drawing.Point(14, 14)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(117, 107)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 0
        Me.picStaff.TabStop = False
        '
        'DDateOfBirth
        '
        Me.DDateOfBirth.Location = New System.Drawing.Point(149, 235)
        Me.DDateOfBirth.MaxDate = New Date(1998, 1, 1, 0, 0, 0, 0)
        Me.DDateOfBirth.MinDate = New Date(1965, 1, 1, 0, 0, 0, 0)
        Me.DDateOfBirth.Name = "DDateOfBirth"
        Me.DDateOfBirth.Size = New System.Drawing.Size(151, 23)
        Me.DDateOfBirth.TabIndex = 46
        Me.DDateOfBirth.Value = New Date(1998, 1, 1, 0, 0, 0, 0)
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(447, 14)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(87, 23)
        Me.btnShow.TabIndex = 48
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(347, 262)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(267, 23)
        Me.btnRegister.TabIndex = 49
        Me.btnRegister.Text = "Register New Member"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "ID:"
        '
        'cboID
        '
        Me.cboID.Enabled = False
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(178, 12)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(40, 23)
        Me.cboID.TabIndex = 52
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(385, 91)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(44, 15)
        Me.lblColour.TabIndex = 53
        Me.lblColour.Text = "Colour"
        '
        'cboDTitle
        '
        Me.cboDTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDTitle.FormattingEnabled = True
        Me.cboDTitle.Items.AddRange(New Object() {"Mr", "Miss", "Mrs", "Dr"})
        Me.cboDTitle.Location = New System.Drawing.Point(149, 133)
        Me.cboDTitle.Name = "cboDTitle"
        Me.cboDTitle.Size = New System.Drawing.Size(151, 23)
        Me.cboDTitle.TabIndex = 54
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDTitle)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DDateOfBirth)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.lblRePassword)
        Me.Controls.Add(Me.lblDNewPassword)
        Me.Controls.Add(Me.txtReTypePassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblDTelephone)
        Me.Controls.Add(Me.txtDHomeTelephone)
        Me.Controls.Add(Me.lblDPhoneNumber)
        Me.Controls.Add(Me.lblDGender)
        Me.Controls.Add(Me.lblDDateOfBirth)
        Me.Controls.Add(Me.lblDSurname)
        Me.Controls.Add(Me.lblDFirstName)
        Me.Controls.Add(Me.lblDTitle)
        Me.Controls.Add(Me.txtDPhoneNumber)
        Me.Controls.Add(Me.txtDGender)
        Me.Controls.Add(Me.txtDSurname)
        Me.Controls.Add(Me.txtDFirstName)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.rdoDentalNurse)
        Me.Controls.Add(Me.rdoTutor)
        Me.Controls.Add(Me.rdoStudent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cboDentist)
        Me.Controls.Add(Me.picStaff)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dental Academy Appointment System - Admin"
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picStaff As System.Windows.Forms.PictureBox
    Friend WithEvents cboDentist As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rdoStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTutor As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDentalNurse As System.Windows.Forms.RadioButton
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents txtDFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtDSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtDGender As System.Windows.Forms.TextBox
    Friend WithEvents txtDPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDTitle As System.Windows.Forms.Label
    Friend WithEvents lblDFirstName As System.Windows.Forms.Label
    Friend WithEvents lblDSurname As System.Windows.Forms.Label
    Friend WithEvents lblDDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblDGender As System.Windows.Forms.Label
    Friend WithEvents lblDPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtDHomeTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblDTelephone As System.Windows.Forms.Label
    Friend WithEvents txtReTypePassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblDNewPassword As System.Windows.Forms.Label
    Friend WithEvents lblRePassword As System.Windows.Forms.Label
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents cboDTitle As System.Windows.Forms.ComboBox
End Class
