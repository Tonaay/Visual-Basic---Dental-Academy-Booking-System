<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointmentList))
        Me.cboAppointmentList = New System.Windows.Forms.ComboBox()
        Me.cboDentists = New System.Windows.Forms.ComboBox()
        Me.lblDTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboPatients = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoRoom1 = New System.Windows.Forms.RadioButton()
        Me.rdoRoom2 = New System.Windows.Forms.RadioButton()
        Me.rdoRoom3 = New System.Windows.Forms.RadioButton()
        Me.rdoRoom4 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtTreatmentDuration = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.btnDeleteAppointment = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.AppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.cboPatientID = New System.Windows.Forms.ComboBox()
        Me.cboDentistID = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cboTreatments = New System.Windows.Forms.ComboBox()
        Me.lblRoomID = New System.Windows.Forms.Label()
        Me.cboTreatmentID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboAppointmentList
        '
        Me.cboAppointmentList.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAppointmentList.FormattingEnabled = True
        Me.cboAppointmentList.Location = New System.Drawing.Point(15, 30)
        Me.cboAppointmentList.Name = "cboAppointmentList"
        Me.cboAppointmentList.Size = New System.Drawing.Size(45, 21)
        Me.cboAppointmentList.TabIndex = 3
        '
        'cboDentists
        '
        Me.cboDentists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDentists.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDentists.FormattingEnabled = True
        Me.cboDentists.Location = New System.Drawing.Point(74, 85)
        Me.cboDentists.Name = "cboDentists"
        Me.cboDentists.Size = New System.Drawing.Size(217, 21)
        Me.cboDentists.TabIndex = 4
        '
        'lblDTitle
        '
        Me.lblDTitle.AutoSize = True
        Me.lblDTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblDTitle.Name = "lblDTitle"
        Me.lblDTitle.Size = New System.Drawing.Size(87, 14)
        Me.lblDTitle.TabIndex = 35
        Me.lblDTitle.Text = "Appointments:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Dentists:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Treatments:"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(394, 28)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(71, 23)
        Me.btnEdit.TabIndex = 42
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(483, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(483, 66)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 40)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboPatients
        '
        Me.cboPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPatients.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPatients.FormattingEnabled = True
        Me.cboPatients.Location = New System.Drawing.Point(374, 137)
        Me.cboPatients.Name = "cboPatients"
        Me.cboPatients.Size = New System.Drawing.Size(223, 21)
        Me.cboPatients.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Patients:"
        '
        'btnHelp
        '
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(576, 21)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(38, 39)
        Me.btnHelp.TabIndex = 62
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Rooms:"
        '
        'rdoRoom1
        '
        Me.rdoRoom1.AutoSize = True
        Me.rdoRoom1.Location = New System.Drawing.Point(65, 193)
        Me.rdoRoom1.Name = "rdoRoom1"
        Me.rdoRoom1.Size = New System.Drawing.Size(82, 18)
        Me.rdoRoom1.TabIndex = 67
        Me.rdoRoom1.TabStop = True
        Me.rdoRoom1.Text = "1 - Fillings"
        Me.rdoRoom1.UseVisualStyleBackColor = True
        '
        'rdoRoom2
        '
        Me.rdoRoom2.AutoSize = True
        Me.rdoRoom2.Location = New System.Drawing.Point(65, 231)
        Me.rdoRoom2.Name = "rdoRoom2"
        Me.rdoRoom2.Size = New System.Drawing.Size(92, 18)
        Me.rdoRoom2.TabIndex = 68
        Me.rdoRoom2.TabStop = True
        Me.rdoRoom2.Text = "2 - Polishing"
        Me.rdoRoom2.UseVisualStyleBackColor = True
        '
        'rdoRoom3
        '
        Me.rdoRoom3.AutoSize = True
        Me.rdoRoom3.Location = New System.Drawing.Point(65, 273)
        Me.rdoRoom3.Name = "rdoRoom3"
        Me.rdoRoom3.Size = New System.Drawing.Size(105, 18)
        Me.rdoRoom3.TabIndex = 69
        Me.rdoRoom3.TabStop = True
        Me.rdoRoom3.Text = "3 - Dental Care"
        Me.rdoRoom3.UseVisualStyleBackColor = True
        '
        'rdoRoom4
        '
        Me.rdoRoom4.AutoSize = True
        Me.rdoRoom4.Location = New System.Drawing.Point(65, 313)
        Me.rdoRoom4.Name = "rdoRoom4"
        Me.rdoRoom4.Size = New System.Drawing.Size(83, 18)
        Me.rdoRoom4.TabIndex = 70
        Me.rdoRoom4.TabStop = True
        Me.rdoRoom4.Text = " 4 - Crowns"
        Me.rdoRoom4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 14)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Time:"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(453, 272)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(146, 22)
        Me.txtTime.TabIndex = 74
        '
        'txtTreatmentDuration
        '
        Me.txtTreatmentDuration.Location = New System.Drawing.Point(453, 307)
        Me.txtTreatmentDuration.Name = "txtTreatmentDuration"
        Me.txtTreatmentDuration.Size = New System.Drawing.Size(146, 22)
        Me.txtTreatmentDuration.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 14)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Treatment Duration:"
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAppointment.Location = New System.Drawing.Point(296, 367)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(145, 53)
        Me.btnAddAppointment.TabIndex = 77
        Me.btnAddAppointment.Text = "Add Appointment"
        Me.btnAddAppointment.UseVisualStyleBackColor = True
        '
        'btnDeleteAppointment
        '
        Me.btnDeleteAppointment.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAppointment.Location = New System.Drawing.Point(465, 367)
        Me.btnDeleteAppointment.Name = "btnDeleteAppointment"
        Me.btnDeleteAppointment.Size = New System.Drawing.Size(149, 53)
        Me.btnDeleteAppointment.TabIndex = 78
        Me.btnDeleteAppointment.Text = "Delete Appointment"
        Me.btnDeleteAppointment.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 399)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(111, 23)
        Me.btnBack.TabIndex = 79
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AppointmentDate
        '
        Me.AppointmentDate.Location = New System.Drawing.Point(453, 229)
        Me.AppointmentDate.MaxDate = New Date(2016, 12, 31, 0, 0, 0, 0)
        Me.AppointmentDate.MinDate = New Date(2016, 2, 16, 0, 0, 0, 0)
        Me.AppointmentDate.Name = "AppointmentDate"
        Me.AppointmentDate.Size = New System.Drawing.Size(146, 22)
        Me.AppointmentDate.TabIndex = 80
        '
        'cboPatientID
        '
        Me.cboPatientID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPatientID.FormattingEnabled = True
        Me.cboPatientID.Location = New System.Drawing.Point(315, 137)
        Me.cboPatientID.Name = "cboPatientID"
        Me.cboPatientID.Size = New System.Drawing.Size(44, 21)
        Me.cboPatientID.TabIndex = 81
        '
        'cboDentistID
        '
        Me.cboDentistID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDentistID.FormattingEnabled = True
        Me.cboDentistID.Location = New System.Drawing.Point(15, 85)
        Me.cboDentistID.Name = "cboDentistID"
        Me.cboDentistID.Size = New System.Drawing.Size(44, 21)
        Me.cboDentistID.TabIndex = 82
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(154, 379)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(118, 41)
        Me.btnRegister.TabIndex = 84
        Me.btnRegister.Text = "Create Appointment"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(77, 29)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(71, 23)
        Me.btnShow.TabIndex = 85
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cboTreatments
        '
        Me.cboTreatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTreatments.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTreatments.FormattingEnabled = True
        Me.cboTreatments.Items.AddRange(New Object() {"Fillings", "Polishing", "Patient Care", "Crowns"})
        Me.cboTreatments.Location = New System.Drawing.Point(74, 137)
        Me.cboTreatments.Name = "cboTreatments"
        Me.cboTreatments.Size = New System.Drawing.Size(217, 21)
        Me.cboTreatments.TabIndex = 5
        '
        'lblRoomID
        '
        Me.lblRoomID.AutoSize = True
        Me.lblRoomID.Location = New System.Drawing.Point(248, 195)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(43, 14)
        Me.lblRoomID.TabIndex = 86
        Me.lblRoomID.Text = "Label8"
        '
        'cboTreatmentID
        '
        Me.cboTreatmentID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTreatmentID.FormattingEnabled = True
        Me.cboTreatmentID.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboTreatmentID.Location = New System.Drawing.Point(16, 137)
        Me.cboTreatmentID.Name = "cboTreatmentID"
        Me.cboTreatmentID.Size = New System.Drawing.Size(44, 21)
        Me.cboTreatmentID.TabIndex = 87
        '
        'frmAppointmentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboTreatmentID)
        Me.Controls.Add(Me.lblRoomID)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cboDentistID)
        Me.Controls.Add(Me.cboPatientID)
        Me.Controls.Add(Me.AppointmentDate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeleteAppointment)
        Me.Controls.Add(Me.btnAddAppointment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTreatmentDuration)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdoRoom4)
        Me.Controls.Add(Me.rdoRoom3)
        Me.Controls.Add(Me.rdoRoom2)
        Me.Controls.Add(Me.rdoRoom1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPatients)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDTitle)
        Me.Controls.Add(Me.cboTreatments)
        Me.Controls.Add(Me.cboDentists)
        Me.Controls.Add(Me.cboAppointmentList)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppointmentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAppointmentList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAppointmentList As System.Windows.Forms.ComboBox
    Friend WithEvents cboDentists As System.Windows.Forms.ComboBox
    Friend WithEvents lblDTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboPatients As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdoRoom1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRoom2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRoom3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRoom4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTreatmentDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddAppointment As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAppointment As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents AppointmentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPatientID As System.Windows.Forms.ComboBox
    Friend WithEvents cboDentistID As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cboTreatments As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoomID As System.Windows.Forms.Label
    Friend WithEvents cboTreatmentID As System.Windows.Forms.ComboBox
End Class
