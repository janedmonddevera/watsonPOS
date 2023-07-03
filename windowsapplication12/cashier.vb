Imports System.Data.SqlClient

Public Class cashier

  
    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        'TODO: This line of code loads data into the 'SystemDataSet8.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter4.Fill(Me.SystemDataSet8.products)
        'TODO: This line of code loads data into the 'SystemDataSet7.listtable' table. You can move, or remove it, as needed.
        Try
            Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
            'TODO: This line of code loads data into the 'SystemDataSet6.listtable' table. You can move, or remove it, as needed.
            Me.ListtableTableAdapter1.Fill(Me.SystemDataSet6.listtable)
        Catch ex As Exception

        End Try
        TextBox1.Text = 1
        Label5.Text = 0
        Unit_PriceTextBox.ReadOnly = True
        Button6.Enabled = False
        Button4.Enabled = False
        Panel8.Visible = False
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button7.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Label3.Text = DateTimePicker1.Text
        Timer1.Start()
        customerno()
        midscreen()
        Panel1.Visible = False
        Panel3.Visible = False
        Panel5.Visible = False

        Label19.Text = 0
        Label20.Text = 0
        queueno()
        Label24.Text = 0
        sum()
        sumtt()
        Button29.Enabled = False
        Button17.Enabled = False
        Button28.Enabled = False
        Button14.Visible = False



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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add()
        Me.ProductsTableAdapter4.Fill(Me.SystemDataSet8.products)
        Button29.Enabled = True
        Button17.Enabled = True
    End Sub
    Private Sub count()

        Dim query2 As String = "SELECT  Top 1(*) as total FROM customer_no ORDER BY DESC"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)


                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("Total").ToString()


                            Label13.Text = hoho
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
    End Sub
    Private Sub add()
        Try

      
        Dim pn As String = Product_IDTextBox.Text
        Dim query2 As String = "SELECT  * FROM products WHERE id = @Product_id"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@Product_id", pn)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim item As String = dt.Rows(0)("Item")
                            Dim hoho As String = dt.Rows(0)("unit_price")
                            Dim hoho1 As String = dt.Rows(0)("unit")
                            Product_NameTextBox.Text = item
                            Unit_PriceTextBox.Text = hoho
                            UnitTextBox.Text = hoho1
                                Dim q As Double = TextBox1.Text
                                Dim s As Double = UnitTextBox.Text
                            If q > s Then

                                MsgBox("Insufficient stock! Only " & s & " are the remaining stock", MsgBoxStyle.Information)
                                TextBox1.Text = s
                                TextBox1.Focus()
                            ElseIf TextBox1.Text = 0 Then
                                MsgBox("Please Enter a Valid Quantity!", MsgBoxStyle.Exclamation)
                            ElseIf UnitTextBox.Text <= 0 Then
                                MsgBox("No Stock Remaining! Please choose different product", MsgBoxStyle.Exclamation)
                            Else
                                insertlist()
                               Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
                                sum()
                                sumtt()

                            End If

                        Else


                        End If

                    End Using
                End Using
            End Using

        End Using


        Catch ex As Exception

        End Try


    End Sub

    Private Sub insertlist()



        Try

        
        Dim product_id As String = Product_IDTextBox.Text
        Dim product_name As String = Product_NameTextBox.Text
        Dim quantity As Integer = TextBox1.Text
            Dim price As Double = Unit_PriceTextBox.Text
            Dim d As Date = DateTimePicker1.Value
        Dim customerno As Integer = Label13.Text
            Dim cashier As String = Label12.Text
        Dim total As Double = 0
        Dim cash As Double = 0
        Dim change As Double = 0
        Dim tt As Double = 0
        Dim gt As Double = 0
        If TextBox1.Text = Nothing Then
            MsgBox("Please Enter your desired quantity for the selected product!", MsgBoxStyle.Critical)
            TextBox1.Focus()
        Else

            Dim query As String = "INSERT INTO listtable Values (@id,@item,@unit,@total_price,@date,@customer_no,@cashier,@total_amount,@cash,@change,@tax,@total_tax,@grand_total)"

            Using con As New SqlConnection(str)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", product_id)
                    cmd.Parameters.AddWithValue("@item", product_name)
                    cmd.Parameters.AddWithValue("@Unit", quantity)
                    cmd.Parameters.AddWithValue("@Date", d)
                    cmd.Parameters.AddWithValue("@Total_Price", price * quantity)
                    cmd.Parameters.AddWithValue("@Customer_no", customerno)
                    cmd.Parameters.AddWithValue("@cashier", cashier)
                    cmd.Parameters.AddWithValue("@total_amount", total)
                    cmd.Parameters.AddWithValue("@cash", cash)
                    cmd.Parameters.AddWithValue("@change", change)
                    cmd.Parameters.AddWithValue("@tax", price * 0.12)
                    cmd.Parameters.AddWithValue("@total_tax", tt)
                    cmd.Parameters.AddWithValue("@grand_total", gt)


                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()


                    MsgBox("Product added to list!", MsgBoxStyle.Information)
                End Using
            End Using
        End If
        updateproducts()
        Catch ex As Exception
            MsgBox("The Seleceted Product is already in your list", MsgBoxStyle.Exclamation)
        End Try

        sum()
        sumtt()

        Product_IDTextBox.Text = ""
        Product_NameTextBox.Text = ""
        TextBox1.Text = 1
        Unit_PriceTextBox.Text = ""
        Product_IDTextBox.Focus()

    End Sub

    Public Sub sum()
        Try


            Dim query2 As String = "SELECT  sum (total_Price) as total FROM listtable"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)


                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then

                                Dim hoho As Double = dt.Rows(0)("Total").ToString()


                                Label5.Text = hoho - Label19.Text
                                Label20.Text = hoho
                            Else



                            End If

                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Label5.Text = 0
            Label19.Text = 0
            Label20.Text = 0
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        removeproduct()
        Me.ProductsTableAdapter4.Fill(Me.SystemDataSet8.products)
        Button1.Enabled = True
        Product_IDTextBox.ReadOnly = False
        Product_NameTextBox.ReadOnly = False
        Button6.Enabled = False
        Button4.Enabled = False
    End Sub
    Private Sub removeproduct()


        Dim Product_name As String = Product_NameTextBox.Text
       

        Dim query2 As String = "SELECT  unit FROM products where item = @product_name"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@Product_name", Product_name)

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("unit").ToString()


                            UnitTextBox.Text = hoho
                            remove()
                            deleterow()
                            sum()
                            sumtt()
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
    End Sub
    Private Sub remove()
        Dim product_name As String = Product_NameTextBox.Text
        Dim query As String = "UPDATE products  SET Unit=@Unit WHERE item= @Product_name"
        Dim quantity As Integer = TextBox7.Text
        Dim q As Integer = UnitTextBox.Text
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Product_name", Product_name)

                cmd.Parameters.AddWithValue("@Unit", q + quantity)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        End Using
    End Sub
    Public Sub deleterow()

        Dim product_name As String = Product_NameTextBox.Text

        Dim query As String = "DELETE FROM listtable where item = @Product_Name"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Product_Name", product_name)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Product_IDTextBox.Text = ""
                Product_NameTextBox.Text = ""
                TextBox1.Text = 1
                Unit_PriceTextBox.Text = ""
                Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
                MessageBox.Show("SUCCESSFULLY DELETED")
            End Using
        End Using
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Product_name As String = Product_NameTextBox.Text


        Dim query2 As String = "SELECT  unit FROM products where item = @product_name"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@Product_name", Product_name)

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("unit").ToString()


                            UnitTextBox.Text = hoho
                            update1()
                            sum()
                            sumtt()
                            Me.ProductsTableAdapter4.Fill(Me.SystemDataSet8.products)
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
    End Sub
    Private Sub update1()

        Dim q As Integer = TextBox7.Text
        Dim a As Integer = UnitTextBox.Text
        Dim d As Integer = TextBox1.Text
        Dim qa As Integer = q + a
        If d > qa Then
            MsgBox("Insufficient stock! " & a & " are the remaining stock", MsgBoxStyle.Information)
            TextBox1.Text = a
            TextBox1.Focus()
        Else

            updated()
            updateproducts()
            Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
        End If
        Product_IDTextBox.Text = ""
        Product_NameTextBox.Text = ""
        TextBox1.Text = 1
        Unit_PriceTextBox.Text = ""
        Button1.Enabled = True
        Product_IDTextBox.ReadOnly = False
        Product_NameTextBox.ReadOnly = False
        Button6.Enabled = False
        Button4.Enabled = False
    End Sub
    Private Sub updated()

        Dim product_name As String = Product_NameTextBox.Text
        Dim quantity As Integer = TextBox1.Text
        Dim price As Integer = TextBox8.Text



        Dim query As String = "UPDATE listtable  SET   item=@Product_name,Unit=@unit,total_Price=@Price WHERE item = @Product_name"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Product_name", product_name)
                cmd.Parameters.AddWithValue("@unit", quantity)
                cmd.Parameters.AddWithValue("@Price", price * quantity)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


                MessageBox.Show("SUCCESSFULLY UPDATED")

            End Using
        End Using

    End Sub
    Private Sub updateproducts()
       
        Try

            Dim Product_name As String = Product_NameTextBox.Text
            Dim quantity As Integer = TextBox1.Text
            Dim d As Integer = UnitTextBox.Text

            If TextBox7.Text = "" Then
                TextBox7.Text = 0
            End If
            Dim query As String = "UPDATE products  SET Unit=@Unit WHERE item = @Product_name"

            Using con As New SqlConnection(str)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Product_name", Product_name)

                    cmd.Parameters.AddWithValue("@Unit", d + TextBox7.Text - quantity)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    TextBox7.Text = 0


                End Using
            End Using
            TextBox7.Text = ""
        Catch ex As Exception
           
        End Try
    End Sub




    Private Sub insertdata(selectrow As DataGridViewRow)
        Product_IDTextBox.Text = selectrow.Cells(0).Value
        Product_NameTextBox.Text = selectrow.Cells(1).Value.ToString()
        UnitTextBox.Text = selectrow.Cells(2).Value.ToString()
        Unit_PriceTextBox.Text = selectrow.Cells(3).Value.ToString()
    End Sub


    Private Sub insertdata1(selectrow As DataGridViewRow)
        Product_NameTextBox.Text = selectrow.Cells(1).Value.ToString()
        Unit_PriceTextBox.Text = selectrow.Cells(3).Value.ToString()
        TextBox7.Text = selectrow.Cells(0).Value.ToString()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        queue.Show()


        Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
        queue.QueuelistTableAdapter.Fill(queue.SystemDataSet8.queuelist)
        queue.QueueTableAdapter.Fill(queue.SystemDataSet8.queue)
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


   

    Private Sub deletelist()
        Dim query As String = "DELETE from listtable "

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub
   
    Private Sub insertreciept()


        Try


            Dim query As String = "INSERT INTO reciept SELECT * FROM listtable "

            Using con As New SqlConnection(str)
                Using cmd As SqlCommand = New SqlCommand(query, con)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End Using
            End Using

        Catch ex As Exception
            MsgBox("NOPE", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.ProductsTableAdapter3.Fill(Me.Pinakadataset.products)
        updateproducts()
    End Sub

    

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOG OUT?", "LOGOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Me.Hide()
            login.Show()
            updatelog()
            login.txtpassword.Text = ""
            login.txtusername.Text = ""
        ElseIf result = DialogResult.Cancel Then
          
        End If
        

    End Sub
    Private Sub updatelog()
        Dim timeout As String = Label6.Text
        Dim usern As String = Label12.Text
        Dim query As String = "update log set timeout=@timeout WHERE username = @username and date = @date"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@timeout", timeout)
                cmd.Parameters.AddWithValue("@username", usern)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                login.txtusername.Text = ""
                login.txtpassword.Text = ""



            End Using
        End Using
    End Sub
    Public Sub customerno()

        Dim query2 As String = "SELECT COUNT(*) as count FROM customer_no"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim hoho As String = dt.Rows(0)("count")
                            Label13.Text = hoho + 1




                        Else


                        End If

                    End Using
                End Using
            End Using

        End Using

    End Sub





    Private Sub Button12_Click(sender As Object, e As EventArgs)
        insertlist()
    End Sub
    Private Sub haha()
        Dim query2 As String = "SELECT  unit_price FROM products WHERE item=@product_name"

        Dim pn As String = Product_NameTextBox.Text
        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@product_name", pn)


                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Integer = dt.Rows(0)("unit_price").ToString()


                            TextBox8.Text = hoho
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Me.ListtableBindingSource2.MovePrevious()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Me.ListtableBindingSource2.MoveNext()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox4.Text = TextBox4.Text + "."
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox4.Text = TextBox4.Text + "."
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox4.Text = TextBox4.Text + "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox4.Text = TextBox4.Text + "1"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox4.Text = TextBox4.Text + "2"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox4.Text = TextBox4.Text + "3"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox4.Text = TextBox4.Text + "4"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox4.Text = TextBox4.Text + "5"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox4.Text = TextBox4.Text + "6"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox4.Text = TextBox4.Text + "7"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox4.Text = TextBox4.Text + "8"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox4.Text = TextBox4.Text + "9"
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox4.Text = ""
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox4.Text = TextBox4.Text.Remove(TextBox4.Text.Length - 1)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel3.Visible = True
        Panel3.Location = New System.Drawing.Point(13, 160)
        Panel7.Location = New System.Drawing.Point(8, 270)
        ListtableDataGridView.Location = New System.Drawing.Point(12, 270)
        ListtableDataGridView.Size = New System.Drawing.Size(681, 150)
        Button13.Visible = False
        Button14.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try

            tinapay1()
            gulaman()
            pandesal()
            pankek()
            updatesalesreport()

            Dim t1 As Double = Label20.Text
            Dim t2 As Double = TextBox4.Text
            Dim total As Double = Label20.Text
            Dim cash As Double = TextBox4.Text
            Dim cn As Integer = Label13.Text
            Dim tt As Double = Label19.Text
            Dim gt As Double = Label20.Text

            If t2 = 0 Then

                MsgBox("Please Insert Cash!", MsgBoxStyle.Critical)

            ElseIf t1 > t2 Then
                MsgBox("Insufficient Cash!", MsgBoxStyle.Exclamation)

            Else


                Label24.Text = t2 - t1
                Dim query As String = "UPDATE listtable SET Total_amount = @total_amount, Cash = @cash , change = @change,total_tax =@total_tax,Grand_total =@grand_total WHERE customer_no = @customer_no "

                Using con As New SqlConnection(str)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@customer_no", cn)
                        cmd.Parameters.AddWithValue("@Total_Amount", total)
                        cmd.Parameters.AddWithValue("@cash", cash)

                        cmd.Parameters.AddWithValue("@total_tax", tt)
                        cmd.Parameters.AddWithValue("@grand_total", gt)
                        cmd.Parameters.AddWithValue("@Change", t2 - t1)


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MsgBox("SUCCESSFULLY BOUGHT", MsgBoxStyle.Information)
                        insertreciept()
                        Button28.Enabled = True
                        Button1.Enabled = False
                    End Using
                End Using
            End If


        Catch ex As Exception

            MsgBox("INVALID! PLEASE TRY AGAIN", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub updatesalesreport()
        Try

       
        Dim dsum As Double = Label9.Text
        Dim wsum As Double = Label25.Text
        Dim msum As Double = Label26.Text
        Dim asum As Double = Label27.Text

        Dim query As String = "UPDATE salesreport SET dailysum = @dsum, weeklysum = @wsum , monthlysum = @msum,annualsum =@asum"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@dsum", dsum)
                cmd.Parameters.AddWithValue("@wsum", wsum)
                cmd.Parameters.AddWithValue("@msum", msum)
                cmd.Parameters.AddWithValue("@asum", asum)



                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Sub sumtt()
        Try


            Dim query2 As String = "SELECT  sum (tax) as total FROM listtable"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)


                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then

                                Dim hoho As Double = dt.Rows(0)("Total").ToString()
                                Label19.Text = hoho

                            Else



                            End If

                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Label5.Text = 0
            Label19.Text = 0
            Label20.Text = 0
        End Try
    End Sub
    Public Sub tinapay1()
        Try

        
            Dim query As String = "SELECT  sum(total_amount) as gtotal FROM reciept WHERE Date = @date "
        Using con As New SqlConnection(Str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("gTotal").ToString()
                                Label9.Text = hoho

                        Else



                        End If


                    End Using
                End Using
            End Using

        End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Sub pandesal()
        Try

       
            Dim query As String = "SELECT  sum(total_amount) as gtotal FROM reciept WHERE (Date<=@Date) and (Date>=@date1)"
        Using con As New SqlConnection(Str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", DateTimePicker2.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("gTotal").ToString()
                            Label25.Text = hoho
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Sub gulaman()
        Try

       
            Dim query As String = "SELECT sum(total_amount) as gtotal FROM reciept WHERE (Date<=@Date) and (Date>=@date1)  "
        Using con As New SqlConnection(Str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", DateTimePicker3.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("gTotal").ToString()
                            Label26.Text = hoho
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Sub pankek()
        Try

      
            Dim query As String = "SELECT sum(total_amount) as gtotal FROM reciept WHERE (Date<=@Date) and (Date>=@date1)  "
        Using con As New SqlConnection(Str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", DateTimePicker4.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Double = dt.Rows(0)("gTotal").ToString()
                            Label27.Text = hoho
                        Else



                        End If

                    End Using
                End Using
            End Using

        End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        buy.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        deletelist()

        Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
        addcus()
        customerno()
        Button1.Enabled = True
        Label5.Text = 0
        Label19.Text = 0
        Label20.Text = 0
        TextBox4.Text = ""
        Label24.Text = 0
        Button29.Enabled = False
        Button17.Enabled = False
        Button28.Enabled = False
    End Sub

    Private Sub ListtableDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ListtableDataGridView.CellContentClick
        Try

       
        Dim index As Integer = e.RowIndex
        Dim selectrow As DataGridViewRow = ListtableDataGridView.Rows(index)
        Dim Product_id As String = selectrow.Cells(0).Value.ToString
        Dim Product_name As String = selectrow.Cells(1).Value.ToString()
        If Product_name IsNot Nothing Then
            insertdata1(selectrow)
            haha()
            TextBox1.Focus()
            Button6.Enabled = True
            Button4.Enabled = True
            Product_IDTextBox.ReadOnly = True
            Product_NameTextBox.ReadOnly = True
            Button1.Enabled = False
        Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addcus()
        Dim query As String = "INSERT INTO customer_no Values (@customer_no)"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@customer_no", Label13.Text + 1)
                

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()



            End Using
        End Using
    End Sub

    
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Label23.Text > 10 Then
            MsgBox("QUEUE is full!", MsgBoxStyle.Information)
           
        Else
            insertqueue()
            queueno()
            Button1.Enabled = False
            MsgBox("Customer No. " & Label13.Text & " is now on hold!", MsgBoxStyle.Information)
            Label5.Text = ""
            Label20.Text = ""
            Label19.Text = ""
            Me.ListtableTableAdapter2.Fill(Me.SystemDataSet7.listtable)
        End If
      
    End Sub
    Private Sub queuelist()

        Dim query As String = "INSERT INTO queuelist Values (@queue)"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@queue", Label13.Text)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()



            End Using
        End Using

    End Sub
    Public Sub queueno()

        Dim query2 As String = "SELECT COUNT(*) as count FROM queuelist"


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim hoho As String = dt.Rows(0)("count")
                            Label23.Text = hoho
                            Button2.Text = "QUEUE (" & Label23.Text & ")"


                        Else


                        End If

                    End Using
                End Using
            End Using

        End Using
    End Sub
    Private Sub insertqueue()





        Dim query As String = "INSERT INTO queue SELECT * FROM listtable "

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()



            End Using
        End Using
       

        queuelist()
        deletelist()

    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectrow As DataGridViewRow = ProductsDataGridView.Rows(index)
        Dim Product_id As String = selectrow.Cells(0).Value.ToString
        Dim Product_name As String = selectrow.Cells(1).Value.ToString()
        If Product_name IsNot Nothing Then
            insertdata(selectrow)
            TextBox1.Focus()
            Button6.Enabled = False
            Button4.Enabled = False
            TextBox1.ReadOnly = False
            Product_NameTextBox.ReadOnly = False
            Button1.Enabled = True
        Else

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel3.Visible = False
        Panel7.Location = New System.Drawing.Point(8, 95)
        ListtableDataGridView.Location = New System.Drawing.Point(15, 95)
        ListtableDataGridView.Size = New System.Drawing.Size(681, 311)
        Button14.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.ProductsBindingSource4.Filter = "id LIKE '%" & TextBox9.Text & "%'or item LIKE '%" & TextBox9.Text & "%' or Category LIKE  '%" & TextBox9.Text & "%' "
        TextBox2.Text = ""
    End Sub

   

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ProductsBindingSource4.Filter = "id LIKE '%" & TextBox2.Text & "%'or item LIKE '%" & TextBox2.Text & "%' or Category LIKE  '%" & TextBox2.Text & "%' "
            TextBox5.Text = ""
        End If
    End Sub

   
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.ProductsBindingSource4.Filter = "id LIKE '%" & TextBox2.Text & "%'or item LIKE '%" & TextBox2.Text & "%' or Category LIKE  '%" & TextBox2.Text & "%' "
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer2.Interval = 500
        TargetDT = DateTime.Now.Add(CountDownFrom)
        Timer2.Start()
        Panel8.Visible = True
        Panel8.Location = New System.Drawing.Point(0.0, -15)
        Button8.Visible = False
       
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Panel8.Visible = False
        Button8.Visible = True
       
        Timer2.Stop()
    End Sub

    
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(30)

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            Label28.Text = ts.ToString("mm\:ss")
        Else
            Label28.Text = "00:00"
            Timer2.Stop()
            MessageBox.Show("BREAK'S OVER")
        End If
    End Sub
End Class
