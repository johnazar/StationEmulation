Public Class FrmAnd
    Private Sub PicAndMachineLogo_Click(sender As Object, e As EventArgs) Handles PicAndMachineLogo.Click
        FrmStation.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Show()

    End Sub

    Private Sub FrmAnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Hide()

    End Sub
End Class
