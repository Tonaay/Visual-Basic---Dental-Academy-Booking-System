Imports System.Data.SqlClient
Public Class frmAppointmentList
    'Sets the selected patient as an integer.'
    Dim SelectedPatient As Integer
    'Sets the selected dentist as an integer.'
    Dim SelectedDentist As Integer
    'This variable is used to count the rows in a dataset.'
    Dim CountRows As Integer
    'This variable is used loop until I can find the row I'm looking for.'
    Dim i As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'The current form will close.'
        Me.Close()
        'Returns to the menu form.'
        frmMenu.Show()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'The help button will display a message helping the user with the form.'
        MessageBox.Show("The appointment list can select each individual existing appointment in order to be edited. New appointments can be made by assigning a dentist to a patient and selecting the treatments and other details.")
    End Sub

    Private Sub cboPatients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPatients.SelectedIndexChanged
        'Sets the combo boxes to make the Patient's name match their ID.'
        SelectedPatient = cboPatients.SelectedIndex
        cboPatientID.SelectedIndex = cboPatients.SelectedIndex
    End Sub

    Private Sub cboDentists_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDentists.SelectedIndexChanged
        'Sets the combo boxes to make the Dentist's name match their ID.'
        SelectedPatient = cboDentists.SelectedIndex
        cboDentistID.SelectedIndex = cboDentists.SelectedIndex
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Enables combo boxes.'
        cboDentists.Enabled = True
        cboPatients.Enabled = True
        cboAppointmentList.Enabled = False
        'Disables show and edit buttons.'
        btnShow.Enabled = False
        btnEdit.Enabled = False
        'Enabled save button.'
        btnSave.Enabled = True
        'Prevents appointments being deleted while editing.'
        btnDeleteAppointment.Enabled = False
        'Makes combo box for treatments enabled.'
        cboTreatments.Enabled = True
        'Makes text fields editable again.'
        txtTime.ReadOnly = False
        'Date enabled.'
        AppointmentDate.Enabled = True
        'All radio buttons are enabled.'
        rdoRoom1.Enabled = True
        rdoRoom2.Enabled = True
        rdoRoom3.Enabled = True
        rdoRoom4.Enabled = True

    End Sub

    Private Sub frmAppointmentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'Combobox for ID's are disabled.'
        cboTreatmentID.Enabled = False
        lblRoomID.Visible = False
        'combo boxes are set to blank.'
        cboAppointmentList.SelectedIndex = -1
        cboDentists.SelectedIndex = -1
        cboPatients.SelectedIndex = -1
        cboTreatments.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAddAppointment.Enabled = False
        btnDeleteAppointment.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'Appointment lists are enabled.'
        cboAppointmentList.Enabled = True
        'The show, cancel and register buttons are enabled.'
        btnShow.Enabled = True
        btnCancel.Enabled = True
        btnRegister.Enabled = True
        'All other combo boxes are disabled.'
        cboDentistID.Enabled = False
        cboPatientID.Enabled = False
        cboPatients.Enabled = False
        cboDentists.Enabled = False
        cboTreatments.Enabled = False
        'Text fields are set to read only to prevent editing.'
        txtTime.ReadOnly = True
        txtTreatmentDuration.ReadOnly = True
        AppointmentDate.Enabled = False
        'All radio buttons are disabled and unchecked.'
        rdoRoom1.Enabled = False
        rdoRoom2.Enabled = False
        rdoRoom3.Enabled = False
        rdoRoom4.Enabled = False
        rdoRoom1.Checked = False
        rdoRoom2.Checked = False
        rdoRoom3.Checked = False
        rdoRoom4.Checked = False

        'All combo boxes and text fields are cleared.'
        cboDentistID.Items.Clear()
        cboPatientID.Items.Clear()
        cboDentists.Items.Clear()
        cboPatients.Items.Clear()
        cboAppointmentList.Items.Clear()
        'Appointment date set to today by default.'
        AppointmentDate.Text = Date.Today
        txtTime.Clear()
        txtTreatmentDuration.Clear()

        'This statement will load all dentists into the combo box for the dentists ID and first names.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentists").Clear()

        Catch ex As Exception

        End Try
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        Countrows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            cboDentistID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentists.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

        'This SQL statement will load all the patient's ID and first name into the combo boxes.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblPatientName")
        Countrows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            cboPatientID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatients.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next

        'This SQL statement will load all the booking appointment ID's into the combo box.'
        Sql = "SELECT * FROM tblBooking"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblBooking").Clear()

        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblNewBooking").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblNewBooking")
        CountRows = ds.Tables("tblNewBooking").Rows.Count
        For i = 0 To ds.Tables("tblNewBooking").Rows.Count - 1
            cboAppointmentList.Items.Add(ds.Tables("tblNewBooking").Rows(i).Item("AppointmentID"))
        Next



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'Combobox for ID's are disabled.'
        cboTreatmentID.Enabled = False
        lblRoomID.Visible = False
        'combo boxes are set to blank.'
        cboAppointmentList.SelectedIndex = -1
        cboDentists.SelectedIndex = -1
        cboPatients.SelectedIndex = -1
        cboTreatments.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAddAppointment.Enabled = False
        btnDeleteAppointment.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'Appointment lists are enabled.'
        cboAppointmentList.Enabled = True
        'The show, cancel and register buttons are enabled.'
        btnShow.Enabled = True
        btnCancel.Enabled = True
        btnRegister.Enabled = True
        'All other combo boxes are disabled.'
        cboDentistID.Enabled = False
        cboPatientID.Enabled = False
        cboPatients.Enabled = False
        cboDentists.Enabled = False
        cboTreatments.Enabled = False
        'Text fields are set to read only to prevent editing.'
        txtTime.ReadOnly = True
        txtTreatmentDuration.ReadOnly = True
        AppointmentDate.Enabled = False
        'All radio buttons are disabled and unchecked.'
        rdoRoom1.Enabled = False
        rdoRoom2.Enabled = False
        rdoRoom3.Enabled = False
        rdoRoom4.Enabled = False
        rdoRoom1.Checked = False
        rdoRoom2.Checked = False
        rdoRoom3.Checked = False
        rdoRoom4.Checked = False

        'All combo boxes and text fields are cleared.'
        cboDentistID.Items.Clear()
        cboPatientID.Items.Clear()
        cboDentists.Items.Clear()
        cboPatients.Items.Clear()
        cboAppointmentList.Items.Clear()
        'Appointment date set to today by default.'
        AppointmentDate.Text = Date.Today
        txtTime.Clear()
        txtTreatmentDuration.Clear()

        'This statement will load all dentists into the combo box for the dentists ID and first names.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentists").Clear()

        Catch ex As Exception

        End Try
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        CountRows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            cboDentistID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentists.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

        'This SQL statement will load all the patient's ID and first name into the combo boxes.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            cboPatientID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatients.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next

        'This SQL statement will load all the booking appointment ID's into the combo box.'
        Sql = "SELECT * FROM tblBooking"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblBooking").Clear()

        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblNewBooking").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblNewBooking")
        CountRows = ds.Tables("tblNewBooking").Rows.Count
        For i = 0 To ds.Tables("tblNewBooking").Rows.Count - 1
            cboAppointmentList.Items.Add(ds.Tables("tblNewBooking").Rows(i).Item("AppointmentID"))
        Next

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'Sets the combo box to blank.'
        cboAppointmentList.SelectedIndex = -1
        'Combo box for appointment list is disabled.'
        cboAppointmentList.Enabled = False
        'Show, edit and save buttons are disabled.'
        btnShow.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'Add button is enabled.'
        btnAddAppointment.Enabled = True
        'Delete buttons are disabled.'
        btnDeleteAppointment.Enabled = False
        'The combo boxes and text fields are enable and editable.'
        cboDentists.Enabled = True
        cboPatients.Enabled = True
        cboTreatments.Enabled = True
        txtTime.ReadOnly = False
        txtTreatmentDuration.ReadOnly = True
        AppointmentDate.Enabled = True


    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'Validation variable used to make sure there is a value in the combo box.'
        AllFieldsValid = True
        'Sets selected appointment as an integer.'
        Dim SelectedAppointment As Integer
        'Validation for presence check for the combo box containing the appointment lists.'
        If cboAppointmentList.Text = "" Then
            MessageBox.Show("Please select an appointment")
            'Passes the validation as false.'
            AllFieldsValid = False
        End If
        'When the validation is correct.'
        If AllFieldsValid = True Then
            'Combo box for appointment list is set as an integer.'
            SelectedAppointment = cboAppointmentList.Text

            Try
                'Clears the dataset.'
                ds.Tables("tblSelectedAppointment").Clear()
            Catch ex As Exception

            End Try

            Try
                'Clears the dataset for dentists name.'
                ds.Tables("tblDentistName").Clear()
            Catch ex As Exception

            End Try
            'Makes sure all ID's are set as an integer.'
            Dim ID As Integer
            Dim PatientID As Integer

            'SQL statement selecting all rows where the appointment ID matches the value in the combo box.'
            Sql = "SELECT * FROM tblBooking WHERE AppointmentID = " & SelectedAppointment & ""
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblSelectedAppointment")

            'All the appointment details are loaded onto the text fields.'
            AppointmentDate.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("AppointmentDate")
            txtTime.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("AppointmentTime")
            cboTreatmentID.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("TreatmentID")
            txtTreatmentDuration.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("TreatmentDuration")
            cboDentistID.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("DentistID")
            cboPatientID.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("PatientID")
            lblRoomID.Text = ds.Tables("tblSelectedAppointment").Rows(0).Item("RoomID")
            ID = ds.Tables("tblSelectedAppointment").Rows(0).Item("DentistID")
            PatientID = ds.Tables("tblSelectedAppointment").Rows(0).Item("PatientID")

            'This checks one of the radio buttons according to the value of the label text.'
            Select Case CInt(lblRoomID.Text)
                Case 2
                    rdoRoom1.Checked = True
                Case 3
                    rdoRoom2.Checked = True
                Case 4
                    rdoRoom3.Checked = True
                Case 5
                    rdoRoom4.Checked = True
            End Select

            'SQL statement selecting the dentist from the combo box containing the loaded ID from the selected appointment.'
            Sql = "SELECT * FROM tblDentists WHERE DentistID = " & ID
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "DentistName")
            'Loads first name onto combo box.'
            cboDentists.Text = ds.Tables("DentistName").Rows(0).Item("DFirstName")

            'SQL statement selecting the patient from the combo box containing the loaded ID from the selected appointment.'
            Sql = "SELECT * FROM tblPatients WHERE PatientID = " & PatientID
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "PatientName")
            'Loads first name onto combo box.'
            cboPatients.Text = ds.Tables("PatientName").Rows(0).Item("FirstName")

            Try
                'Clears the dataset.'
                ds.Tables("DentistName").Clear()
            Catch ex As Exception

            End Try

            Try
                'Clears the dataset.'
                ds.Tables("PatientName").Clear()
            Catch ex As Exception

            End Try

            'Disables the show button and combo box for the appointment list.'
            btnShow.Enabled = False
            cboAppointmentList.Enabled = False
            'Enables edit and delete buttons.'
            'Disables save, add and register buttons.'
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnDeleteAppointment.Enabled = True
            btnAddAppointment.Enabled = False
            btnRegister.Enabled = False
        End If
    End Sub

    Private Sub cboTreatments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTreatments.SelectedIndexChanged

        'I create a case statement in order to change the text in the treatment duration field so that it matches the treatment when the treatment type is selected.'
        Select Case cboTreatments.SelectedItem
            'If Fillings is selected the duration will be 30 minutes.'
            Case "Fillings"
                txtTreatmentDuration.Text = "30"
                rdoRoom1.Checked = True
                lblRoomID.Text = "2"
                cboTreatmentID.Text = "1"
                'If Polishing is selected the duration will be 60 minutes.'
            Case "Polishing"
                txtTreatmentDuration.Text = "60"
                rdoRoom2.Checked = True
                lblRoomID.Text = "3"
                cboTreatmentID.Text = "2"
                'If Patient Care is selected the duration will be 60 minutes.'
            Case "Patient Care"
                txtTreatmentDuration.Text = "60"
                rdoRoom3.Checked = True
                lblRoomID.Text = "4"
                cboTreatmentID.Text = "3"
                'If Crowns is selected the duration will be 60 minutes.'
            Case "Crowns"
                txtTreatmentDuration.Text = "60"
                rdoRoom4.Checked = True
                lblRoomID.Text = "5"
                cboTreatmentID.Text = "4"
                'I make sure that the text box is cleared when the cbo field is empty.'
            Case cboTreatments.SelectedIndex = -1
                txtTreatmentDuration.Clear()

        End Select
    End Sub

    Private Sub btnAddAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAppointment.Click
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'Calls in validation function for the text fields and combo boxes.'
        If ValidateFields(txtTime, cboDentists, cboPatients) = True Then
            Dim Sql As String = ""

            Try
                'Dataset is cleared.'
                ds.Tables("tblBooking").Clear()
            Catch ex As Exception
            End Try

            Try
                'Dataset is cleared.'
                ds.Tables("tblNewBooking").Clear()
            Catch ex As Exception
            End Try

            'SQL to create a new row in the booking table.'
            Sql = "Select * from tblBooking"
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblBooking")
            Dim cb As New SqlCommandBuilder(da)
            Dim dsNewRow As DataRow
            'New row in dataset.'
            dsNewRow = ds.Tables("tblBooking").NewRow()

            'Each radio button has a set ID.'
            If rdoRoom1.Checked = True Then
                dsNewRow.Item("RoomID") = 2
            ElseIf rdoRoom2.Checked = True Then
                dsNewRow.Item("RoomID") = 3
            ElseIf rdoRoom3.Checked = True Then
                dsNewRow.Item("RoomID") = 4
            ElseIf rdoRoom4.Checked = True Then
                dsNewRow.Item("RoomID") = 5
            End If

            'All details are added as a new row from the text fields.'
            dsNewRow.Item("AppointmentDate") = AppointmentDate.Value
            dsNewRow.Item("AppointmentTime") = txtTime.Text
            dsNewRow.Item("PatientID") = CInt(cboPatientID.Text)
            dsNewRow.Item("DentistID") = CInt(cboDentistID.Text)
            dsNewRow.Item("TreatmentID") = CInt(cboTreatmentID.Text)
            dsNewRow.Item("TreatmentDuration") = CInt(txtTreatmentDuration.Text)

            'New row added.'
            ds.Tables("tblBooking").Rows.Add(dsNewRow)
            'Dataset is updated.'
            da.Update(ds, "tblBooking")
            'Closes the connection.'
            dbconn.Close()
            'Message box showing the appointment has been successfully booked.'
            MessageBox.Show("Your appointment has been booked onto the system.")

            'This variable is used to count the rows in a dataset.'
            Dim CountRows As Integer
            'This variable is used loop until I can find the row I'm looking for.'
            'Combobox for ID's are disabled.'
            cboTreatmentID.Enabled = False
            lblRoomID.Visible = False
            'combo boxes are set to blank.'
            cboAppointmentList.SelectedIndex = -1
            cboDentists.SelectedIndex = -1
            cboPatients.SelectedIndex = -1
            cboTreatments.SelectedIndex = -1
            'Add, delete, edit and save buttons are disabled.'
            btnAddAppointment.Enabled = False
            btnDeleteAppointment.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = False
            'Appointment lists are enabled.'
            cboAppointmentList.Enabled = True
            'The show, cancel and register buttons are enabled.'
            btnShow.Enabled = True
            btnCancel.Enabled = True
            btnRegister.Enabled = True
            'All other combo boxes are disabled.'
            cboDentistID.Enabled = False
            cboPatientID.Enabled = False
            cboPatients.Enabled = False
            cboDentists.Enabled = False
            cboTreatments.Enabled = False
            'Text fields are set to read only to prevent editing.'
            txtTime.ReadOnly = True
            txtTreatmentDuration.ReadOnly = True
            AppointmentDate.Enabled = False
            'All radio buttons are disabled and unchecked.'
            rdoRoom1.Enabled = False
            rdoRoom2.Enabled = False
            rdoRoom3.Enabled = False
            rdoRoom4.Enabled = False
            rdoRoom1.Checked = False
            rdoRoom2.Checked = False
            rdoRoom3.Checked = False
            rdoRoom4.Checked = False

            'All combo boxes and text fields are cleared.'
            cboDentistID.Items.Clear()
            cboPatientID.Items.Clear()
            cboDentists.Items.Clear()
            cboPatients.Items.Clear()
            cboAppointmentList.Items.Clear()
            'Appointment date set to today by default.'
            AppointmentDate.Text = Date.Today
            txtTime.Clear()
            txtTreatmentDuration.Clear()

            'This statement will load all dentists into the combo box for the dentists ID and first names.'
            Sql = "SELECT * FROM tblDentists"
            da = New SqlDataAdapter(Sql, dbconn)

            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblDentists").Clear()

            Catch ex As Exception

            End Try
            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblDentistsName").Clear()
            Catch ex As Exception

            End Try
            da.Fill(ds, "tblDentistsName")
            CountRows = ds.Tables("tblDentistsName").Rows.Count
            For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
                cboDentistID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
                cboDentists.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
            Next

            'This SQL statement will load all the patient's ID and first name into the combo boxes.'
            Sql = "SELECT * FROM tblPatients"
            da = New SqlDataAdapter(Sql, dbconn)

            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblPatients").Clear()
            Catch ex As Exception

            End Try

            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblPatientName").Clear()
            Catch ex As Exception

            End Try

            da.Fill(ds, "tblPatientName")
            CountRows = ds.Tables("tblPatientName").Rows.Count
            For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
                cboPatientID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
                cboPatients.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
            Next

            'This SQL statement will load all the booking appointment ID's into the combo box.'
            Sql = "SELECT * FROM tblBooking"
            da = New SqlDataAdapter(Sql, dbconn)
            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblBooking").Clear()

            Catch ex As Exception

            End Try

            Try
                'Dataset is cleared first before retrieving the updated list.'
                ds.Tables("tblNewBooking").Clear()
            Catch ex As Exception

            End Try

            da.Fill(ds, "tblNewBooking")
            CountRows = ds.Tables("tblNewBooking").Rows.Count
            For i = 0 To ds.Tables("tblNewBooking").Rows.Count - 1
                cboAppointmentList.Items.Add(ds.Tables("tblNewBooking").Rows(i).Item("AppointmentID"))
            Next

        End If

    End Sub
    Public Function ValidateFields(ByVal txtTime As TextBox, ByVal cboDentists As ComboBox, ByVal cboPatients As ComboBox) As Boolean
        AllFieldsValid = True
        'Using this line of validation, I can do a visible check on the all the text boxes I need without having to make seperate lines for each visible check.'
        If txtTime.Text = "" Or txtTreatmentDuration.Text = "" Or cboDentists.Text = "" Or cboPatients.Text = "" Then
            MessageBox.Show("Blank box detected. Please fill in all required fields.")
            AllFieldsValid = False
        End If
        If AllFieldsValid = True Then

            'If this boolean value is true then It will return the function as true which can be called in the login button.'
            ValidateFields = True
        Else
            'The value is returned as false therefore the user cannot proceed to the next form.'
            ValidateFields = False
        End If
    End Function


    Private Sub cboTreatmentID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTreatmentID.SelectedIndexChanged
        'Sets the treatment text to different treatments depending on what the ID is set to.'
        If cboTreatmentID.Text = "1" Then
            cboTreatments.Text = "Fillings"
        ElseIf cboTreatmentID.Text = "2" Then
            cboTreatments.Text = "Polishing"
        ElseIf cboTreatmentID.Text = "3" Then
            cboTreatments.Text = "Patient Care"
        ElseIf cboTreatmentID.Text = "4" Then
            cboTreatments.Text = "Crowns"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'I dim 'response' as a message result in order to bring up an input box for the user to decide if they are certain to proceed.'
        Dim response As MsgBoxResult
        'Sets the selected appointment as an integer.'
        Dim SelectedAppointment As Integer
        'Sets the combo box as an integer.'
        SelectedAppointment = cboAppointmentList.Text
        'This is the repsonse used to decide if the user wants to proceed.'
        response = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        'If the response is yes then validation is called.'
        If response = MsgBoxResult.Yes Then
            If ValidateFields(txtTime, cboDentists, cboPatients) = True Then
                'SQL statement selecting the row from the appointment ID in the combo box.'
                Sql = "SELECT * FROM tblBooking WHERE AppointmentID = " & SelectedAppointment
                da = New SqlDataAdapter(Sql, dbconn)
                'Dataset is filled with updated data.'
                da.Fill(ds, "tblAppointmentUpdate")

                Dim cb As New SqlCommandBuilder(da)
                'Updated data is saved back into the row from the textfields.'
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("AppointmentDate") = AppointmentDate.Value
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("AppointmentTime") = txtTime.Text
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("PatientID") = cboPatientID.Text
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("DentistID") = cboDentistID.Text
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("RoomID") = lblRoomID.Text
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("TreatmentID") = cboTreatmentID.Text
                ds.Tables("tblAppointmentUpdate").Rows(0).Item("TreatmentDuration") = txtTreatmentDuration.Text
                'Dataset is updated.'
                da.Update(ds, "tblAppointmentUpdate")
                'Message boxes to show if the update was successful or not.'
                MessageBox.Show("Details have been saved and updated")
            Else
                MessageBox.Show("Invalid Row, no changes made.")
            End If
        End If

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'Combobox for ID's are disabled.'
        cboTreatmentID.Enabled = False
        lblRoomID.Visible = False
        'combo boxes are set to blank.'
        cboAppointmentList.SelectedIndex = -1
        cboDentists.SelectedIndex = -1
        cboPatients.SelectedIndex = -1
        cboTreatments.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAddAppointment.Enabled = False
        btnDeleteAppointment.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'Appointment lists are enabled.'
        cboAppointmentList.Enabled = True
        'The show, cancel and register buttons are enabled.'
        btnShow.Enabled = True
        btnCancel.Enabled = True
        btnRegister.Enabled = True
        'All other combo boxes are disabled.'
        cboDentistID.Enabled = False
        cboPatientID.Enabled = False
        cboPatients.Enabled = False
        cboDentists.Enabled = False
        cboTreatments.Enabled = False
        'Text fields are set to read only to prevent editing.'
        txtTime.ReadOnly = True
        txtTreatmentDuration.ReadOnly = True
        AppointmentDate.Enabled = False
        'All radio buttons are disabled and unchecked.'
        rdoRoom1.Enabled = False
        rdoRoom2.Enabled = False
        rdoRoom3.Enabled = False
        rdoRoom4.Enabled = False
        rdoRoom1.Checked = False
        rdoRoom2.Checked = False
        rdoRoom3.Checked = False
        rdoRoom4.Checked = False

        'All combo boxes and text fields are cleared.'
        cboDentistID.Items.Clear()
        cboPatientID.Items.Clear()
        cboDentists.Items.Clear()
        cboPatients.Items.Clear()
        cboAppointmentList.Items.Clear()
        'Appointment date set to today by default.'
        AppointmentDate.Text = Date.Today
        txtTime.Clear()
        txtTreatmentDuration.Clear()

        'This statement will load all dentists into the combo box for the dentists ID and first names.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentists").Clear()

        Catch ex As Exception

        End Try
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        CountRows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            cboDentistID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentists.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

        'This SQL statement will load all the patient's ID and first name into the combo boxes.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            cboPatientID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatients.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next

        'This SQL statement will load all the booking appointment ID's into the combo box.'
        Sql = "SELECT * FROM tblBooking"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblBooking").Clear()

        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblNewBooking").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblNewBooking")
        CountRows = ds.Tables("tblNewBooking").Rows.Count
        For i = 0 To ds.Tables("tblNewBooking").Rows.Count - 1
            cboAppointmentList.Items.Add(ds.Tables("tblNewBooking").Rows(i).Item("AppointmentID"))
        Next


    End Sub

    Private Sub btnDeleteAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAppointment.Click
        'Sets the appointment as an integer.'
        Dim SelectedAppointment As Integer
        'Sets the combo box as an integer.'
        SelectedAppointment = cboAppointmentList.Text

        Try
            'Clears the dataset.'
            ds.Tables("tblBooking").Clear()
        Catch ex As Exception

        End Try

        'Selects the whole row where the appointment ID matches the combo box.'
        Sql = "DELETE FROM tblBooking WHERE AppointmentID = " & SelectedAppointment & ""

        da = New SqlDataAdapter(Sql, dbconn)
        'Record is deleted.'
        da.Fill(ds, "tblBooking")

        MessageBox.Show("Record deleted")



        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'Combobox for ID's are disabled.'
        cboTreatmentID.Enabled = False
        lblRoomID.Visible = False
        'combo boxes are set to blank.'
        cboAppointmentList.SelectedIndex = -1
        cboDentists.SelectedIndex = -1
        cboPatients.SelectedIndex = -1
        cboTreatments.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAddAppointment.Enabled = False
        btnDeleteAppointment.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'Appointment lists are enabled.'
        cboAppointmentList.Enabled = True
        'The show, cancel and register buttons are enabled.'
        btnShow.Enabled = True
        btnCancel.Enabled = True
        btnRegister.Enabled = True
        'All other combo boxes are disabled.'
        cboDentistID.Enabled = False
        cboPatientID.Enabled = False
        cboPatients.Enabled = False
        cboDentists.Enabled = False
        cboTreatments.Enabled = False
        'Text fields are set to read only to prevent editing.'
        txtTime.ReadOnly = True
        txtTreatmentDuration.ReadOnly = True
        AppointmentDate.Enabled = False
        'All radio buttons are disabled and unchecked.'
        rdoRoom1.Enabled = False
        rdoRoom2.Enabled = False
        rdoRoom3.Enabled = False
        rdoRoom4.Enabled = False
        rdoRoom1.Checked = False
        rdoRoom2.Checked = False
        rdoRoom3.Checked = False
        rdoRoom4.Checked = False

        'All combo boxes and text fields are cleared.'
        cboDentistID.Items.Clear()
        cboPatientID.Items.Clear()
        cboDentists.Items.Clear()
        cboPatients.Items.Clear()
        cboAppointmentList.Items.Clear()
        'Appointment date set to today by default.'
        AppointmentDate.Text = Date.Today
        txtTime.Clear()
        txtTreatmentDuration.Clear()

        'This statement will load all dentists into the combo box for the dentists ID and first names.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentists").Clear()

        Catch ex As Exception

        End Try
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        CountRows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            cboDentistID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentists.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

        'This SQL statement will load all the patient's ID and first name into the combo boxes.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            cboPatientID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatients.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next

        'This SQL statement will load all the booking appointment ID's into the combo box.'
        Sql = "SELECT * FROM tblBooking"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblBooking").Clear()

        Catch ex As Exception

        End Try

        Try
            'Dataset is cleared first before retrieving the updated list.'
            ds.Tables("tblNewBooking").Clear()
        Catch ex As Exception

        End Try

        da.Fill(ds, "tblNewBooking")
        CountRows = ds.Tables("tblNewBooking").Rows.Count
        For i = 0 To ds.Tables("tblNewBooking").Rows.Count - 1
            cboAppointmentList.Items.Add(ds.Tables("tblNewBooking").Rows(i).Item("AppointmentID"))
        Next
    End Sub
End Class