Imports System.Data.SqlClient
Public Class frmAdmin
    'Sets the selected dentist's name as a string.'
    Dim SelecteddentistsName As String
    'Makes the value used to count the dataset rows as an integer.'
    Dim Countrows As Integer

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Checks if the Dentist name table is present and removes it.'
        If ds.Tables.Contains("tblDentistsName") Then
            ds.Tables.Remove("tblDentistsName")
        End If
        'Makes sure that the combo box is reset.'
        cboDentist.SelectedIndex = -1
        'When the form loads the buttons will be set to their default state.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        cboDentist.Enabled = True
        btnShow.Enabled = True
        btnRegister.Enabled = True
        lblColour.Visible = False

        'This makes sure that the combo box for the dentists title is disabled.'
        cboDTitle.Enabled = False
        'I make the text fields read-only so that the user cannot enter anything into them.'
        txtDFirstName.ReadOnly = True
        txtDSurname.ReadOnly = True
        txtDGender.ReadOnly = True
        txtDPhoneNumber.ReadOnly = True
        txtDHomeTelephone.ReadOnly = True
        txtNewPassword.ReadOnly = True
        txtReTypePassword.ReadOnly = True
        DDateOfBirth.Enabled = False

        'This makes sure that the radio buttons cannot be checked.'
        rdoStudent.Enabled = False
        rdoDentalNurse.Enabled = False
        rdoTutor.Enabled = False
        rdoStudent.Checked = True

        'This variable is used to count the rows in a dataset.'
        Dim CountRows As Integer
        'This variable is used loop until I can find the row I'm looking for.'
        Dim i As Integer

        'Defaults the staff image to the student by default.'

        picStaff.Image = My.Resources.picStudent

        'This sql statement will retrieve all the dentist ID's onto the combo box.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            'Clears the dataset to make sure that the data is not retrieved twice.'
            ds.Tables("tblDentists").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        CountRows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            cboID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentist.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

        'This makes sure that the radio buttons will change the label so that the label text will change the actual staff image.'
        If rdoDentalNurse.Checked = True Then
            lblColour.Text = "Blue"
        ElseIf rdoTutor.Checked = True Then
            lblColour.Text = "Red"
        ElseIf rdoStudent.Checked = True Then
            lblColour.Text = "Green"
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        'Closes the current form.'
        Me.Close()
        'Returns to the login form.'
        frmLogin.Show()
        'Makes sure the title is reset.'
        cboDTitle.SelectedIndex = -1
        'Clears all textfields.'
        txtDFirstName.Clear()
        txtDSurname.Clear()
        txtDGender.Clear()
        txtDPhoneNumber.Clear()
        txtNewPassword.Clear()
        txtReTypePassword.Clear()
        'Clears all combo boxes.'
        cboDentist.Items.Clear()
        cboID.Items.Clear()

        'Clears the dataset.'
        Try
            If ds.Tables("tblDentists").Rows.Count > 0 Then
                ds.Tables("tblDentists").Clear()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub rdoTutor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoTutor.CheckedChanged
        'Sets the image to tutor image when radio button is checked.'
        picStaff.Image = My.Resources.picTutor
    End Sub

    Private Sub rdoStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStudent.CheckedChanged
        'Sets the image to student image when radio button is checked.'
        picStaff.Image = My.Resources.picStudent
    End Sub

    Private Sub rdoDentalNurse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDentalNurse.CheckedChanged
        'Sets the image to dental nurse image when radio button is checked.'
        picStaff.Image = My.Resources.picDentalNurse
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Calls in the function to validate the text fields.'
        If ValidateStaff(cboDTitle, txtDFirstName, txtDSurname, txtDGender, txtDPhoneNumber, txtDHomeTelephone, txtNewPassword, txtReTypePassword) = True Then
            'If the function is returned as true then the sql will run and clear the dataset.'
            Dim Sql As String = ""
            Try
                ds.Tables("tblDentist").Clear()
            Catch ex As Exception
            End Try

            Try
                ds.Tables("tblNewDentist").Clear()
            Catch ex As Exception
            End Try
            'This statement will create a new row in the dentist table.'
            Sql = "Select * from tblDentists"
            'Creates a new data adapter.'
            da = New SqlDataAdapter(Sql, dbconn)
            'fills the dataset.'
            da.Fill(ds, "tblDentists")
            Dim cb As New SqlCommandBuilder(da)
            Dim dsNewRow As DataRow
            'Creates a new row.'
            dsNewRow = ds.Tables("tblDentists").NewRow()

            'Creates a new row for the user type from the radio buttons.'
            If rdoDentalNurse.Checked = True Then
                dsNewRow.Item("DColour") = "Blue"
            ElseIf rdoStudent.Checked = True Then
                dsNewRow.Item("DColour") = "Green"
            ElseIf rdoTutor.Checked = True Then
                dsNewRow.Item("DColour") = "Red"
            End If
            'Creates a new row for the rest of the dentist details from the textfields.'
            dsNewRow.Item("DTitle") = cboDTitle.Text
            dsNewRow.Item("DFirstName") = txtDFirstName.Text
            dsNewRow.Item("DSurname") = txtDSurname.Text
            dsNewRow.Item("DDateOfBirth") = DDateOfBirth.Text
            dsNewRow.Item("DGender") = txtDGender.Text
            dsNewRow.Item("DPhoneNumber") = txtDPhoneNumber.Text
            dsNewRow.Item("DHomeTelephone") = txtDHomeTelephone.Text
            dsNewRow.Item("DPassword") = txtNewPassword.Text

            'New row is added.'
            ds.Tables("tblDentists").Rows.Add(dsNewRow)
            'Updates the dataset.'
            da.Update(ds, "tblDentists")
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblDentists")
            dbconn.Close()

            'This statement will select the registered user.'
            Sql = "SELECT TOP 1 * FROM tblDentists ORDER BY tblDentists.DentistID DESC;"
            da = New SqlDataAdapter(Sql, dbconn)
            Try
                da.Fill(ds, "tblNewDentist")
            Catch ex As Exception
                MessageBox.Show(vbCrLf & ex.Message)
            End Try
            'A message box will show showing the newly registered user's ID and Password.'
            MessageBox.Show("Your new DentistID is: " & ds.Tables("tblNewDentist").Rows(0).Item("DentistID") & " Your new Password is: " & ds.Tables("tblNewDentist").Rows(0).Item("DPassword"))
            dbconn.Close()
            Connect()

            MessageBox.Show("The patient's details have been saved onto the database.")

            'Resets all objects on form to their original states.'
            cboDentist.SelectedIndex = -1
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = False
            cboDentist.Enabled = True
            btnShow.Enabled = True
            btnRegister.Enabled = True
            'Resets combo box.'
            cboDTitle.SelectedIndex = -1
            'Clears all textfields.'
            txtDFirstName.Clear()
            txtDSurname.Clear()
            txtDGender.Clear()
            txtDPhoneNumber.Clear()
            txtDHomeTelephone.Clear()
            txtNewPassword.Clear()
            txtReTypePassword.Clear()
            'Makes sure date is set back to the original date.'
            DDateOfBirth.Text = "01/01/1998"

            'Sets textfields back to original so they can't be edited.'
            cboDTitle.Enabled = False
            txtDFirstName.ReadOnly = True
            txtDSurname.ReadOnly = True
            txtDGender.ReadOnly = True
            txtDPhoneNumber.ReadOnly = True
            txtDHomeTelephone.ReadOnly = True
            txtNewPassword.ReadOnly = True
            txtReTypePassword.ReadOnly = True
            DDateOfBirth.Enabled = False
            'Changes the staff image back to the default image for students.'
            picStaff.Image = My.Resources.picStudent
            'Disabled all radio buttons.'
            rdoStudent.Enabled = False
            rdoDentalNurse.Enabled = False
            rdoTutor.Enabled = False
            rdoStudent.Checked = True
            'Clears the combo boxes.'
            cboDentist.Items.Clear()
            cboID.Items.Clear()

            'Statement reloads all dentists onto the combo boxes.'
            Sql = "SELECT * FROM tblDentists"
            da = New SqlDataAdapter(Sql, dbconn)
            Try
                ds.Tables("tblDentistsName").Clear()
            Catch ex As Exception

            End Try
            da.Fill(ds, "tblDentistsName")
            Countrows = ds.Tables("tblDentistsName").Rows.Count
            For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
                cboID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
                cboDentist.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
            Next


        End If
    End Sub

    Public Function ValidateStaff(ByVal cboDTitle As ComboBox, ByVal txtDFirstName As TextBox, ByVal txtDSurName As TextBox, ByVal txtDGender As TextBox, ByVal txtDPhoneNumber As TextBox, ByVal txtHomePhone As TextBox, ByVal txtNewPassword As TextBox, ByVal txtReTypePassword As TextBox) As Boolean
        AllFieldsValid = True
        'Using this line of validation, I can do a visible check on the all the text boxes I need without having to make seperate lines for each visible check.'
        If cboDTitle.Text = "" Or txtDFirstName.Text = "" Or txtDSurName.Text = "" Or txtDGender.Text = "" Or txtDPhoneNumber.Text = "" Or txtNewPassword.Text = "" Or txtReTypePassword.Text = "" Then
            MessageBox.Show("Blank box detected. Please fill in all required fields.")
            AllFieldsValid = False
        ElseIf IsNumeric(cboDTitle.Text) Or IsNumeric(txtDFirstName.Text) = True Or IsNumeric(txtDSurName.Text) Or IsNumeric(txtDGender.Text) = True Then
            MessageBox.Show("First, Surname and Gender must not be numeric.")
            AllFieldsValid = False
            'Declaring the textbox as a date will make sure the date is in the correct format.'
            'I make sure if the numeric text fields are numeric and if not then a message box will appear.'
        ElseIf IsNumeric(txtDPhoneNumber.Text) And IsNumeric(txtDHomeTelephone.Text) = False Then
            MessageBox.Show("Phone numbers and Home number must be numeric.")
            AllFieldsValid = False
            'For these validations I have done a textlength check to make sure that the fields are valid.'
        ElseIf txtDFirstName.TextLength < 2 Or txtDSurName.TextLength < 2 Then
            MessageBox.Show("First and Surname must be at least 2 characters or above.")
            AllFieldsValid = False
        ElseIf txtDFirstName.TextLength > 20 Or txtDSurName.TextLength > 20 Then
            MessageBox.Show("First and Surname must be 20 characters less.")
            AllFieldsValid = False
            'Now I am able to validate to make sure that the field can only contain 1 character.'
        ElseIf txtDGender.Text <> "M" And txtDGender.Text <> "F" Then
            MessageBox.Show("Gender must be 1 character. Either 'M' or 'F'.")
            AllFieldsValid = False
            'Telephone validated for 11 numbers. If not 11 numbers then error message will appear.'
        ElseIf txtDPhoneNumber.TextLength < 11 Or txtDPhoneNumber.TextLength > 11 Or txtDHomeTelephone.TextLength < 11 Or txtDHomeTelephone.TextLength > 11 Then
            MessageBox.Show("Telephone numbers has to be 11 numbers long.")
            AllFieldsValid = False
        ElseIf txtNewPassword.Text <> txtReTypePassword.Text Then
            MessageBox.Show("Passwords need to be the same in order to validate.")
            AllFieldsValid = False
            Me.Refresh()
        End If
        If AllFieldsValid = True Then

            'If this boolean value is true then It will return the function as true which can be called in the login button.'
            ValidateStaff = True
        Else
            'The value is returned as false therefore the user cannot proceed to the next form.'
            ValidateStaff = False

        End If

    End Function

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        MessageBox.Show("All details are required to be entered in the textfields. You can also load existing users by using the list in order to edit any details required. Select a profile for each member so they can be registered as a student, tutor or staff.")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Makes all text fields enabled so details can be edited.'
        cboDTitle.Enabled = True
        txtDFirstName.ReadOnly = False
        txtDSurname.ReadOnly = False
        txtDGender.ReadOnly = False
        txtDPhoneNumber.ReadOnly = False
        txtDHomeTelephone.ReadOnly = False
        txtNewPassword.ReadOnly = False
        txtReTypePassword.ReadOnly = False
        DDateOfBirth.Enabled = True
        'Disables delete button.'
        btnDelete.Enabled = False
        btnSave.Enabled = True
        'Disables the edit button so it cannot be pressed again unless cancelled.'
        btnEdit.Enabled = False
        'Makes the radio buttons checkable again.'
        rdoStudent.Enabled = True
        rdoDentalNurse.Enabled = True
        rdoTutor.Enabled = True


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'I dim 'response' as a message result in order to bring up an input box for the user to decide if they are certain to proceed.'
        Dim response As MsgBoxResult
        'Selected Dentist will be the dentist ID which will be an integer.'
        Dim SelectedDentist As Integer
        'Dims the comb box for ID as an integer.'
        SelectedDentist = cboID.Text
        'This is the repsonse used to decide if the user wants to proceed.'
        response = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        'If the response is yes then validation is called.'
        If response = MsgBoxResult.Yes Then
            If ValidateStaff(cboDTitle, txtDFirstName, txtDSurname, txtDGender, txtDPhoneNumber, txtDHomeTelephone, txtNewPassword, txtReTypePassword) = True Then
                'This statement selects where the data will be saved at from the dentist ID.'
                Sql = "SELECT * FROM tblDentists WHERE DentistID = " & SelectedDentist
                da = New SqlDataAdapter(Sql, dbconn)
                Dim cb As New SqlCommandBuilder(da)
                da.Fill(ds, "tblUpdateDentist")

                'All the rows will equal what is entered from the text fields.'
                ds.Tables("tblUpdateDentist").Rows(0).Item("DTitle") = cboDTitle.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DFirstName") = txtDFirstName.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DSurname") = txtDSurname.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DDateOfBirth") = DDateOfBirth.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DGender") = txtDGender.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DPhoneNumber") = txtDPhoneNumber.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DHomeTelephone") = txtDHomeTelephone.Text
                ds.Tables("tblUpdateDentist").Rows(0).Item("DPassword") = txtNewPassword.Text

                'Make sure the radio buttons will set the colours for the staff.'
                If rdoDentalNurse.Checked = True Then
                    lblColour.Text = "Blue"
                ElseIf rdoTutor.Checked = True Then
                    lblColour.Text = "Red"
                ElseIf rdoStudent.Checked = True Then
                    lblColour.Text = "Green"
                End If
                'The radio buttons will change the label text which is then saved onto the colour row on the dentist table.'
                ds.Tables("tblUpdateDentist").Rows(0).Item("DColour") = lblColour.Text

                'Updates the dataset.'
                da.Update(ds, "tblUpdateDentist")
                'Message box shows that the details have been saved.'
                MessageBox.Show("Details have been saved and updated")
            Else
                'If any rows are invalid a message box will show.'
                MessageBox.Show("Invalid Row, no changes made.")
            End If
        End If

        'This is the same code from the cancel button.'
        'Resets combo boxes.'
        cboDentist.SelectedIndex = -1

        'Sets buttons to default state when the form loads.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        cboDentist.Enabled = True
        btnShow.Enabled = True
        btnRegister.Enabled = True
        cboDTitle.SelectedIndex = -1

        'Clears all textfields.'
        txtDFirstName.Clear()
        txtDSurname.Clear()
        txtDGender.Clear()
        txtDPhoneNumber.Clear()
        txtDHomeTelephone.Clear()
        txtNewPassword.Clear()
        txtReTypePassword.Clear()
        DDateOfBirth.Text = "01/01/1998"

        'Disables combo box.'
        cboDTitle.Enabled = False
        'Makes text fields read only to prevent editing.'
        txtDFirstName.ReadOnly = True
        txtDSurname.ReadOnly = True
        txtDGender.ReadOnly = True
        txtDPhoneNumber.ReadOnly = True
        txtDHomeTelephone.ReadOnly = True
        txtNewPassword.ReadOnly = True
        txtReTypePassword.ReadOnly = True
        DDateOfBirth.Enabled = False
        'Staff image is reset to student.'
        picStaff.Image = My.Resources.picStudent
        rdoStudent.Enabled = False
        rdoDentalNurse.Enabled = False
        rdoTutor.Enabled = False
        rdoStudent.Checked = True
        'Combo boxes are cleared.'
        cboDentist.Items.Clear()
        cboID.Items.Clear()

        'Selects all from Dentist table.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)
        'Clears all the datasets used on the form.'
        Try
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try

        Try
            ds.Tables("tblUpdateDentist").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        Countrows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            'Refills comboboxes with data from table.'
            cboID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentist.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'This resets the combo box containing the dentist's name.'
        cboDentist.SelectedIndex = -1
        'All buttons are reset to what they were when the form loaded.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        cboDentist.Enabled = True
        btnShow.Enabled = True
        btnRegister.Enabled = True
        cboDTitle.SelectedIndex = -1
        'All text fields are cleared.'
        txtDFirstName.Clear()
        txtDSurname.Clear()
        txtDGender.Clear()
        txtDPhoneNumber.Clear()
        txtDHomeTelephone.Clear()
        txtNewPassword.Clear()
        txtReTypePassword.Clear()
        'Date of birth value is reset to default.'
        DDateOfBirth.Text = "01/01/1998"
        'Disabled combo boxes.'
        cboDTitle.Enabled = False
        'Sets textfields to read only to prevent editing.'
        txtDFirstName.ReadOnly = True
        txtDSurname.ReadOnly = True
        txtDGender.ReadOnly = True
        txtDPhoneNumber.ReadOnly = True
        txtDHomeTelephone.ReadOnly = True
        txtNewPassword.ReadOnly = True
        txtReTypePassword.ReadOnly = True
        'Date of birth field is disabled.'
        DDateOfBirth.Enabled = False
        'Staff image is reset to student.'
        picStaff.Image = My.Resources.picStudent
        'Radio buttons are disabled.'
        rdoStudent.Enabled = False
        rdoDentalNurse.Enabled = False
        rdoTutor.Enabled = False
        rdoStudent.Checked = True

        'Combo boxes are cleared.'
        cboDentist.Items.Clear()
        cboID.Items.Clear()

        'Sequel statement retrieves all rows from dentist table.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        Countrows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            'ID and Firstnames of all dentists are put into the combo boxes.'
            cboID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentist.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Makes selected dentist ID as an integer.'
        Dim SelectedDentist As Integer
        'Sets combo box as integer.'
        SelectedDentist = cboID.Text

        'Clears dataset.'
        Try
            ds.Tables("tblDentist").Clear()
        Catch ex As Exception

        End Try
        'Selects the dentist ID from the combo box.'
        Sql = "DELETE FROM tblDentists WHERE DentistID = " & SelectedDentist & ""

        da = New SqlDataAdapter(Sql, dbconn)
        'Deletes the whole row from the selected ID.'
        da.Fill(ds, "tblDentists")

        'Message box shows telling the user that the record is delete.d.'
        MessageBox.Show("Record deleted")

        'This resets the combo box containing the dentist's name.'
        cboDentist.SelectedIndex = -1
        'All buttons are reset to what they were when the form loaded.'
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        cboDentist.Enabled = True
        btnShow.Enabled = True
        btnRegister.Enabled = True
        cboDTitle.SelectedIndex = -1
        'All text fields are cleared.'
        txtDFirstName.Clear()
        txtDSurname.Clear()
        txtDGender.Clear()
        txtDPhoneNumber.Clear()
        txtDHomeTelephone.Clear()
        txtNewPassword.Clear()
        txtReTypePassword.Clear()
        'Date of birth value is reset to default.'
        DDateOfBirth.Text = "01/01/1998"
        'Disabled combo boxes.'
        cboDTitle.Enabled = False
        'Sets textfields to read only to prevent editing.'
        txtDFirstName.ReadOnly = True
        txtDSurname.ReadOnly = True
        txtDGender.ReadOnly = True
        txtDPhoneNumber.ReadOnly = True
        txtDHomeTelephone.ReadOnly = True
        txtNewPassword.ReadOnly = True
        txtReTypePassword.ReadOnly = True
        'Date of birth field is disabled.'
        DDateOfBirth.Enabled = False
        'Staff image is reset to student.'
        picStaff.Image = My.Resources.picStudent
        'Radio buttons are disabled.'
        rdoStudent.Enabled = False
        rdoDentalNurse.Enabled = False
        rdoTutor.Enabled = False
        rdoStudent.Checked = True

        'Combo boxes are cleared.'
        cboDentist.Items.Clear()
        cboID.Items.Clear()

        'Sequel statement retrieves all rows from dentist table.'
        Sql = "SELECT * FROM tblDentists"
        da = New SqlDataAdapter(Sql, dbconn)
        Try
            ds.Tables("tblDentistsName").Clear()
        Catch ex As Exception

        End Try
        da.Fill(ds, "tblDentistsName")
        Countrows = ds.Tables("tblDentistsName").Rows.Count
        For i = 0 To ds.Tables("tblDentistsName").Rows.Count - 1
            'ID and Firstnames of all dentists are put into the combo boxes.'
            cboID.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DentistID"))
            cboDentist.Items.Add(ds.Tables("tblDentistsName").Rows(i).Item("DFirstName"))
        Next

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'Makes sure that combo boxes are reset and disabled.'
        cboDentist.SelectedIndex = -1
        cboDentist.Enabled = False
        'Makes sure that the user can't save it the user as a existing user by disabling buttons.'
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnShow.Enabled = False
        'Enabled add button so details can be added onto database.'
        btnAdd.Enabled = True
        'Disables delete button.'
        btnDelete.Enabled = False
        DDateOfBirth.Enabled = True
        'Disables register button to prevent resets.'
        btnRegister.Enabled = False
        'Enables radio buttons and textfields.'
        rdoStudent.Enabled = True
        rdoDentalNurse.Enabled = True
        rdoTutor.Enabled = True
        cboDTitle.Enabled = True
        txtDFirstName.ReadOnly = False
        txtDSurname.ReadOnly = False
        txtDGender.ReadOnly = False
        txtDPhoneNumber.ReadOnly = False
        txtDHomeTelephone.ReadOnly = False
        txtNewPassword.ReadOnly = False
        txtReTypePassword.ReadOnly = False
        rdoStudent.Checked = True


    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'Sets the validation as true.'
        AllFieldsValid = True
        'Sets the selected dentist as an integer.'
        Dim SelectedDentist As Integer
        'Validation to make sure that there is data in the combo box.'
        If cboDentist.Text = "" Then
            MessageBox.Show("Please select a member")
            'Makes the fields invalid so the dentist's data doesn't load.'
            AllFieldsValid = False
        End If

        If AllFieldsValid = True Then
            'Edit button is enabled.'
            btnEdit.Enabled = True
            'Makes sure the user cannot create two same users by disabling the add button.'
            btnAdd.Enabled = False
            btnRegister.Enabled = False
            'Prevents data from being retrieved again.'
            btnShow.Enabled = False
            'Makes sure the user cannot load another user.'
            cboDentist.Enabled = False
            'Deleting the record is available.'
            btnDelete.Enabled = True

            'Sets the combo box as an integer.'
            SelectedDentist = cboID.Text
            Try
                'Clears the dataset.'
                ds.Tables("tblSelectedDentist").Clear()
            Catch ex As Exception

            End Try

            'Selects the selected dentist from combo box.'
            Sql = "SELECT * FROM tblDentists WHERE DentistID = " & SelectedDentist & ""
            da = New SqlDataAdapter(Sql, dbconn)
            da.Fill(ds, "tblSelectedDentist")

            'The dentists data will load into the text fields, labels and combo boxes.'
            cboDTitle.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DTitle")
            txtDFirstName.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DFirstName")
            txtDSurname.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DSurname")
            DDateOfBirth.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DDateOfBirth")
            txtDGender.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DGender")
            txtDPhoneNumber.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DPhoneNumber")
            txtDHomeTelephone.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DHomeTelephone")
            txtNewPassword.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DPassword")
            txtReTypePassword.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DPassword")
            lblColour.Text = ds.Tables("tblSelectedDentist").Rows(0).Item("DColour")

            'The dentist colour will load onto the label text.'
            Select Case lblColour.Text
                Case "Green"

                    rdoStudent.Checked = True
                Case "Blue"

                    rdoDentalNurse.Checked = True
                Case "Red"

                    rdoTutor.Checked = True


            End Select

        End If

    End Sub

    Private Sub cboDentist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDentist.SelectedIndexChanged
        'Set the combo box for dentists name to match their ID's.'
        SelecteddentistsName = cboDentist.SelectedIndex
        cboID.SelectedIndex = cboDentist.SelectedIndex

    End Sub

    Private Sub txtDFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDFirstName.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtDSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDSurname.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtDGender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDGender.KeyPress
        'Ignore everything but letter keys.'
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtDPhoneNumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDPhoneNumber.KeyPress
        'Ignore everything but numeric keys.'
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtDHomeTelephone_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDHomeTelephone.KeyPress
        'Ignore everything but numeric keys.'
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

End Class