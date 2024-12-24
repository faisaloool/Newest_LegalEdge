Imports System.Data.SqlClient

Public Class frmLawyer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Int32
    Private Sub frmLawyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, role As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblName.Text = lblName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblRole.Text = lblRole.Tag + role
        lblNationality.Text = lblNationality.Tag + nationality
    End Sub


End Class