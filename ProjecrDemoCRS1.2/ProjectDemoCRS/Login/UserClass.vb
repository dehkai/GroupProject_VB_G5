Public Class UserClass
    Private userName As String
    Private password As String
    Private userAccess As String
    Public Sub setUserData(userName As String, password As String)
        Me.userName = userName
        Me.password = password
    End Sub
    Public Sub setUserData(userName As String, password As String, userAccess As String)
        Me.userName = userName
        Me.password = password
        Me.userAccess = userAccess
    End Sub
    Public Function getUser() As UserClass
        Return Me
    End Function
End Class
