Public Class LoginForm
    Dim user As UserClass
    Dim loginModel As LoginModel
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        user.setUserData(UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Dim valid = loginModel.checkLogin(user)
        If (valid) Then
            CrsMainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        user = New UserClass()
        loginModel = New LoginModel
    End Sub
End Class
