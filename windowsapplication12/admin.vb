Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class admin
   
    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        'TODO: This line of code loads data into the 'SystemDataSet13.log' table. You can move, or remove it, as needed.
        Me.LogTableAdapter3.Fill(Me.SystemDataSet13.log)
        'TODO: This line of code loads data into the 'Datesetdataset.reciept' table. You can move, or remove it, as needed.
        Me.RecieptTableAdapter.Fill(Me.Datesetdataset.reciept)
        'TODO: This line of code loads data into the 'Datesetdataset.log' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'SystemDataSet10.accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter1.Fill(Me.SystemDataSet10.accounts)
        'TODO: This line of code loads data into the 'SystemDataSet9.accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.SystemDataSet9.accounts)
        'TODO: This line of code loads data into the 'SystemDataSet8.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
        'TODO: This line of code loads data into the 'SystemDataSet3.products' table. You can move, or remove it, as needed.
        WebBrowser1.Visible = False
        WebBrowser2.Visible = False

        Label9.Text = login.txtusername.Text
        Button7.Enabled = False

        Button6.Enabled = False
        Label6.Text = cashier.DateTimePicker1.Value
        Panel4.Visible = False

        Button33.FlatStyle = FlatStyle.Flat
        Button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button33.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button34.FlatStyle = FlatStyle.Flat
        Button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button34.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        WebBrowser1.Visible = False

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button11.FlatStyle = FlatStyle.Flat
        Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button11.BackColor = System.Drawing.Color.White

        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)


        Timer1.Start()

        Button10.FlatStyle = FlatStyle.Flat
        Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button10.BackColor = System.Drawing.Color.Transparent

        Button9.FlatStyle = FlatStyle.Flat
        Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button9.BackColor = System.Drawing.Color.Transparent

        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button8.BackColor = System.Drawing.Color.Transparent

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button2.BackColor = System.Drawing.Color.Transparent

        Button13.FlatStyle = FlatStyle.Flat
        Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button13.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button14.FlatStyle = FlatStyle.Flat
        Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button19.FlatStyle = FlatStyle.Flat
        Button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button20.FlatStyle = FlatStyle.Flat
        Button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button36.FlatStyle = FlatStyle.Flat
        Button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button36.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button37.FlatStyle = FlatStyle.Flat
        Button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button37.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button38.FlatStyle = FlatStyle.Flat
        Button38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button38.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)


        CrystalReportViewer1.Visible = False
        CrystalReportViewer2.Visible = False
        CrystalReportViewer3.Visible = False
        CrystalReportViewer4.Visible = False
        sumcost()
        sumincome()
        sumincomeasoftoday()
        sumloss()

        midscreen()
        PictureBox4.Visible = False
        PictureBox6.Visible = False

        GroupBox4.Visible = False

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
        sumcost()
        sumincome()
        sumincomeasoftoday()
        sumloss()
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


    Public Sub tinapay1()

        Dim query As String = "SELECT  * FROM reciept WHERE Date = @date ORDER BY Date ASC "
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", cashier.DateTimePicker1.Value)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        Dim r1 As New dailysales

                        r1.SetDataSource(dt)

                        CrystalReportViewer1.ReportSource = r1

                        CrystalReportViewer1.RefreshReport()

                        CrystalReportViewer1.Refresh()


                    End Using
                End Using
            End Using

        End Using

    End Sub
    Public Sub pandesal()

        Dim query As String = "SELECT  * FROM reciept WHERE (Date<=@Date) and (Date>=@date1) ORDER BY Date ASC "
        Using con As New SqlConnection(str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", cashier.DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", cashier.DateTimePicker2.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        Dim r1 As New weeklysales
                        r1.SetDataSource(dt)

                        CrystalReportViewer2.ReportSource = r1

                        CrystalReportViewer2.RefreshReport()

                        CrystalReportViewer2.Refresh()

                    End Using
                End Using
            End Using

        End Using

    End Sub
    Public Sub gulaman()

        Dim query As String = "SELECT * FROM reciept WHERE (Date<=@Date) and (Date>=@date1) ORDER BY Date ASC  "
        Using con As New SqlConnection(str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", cashier.DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", cashier.DateTimePicker3.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)


                        Dim r1 As New monthlysales
                        r1.SetDataSource(dt)

                        CrystalReportViewer3.ReportSource = r1

                        CrystalReportViewer3.RefreshReport()

                        CrystalReportViewer3.Refresh()

                    End Using
                End Using
            End Using

        End Using

    End Sub
    Public Sub pankek()

        Dim query As String = "SELECT * FROM reciept WHERE (Date<=@Date) and (Date>=@date1)  ORDER BY Date ASC "
        Using con As New SqlConnection(str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", cashier.DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Date1", cashier.DateTimePicker4.Value)

                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        Dim r1 As New yearlysales
                        r1.SetDataSource(dt)

                        CrystalReportViewer4.ReportSource = r1

                        CrystalReportViewer4.RefreshReport()

                        CrystalReportViewer4.Refresh()

                    End Using
                End Using
            End Using

        End Using


    End Sub
    Public Sub tinola()


        Dim query As String = "SELECT * FROM reciept ORDER BY Date ASC "
        Using con As New SqlConnection(str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)



                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)


                    End Using
                End Using
            End Using

        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = System.Drawing.Color.White
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Me.ProductsBindingSource.Filter = "Product_name LIKE '%" & TextBox7.Text & "%' or Product_id LIKE '%" & TextBox7.Text & "%'"
        GroupBox1.Location = New System.Drawing.Point(43, 187)
        GroupBox1.Visible = True

        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
        Button3.Enabled = True
        Button11.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.BackColor = System.Drawing.Color.White
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
        GroupBox4.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
        Button3.Enabled = True
        Button1.Visible = True
    End Sub

   
    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox6.Text & "%'or item LIKE '%" & TextBox6.Text & "%' or Category LIKE '%" & TextBox6.Text & "%'"
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox7.Text & "%'or item LIKE '%" & TextBox7.Text & "%' or Category LIKE '%" & TextBox7.Text & "%'"
        TextBox6.Text = ""
    End Sub



    Private Sub ProductsDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView1.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectrow As DataGridViewRow = ProductsDataGridView1.Rows(index)
        Dim Product_id As String = selectrow.Cells(0).Value.ToString
        Dim Product_name As String = selectrow.Cells(1).Value.ToString()
        If Product_name IsNot Nothing Then
            insertdata(selectrow)
            Button5.Enabled = False
            Button7.Enabled = True
            Button6.Enabled = True
        Else

        End If
    End Sub
    Private Sub insertdata(selectrow As DataGridViewRow)
        TextBox1.Text = selectrow.Cells(0).Value
        TextBox2.Text = selectrow.Cells(1).Value.ToString()
        TextBox3.Text = selectrow.Cells(2).Value.ToString()
        TextBox4.Text = selectrow.Cells(3).Value.ToString()
        CategoryTextBox.Text = selectrow.Cells(4).Value.ToString()
        CostTextBox1.Text = selectrow.Cells(5).Value.ToString()
        Manufactured_DateDateTimePicker.Value = selectrow.Cells(6).Value.ToString()
        Expiration_DateDateTimePicker.Value = selectrow.Cells(7).Value.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        add()
        sumcost()
        sumincome()
        sumincomeasoftoday()
        sumloss()

        Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
        Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox7.Text & "%'or item LIKE '%" & TextBox7.Text & "%' or Category LIKE '%" & TextBox7.Text & "%'"
        TextBox5.Text = ""
        refreshproducts()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        CostTextBox1.Text = ""
        CategoryTextBox.Text = ""
    End Sub
    Private Sub sumcost()
        Try


            Dim query2 As String = "SELECT  sum (cost) as total FROM products"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)


                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then

                                Dim hoho As Double = dt.Rows(0)("Total").ToString()


                                Label10.Text = hoho
                            Else



                            End If

                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Label10.Text = 0
        End Try

    End Sub
    Private Sub sumincome()
        Try


            Dim query2 As String = "SELECT  sum (total_price) as total FROM products"


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
        Catch ex As Exception
            Label13.Text = 0
        End Try

    End Sub
    Private Sub sumincomeasoftoday()
        Try


            Dim query2 As String = "SELECT  sum(total_price) as total FROM reciept"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)


                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then

                                Dim hoho As Double = dt.Rows(0)("total").ToString()


                                Label11.Text = hoho
                            Else


                            End If

                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Label11.Text = 0
        End Try

    End Sub
    Private Sub sumloss()
        Try


            Dim query2 As String = "SELECT  sum (total_price) as total FROM products where expiration_date<@date"


            Using con As New SqlConnection(str)

                Using cmd As SqlCommand = New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@date", cashier.DateTimePicker1.Value)

                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd

                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then

                                Dim hoho As Double = dt.Rows(0)("Total").ToString()


                                Label12.Text = hoho
                            Else
                                Label12.Text = 0


                            End If

                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            Label12.Text = 0
        End Try

    End Sub
    Private Sub add()
        Try
            If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
                MsgBox("All fields are Required! Please enter the corresponding data needed to add", MsgBoxStyle.Exclamation)
            Else

                Dim product_id As String = TextBox1.Text
                Dim product_name As String = TextBox2.Text
                Dim quantity As Double = TextBox3.Text
                Dim price As Double = TextBox4.Text
                Dim mfd As Date = Manufactured_DateDateTimePicker.Value
                Dim expd As Date = Expiration_DateDateTimePicker.Value
                Dim cost As Double = CostTextBox1.Text
                Dim cat As String = CategoryTextBox.Text
                Dim query As String = "INSERT INTO products VALUES (@id,@item,@Unit,@Unit_Price,@Total_price,@Manufactured_Date,@Expiration_Date,@Cost,@category)"

                Using con As New SqlConnection(str)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", product_id)
                        cmd.Parameters.AddWithValue("@item", product_name)
                        cmd.Parameters.AddWithValue("@Unit", quantity)
                        cmd.Parameters.AddWithValue("@Unit_Price", price)
                        cmd.Parameters.AddWithValue("@Total_price", price * quantity)
                        cmd.Parameters.AddWithValue("@Manufactured_Date", mfd)
                        cmd.Parameters.AddWithValue("@Expiration_Date", expd)
                        cmd.Parameters.AddWithValue("@cost", cost)
                        cmd.Parameters.AddWithValue("@category", cat)

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MsgBox("Product has been added to the list!", MsgBoxStyle.Information)
                    End Using
                End Using
            End If
            Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
        Catch ex As Exception
            MsgBox("A product with the same id is already in the list!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
        Dim product_name As String = TextBox2.Text

        Dim query As String = "DELETE FROM products where item = @Product_name"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Product_name", product_name)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                CostTextBox1.Text = ""
                CategoryTextBox.Text = ""
                sumcost()
                sumincome()
                sumincomeasoftoday()
                sumloss()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information)
                Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox7.Text & "%'or item LIKE '%" & TextBox7.Text & "%' or Category LIKE '%" & TextBox7.Text & "%'"
                TextBox5.Text = ""
                refreshproducts()
            End Using
        End Using
        Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Product_id As String = TextBox1.Text
        Dim Product_name As String = TextBox2.Text
        Dim Quantity As Double = TextBox3.Text
        Dim Price As Double = TextBox4.Text
        Dim mfd As Date = Manufactured_DateDateTimePicker.Value
        Dim expd As Date = Expiration_DateDateTimePicker.Value
        Dim cost As Double = CostTextBox1.Text
        Dim cat As String = CategoryTextBox.Text

        Dim query As String = "UPDATE products SET id=@Product_id , item=@Product_name,Unit=@Unit,Unit_Price=@Unit_Price,Total_Price=@Total_Price,Manufactured_Date=@Manufactured_date,Expiration_Date =@expiration_Date,Cost = @cost,Category = @category WHERE id = @Product_id"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Product_id", Product_id)
                cmd.Parameters.AddWithValue("@Product_name", Product_name)
                cmd.Parameters.AddWithValue("@Unit", Quantity)
                cmd.Parameters.AddWithValue("@Unit_Price", Price)
                cmd.Parameters.AddWithValue("@Total_Price", Price * Quantity)
                cmd.Parameters.AddWithValue("@Manufactured_Date", mfd)
                cmd.Parameters.AddWithValue("@Expiration_date", expd)
                cmd.Parameters.AddWithValue("@cost", cost)
                cmd.Parameters.AddWithValue("@category", cat)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                CostTextBox1.Text = ""
                CategoryTextBox.Text = ""

                MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information)
                sumcost()
                sumincome()
                sumincomeasoftoday()
                sumloss()
                Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox7.Text & "%'or item LIKE '%" & TextBox7.Text & "%' or Category LIKE '%" & TextBox7.Text & "%'"
                TextBox5.Text = ""
                refreshproducts()
            End Using
        End Using
        Me.ProductsTableAdapter3.Fill(Me.SystemDataSet8.products)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Me.ProductsBindingSource3.MoveFirst()
        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.ProductsBindingSource3.MovePrevious()
        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductsBindingSource3.MoveNext()
        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.ProductsBindingSource3.MoveLast()
        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        search()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Button5.Enabled = True
        Button6.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub
    Private Sub search()

        Dim query As String = "SELECT count(*) as count FROM products "


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query, con)


                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Dim hoho As Integer = dt.Rows(0)("count").ToString()
                            hoho = hoho + 1
                            TextBox1.Text = "P-" & hoho & ""
                        Else
                            TextBox1.Text = 1
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            TextBox4.Text = ""



                        End If


                    End Using
                End Using
            End Using
        End Using

    End Sub

  
    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox5.Text & "%'or item LIKE '%" & TextBox5.Text & "%' or Category LIKE '%" & TextBox5.Text & "%'"
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox7.Text & "%'or item LIKE '%" & TextBox7.Text & "%' or Category LIKE '%" & TextBox7.Text & "%'"
        TextBox5.Text = ""
        refreshproducts()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button11.Visible = True
        Panel4.Visible = False
        GroupBox2.Location = New System.Drawing.Point(43, 187)
        GroupBox4.Visible = False
        GroupBox3.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
        Button1.Enabled = True

     
        Button3.BackColor = System.Drawing.Color.White
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button33.BackColor = System.Drawing.Color.White
        




        

        Dim lbl11 As Double = Label11.Text
        Dim lbl10 As Double = Label10.Text
        Label21.Text = lbl11 - lbl10

        If Label21.Text < 0 Then
            PictureBox4.Visible = False
            PictureBox6.Visible = True
        Else
            PictureBox4.Visible = True
            PictureBox6.Visible = False
        End If

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then


            tinapay1()

            CrystalReportViewer1.Visible = True

        Else
            CrystalReportViewer2.Visible = False
            CrystalReportViewer3.Visible = False
            CrystalReportViewer4.Visible = False


        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        With RadioButton2
            If .Checked Then


                pandesal()
               
                CrystalReportViewer2.Visible = True
            Else
                CrystalReportViewer1.Visible = False
                CrystalReportViewer3.Visible = False
                CrystalReportViewer4.Visible = False



            
            End If
        End With
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        With RadioButton3
            If .Checked Then

                gulaman()
              
                CrystalReportViewer3.Visible = True
            Else
                CrystalReportViewer1.Visible = False
                CrystalReportViewer2.Visible = False
                CrystalReportViewer4.Visible = False


            End If
        End With
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        With RadioButton4
            If .Checked Then


                pankek()
            
                CrystalReportViewer4.Visible = True
            Else
                CrystalReportViewer1.Visible = False
                CrystalReportViewer2.Visible = False
                CrystalReportViewer3.Visible = False



         
            End If
        End With
    End Sub

    








    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = System.Drawing.Color.White
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = True
        GroupBox15.Location = New System.Drawing.Point(43, 187)
        Me.LogBindingSource3.Filter = "usertype LIKE '%" & TextBox7.Text & "%'"
        TextBox15.Text = ""
        Me.LogTableAdapter3.Fill(Me.SystemDataSet13.log)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        EmailTextBox.Enabled = False
        AgeTextBox.Enabled = False
        GenderTextBox.Enabled = False
        AddressTextBox.Enabled = False
        TextBox12.Enabled = False
        Button14.BackColor = System.Drawing.Color.White
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

        GroupBox4.Visible = True
        GroupBox3.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
        accounts()
        GroupBox4.Location = New System.Drawing.Point(43, 187)

        Button24.Enabled = False
        Button25.Enabled = False
        Button30.Enabled = False

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

       

        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOG OUT?", "LOGOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            updatelog()
            login.Show()
            Me.Hide()
            Me.LogTableAdapter3.Fill(Me.SystemDataSet13.log)
            cashier.ProductsTableAdapter4.Fill(cashier.SystemDataSet8.products)
        ElseIf result = DialogResult.Cancel Then

        End If
    End Sub
    Private Sub updatelog()
        Dim timeout As String = Label7.Text
        Dim usern As String = Label9.Text
        Dim query As String = "update log set timeout=@timeout WHERE username = @username and date = @date"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@timeout", timeout)
                cmd.Parameters.AddWithValue("@username", usern)
                cmd.Parameters.AddWithValue("@date", login.DateTimePicker1.Value)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                login.txtusername.Text = ""
                login.txtpassword.Text = ""



            End Using
        End Using
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.White
        Button20.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        GroupBox13.Location = New System.Drawing.Point(43, 187)
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = True
        GroupBox15.Visible = False

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button14.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button19.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button20.BackColor = System.Drawing.Color.White
        Button4.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button11.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
      
        Button36.BackColor = System.Drawing.Color.White
        GroupBox12.Location = New System.Drawing.Point(43, 187)
        GroupBox12.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox13.Visible = False
        GroupBox15.Visible = False
    End Sub



    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        Dim ofd As New OpenFileDialog


        ofd.Filter = "images|*.jpg;*.png;*.gif;,*.bmp"


        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox5.Image = Image.FromFile(ofd.FileName)

        End If
    End Sub
    Public Sub accounts()
        Try

       
        Dim usern As String = UsernameTextBox.Text
            Dim query As String = "SELECT  * FROM accounts WHERE username = @username  "
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", usern)
                con.Open()
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                First_nameTextBox.Text = dt.Rows(0)(1)
                                Last_nameTextBox.Text = dt.Rows(0)(2)
                                EmailTextBox.Text = dt.Rows(0)(3)
                                AgeTextBox.Text = dt.Rows(0)(4)
                                GenderTextBox.Text = dt.Rows(0)(5)
                                AddressTextBox.Text = dt.Rows(0)(6)
                                TextBox12.Text = dt.Rows(0)(10)


                                Dim img() As Byte
                                img = dt(0)(0)

                                Dim ms As New MemoryStream(img)

                                PictureBox5.Image = Image.FromStream(ms)


                            End If


                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            MsgBox("NO DATA!", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    


    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        updateacc()
        Me.AccountsTableAdapter1.Fill(Me.SystemDataSet10.accounts)
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        EmailTextBox.Enabled = False
        AgeTextBox.Enabled = False
        GenderTextBox.Enabled = False
        AddressTextBox.Enabled = False
        TextBox12.Enabled = False
    End Sub
    Private Sub updateacc()


        Try

      
        Dim fn As String = First_nameTextBox.Text
        Dim ln As String = Last_nameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim age As Integer = AgeTextBox.Text
        Dim gender As String = GenderTextBox.Text
        Dim address As String = AddressTextBox.Text
        Dim username As String = UsernameTextBox.Text
            Dim salary As Double = TextBox12.Text
            Dim query As String = "update  accounts set img=@img,first_name=@First_name,last_name=@Last_name,email=@Email,age=@age,gender=@gender,address=@address,username=@username,salary = @salary where username = @username"
        Dim memstr As New MemoryStream


        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                PictureBox5.Image.Save(memstr, System.Drawing.Imaging.ImageFormat.Jpeg)
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
                cmd.Parameters.AddWithValue("@img", arrimage)
                    cmd.Parameters.AddWithValue("@salary", salary)
                MsgBox("UPDATED SUCCESSFULLY!", MsgBoxStyle.Information)


                cmd.ExecuteNonQuery()
                con.Close()
                    logname()


            End Using
        End Using
        Catch ex As Exception
            MsgBox("Something went wrong! please try again", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub logname()
        Dim query As String = "update  log set first_name =@first_name,last_name=@last_name where username = @username"

        Dim fn As String = First_nameTextBox.Text
        Dim ln As String = Last_nameTextBox.Text
        Dim username As String = UsernameTextBox.Text
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@first_name", fn)
                cmd.Parameters.AddWithValue("@last_name", ln)



                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        End Using
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Hide()
        create.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        GroupBox6.Visible = True
        GroupBox5.Visible = False
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        GroupBox6.Visible = False
        GroupBox5.Visible = True
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If TextBox9.Text = "" And TextBox10.Text = "" Then
            MsgBox("Please insert password!", MsgBoxStyle.Critical)
        ElseIf TextBox10.Text <> TextBox9.Text Then
            MsgBox("Passwrod does not match!", MsgBoxStyle.Exclamation)
        Else
            updatepassword()
            GroupBox6.Visible = False
            GroupBox5.Visible = True
        End If
    End Sub
    Private Sub updatepassword()
        Dim usern As String = UsernameTextBox.Text
        Dim passw As String = TextBox9.Text
        Dim query As String = "UPDATE accounts SET password = @password where username=@username"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@password", passw)
                cmd.Parameters.AddWithValue("@username", usern)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""

                MessageBox.Show("SUCCESSFULLY UPDATED")
                updatepassword1()
            End Using
        End Using
    End Sub
    Private Sub updatepassword1()
        Dim usern As String = UsernameTextBox.Text
        Dim passw As String = TextBox9.Text
        Dim query As String = "UPDATE login SET password = @password where username=@username"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@password", passw)
                cmd.Parameters.AddWithValue("@username", usern)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""


            End Using
        End Using
    End Sub

    

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Panel4.Visible = True
        CrystalReportViewer1.Visible = True
        CrystalReportViewer2.Visible = False
        CrystalReportViewer3.Visible = False
        CrystalReportViewer4.Visible = False
        RadioButton1.Checked = True
        Panel8.Visible = False
        Button34.BackColor = System.Drawing.Color.White
        Button33.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        expireditems()
    End Sub
    Public Sub expireditems()

        Dim query As String = "SELECT  * FROM products WHERE expiration_date < @date ORDER BY expiration_date ASC "
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Date", cashier.DateTimePicker1.Value)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()



                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ProductsDataGridView1.DataSource = dt
                        Else
                            MsgBox("NO DATA TO SHOW!", MsgBoxStyle.Information)
                        End If

                    End Using
                End Using
            End Using

        End Using

    End Sub
    Public Sub refreshproducts()

        Dim query As String = "SELECT  * FROM products  ORDER BY id "
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)


                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        ProductsDataGridView1.DataSource = dt


                    End Using
                End Using
            End Using

        End Using

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        accounts()
    End Sub

    Private Sub AccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGridView.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectrow As DataGridViewRow = AccountsDataGridView.Rows(index)
        Dim first_name As String = selectrow.Cells(0).Value.ToString
        Dim last_name As String = selectrow.Cells(1).Value.ToString()
        If last_name IsNot Nothing Then
            insertdataacc(selectrow)
            accounts()
        Else

        End If
    End Sub
    Private Sub insertdataacc(selectrow As DataGridViewRow)
        UsernameTextBox.Text = selectrow.Cells(6).Value

    End Sub


    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Button24.Enabled = True
        Button25.Enabled = True
        Button30.Enabled = True
        First_nameTextBox.Enabled = True
        Last_nameTextBox.Enabled = True
        EmailTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GenderTextBox.Enabled = True
        AddressTextBox.Enabled = True
        TextBox12.Enabled = True
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Panel8.Visible = True
        Panel4.Visible = False
        Button33.BackColor = System.Drawing.Color.White
        Button34.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        outofstock()
    End Sub
    Private Sub outofstock()


        Dim query As String = "SELECT  * FROM products WHERE unit = 0"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ProductsDataGridView1.DataSource = dt
                        Else
                            MsgBox("NO DATA TO SHOW!", MsgBoxStyle.Information)
                        End If



                    End Using
                End Using
            End Using

        End Using

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        replenish()
    End Sub
    Private Sub replenish()



        Dim query As String = "SELECT  * FROM products WHERE unit<50"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            ProductsDataGridView1.DataSource = dt
                        Else
                            MsgBox("NO DATA TO SHOW!", MsgBoxStyle.Information)
                        End If



                    End Using
                End Using
            End Using

        End Using

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        WebBrowser1.Visible = True
        WebBrowser2.Visible = False
        Panel10.Visible = False
        Button38.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button37.BackColor = System.Drawing.Color.White
        Button36.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        WebBrowser1.Visible = False
        WebBrowser2.Visible = True
        Panel10.Visible = False
        Button38.BackColor = System.Drawing.Color.White
        Button37.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button36.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        WebBrowser1.Visible = False
        WebBrowser2.Visible = False
        Panel10.Visible = True
        Button38.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button37.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)
        Button36.BackColor = System.Drawing.Color.White
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Me.AccountsTableAdapter1.Fill(Me.SystemDataSet10.accounts)
        Me.AccountsBindingSource1.Filter = "first_name LIKE '%" & TextBox7.Text & "%'"
        TextBox8.Text = ""
    End Sub

  

    Private Sub TextBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.AccountsBindingSource1.Filter = "first_name LIKE '%" & TextBox8.Text & "%'or last_name LIKE '%" & TextBox8.Text & "%' or username LIKE '%" & TextBox8.Text & "%'"
        End If
    End Sub

  

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        searchtransac()
        RecieptDataGridView.Visible = False
    End Sub
    Private Sub searchtransac()


        Dim query As String = "SELECT  * FROM reciept WHERE customer_no = @customer_no "
        Using con As New SqlConnection(str)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@customer_no", TextBox11.Text)


                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Dim r1 As New CrystalReport1
                            r1.SetDataSource(dt)

                            CrystalReportViewer5.ReportSource = r1

                            CrystalReportViewer5.RefreshReport()

                            CrystalReportViewer5.Refresh()
                        Else
                            MsgBox("NO DATA TO SHOW!", MsgBoxStyle.Information)

                        End If
                      

                    End Using
                End Using
            End Using

        End Using

    End Sub

    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchtransac()
        End If
    End Sub

  
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        CrystalReportViewer5.Visible = False
        RecieptDataGridView.Visible = True
        TextBox11.Text = ""
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.LogBindingSource3.Filter = "date = '" & DateTimePicker2.Value & "'"
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Me.LogBindingSource3.Filter = "usertype LIKE '%" & Button43.Text & "%'"

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Me.LogBindingSource3.Filter = "usertype LIKE '%" & Button44.Text & "%'"
    End Sub

 
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LogDataGridView.CellContentClick

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Me.LogBindingSource3.Filter = "usertype LIKE '%" & TextBox7.Text & "%'"
        TextBox15.Text = ""
        Me.LogTableAdapter3.Fill(Me.SystemDataSet13.log)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox6.Text & "%'or item LIKE '%" & TextBox6.Text & "%' or Category LIKE  '%" & TextBox6.Text & "%' "
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.ProductsBindingSource3.Filter = "id LIKE '%" & TextBox5.Text & "%'or item LIKE '%" & TextBox5.Text & "%' or Category LIKE '%" & TextBox5.Text & "%'"
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Me.AccountsBindingSource1.Filter = "first_name LIKE '%" & TextBox8.Text & "%'or last_name LIKE '%" & TextBox8.Text & "%' or username LIKE '%" & TextBox8.Text & "%'"
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Me.LogBindingSource3.Filter = "usertype LIKE '%" & TextBox15.Text & "%' or first_name LIKE '%" & TextBox15.Text & "%' or last_name LIKE '%" & TextBox15.Text & "%' or username LIKE '%" & TextBox15.Text & "%'"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try

      
        Dim query As String = "DELETE FROM accounts where username = @username"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("SUCCESSFULLY DELETED")
            End Using
        End Using

        Dim query1 As String = "DELETE FROM login where username = @username"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query1, con)

                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            End Using
        End Using
            Me.AccountsTableAdapter1.Fill(Me.SystemDataSet10.accounts)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox10.UseSystemPasswordChar = False
            TextBox9.UseSystemPasswordChar = False
        Else
            TextBox10.UseSystemPasswordChar = True
            TextBox9.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        cashier.Show()
        Me.Hide()
        cashier.Label12.Text = Label9.Text
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim query As String = "DELETE from reciept "

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        cashier.tinapay1()
        cashier.gulaman()
        cashier.pandesal()
        cashier.pankek()
        sumincomeasoftoday()
        tinapay1()
        gulaman()
        pandesal()
        pankek()
        Dim lbl11 As Double = Label11.Text
        Dim lbl10 As Double = Label10.Text
        Label21.Text = lbl11 - lbl10
        custno()
    End Sub
    Private Sub custno()
        Dim query As String = "DELETE from customer_no "

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

End Class