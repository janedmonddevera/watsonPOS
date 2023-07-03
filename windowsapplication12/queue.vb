Imports System.Data.SqlClient

Public Class queue

    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet8.queue' table. You can move, or remove it, as needed.
        Me.QueueTableAdapter.Fill(Me.SystemDataSet8.queue)
        'TODO: This line of code loads data into the 'SystemDataSet7.listtable' table. You can move, or remove it, as needed.
        Me.ListtableTableAdapter.Fill(Me.SystemDataSet7.listtable)
        'TODO: This line of code loads data into the 'SystemDataSet8.queuelist' table. You can move, or remove it, as needed.
        Me.QueuelistTableAdapter.Fill(Me.SystemDataSet8.queuelist)

        midscreen()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192)

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
  


    Private Sub queuelist()
        Dim cn As Integer = TextBox1.Text
        Dim query As String = "INSERT INTO listtable SELECT * FROM queue WHERE customer_no = @customer_no"

        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@customer_no", cn)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

               

            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

        
        queuelist()
        deletequeue()
        deletequeuelist()
        cashier.queueno()
        Me.Hide()
        Me.QueueTableAdapter.Fill(Me.SystemDataSet8.queue)
        cashier.ListtableTableAdapter2.Fill(cashier.SystemDataSet7.listtable)
        cashier.Label13.Text = TextBox1.Text
        cashier.sum()
            cashier.sumtt()
            cashier.Label13.Text = TextBox1.Text
            cashier.Button17.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Public Sub deletequeue()

        Dim cn As String = TextBox1.Text

        Dim query As String = "DELETE FROM queue where customer_no = @customer_no"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@customer_no", cn)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        End Using
    End Sub
    Public Sub deletequeuelist()

        Dim cn As String = TextBox1.Text

        Dim query As String = "DELETE FROM queuelist where queue = @customer_no"
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@customer_no", cn)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        End Using
    End Sub
    Private Sub queue()
        Dim cn As Integer = TextBox1.Text
        Dim query2 As String = "SELECT  * FROM queue where customer_no=@customer_no "


        Using con As New SqlConnection(str)

            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@customer_no", cn)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                      
                        QueueDataGridView.DataSource = dt





                    End Using
                End Using
            End Using

        End Using
    End Sub

   
   

    Private Sub QueuelistDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles QueuelistDataGridView.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectrow As DataGridViewRow = QueuelistDataGridView.Rows(index)
        Dim Product_id As String = selectrow.Cells(0).Value.ToString

        If Product_id IsNot Nothing Then
            insertdata(selectrow)
            queue()
        Else

        End If
    End Sub
    Private Sub insertdata(selectrow As DataGridViewRow)
        TextBox1.Text = selectrow.Cells(0).Value
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
End Class