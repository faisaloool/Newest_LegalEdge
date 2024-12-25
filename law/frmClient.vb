Imports System.Data
Imports System.Data.SqlClient
Public Class frmClient
    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, nationalID As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblName.Text = lblName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblNationality.Text = lblNationality.Tag + nationality
        lblNationalID.Text = lblNationalID.Tag + nationalID
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub
End Class