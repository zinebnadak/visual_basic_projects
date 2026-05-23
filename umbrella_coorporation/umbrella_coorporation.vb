Public Class Form1
    Private loggedin As Boolean = False 'denna globara variable används nu av alla objekt nedanför för att kolla läget och vad om ska visas, kontrollera groupboxen


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Show()
        TabControl1.Hide()
        GroupBox3.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    'custom funktion som checkar status om man är inloggad, och ändrar logged in statusarna
    Private Sub checklogin()
        If loggedin = True Then
            Label5.Text = "Logged In"
            Label5.ForeColor = Color.Green 'byt färgen, alla properties kan ändras med kod
            GroupBox1.Hide() 'hidden när man är logged in
            TabControl1.Show()
            GroupBox3.Show()
            Button3.Show()
        Else
            Label5.Text = "Not Logged In"
            Label5.ForeColor = Color.Red
            TextBox3.Text = "" 'töm fälten när man loggar ut
            TextBox4.Text = ""
            TabControl1.Hide() 'den rutan som har tabbar
            GroupBox3.Hide()
            Button3.Hide()
            GroupBox1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'skapa variablerna med Dim och variabel typ
        Dim employeecode As String
        Dim Password As String
        Dim correctemployeecode As String
        Dim correctpassword As String

        'ge variablerna värden
        employeecode = TextBox3.Text
        Password = TextBox4.Text
        'ersätt med databas 
        correctemployeecode = "IT25-22"
        correctpassword = "123"

        'checka om rätt code och lösen
        If employeecode = correctemployeecode AndAlso Password = correctpassword Then
            loggedin = True
            checklogin() 'om sant ska visa Not logged in 
            MessageBox.Show("Login Sucessful")

        Else
            loggedin = False 'global variabel, kontrollerar vad knappen gör med groupboxen göm/visa
            checklogin() 'om falskt ska visa Logged in 
            MessageBox.Show("Login Unsucessful")

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loggedin = False
        checklogin()
        GroupBox2.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class

' hide the content using group box, second group box with initial logging in