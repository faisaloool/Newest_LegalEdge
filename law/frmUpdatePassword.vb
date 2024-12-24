Public Class frmUpdatePassword
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' here, you should update the database, but suggest it gets updated.
        MessageBox.Show("Password Updated Successfully.")
        frmLawyer.Show()
        Me.Hide()
    End Sub
End Class