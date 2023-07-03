Imports System.Data.SqlClient


Public Class buy
    Dim str As String = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    Private Sub buy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buy()
        midscreen()
       
    End Sub

    Public Sub buy()

        Dim query As String = "SELECT * FROM reciept WHERE Customer_no = @customer_no "
        Using con As New SqlConnection(str)
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@customer_no", cashier.Label13.Text)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)

                        Dim r1 As New CrystalReport1
                        r1.SetDataSource(dt)

                        CrystalReportViewer1.ReportSource = r1

                        CrystalReportViewer1.RefreshReport()

                        CrystalReportViewer1.Refresh()
                    End Using
                End Using
            End Using

        End Using
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

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class