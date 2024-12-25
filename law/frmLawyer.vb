Imports System.Data.SqlClient
Imports System.Data
Public Class frmLawyer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Int32
    Private Sub frmLawyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, role As String, lawyerID As String, password As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblName.Text = lblName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblRole.Text = lblRole.Tag + role
        lblNationality.Text = lblNationality.Tag + nationality
        lblLawyerID.Text = lblLawyerID.Tag + lawyerID

        frmUpdatePassword.oldPassword = password
        frmUpdatePassword.SignedInID = lawyerID
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmUpdatePassword.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        frmAddClient.Show()
        Me.Hide()
    End Sub

    Private Sub NewCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCaseToolStripMenuItem.Click
        frmAddCase.Show()
        Me.Hide()
    End Sub
End Class