Public Class frmHome
    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        frmContact.Show()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ServeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServeToolStripMenuItem.Click
        frmServices.Show()
        Me.Hide()
    End Sub
End Class