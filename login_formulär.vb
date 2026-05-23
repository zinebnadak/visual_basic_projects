Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employeecode As String
        Dim password As String

        employeecode = TextBox1.Text
        password = TextBox2.Text

        Dim correctemployeecode As String
        Dim correctpassword As String

        correctemployeecode = "IT25-22"
        correctpassword = "abc"

        If employeecode = correctemployeecode AndAlso password = correctpassword Then
            MessageBox.Show("Login Successful!")
        Else
            MessageBox.Show("Login Unsuccessful!")
        End If
    End Sub
End Class

' No database In this code, we hard code the emcode and password 
' The Dim variables can you find at the very top in the boxes properties topup
' Create a message box using "MessageBox" in code if the password is successful and if it is not