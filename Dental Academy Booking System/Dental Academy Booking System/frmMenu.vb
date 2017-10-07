Imports System.Data.SqlClient
Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer
        'This makes sure that the label is invisible. This is used as an indicator for the image to change to a specific image.'
        Colour.Visible = False
        'Makes sure that the button reset cannot be pressed when the form loads.'
        btnReset.Enabled = False
        'Makes sure that the record cannot be deleted as there would be no information to delete.'
        btnComplete.Enabled = False
        'Makes sure that the ID is equal the integer in the module, so when the user logs in, it will be displayed in the textfield.'
        txtID.Text = DentistID
        'This section loads all the data from the selected dentist into the textfields.'
        txtDTitle.Text = ds.Tables("tblDentists").Rows(0).Item("DTitle")
        txtDFirstName.Text = ds.Tables("tblDentists").Rows(0).Item("DFirstName")
        txtDSurname.Text = ds.Tables("tblDentists").Rows(0).Item("DSurname")
        Colour.Text = ds.Tables("tblDentists").Rows(0).Item("DColour")

        'After label has changed text from the dataset, the text will change what the picture represents in the case statement.'
        Select Case Colour.Text.ToString
            Case "Green"
                picStaff.Image = My.Resources.picStudent
            Case "Blue"
                picStaff.Image = My.Resources.picDentalNurse
            Case "Red"
                picStaff.Image = My.Resources.picTutor
        End Select

        'This Selects the row from the booking table where the dentist ID matches the dentist that logs in and loads all their appointments onto a list box and combo box.'
        Sql = "SELECT * FROM tblBooking Where DentistID = " & DentistID
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblAppointmentListings")
        CountRows = ds.Tables("tblAppointmentListings").Rows.Count
        For i = 0 To CountRows - 1
            lstPatientsToday.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentDate") & "      :      " & (ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentTime")))
            cboAppointmentID.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentID"))
        Next
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOff.Click
        'This will close the form making sure that any details are cleared.'
        Me.Close()
        'The login form will show again.'
        frmLogin.Show()
        'Clears the textfields in the login form so that the next user who logs on will not be able to log into another users account.'
        frmLogin.txtUserID.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.txtAdminPassword.Clear()
        'Makes sure that the dentist details are cleared from the menu form.'
        txtID.Clear()
        txtDTitle.Clear()
        txtDFirstName.Clear()
        txtDSurname.Clear()
        'Makes sure the dataset is cleared so that a new user can load their details.'
        Try
            If ds.Tables("tblDentists").Rows.Count > 0 Then
                ds.Tables("tblDentists").Clear()
            End If
        Catch ex As Exception
            'Ignore error if dataset doesn't exist.'
        End Try

    End Sub

    Private Sub btnPatientList_Click(sender As System.Object, e As System.EventArgs) Handles btnPatientList.Click
        'Hides the current form.'
        Me.Hide()
        'Shows the patient list form.'
        frmPatientList.Show()
    End Sub

    Private Sub btnAppointmentList_Click(sender As System.Object, e As System.EventArgs) Handles btnAppointmentList.Click
        'Hides the current form.'
        Me.Hide()
        'Shows the appointment list form.'
        frmAppointmentList.Show()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'Help box to show how to use the current form.'
        MessageBox.Show("Your appointments will have loaded onto the list boxes. Please select an individual appointment in order to view details and confirm completion. You can also access the Patient list and Appointment list form.")
    End Sub

  
    Private Sub picStaff_Click(sender As System.Object, e As System.EventArgs) Handles picStaff.Click

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Clears the list box and appointment combobox.'
        lstPatientsToday.Items.Clear()
        cboAppointmentID.Items.Clear()
        'Makes sure the combo box is blank.'
        cboAppointmentID.SelectedIndex = -1
 
        Try
            'Makes sure that if there is any data in the dataset. If there is, it will be cleared.'
            If ds.Tables("tblAppointmentListings").Rows.Count > 0 Then
                ds.Tables("tblAppointmentListings").Clear()
            End If
        Catch ex As Exception
            'Ignore error if dataset doesn't exist.'
        End Try
        'Sql statement selecting the dentist ID from the booking table which will load the dentists appointments onto the combo box and list box.'
    Sql = "SELECT * FROM tblBooking Where DentistID = " & DentistID
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblAppointmentListings")
        CountRows = ds.Tables("tblAppointmentListings").Rows.Count
        For i = 0 To CountRows - 1
            lstPatientsToday.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentDate") & "      :      " & (ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentTime")))
            cboAppointmentID.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentID"))
        Next
    End Sub

    Private Sub cboAppointmentID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAppointmentID.SelectedIndexChanged
        'If a ID is selected from the combo box. the refresh button will be disabled to prevent refreshing the dataset while it is in use.'
        btnRefresh.Enabled = False
    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        'This makes sure that the ID for the appointment and patients are an integer.'
        Dim SelectedAppointmentID As Integer
        Dim SelectedPatientID As Integer
        'Enables the button to display the patients details.'
        btnDisplayPatient.Enabled = True
        'Makes sure that the combo box values are an integer.'
        SelectedPatientID = cboPatientID.SelectedItem
        SelectedAppointmentID = cboAppointmentID.SelectedItem
        'Disables the display button so you can't retrieve the same details again.'
        btnDisplay.Enabled = False
        'Validation check to make sure that there is data in the combo boxes.'
        AllFieldsValid = True
        If cboAppointmentID.Text = "" Then
            MessageBox.Show("Please select a member")
            AllFieldsValid = False
        End If

        If AllFieldsValid = True Then
            'Selects the appointment ID from the booking table and loads data such as date and time from the booking to the text fields.'
            Sql = "SELECT * FROM tblBooking WHERE AppointmentID = " & SelectedAppointmentID & ""
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblSelectedPatientID")

            cboPatientID.Text = ds.Tables("tblSelectedPatientID").Rows(0).Item("PatientID")
            lblTime.Text = ds.Tables("tblSelectedPatientID").Rows(0).Item("AppointmentTime")
            lblDate.Text = ds.Tables("tblSelectedPatientID").Rows(0).Item("AppointmentDate")
            lblDuration.Text = ds.Tables("tblSelectedPatientID").Rows(0).Item("TreatmentDuration")
            lblTreatmentID.Text = ds.Tables("tblSelectedPatientID").Rows(0).Item("TreatmentID")

            'Makes sure that the user can't redisplay the same details.'
            btnDisplay.Enabled = False
        End If
    End Sub

    Private Sub btnDisplayPatient_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplayPatient.Click
        'This makes sure that the ID for the appointment, patients and treatments.'
        Dim SelectedAppointmentID As Integer
        Dim SelectedPatientID As Integer
        Dim SelectedTreatment As Integer
        'Disables the display patient button.'
        btnDisplayPatient.Enabled = False
        'Makes the comboboxes and label fields for the ID an integer.'
        SelectedPatientID = cboPatientID.Text
        SelectedAppointmentID = cboAppointmentID.SelectedItem
        SelectedTreatment = lblTreatmentID.Text
        'Makes sure the buttons for resetting the fields and deleting the appointments are enabled.'
        btnReset.Enabled = True
        btnComplete.Enabled = True

        'This sequel statement will select the patients ID from the patients table and display all their details on the text fields.'
        Sql = "SELECT * FROM tblPatients WHERE PatientID = " & SelectedPatientID
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblPatientSelected")

        txtTitle.Text = ds.Tables("tblPatientSelected").Rows(0).Item("Title")
        txtFirstName.Text = ds.Tables("tblPatientSelected").Rows(0).Item("FirstName")
        txtSurname.Text = ds.Tables("tblPatientSelected").Rows(0).Item("Surname")
        txtDateOfBirth.Text = ds.Tables("tblPatientSelected").Rows(0).Item("DateOfBirth")
        txtPhoneNumber.Text = ds.Tables("tblPatientSelected").Rows(0).Item("PhoneNumber")
        txtHomeTelephone.Text = ds.Tables("tblPatientSelected").Rows(0).Item("HomeNumber")

        'This statement will select all the treatments from the ID and displays the treatment type from that ID.'
        Sql = "SELECT * FROM tblTreatment WHERE TreatmentID = " & SelectedTreatment
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblTreatmentSelected")
        lblTreatment.Text = ds.Tables("tblTreatmentSelected").Rows(0).Item("TreatmentType")

    End Sub

    Private Sub btnComplete_Click(sender As System.Object, e As System.EventArgs) Handles btnComplete.Click
        'Makes the Selected appointment ID and integer.'
        Dim SelectedAppointment As Integer
        SelectedAppointment = cboAppointmentID.Text

        'Clears the dataset.'
        Try
            ds.Tables("tblBooking").Clear()
        Catch ex As Exception

        End Try

        'Statement to delete the row from the booking table where the ID is equal to the selected appointment.'
        Sql = "DELETE FROM tblBooking WHERE AppointmentID = " & SelectedAppointment & ""

        da = New SqlDataAdapter(Sql, dbconn)

        da.Fill(ds, "tblBooking")

        MessageBox.Show("Record deleted")

        'Same code as reset.'
        Dim CountRows As Integer
        Dim i As Integer

        'Clearing all text fields and combo fields resetting.'
        cboAppointmentID.SelectedIndex = -1
        cboPatientID.SelectedIndex = -1
        cboAppointmentID.Items.Clear()
        cboPatientID.Items.Clear()
        cboPatientID.Text = ""

        txtTitle.Clear()
        txtFirstName.Clear()
        txtSurname.Clear()
        txtPhoneNumber.Clear()
        txtHomeTelephone.Clear()
        txtDateOfBirth.Clear()
        'Makes sure labels are reset to what they were originally.'
        lblTreatment.Text = "Treatment"
        lblTreatmentID.Text = "Treatment ID"
        lblTime.Text = "00:00"
        lblDate.Text = "DD/MM/YYYY"
        lblDuration.Text = "00"

        'Clears the list box.'
        lstPatientsToday.Items.Clear()

        'Clears the appointment listings.'
        If ds.Tables("tblAppointmentListings").Rows.Count > 0 Then
            Try
                ds.Tables("tblAppointmentListings").Clear()
            Catch ex As Exception

            End Try
        End If
        'Clears the tables for the selected patient.'
        If ds.Tables("tblSelectedPatientID").Rows.Count > 0 Then
            Try
                ds.Tables("tblSelectedPatientID").Clear()
            Catch ex As Exception

            End Try
        End If
        'Clears the dataset for the patients details.'
        If ds.Tables("tblPatientSelected").Rows.Count > 0 Then
            Try
                ds.Tables("tblPatientSelected").Clear()
            Catch ex As Exception

            End Try
        End If
        'Clears the dataset for the selected treatment.'
        If ds.Tables("tblTreatmentSelected").Rows.Count > 0 Then
            Try
                ds.Tables("tblTreatmentSelected").Clear()
            Catch ex As Exception

            End Try
        End If
        'Statement to reload the details back onto the combo box and list box.'
        Sql = "SELECT * FROM tblBooking Where DentistID = " & DentistID
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblAppointmentListings")
        CountRows = ds.Tables("tblAppointmentListings").Rows.Count
        For i = 0 To CountRows - 1
            lstPatientsToday.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentDate") & "      :      " & (ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentTime")))
            cboAppointmentID.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentID"))
        Next

        'Makes sure that the buttons are reset to their original state.'
        btnReset.Enabled = False
        btnComplete.Enabled = False
        btnDisplay.Enabled = True
        cboAppointmentID.SelectedIndex = -1
        cboPatientID.SelectedIndex = -1
        btnRefresh.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Makes sure the combo boxes are blank.'
        cboAppointmentID.SelectedIndex = -1
        cboPatientID.SelectedIndex = -1
        cboAppointmentID.Items.Clear()
        cboPatientID.Items.Clear()
        cboPatientID.Text = ""

        'Clears all text fields for the patients details.'
        txtTitle.Clear()
        txtFirstName.Clear()
        txtSurname.Clear()
        txtPhoneNumber.Clear()
        txtHomeTelephone.Clear()
        txtDateOfBirth.Clear()
        'Resets the labels to their original state.'
        lblTreatment.Text = "Treatment"
        lblTreatmentID.Text = "Treatment ID"
        lblTime.Text = "00:00"
        lblDate.Text = "DD/MM/YYYY"
        lblDuration.Text = "00"

        'Clears the list box.'
        lstPatientsToday.Items.Clear()

        'Clearing all datasets used on the form'
        If ds.Tables("tblAppointmentListings").Rows.Count > 0 Then
            Try
                    ds.Tables("tblAppointmentListings").Clear()
        Catch ex As Exception

            End Try
        End If

        If ds.Tables("tblSelectedPatientID").Rows.Count > 0 Then
            Try
                ds.Tables("tblSelectedPatientID").Clear()
            Catch ex As Exception

            End Try
        End If

        If ds.Tables("tblPatientSelected").Rows.Count > 0 Then
            Try
                ds.Tables("tblPatientSelected").Clear()
            Catch ex As Exception

            End Try
        End If

        If ds.Tables("tblTreatmentSelected").Rows.Count > 0  Then
            Try
                ds.Tables("tblTreatmentSelected").Clear()
            Catch ex As Exception

            End Try
        End If

        'Statement to reload the details back into the combo box and list box.'
        Sql = "SELECT * FROM tblBooking Where DentistID = " & DentistID
        da = New SqlDataAdapter(Sql, dbconn)
        da.Fill(ds, "tblAppointmentListings")
        CountRows = ds.Tables("tblAppointmentListings").Rows.Count
        For i = 0 To CountRows - 1
            lstPatientsToday.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentDate") & "      :      " & (ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentTime")))
            cboAppointmentID.Items.Add(ds.Tables("tblAppointmentListings").Rows(i).Item("AppointmentID"))
        Next

        'Setting the buttons to their original state.'
        btnReset.Enabled = False
        btnComplete.Enabled = False
        btnDisplay.Enabled = True
        cboAppointmentID.SelectedIndex = -1
        cboPatientID.SelectedIndex = -1
        btnRefresh.Enabled = True
    End Sub
End Class