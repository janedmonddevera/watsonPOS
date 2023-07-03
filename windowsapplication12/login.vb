Imports System.Data.SqlClient


Public Class login
    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
        txtpassword.UseSystemPasswordChar = True
        txtusername.Focus()
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button3.BackColor = System.Drawing.Color.Transparent

        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New Font(Button4.Font, FontStyle.Underline)

        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button5.BackColor = System.Drawing.Color.Transparent
        Timer1.Start()
        midscreen()

        GroupBox1.Visible = False
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
    Private Sub login()
        Using con As New SqlConnection(str)
            con.Open()
            cmd = New SqlCommand("login1", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@Username", txtusername.Text)
                .Parameters.AddWithValue("@Password", txtpassword.Text)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()

                If CInt(.Parameters("@result").Value = 1) Then
                    LoginSystem()
                Else
                    MsgBox("Username or Password are Invalid!", vbCritical)
                End If


            End With
        End Using
        con.Close()

    End Sub
    Sub LoginSystem()

        If txtusername.Text = "" And txtpassword.Text = "" Then
            MsgBox("All fields are required!", MsgBoxStyle.Critical)
        ElseIf txtusername.Text = "" Then
            MsgBox("Username is Required!", MsgBoxStyle.Critical)
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Password is Required!", MsgBoxStyle.Critical)
            txtpassword.Focus()
        Else

            Dim query2 As String = "SELECT  * FROM login WHERE Username =@Username and Password = @Password"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Dim hoho As String = dt.Rows(0)(2)
                                If hoho = "saleperson" Then
                                    Me.Hide()
                                    MsgBox("Welcome " & txtusername.Text & "!", MsgBoxStyle.Information)
                                    cashier.Show()

                                    cashier.Label12.Text = txtusername.Text
                                    selectfl()
                                ElseIf hoho = "admin     " Then
                                    Me.Hide()
                                    MsgBox("Welcome " & txtusername.Text & "!", MsgBoxStyle.Information)
                                    admin.Show()
                                    admin.Label9.Text = txtusername.Text
                                    selectfl()
                                End If

                            Else
                                MsgBox("Username or Password Are invalid!", MsgBoxStyle.Critical)
                                txtpassword.Text = ""
                                txtusername.Text = ""

                            End If

                        End Using
                    End Using
                End Using

            End Using

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()

    End Sub
    Private Sub selectfl()

        Dim query2 As String = "SELECT  first_name,last_name,usertype FROM accounts where username =@username"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)

                cmd.Parameters.AddWithValue("@username", txtusername.Text)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            TextBox6.Text = dt.Rows(0)("first_name")
                            TextBox5.Text = dt.Rows(0)("last_name")
                            TextBox4.Text = dt.Rows(0)("usertype")
                            insertlog()


                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using



    End Sub
    Private Sub insertlog()
        Try


            Dim first_name As String = TextBox6.Text
            Dim last_name As String = TextBox5.Text
            Dim usern As String = txtusername.Text
            Dim usert As String = TextBox4.Text
            Dim date1 As Date = DateTimePicker1.Value
            Dim timein As String = Label5.Text
            Dim query As String = "insert into log values (@first_name,@last_name,@timein,@timeout,@date,@username,@usertype)"

            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@first_name", first_name)
                    cmd.Parameters.AddWithValue("@last_name", last_name)
                    cmd.Parameters.AddWithValue("@username", txtusername.Text)
                    cmd.Parameters.AddWithValue("@timein", timein)
                    cmd.Parameters.AddWithValue("@timeout", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@usertype", usert)
                    cmd.Parameters.AddWithValue("@date", date1)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()


                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        With CheckBox1
            If .Checked Then
                txtpassword.UseSystemPasswordChar = False
            Else
                txtpassword.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        GroupBox1.Visible = True
        pass.UseSystemPasswordChar = True
        pass1.UseSystemPasswordChar = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If pass.Text = "" And pass1.Text = "" Then
            MsgBox("Please insert new password!", MsgBoxStyle.Exclamation)
        ElseIf pass.Text <> pass1.Text Then
            MsgBox("password doesn't match!", MsgBoxStyle.Exclamation)
        Else
            changepass()
            changepassacc()
            GroupBox1.Visible = False
            Panel1.Visible = True
        End If

    End Sub
    Private Sub changepass()
        Dim query As String = "UPDATE login SET password=@password WHERE username = @username"

        Dim password As String = pass.Text
        Dim username As String = TextBox7.Text
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@username", username)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                txtusername.Text = ""
                txtpassword.Text = ""


                MessageBox.Show("SUCCESSFULLY CHANGED")

            End Using
        End Using
    End Sub
    Private Sub changepassacc()
        Dim query As String = "UPDATE accounts SET password=@password WHERE username = @username"

        Dim password As String = pass.Text
        Dim username As String = TextBox7.Text
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@username", username)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                txtusername.Text = ""
                txtpassword.Text = ""



            End Using
        End Using
    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        With CheckBox2
            If .Checked Then
                pass.UseSystemPasswordChar = False
                pass1.UseSystemPasswordChar = False
            Else
                pass.UseSystemPasswordChar = True
                pass1.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class