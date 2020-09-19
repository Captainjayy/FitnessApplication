Public Class Form3

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form4.Show()
        Me.Hide()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form6.Show()
        Me.Hide()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form16.Show()

    End Sub
End Class