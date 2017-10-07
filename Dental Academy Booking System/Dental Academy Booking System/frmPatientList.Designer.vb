<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientList))
        Me.cboPatientList = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDTelephone = New System.Windows.Forms.Label()
        Me.txtHomeNumber = New System.Windows.Forms.TextBox()
        Me.lblDPhoneNumber = New System.Windows.Forms.Label()
        Me.lblDGender = New System.Windows.Forms.Label()
        Me.lblDDateOfBirth = New System.Windows.Forms.Label()
        Me.lblDSurname = New System.Windows.Forms.Label()
        Me.lblDFirstName = New System.Windows.Forms.Label()
        Me.lblDTitle = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.picDentalAcademyLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAllergyInfo = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbYes = New System.Windows.Forms.CheckBox()
        Me.chbNo = New System.Windows.Forms.CheckBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.lblAllergyCheck = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.picDentalAcademyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPatientList
        '
        Me.cboPatientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPatientList.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPatientList.FormattingEnabled = True
        Me.cboPatientList.Location = New System.Drawing.Point(97, 12)
        Me.cboPatientList.Name = "cboPatientList"
        Me.cboPatientList.Size = New System.Drawing.Size(194, 21)
        Me.cboPatientList.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(311, 39)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(396, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(483, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDTelephone
        '
        Me.lblDTelephone.AutoSize = True
        Me.lblDTelephone.Location = New System.Drawing.Point(21, 259)
        Me.lblDTelephone.Name = "lblDTelephone"
        Me.lblDTelephone.Size = New System.Drawing.Size(88, 14)
        Me.lblDTelephone.TabIndex = 41
        Me.lblDTelephone.Text = "Home Number:"
        '
        'txtHomeNumber
        '
        Me.txtHomeNumber.Location = New System.Drawing.Point(130, 256)
        Me.txtHomeNumber.Name = "txtHomeNumber"
        Me.txtHomeNumber.Size = New System.Drawing.Size(151, 22)
        Me.txtHomeNumber.TabIndex = 40
        '
        'lblDPhoneNumber
        '
        Me.lblDPhoneNumber.AutoSize = True
        Me.lblDPhoneNumber.Location = New System.Drawing.Point(22, 226)
        Me.lblDPhoneNumber.Name = "lblDPhoneNumber"
        Me.lblDPhoneNumber.Size = New System.Drawing.Size(90, 14)
        Me.lblDPhoneNumber.TabIndex = 39
        Me.lblDPhoneNumber.Text = "Phone Number:"
        '
        'lblDGender
        '
        Me.lblDGender.AutoSize = True
        Me.lblDGender.Location = New System.Drawing.Point(29, 197)
        Me.lblDGender.Name = "lblDGender"
        Me.lblDGender.Size = New System.Drawing.Size(80, 14)
        Me.lblDGender.TabIndex = 38
        Me.lblDGender.Text = "Gender M / F:"
        '
        'lblDDateOfBirth
        '
        Me.lblDDateOfBirth.AutoSize = True
        Me.lblDDateOfBirth.Location = New System.Drawing.Point(30, 162)
        Me.lblDDateOfBirth.Name = "lblDDateOfBirth"
        Me.lblDDateOfBirth.Size = New System.Drawing.Size(80, 14)
        Me.lblDDateOfBirth.TabIndex = 37
        Me.lblDDateOfBirth.Text = "Date Of Birth:"
        '
        'lblDSurname
        '
        Me.lblDSurname.AutoSize = True
        Me.lblDSurname.Location = New System.Drawing.Point(53, 130)
        Me.lblDSurname.Name = "lblDSurname"
        Me.lblDSurname.Size = New System.Drawing.Size(58, 14)
        Me.lblDSurname.TabIndex = 36
        Me.lblDSurname.Text = "Surname:"
        '
        'lblDFirstName
        '
        Me.lblDFirstName.AutoSize = True
        Me.lblDFirstName.Location = New System.Drawing.Point(42, 95)
        Me.lblDFirstName.Name = "lblDFirstName"
        Me.lblDFirstName.Size = New System.Drawing.Size(69, 14)
        Me.lblDFirstName.TabIndex = 35
        Me.lblDFirstName.Text = "First Name:"
        '
        'lblDTitle
        '
        Me.lblDTitle.AutoSize = True
        Me.lblDTitle.Location = New System.Drawing.Point(77, 60)
        Me.lblDTitle.Name = "lblDTitle"
        Me.lblDTitle.Size = New System.Drawing.Size(35, 14)
        Me.lblDTitle.TabIndex = 34
        Me.lblDTitle.Text = "Title:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(130, 223)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(151, 22)
        Me.txtPhoneNumber.TabIndex = 33
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(130, 191)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(151, 22)
        Me.txtGender.TabIndex = 32
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(130, 127)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(151, 22)
        Me.txtSurname.TabIndex = 30
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 92)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(151, 22)
        Me.txtFirstName.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Postcode:"
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(443, 194)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(151, 22)
        Me.txtPostCode.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "County:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 14)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "City:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(381, 100)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(42, 14)
        Me.Label.TabIndex = 47
        Me.Label.Text = "Street:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "House Number:"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(443, 161)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(151, 22)
        Me.txtCounty.TabIndex = 45
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(443, 129)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(151, 22)
        Me.txtCity.TabIndex = 44
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(443, 97)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(151, 22)
        Me.txtStreet.TabIndex = 43
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(443, 65)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(151, 22)
        Me.txtHouseNumber.TabIndex = 42
        '
        'picDentalAcademyLogo
        '
        Me.picDentalAcademyLogo.Image = CType(resources.GetObject("picDentalAcademyLogo.Image"), System.Drawing.Image)
        Me.picDentalAcademyLogo.Location = New System.Drawing.Point(20, 301)
        Me.picDentalAcademyLogo.Name = "picDentalAcademyLogo"
        Me.picDentalAcademyLogo.Size = New System.Drawing.Size(361, 88)
        Me.picDentalAcademyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDentalAcademyLogo.TabIndex = 52
        Me.picDentalAcademyLogo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(111, 25)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 14)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Allergy Information:"
        '
        'txtAllergyInfo
        '
        Me.txtAllergyInfo.Location = New System.Drawing.Point(443, 281)
        Me.txtAllergyInfo.Multiline = True
        Me.txtAllergyInfo.Name = "txtAllergyInfo"
        Me.txtAllergyInfo.Size = New System.Drawing.Size(155, 80)
        Me.txtAllergyInfo.TabIndex = 55
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(396, 379)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 41)
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(511, 379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 41)
        Me.btnDelete.TabIndex = 57
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 14)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Allergies:"
        '
        'chbYes
        '
        Me.chbYes.AutoSize = True
        Me.chbYes.Location = New System.Drawing.Point(468, 232)
        Me.chbYes.Name = "chbYes"
        Me.chbYes.Size = New System.Drawing.Size(44, 18)
        Me.chbYes.TabIndex = 59
        Me.chbYes.Text = "Yes"
        Me.chbYes.UseVisualStyleBackColor = True
        '
        'chbNo
        '
        Me.chbNo.AutoSize = True
        Me.chbNo.Location = New System.Drawing.Point(533, 232)
        Me.chbNo.Name = "chbNo"
        Me.chbNo.Size = New System.Drawing.Size(41, 18)
        Me.chbNo.TabIndex = 60
        Me.chbNo.Text = "No"
        Me.chbNo.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(576, 10)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(38, 39)
        Me.btnHelp.TabIndex = 61
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Location = New System.Drawing.Point(130, 158)
        Me.DateOfBirth.MaxDate = New Date(1998, 1, 1, 0, 0, 0, 0)
        Me.DateOfBirth.MinDate = New Date(1965, 1, 1, 0, 0, 0, 0)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(151, 22)
        Me.DateOfBirth.TabIndex = 62
        Me.DateOfBirth.Value = New Date(1998, 1, 1, 0, 0, 0, 0)
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(311, 10)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(70, 23)
        Me.btnShow.TabIndex = 63
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(173, 394)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(208, 23)
        Me.btnRegister.TabIndex = 64
        Me.btnRegister.Text = "Register New Member"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'cboTitle
        '
        Me.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr", "Miss", "Mrs", "Dr"})
        Me.cboTitle.Location = New System.Drawing.Point(130, 57)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(151, 22)
        Me.cboTitle.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 14)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "ID:"
        '
        'cboID
        '
        Me.cboID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(40, 12)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(37, 21)
        Me.cboID.TabIndex = 67
        '
        'lblAllergyCheck
        '
        Me.lblAllergyCheck.AutoSize = True
        Me.lblAllergyCheck.Location = New System.Drawing.Point(311, 233)
        Me.lblAllergyCheck.Name = "lblAllergyCheck"
        Me.lblAllergyCheck.Size = New System.Drawing.Size(38, 14)
        Me.lblAllergyCheck.TabIndex = 68
        Me.lblAllergyCheck.Text = "Check"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(437, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 14)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "(Type ""None"" If no allergies)"
        '
        'frmPatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAllergyCheck)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.chbNo)
        Me.Controls.Add(Me.chbYes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAllergyInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picDentalAcademyLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtHouseNumber)
        Me.Controls.Add(Me.lblDTelephone)
        Me.Controls.Add(Me.txtHomeNumber)
        Me.Controls.Add(Me.lblDPhoneNumber)
        Me.Controls.Add(Me.lblDGender)
        Me.Controls.Add(Me.lblDDateOfBirth)
        Me.Controls.Add(Me.lblDSurname)
        Me.Controls.Add(Me.lblDFirstName)
        Me.Controls.Add(Me.lblDTitle)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cboPatientList)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatientList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatientList"
        CType(Me.picDentalAcademyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPatientList As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDTelephone As System.Windows.Forms.Label
    Friend WithEvents txtHomeNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblDGender As System.Windows.Forms.Label
    Friend WithEvents lblDDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblDSurname As System.Windows.Forms.Label
    Friend WithEvents lblDFirstName As System.Windows.Forms.Label
    Friend WithEvents lblDTitle As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseNumber As System.Windows.Forms.TextBox
    Friend WithEvents picDentalAcademyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAllergyInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chbYes As System.Windows.Forms.CheckBox
    Friend WithEvents chbNo As System.Windows.Forms.CheckBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents DateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents lblAllergyCheck As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
