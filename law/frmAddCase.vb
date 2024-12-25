Public Class frmAddCase
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("Criminal")
        ComboBox1.Items.Add("Civil")
        ComboBox1.Items.Add("Administrative")
        ComboBox1.Items.Add("Business and Corporate")
        ComboBox1.Items.Add("Administrative")

        ComboBox1.Items.Add("Environmental")
        ComboBox1.Items.Add("Tax")

        ComboBox1.Items.Add("International")
    End Sub

    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class