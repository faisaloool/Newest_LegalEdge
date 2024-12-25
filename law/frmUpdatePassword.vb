Imports System.Data.SqlClient

Public Class frmUpdatePassword
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Int32
    Public SignedInID As String
    Public oldPassword As String

    Private Sub frmUpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Desktop\meow\law\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If oldPassword = TextBox1.Text Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Lawyer set Password = '" + TextBox2.Text + "' where Lawyer_ID = " + SignedInID + ""
                cmd.ExecuteNonQuery()
            End If
            MessageBox.Show("Password Updated Successfully.")
            frmLawyer.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An Error Occurred")
        End Try
    End Sub

End Class