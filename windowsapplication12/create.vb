Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class create
    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If First_NameTextBox.Text = "" And Last_NameTextBox.Text = "" And EmailTextBox.Text = "" And Label10.Text = "" And TextBox1.Text = "" And TextBox2.Text = "" And TextBox5.Text = "" And ComboBox1.SelectedItem = "" Then
            MsgBox("All fields are required!", MsgBoxStyle.Exclamation)
        Else
            createacc()
            First_NameTextBox.Text = ""
            Last_NameTextBox.Text = ""
            EmailTextBox.Text = ""

            Label10.Text = ""


            admin.AccountsTableAdapter1.Fill(admin.SystemDataSet10.accounts)

        End If


    End Sub
    Private Sub createacc()


        Try

        
        Dim fn As String = First_NameTextBox.Text
        Dim ln As String = Last_NameTextBox.Text
        Dim email As String = EmailTextBox.Text
            Dim age As Integer = ComboBox2.SelectedItem
        Dim gender As String = Label10.Text
        Dim address As String = TextBox5.Text
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
            Dim usert As String = ComboBox1.SelectedItem
            Dim salary As Double = 0.0

            Dim query As String = "INSERT INTO accounts VALUES (@img,@First_name,@Last_name,@Email,@age,@gender,@address,@username,@password,@usertype,@salary)"
        Dim memstr As New MemoryStream
       

        Using con As New SqlConnection(Str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                PictureBox1.Image.Save(memstr, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrimage() As Byte
                arrimage = memstr.GetBuffer
                Dim filesize As UInt32
                filesize = memstr.Length
                memstr.Close()
                con.Open()
                cmd.Parameters.AddWithValue("@first_name", fn)
                cmd.Parameters.AddWithValue("@last_name", ln)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@age", age)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@img", arrimage)
                    cmd.Parameters.AddWithValue("@usertype", usert)
                    cmd.Parameters.AddWithValue("@salary", salary)

               


                cmd.ExecuteNonQuery()
                con.Close()
                logininsert()
                    MsgBox("You've Successfully Created an account!", MsgBoxStyle.Information)
                    admin.Show()
                    Me.Hide()
            End Using
            End Using

        Catch ex As Exception
            MsgBox("Username Already Exist! Please try again", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
        End Try
    End Sub
    Private Sub logininsert()
        Dim query As String = "INSERT INTO login VALUES (@username,@password,@usertype)"
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim usertype As String = ComboBox1.SelectedItem
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                
                con.Open()
              
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@usertype", usertype)




                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        End Using
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        TextBox3.UseSystemPasswordChar = True
        ComboBox1.Text = "Usertype"
        midscreen()
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button2.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
    End Sub
    Private Sub midscreen()
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label10.Text = RadioButton1.Text
        Else
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label10.Text = RadioButton2.Text
        End If
    End Sub

    
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class