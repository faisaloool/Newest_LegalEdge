Imports System.Data.SqlClient

Public Class frmAddClient
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\albab\OneDrive\Desktop\law newest\new law\law (2)\law\law\LegalEdgeDatabase.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub MyPRofileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyPRofileToolStripMenuItem.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Client values ('" + txtName.Text + "', '" + txtBirthdate.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + comboGender.Text + "', '" + txtPhone.Text + "', '" + txtNationality.Text + "', '" + txtPassword.Text + "', '" + txtNationalIDNumber.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Client Inserted Successfully")
    End Sub
End Class