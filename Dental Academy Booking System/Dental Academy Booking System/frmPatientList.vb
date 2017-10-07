Imports System.Data.SqlClient
Public Class frmPatientList
    'Sets this variable for dentist's name as a string.'
    Dim SelectedPatientName As String
    'Countrows is set as integer for counting the rows in a dataset.'
    Dim Countrows As Integer
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Clears all fields
        cboTitle.SelectedIndex = -1
        txtFirstName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtPhoneNumber.Clear()
        txtHomeNumber.Clear()
        txtHouseNumber.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtCounty.Clear()
        txtPostCode.Clear()
        txtAllergyInfo.Clear()
        'Makes sure check boxes are not checked.'
        chbYes.Checked = False
        chbNo.Checked = False
        'Closes the form.'
        Me.Close()
        'Returns to the menu form.'
        frmMenu.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Validation for all text fields are called.'
        'If validation is passed on then the sql will be called.'
        If ValidatePatient(txtFirstName, txtSurname, txtGender, txtPhoneNumber, txtHomeNumber, txtHouseNumber, txtStreet, txtCity, txtCounty, txtPostCode) = True Then
            Dim Sql As String = ""
            Try
                'Clears dataset.'
                ds.Clear()
            Catch ex As Exception
            End Try
            'Selects all from the patients table.'
            Sql = "Select * from tblPatients"
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblPatients")
            Dim cb As New SqlCommandBuilder(da)
            Dim dsNewRow As DataRow
            'Creates a new row for the dataset.'
            dsNewRow = ds.Tables("tblPatients").NewRow()

            'Sets the new row according to the check boxes.'
            If chbYes.Checked = True Then
                dsNewRow.Item("Allergies") = "Y"
            ElseIf chbNo.Checked = True Then
                dsNewRow.Item("Allergies") = "N"
            End If
            'Creates new row for the registered patients details.'
            dsNewRow.Item("Title") = cboTitle.Text
            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("Surname") = txtSurname.Text
            dsNewRow.Item("DateOfBirth") = DateOfBirth.Text
            dsNewRow.Item("Gender") = txtGender.Text
            dsNewRow.Item("PhoneNumber") = txtPhoneNumber.Text
            dsNewRow.Item("HomeNumber") = txtHomeNumber.Text
            dsNewRow.Item("HouseNumber") = txtHouseNumber.Text
            dsNewRow.Item("Street") = txtStreet.Text
            dsNewRow.Item("City") = txtCity.Text
            dsNewRow.Item("County") = txtCounty.Text
            dsNewRow.Item("PostCode") = txtPostCode.Text
            dsNewRow.Item("AllergyDetails") = txtAllergyInfo.Text
            'New row is added to the database.'
            ds.Tables("tblPatients").Rows.Add(dsNewRow)
            'Data set is updated.'
            da.Update(ds, "tblPatients")
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblPatients")
            dbconn.Close()
            Connect()

            MessageBox.Show("The patient's details have been saved onto the database.")

            'Form resets to original state.'
            'Combo boxes are reset.'
            cboPatientList.SelectedIndex = -1
            'Add, delete, edit and save buttons are disabled.'
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = False
            'Combo box is enabled to select the patient.'
            cboPatientList.Enabled = True
            'Show and register buttons are enabled.'
            btnShow.Enabled = True
            btnRegister.Enabled = True

            'Combo box is reset.'
            cboTitle.SelectedIndex = -1
            'All text fields are cleared.'
            txtFirstName.Clear()
            txtSurname.Clear()
            txtGender.Clear()
            txtPhoneNumber.Clear()
            txtHomeNumber.Clear()
            txtHouseNumber.Clear()
            txtStreet.Clear()
            txtCity.Clear()
            txtCounty.Clear()
            txtPostCode.Clear()
            txtAllergyInfo.Clear()
            'Date of birth is reset to default.'
            DateOfBirth.Text = "01/01/1998"
            'Both check boxes are unchecked.'
            chbYes.Checked = False
            chbNo.Checked = False
            'Makes sure all combo boxes are disabled apart from the patient list.'
            cboTitle.Enabled = False
            'All text fields are read only to prevent editing.'
            txtFirstName.ReadOnly = True
            txtSurname.ReadOnly = True
            txtGender.ReadOnly = True
            txtPhoneNumber.ReadOnly = True
            txtHomeNumber.ReadOnly = True
            txtHouseNumber.ReadOnly = True
            txtStreet.ReadOnly = True
            txtCity.ReadOnly = True
            txtCounty.ReadOnly = True
            txtPostCode.ReadOnly = True
            txtAllergyInfo.ReadOnly = True
            DateOfBirth.Enabled = False

            'All combo boxes are cleared.'
            cboPatientList.Items.Clear()
            cboID.Items.Clear()

        End If

        'Sql statment will reload the patients first name and ID back onto the combo boxes.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblPatientName")
        Countrows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            cboID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatientList.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next
    End Sub
    Public Function ValidatePatient(ByVal txtFirstName As TextBox, ByVal txtSurname As TextBox, ByVal txtGender As TextBox, ByVal txtPhoneNumber As TextBox, ByVal txtHomeNumber As TextBox, ByVal txtHouseNumber As TextBox, ByVal txtStreet As TextBox, ByVal txtCity As TextBox, ByVal txtCounty As TextBox, ByVal txtPostCode As TextBox) As Boolean
        AllFieldsValid = True
        'Using this line of validation, I can do a visible check on the all the text boxes I need without having to make seperate lines for each visible check.'
        If txtFirstName.Text = "" Or txtSurname.Text = "" Or txtGender.Text = "" Or txtPhoneNumber.Text = "" Or txtHomeNumber.Text = "" Or txtHouseNumber.Text = "" Or txtStreet.Text = "" Or txtCity.Text = "" Or txtCounty.Text = "" Or txtPostCode.Text = "" Or txtAllergyInfo.Text = "" Then
            MessageBox.Show("Blank box detected. Please fill in all required fields.")
            AllFieldsValid = False
        ElseIf IsNumeric(txtFirstName.Text) = True Or IsNumeric(txtSurname.Text) Or IsNumeric(txtGender.Text) = True Then
            MessageBox.Show("First, Surname and Gender must not be numeric.")
            AllFieldsValid = False
            'Declaring the textbox as a date will make sure the date is in the correct format.'
            'I make sure if the numeric text fields are numeric and if not then a message box will appear.'
        ElseIf IsNumeric(txtPhoneNumber.Text) = False Or IsNumeric(txtHomeNumber.Text) = False Or IsNumeric(txtHouseNumber.Text) = False Then
            MessageBox.Show("Phone numbers and Home number must be numeric.")
            AllFieldsValid = False
            'For these validations I have done a textlength check to make sure that the fields are valid.'
        ElseIf txtFirstName.TextLength < 2 Or txtSurname.TextLength < 2 Then
            MessageBox.Show("First and Surname must be at least 2 characters or above.")
            AllFieldsValid = False
        ElseIf txtFirstName.TextLength > 20 Or txtSurname.TextLength > 20 Then
            MessageBox.Show("First and Surname must be 20 characters less.")
            AllFieldsValid = False
            'Now I am able to validate to make sure that the field can only contain 1 character.'
        ElseIf txtGender.Text <> "M" And txtGender.Text <> "F" Then
            MessageBox.Show("Gender must be 1 character. Either 'M' or 'F'.")
            AllFieldsValid = False
            'Telephone validated for 11 numbers. If not 11 numbers then error message will appear.'
        ElseIf txtPhoneNumber.TextLength < 11 Or txtPhoneNumber.TextLength > 11 Or txtHomeNumber.TextLength < 11 Or txtHomeNumber.TextLength > 11 Then
            MessageBox.Show("Telephone numbers has to be 11 numbers long.")
            AllFieldsValid = False
        ElseIf txtPostCode.TextLength < 6 Or txtPostCode.TextLength > 8 Then
            MessageBox.Show("Post Code must be between 6 to 8 characters.")
            'If the passwords do not match then a error message will appear.'
            AllFieldsValid = False
        End If
        Me.Refresh()
        If AllFieldsValid = True Then
            'If this boolean value is true then It will return the function as true which can be called in the login button.'
            ValidatePatient = True
        Else
            'The value is returned as false therefore the user cannot proceed to the next form.'
            ValidatePatient = False
        End If
    End Function

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'A simple messagebox which appears telling the user how to use the current form.'
        MessageBox.Show("Enter the patient's details onto the text fields, the validated data will be saved onto the database which will add the new patient onto the list. The member can then be selected for an appointment.")
    End Sub

    Private Sub frmPatientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Sets the combo box text to blank.'
        cboPatientList.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'The combo box containing the Patients names are loaded.'
        cboPatientList.Enabled = True
        'This button enables the patients details to be shown onto the text fields.'
        btnShow.Enabled = True
        'This allows the user to input data into the text fields.'
        btnRegister.Enabled = True
        'Sets the title to blank.'
        cboTitle.SelectedIndex = -1
        'Clears all textfields.'
        txtFirstName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtPhoneNumber.Clear()
        txtHomeNumber.Clear()
        txtHouseNumber.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtCounty.Clear()
        txtPostCode.Clear()
        txtAllergyInfo.Clear()
        'Sets date of birth back to default.'
        DateOfBirth.Text = "01/01/1998"

        'Makes sure the label is invisible.'
        lblAllergyCheck.Visible = False
        'Disables the combo box for the patient's title.'
        cboTitle.Enabled = False
        'Makes all text fields read only so they can't be edited.'
        txtFirstName.ReadOnly = True
        txtSurname.ReadOnly = True
        txtGender.ReadOnly = True
        txtPhoneNumber.ReadOnly = True
        txtHomeNumber.ReadOnly = True
        txtHouseNumber.ReadOnly = True
        txtStreet.ReadOnly = True
        txtCity.ReadOnly = True
        txtCounty.ReadOnly = True
        txtPostCode.ReadOnly = True
        txtAllergyInfo.ReadOnly = True
        'Unchecks check boxes.'
        chbNo.Enabled = False
        chbYes.Enabled = False

        'Selects all from the patients table.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try
        Try
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblPatientName")
        Countrows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            'Retrieves all patients and sets their ID and first names into the combo box.'
            cboID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatientList.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Sets the combo box text to blank.'
        cboPatientList.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'The combo box containing the Patients names are loaded.'
        cboPatientList.Enabled = True
        'This button enables the patients details to be shown onto the text fields.'
        btnShow.Enabled = True
        'This allows the user to input data into the text fields.'
        btnRegister.Enabled = True
        'Sets the title to blank.'
        cboTitle.SelectedIndex = -1
        'Clears all textfields.'
        txtFirstName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtPhoneNumber.Clear()
        txtHomeNumber.Clear()
        txtHouseNumber.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtCounty.Clear()
        txtPostCode.Clear()
        txtAllergyInfo.Clear()
        'Sets date of birth back to default.'
        DateOfBirth.Text = "01/01/1998"

        'Makes sure the label is invisible.'
        lblAllergyCheck.Visible = False
        'Disables the combo box for the patient's title.'
        cboTitle.Enabled = False
        'Makes all text fields read only so they can't be edited.'
        txtFirstName.ReadOnly = True
        txtSurname.ReadOnly = True
        txtGender.ReadOnly = True
        txtPhoneNumber.ReadOnly = True
        txtHomeNumber.ReadOnly = True
        txtHouseNumber.ReadOnly = True
        txtStreet.ReadOnly = True
        txtCity.ReadOnly = True
        txtCounty.ReadOnly = True
        txtPostCode.ReadOnly = True
        txtAllergyInfo.ReadOnly = True
        'Unchecks check boxes.'
        chbNo.Enabled = False
        chbYes.Enabled = False

        cboPatientList.Items.Clear()
        cboID.Items.Clear()

        'Selects all from the patients table.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)
   
        Try
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        Try
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception
        End Try

        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            'Retrieves all patients and sets their ID and first names into the combo box.'
            cboID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatientList.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Enables combo box for title.'
        cboTitle.Enabled = True
        'Turns of read only for text fields so that the user can input their details.'
        txtFirstName.ReadOnly = False
        txtSurname.ReadOnly = False
        txtGender.ReadOnly = False
        txtPhoneNumber.ReadOnly = False
        txtHomeNumber.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtCounty.ReadOnly = False
        txtPostCode.ReadOnly = False
        txtHouseNumber.ReadOnly = False
        txtAllergyInfo.ReadOnly = False
        'Enables check boxes.'
        chbNo.Enabled = True
        chbYes.Enabled = True
        DateOfBirth.Enabled = True
        'Disables the delete button so the user can't delete the record while it's being edited.'
        btnDelete.Enabled = False
        'Save button is enabled to save what the user has edited into the text fields.'
        btnSave.Enabled = True

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'Makes sure that the user cannot load any profiles when they are making a new one.'
        'Sets the value of the combo to blank.'
        cboPatientList.SelectedIndex = -1
        'Disables the combo box.'
        cboPatientList.Enabled = False
        'Disables edit, save, show and delete buttons.'
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnShow.Enabled = False
        'Add button is enabled to create a new row from the text fields.'
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        'Date of birth is enabled.'
        DateOfBirth.Enabled = True
        'Combo box for the title is enabled.'
        cboTitle.Enabled = True
        'Read only is disabled so all the text fields can be edited again.'
        txtFirstName.ReadOnly = False
        txtSurname.ReadOnly = False
        txtGender.ReadOnly = False
        txtPhoneNumber.ReadOnly = False
        txtHomeNumber.ReadOnly = False
        txtHouseNumber.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtCounty.ReadOnly = False
        txtPostCode.ReadOnly = False
        txtAllergyInfo.ReadOnly = False
        'Check boxes are enabled.'
        chbNo.Enabled = True
        chbYes.Enabled = True
        'Makes sure user cannot press the same button again.'
        btnRegister.Enabled = False
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'Sets variable to true.'
        AllFieldsValid = True
        'Sets the selected patient as an integer.'
        Dim SelectedPatient As Integer
        'Presence check validation for the combo box.'

        If cboPatientList.Text = "" Then
            MessageBox.Show("Please select a patient.")
            AllFieldsValid = False
            'Validation is not accepted.'
        End If

        If AllFieldsValid = True Then
            'Edit, and delete buttons are enabled.'
            btnEdit.Enabled = True
            'Patient list cannot be used to prevent loading another profile.'
            cboPatientList.Enabled = False
            'Add button is disabled when editing an existing profile.'
            btnAdd.Enabled = False
            btnRegister.Enabled = False
            btnShow.Enabled = False
            btnDelete.Enabled = True
            'Sets the combo box as an integer.'
            SelectedPatient = cboID.Text
            Try
                'Clears the dataset.'
                ds.Tables("tblSelectedPatient").Clear()
            Catch ex As Exception

            End Try

            'SQL statement retrieving all the patients details from the selected ID in the combo box.'
            Sql = "SELECT * FROM tblPatients WHERE PatientID = " & SelectedPatient & ""
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblSelectedPatient")

            'Details are loaded onto the text fields.'
            cboTitle.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("Title")
            txtFirstName.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("FirstName")
            txtSurname.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("Surname")
            DateOfBirth.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("DateOfBirth")
            txtGender.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("Gender")
            txtPhoneNumber.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("PhoneNumber")
            txtHomeNumber.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("HomeNumber")
            txtHouseNumber.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("HouseNumber")
            txtStreet.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("Street")
            txtCity.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("City")
            txtCounty.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("County")
            txtPostCode.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("PostCode")
            lblAllergyCheck.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("Allergies")
            txtAllergyInfo.Text = ds.Tables("tblSelectedPatient").Rows(0).Item("AllergyDetails")

            'Checks one of the check boxes according to the value of the label's text.'
            Select Case lblAllergyCheck.Text

                Case "Y"

                    chbYes.Checked = True
                Case "N"

                    chbNo.Checked = True

            End Select

        End If


    End Sub

    Private Sub cboPatientList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPatientList.SelectedIndexChanged
        'Sets the combo boxes to make the Patient's name match their ID.'
        SelectedPatientName = cboPatientList.SelectedIndex
        cboID.SelectedIndex = cboPatientList.SelectedIndex
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Sets the selected patient as an integer.'
        Dim SelectedPatient As Integer
        'The combo box will be set as the integer.'
        SelectedPatient = cboID.Text

        Try
            'Clears the dataset.'
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try
        'SQL statement to delete the whole row where the PatientID matches the ID in the combo box.'
        Sql = "DELETE FROM tblPatients WHERE PatientID = " & SelectedPatient & ""

        da = New SqlDataAdapter(Sql, dbconn)

        da.Fill(ds, "tblPatients")

        MessageBox.Show("Record deleted")

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Sets the combo box text to blank.'
        cboPatientList.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'The combo box containing the Patients names are loaded.'
        cboPatientList.Enabled = True
        'This button enables the patients details to be shown onto the text fields.'
        btnShow.Enabled = True
        'This allows the user to input data into the text fields.'
        btnRegister.Enabled = True
        'Sets the title to blank.'
        cboTitle.SelectedIndex = -1
        'Clears all textfields.'
        txtFirstName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtPhoneNumber.Clear()
        txtHomeNumber.Clear()
        txtHouseNumber.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtCounty.Clear()
        txtPostCode.Clear()
        txtAllergyInfo.Clear()
        'Sets date of birth back to default.'
        DateOfBirth.Text = "01/01/1998"

        'Makes sure the label is invisible.'
        lblAllergyCheck.Visible = False
        'Disables the combo box for the patient's title.'
        cboTitle.Enabled = False
        'Makes all text fields read only so they can't be edited.'
        txtFirstName.ReadOnly = True
        txtSurname.ReadOnly = True
        txtGender.ReadOnly = True
        txtPhoneNumber.ReadOnly = True
        txtHomeNumber.ReadOnly = True
        txtHouseNumber.ReadOnly = True
        txtStreet.ReadOnly = True
        txtCity.ReadOnly = True
        txtCounty.ReadOnly = True
        txtPostCode.ReadOnly = True
        txtAllergyInfo.ReadOnly = True
        'Unchecks check boxes.'
        chbNo.Enabled = False
        chbYes.Enabled = False

        cboPatientList.Items.Clear()
        cboID.Items.Clear()

        'Selects all from the patients table.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            'Retrieves all patients and sets their ID and first names into the combo box.'
            cboID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatientList.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'I dim 'response' as a message result in order to bring up an input box for the user to decide if they are certain to proceed.'
        Dim response As MsgBoxResult
        'Sets this variable for dentist's name as a string.'
        Dim SelectedPatient As Integer
        SelectedPatient = cboID.Text
        'This is the repsonse used to decide if the user wants to proceed.'
        response = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        'If the response is yes then validation is called.'
        If response = MsgBoxResult.Yes Then
            'Validation is called. If it is passed as true, the SQL statement will be called.'
            If ValidatePatient(txtFirstName, txtSurname, txtGender, txtPhoneNumber, txtHomeNumber, txtHouseNumber, txtStreet, txtCity, txtCounty, txtPostCode) = True Then
                'SQL statement selected the whole row from the patients table where the patient ID matches the selected patient from the combo box.'
                Sql = "SELECT * FROM tblpatients WHERE PatientID = " & SelectedPatient
                da = New SqlDataAdapter(Sql, dbconn)
                Dim cb As New SqlCommandBuilder(da)
                da.Fill(ds, "tblUpdatePatient")

                'The selected row is updated with the details from the text fields.'
                ds.Tables("tblUpdatePatient").Rows(0).Item("Title") = cboTitle.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("FirstName") = txtFirstName.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("Surname") = txtSurname.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("DateOfBirth") = DateOfBirth.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("Gender") = txtGender.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("PhoneNumber") = txtPhoneNumber.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("HomeNumber") = txtHomeNumber.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("HouseNumber") = txtHouseNumber.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("Street") = txtStreet.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("City") = txtCity.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("County") = txtCounty.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("AllergyDetails") = txtAllergyInfo.Text
                ds.Tables("tblUpdatePatient").Rows(0).Item("Allergies") = lblAllergyCheck.Text
                'The dataset is updated.'
                da.Update(ds, "tblUpdatePatient")

                'Messagebox shows if the procedure is succesful.'
                MessageBox.Show("Details have been saved and updated")
            Else
                MessageBox.Show("Invalid Row, no changes made.")
            End If
        End If

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Sets the combo box text to blank.'
        cboPatientList.SelectedIndex = -1
        'Add, delete, edit and save buttons are disabled.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        'The combo box containing the Patients names are loaded.'
        cboPatientList.Enabled = True
        'This button enables the patients details to be shown onto the text fields.'
        btnShow.Enabled = True
        'This allows the user to input data into the text fields.'
        btnRegister.Enabled = True
        'Sets the title to blank.'
        cboTitle.SelectedIndex = -1
        'Clears all textfields.'
        txtFirstName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtPhoneNumber.Clear()
        txtHomeNumber.Clear()
        txtHouseNumber.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtCounty.Clear()
        txtPostCode.Clear()
        txtAllergyInfo.Clear()
        'Sets date of birth back to default.'
        DateOfBirth.Text = "01/01/1998"

        'Makes sure the label is invisible.'
        lblAllergyCheck.Visible = False
        'Disables the combo box for the patient's title.'
        cboTitle.Enabled = False
        'Makes all text fields read only so they can't be edited.'
        txtFirstName.ReadOnly = True
        txtSurname.ReadOnly = True
        txtGender.ReadOnly = True
        txtPhoneNumber.ReadOnly = True
        txtHomeNumber.ReadOnly = True
        txtHouseNumber.ReadOnly = True
        txtStreet.ReadOnly = True
        txtCity.ReadOnly = True
        txtCounty.ReadOnly = True
        txtPostCode.ReadOnly = True
        txtAllergyInfo.ReadOnly = True
        'Unchecks check boxes.'
        chbNo.Enabled = False
        chbYes.Enabled = False
        'Clears combo box of items.'
        cboPatientList.Items.Clear()
        cboID.Items.Clear()

        'Selects all from the patients table.'
        Sql = "SELECT * FROM tblPatients"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblPatientName").Clear()
        Catch ex As Exception

        End Try

        Try
            ds.Tables("tblPatients").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblPatientName")
        CountRows = ds.Tables("tblPatientName").Rows.Count
        For i = 0 To ds.Tables("tblPatientName").Rows.Count - 1
            'Retrieves all patients and sets their ID and first names into the combo box.'
            cboID.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("PatientID"))
            cboPatientList.Items.Add(ds.Tables("tblPatientName").Rows(i).Item("FirstName"))
        Next
    End Sub

    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtGender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGender.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtPhoneNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        'Ignore everything but numeric characters.'
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtHomeNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHomeNumber.KeyPress
        'Ignore everything but numeric characters.'
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtHouseNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHouseNumber.KeyPress
        'Ignore everything but numeric characters.'
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

End Class