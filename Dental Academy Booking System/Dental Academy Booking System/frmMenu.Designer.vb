<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDTitle = New System.Windows.Forms.Label()
        Me.txtDTitle = New System.Windows.Forms.TextBox()
        Me.txtDFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnPatientList = New System.Windows.Forms.Button()
        Me.btnAppointmentList = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHomeTelephone = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtHomeTelephone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstPatientsToday = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Colour = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTreatmentID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cboAppointmentID = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboPatientID = New System.Windows.Forms.ComboBox()
        Me.btnDisplayPatient = New System.Windows.Forms.Button()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStaff
        '
        Me.picStaff.Image = Global.Dental_Academy_Booking_System.My.Resources.Resources.picDentalNurse
        Me.picStaff.Location = New System.Drawing.Point(14, 15)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(117, 115)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 1
        Me.picStaff.TabStop = False
        '
        'txtID
        '
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(213, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(151, 22)
        Me.txtID.TabIndex = 10
        '
        'lblDTitle
        '
        Me.lblDTitle.AutoSize = True
        Me.lblDTitle.Location = New System.Drawing.Point(185, 21)
        Me.lblDTitle.Name = "lblDTitle"
        Me.lblDTitle.Size = New System.Drawing.Size(22, 14)
        Me.lblDTitle.TabIndex = 21
        Me.lblDTitle.Text = "ID:"
        '
        'txtDTitle
        '
        Me.txtDTitle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDTitle.Location = New System.Drawing.Point(213, 51)
        Me.txtDTitle.Name = "txtDTitle"
        Me.txtDTitle.ReadOnly = True
        Me.txtDTitle.Size = New System.Drawing.Size(151, 22)
        Me.txtDTitle.TabIndex = 22
        '
        'txtDFirstName
        '
        Me.txtDFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDFirstName.Location = New System.Drawing.Point(213, 81)
        Me.txtDFirstName.Name = "txtDFirstName"
        Me.txtDFirstName.ReadOnly = True
        Me.txtDFirstName.Size = New System.Drawing.Size(151, 22)
        Me.txtDFirstName.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "First Name:"
        '
        'txtDSurname
        '
        Me.txtDSurname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDSurname.Location = New System.Drawing.Point(213, 110)
        Me.txtDSurname.Name = "txtDSurname"
        Me.txtDSurname.ReadOnly = True
        Me.txtDSurname.Size = New System.Drawing.Size(151, 22)
        Me.txtDSurname.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Surname:"
        '
        'btnLogOff
        '
        Me.btnLogOff.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOff.Location = New System.Drawing.Point(12, 395)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(111, 25)
        Me.btnLogOff.TabIndex = 44
        Me.btnLogOff.Text = "Log Off"
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(14, 207)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(164, 25)
        Me.btnDisplay.TabIndex = 45
        Me.btnDisplay.Text = "Open Patient ID"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnPatientList
        '
        Me.btnPatientList.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientList.Location = New System.Drawing.Point(380, 18)
        Me.btnPatientList.Name = "btnPatientList"
        Me.btnPatientList.Size = New System.Drawing.Size(112, 79)
        Me.btnPatientList.TabIndex = 46
        Me.btnPatientList.Text = "Patient List"
        Me.btnPatientList.UseVisualStyleBackColor = True
        '
        'btnAppointmentList
        '
        Me.btnAppointmentList.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointmentList.Location = New System.Drawing.Point(504, 18)
        Me.btnAppointmentList.Name = "btnAppointmentList"
        Me.btnAppointmentList.Size = New System.Drawing.Size(110, 79)
        Me.btnAppointmentList.TabIndex = 47
        Me.btnAppointmentList.Text = "Appointment List"
        Me.btnAppointmentList.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(299, 183)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(151, 22)
        Me.txtTitle.TabIndex = 48
        '
        'btnHelp
        '
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(570, 130)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(38, 39)
        Me.btnHelp.TabIndex = 50
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(299, 280)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.Size = New System.Drawing.Size(151, 22)
        Me.txtDateOfBirth.TabIndex = 53
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(299, 247)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(151, 22)
        Me.txtSurname.TabIndex = 52
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(299, 315)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(151, 22)
        Me.txtPhoneNumber.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 14)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Date Of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(203, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 14)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Phone Number:"
        '
        'lblHomeTelephone
        '
        Me.lblHomeTelephone.AutoSize = True
        Me.lblHomeTelephone.Location = New System.Drawing.Point(192, 350)
        Me.lblHomeTelephone.Name = "lblHomeTelephone"
        Me.lblHomeTelephone.Size = New System.Drawing.Size(103, 14)
        Me.lblHomeTelephone.TabIndex = 62
        Me.lblHomeTelephone.Text = "Home Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Surname:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(224, 218)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 14)
        Me.Label.TabIndex = 64
        Me.Label.Text = "First Name:"
        '
        'btnComplete
        '
        Me.btnComplete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(497, 395)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(111, 25)
        Me.btnComplete.TabIndex = 66
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(299, 216)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(150, 22)
        Me.txtFirstName.TabIndex = 67
        '
        'txtHomeTelephone
        '
        Me.txtHomeTelephone.Location = New System.Drawing.Point(299, 347)
        Me.txtHomeTelephone.Name = "txtHomeTelephone"
        Me.txtHomeTelephone.ReadOnly = True
        Me.txtHomeTelephone.Size = New System.Drawing.Size(152, 22)
        Me.txtHomeTelephone.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 14)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(252, 386)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 14)
        Me.lblTime.TabIndex = 70
        Me.lblTime.Text = "00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Duration:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(367, 386)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(19, 14)
        Me.lblDuration.TabIndex = 72
        Me.lblDuration.Text = "00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(399, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Minutes"
        '
        'lstPatientsToday
        '
        Me.lstPatientsToday.FormattingEnabled = True
        Me.lstPatientsToday.ItemHeight = 14
        Me.lstPatientsToday.Location = New System.Drawing.Point(14, 251)
        Me.lstPatientsToday.Name = "lstPatientsToday"
        Me.lstPatientsToday.Size = New System.Drawing.Size(164, 116)
        Me.lstPatientsToday.TabIndex = 28
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(14, 148)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(164, 23)
        Me.btnRefresh.TabIndex = 74
        Me.btnRefresh.Text = "Refresh List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Colour
        '
        Me.Colour.AutoSize = True
        Me.Colour.Location = New System.Drawing.Point(559, 110)
        Me.Colour.Name = "Colour"
        Me.Colour.Size = New System.Drawing.Size(49, 14)
        Me.Colour.TabIndex = 75
        Me.Colour.Text = "Label12"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(501, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 14)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Treatments:"
        '
        'lblTreatmentID
        '
        Me.lblTreatmentID.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatmentID.Location = New System.Drawing.Point(468, 221)
        Me.lblTreatmentID.Name = "lblTreatmentID"
        Me.lblTreatmentID.Size = New System.Drawing.Size(140, 27)
        Me.lblTreatmentID.TabIndex = 77
        Me.lblTreatmentID.Text = "Treatment ID"
        Me.lblTreatmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(215, 406)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 14)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(252, 406)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(77, 14)
        Me.lblDate.TabIndex = 79
        Me.lblDate.Text = "DD/MM/YYYY"
        '
        'cboAppointmentID
        '
        Me.cboAppointmentID.FormattingEnabled = True
        Me.cboAppointmentID.Location = New System.Drawing.Point(141, 177)
        Me.cboAppointmentID.Name = "cboAppointmentID"
        Me.cboAppointmentID.Size = New System.Drawing.Size(37, 22)
        Me.cboAppointmentID.TabIndex = 80
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 181)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 14)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Appointment ID:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(232, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 14)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Patient ID:"
        '
        'cboPatientID
        '
        Me.cboPatientID.Enabled = False
        Me.cboPatientID.FormattingEnabled = True
        Me.cboPatientID.Location = New System.Drawing.Point(299, 154)
        Me.cboPatientID.Name = "cboPatientID"
        Me.cboPatientID.Size = New System.Drawing.Size(150, 22)
        Me.cboPatientID.TabIndex = 83
        '
        'btnDisplayPatient
        '
        Me.btnDisplayPatient.Enabled = False
        Me.btnDisplayPatient.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayPatient.Location = New System.Drawing.Point(455, 154)
        Me.btnDisplayPatient.Name = "btnDisplayPatient"
        Me.btnDisplayPatient.Size = New System.Drawing.Size(71, 25)
        Me.btnDisplayPatient.TabIndex = 84
        Me.btnDisplayPatient.Text = "Display"
        Me.btnDisplayPatient.UseVisualStyleBackColor = True
        '
        'lblTreatment
        '
        Me.lblTreatment.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatment.Location = New System.Drawing.Point(468, 248)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(140, 52)
        Me.lblTreatment.TabIndex = 85
        Me.lblTreatment.Text = "Treatment"
        Me.lblTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(495, 318)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 71)
        Me.btnReset.TabIndex = 86
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.btnDisplayPatient)
        Me.Controls.Add(Me.cboPatientID)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboAppointmentID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTreatmentID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Colour)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHomeTelephone)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.lblHomeTelephone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtDateOfBirth)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnAppointmentList)
        Me.Controls.Add(Me.btnPatientList)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.lstPatientsToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDSurname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDFirstName)
        Me.Controls.Add(Me.txtDTitle)
        Me.Controls.Add(Me.lblDTitle)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.picStaff)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picStaff As System.Windows.Forms.PictureBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblDTitle As System.Windows.Forms.Label
    Friend WithEvents txtDTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnPatientList As System.Windows.Forms.Button
    Friend WithEvents btnAppointmentList As System.Windows.Forms.Button
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents txtDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHomeTelephone As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstPatientsToday As System.Windows.Forms.ListBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Colour As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTreatmentID As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cboAppointmentID As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboPatientID As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisplayPatient As System.Windows.Forms.Button
    Friend WithEvents lblTreatment As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
