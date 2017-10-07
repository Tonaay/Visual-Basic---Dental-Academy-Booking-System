Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'On form load I will call in the subroutine in order to connect to the database.'
        Connect()
        'I set the properties of each of the three text boxes so that it can only show a phone number which cannot be manipulated and only copied.'
        txtPhone1.Text = "03069 990705"
        txtPhone1.BorderStyle = BorderStyle.None
        txtPhone1.ReadOnly = True
        txtPhone1.SelectionStart() = 0
        txtPhone1.SelectionLength = txtPhone1.Text.Length
        txtPhone1.ScrollToCaret()
        txtPhone1.Focus()

        txtPhone2.Text = "03069 990447"
        txtPhone2.BorderStyle = BorderStyle.None
        txtPhone2.ReadOnly = True
        txtPhone2.SelectionStart() = 0
        txtPhone2.SelectionLength = txtPhone2.Text.Length
        txtPhone2.ScrollToCaret()
        txtPhone2.Focus()

        txtPhone3.Text = "03069 990655"
        txtPhone3.BorderStyle = BorderStyle.None
        txtPhone3.ReadOnly = True
        txtPhone3.SelectionStart() = 0
        txtPhone3.SelectionLength = txtPhone1.Text.Length
        txtPhone3.ScrollToCaret()
        txtPhone3.Focus()
    End Sub
    Private Sub btnAdmin_Click(sender As System.Object, e As System.EventArgs) Handles btnAdmin.Click
        'If the answer is "dent" then the current form will hide and the admin form will show.'
        If txtAdminPassword.Text = "dent" Then
            Me.Hide()
            frmAdmin.Show()
            'Makes sure that the dataset is removed so that an updated dataset will load when re-entering the form.'
            If ds.Tables.Contains("tblDentists") Then
                ds.Tables.Remove("tblDentists")
            End If
            'clear the textfield so that if another user logs, on they will need to re-enter the password to access the admin form.'
            txtAdminPassword.Clear()
        Else
            'If the answer is incorrect, a message box will be displayed and the input box will close.'
            MessageBox.Show("Incorrect Password")
            txtAdminPassword.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'I dim a message box to allow the user to decide incase they accidently close the program.'
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close the program?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        'If the response is yes, the program will close                
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            'If the response is no, the program will remain open.'
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'This calls the function to validate the login details in the textfields.'
        If ValidateLogin(txtUserID, txtPassword) = True Then
            'the form will hide if the function returns as true.'
            Me.Hide()
            'The menu form will show.'
            frmMenu.Show()
            'This will make sure that the logged in dentists name will load onto the menu form.'
            DentistID = ds.Tables("tblDentists").Rows(0).Item("DentistID")
            frmMenu.txtDTitle.Text = ds.Tables("tblDentists").Rows(0).Item("DTitle")
            frmMenu.txtDFirstName.Text = ds.Tables("tblDentists").Rows(0).Item("DFirstName")
            frmMenu.txtDSurname.Text = ds.Tables("tblDentists").Rows(0).Item("DSurname")
            'clear the textfield so that if another user logs, on they will need to re-enter the password to access the admin form.'
            txtAdminPassword.Clear()
        End If
    End Sub

    Public Function ValidateLogin(ByVal txtUserID As TextBox, ByVal txtPassword As TextBox) As Boolean
        AllFieldsValid = True
        'validation to check that the password and username are entered.'
        If String.IsNullOrWhiteSpace(txtUserID.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your MemberID and a Password.")
            AllFieldsValid = False
            'Further validation checks that the username is numeric'
        ElseIf Not IsNumeric(txtUserID.Text) Then
            'Validation to check if there are any numeric values in the Username'
            MessageBox.Show("UserID must be numeric...")
            AllFieldsValid = False
        ElseIf txtUserID.Text < 1 Then
            'Validation to see if the text ID is less than 1 or more than 30'
            MessageBox.Show("ID cannot be less than 1.")
            AllFieldsValid = False
        ElseIf txtUserID.Text > 100 Then
            'Validation for textlength on the member ID. The ID must not be larger than 30 or less than 0.'
            MessageBox.Show("ID cannot be bigger than 100.")
            AllFieldsValid = False
        End If
        'If all fields value is true then the user will be able to log in.' 
        If AllFieldsValid = True Then
            'Dims the log member as the User ID text.'
            LogMember = txtUserID.Text
            'Selects all from the Dentists table where the Dentist ID matches the ID text field.'
            Sql = "select * from tblDentists where DentistID= " & LogMember
            Try
                ds.Clear()
            Catch ex As Exception
                'Ignore first time.'
            End Try
            'Creates a new sql data adapter for the dataset.'
            da = New SqlDataAdapter(Sql, dbconn)
            'Fills the dataset.'
            da.Fill(ds, "tblDentists")
            'Makes sure the password is from the user logging on.'
            If ds.Tables("tblDentists").Rows.Count > 0 Then
                If ds.Tables("tblDentists").Rows(0).Item("DPassword") = txtPassword.Text Then
                    DentistID = LogMember
                    'If this boolean value is true then It will return the function as true which can be called in the login button.'
                    ValidateLogin = True
                Else
                    'The value is returned as false therefore the user cannot proceed to the next form.'
                    ValidateLogin = False
                    MessageBox.Show("Password is incorrect or doesn't match ID.")
                End If
            Else
                'Error message saying the ID doesn't exist.'
                MessageBox.Show("ID does not exist.")
            End If
        End If
    End Function

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'The help button will display a message helping the user with the form.'
        MessageBox.Show("Use your personal ID that has been set to you into the the text fields. Passwords must be exactly how you set it. If you have any technical difficulties, please contact the administrations office. Receptionists can access the admin form by entering the correct password which is written on the counter.")
    End Sub
End Class