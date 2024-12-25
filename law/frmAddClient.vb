Imports System.Data.SqlClient
Imports System.Data
Public Class frmAddClient
    Dim cmd As New SqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        frmLawyer.Show()
        Me.Close()
        'meow
    End Sub
End Class