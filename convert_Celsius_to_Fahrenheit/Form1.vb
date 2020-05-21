Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCOne.Clear()
        txtCTwo.Clear()
        txtCThree.Clear()
        lblFOne.Text = ""
        lblFTwo.Text = ""
        lblFThree.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fahrenheitOne As Single
            Dim fahrenheitTwo As Single
            Dim fahrenheitThree As Single


            fahrenheitOne = CSng(1.8 * CSng(txtCOne.Text) + 32)
            fahrenheitTwo = CSng(1.8 * CSng(txtCTwo.Text) + 32)
            fahrenheitThree = CSng(1.8 * CSng(txtCThree.Text) + 32)

            lblFOne.Text = CStr(fahrenheitOne)
            lblFTwo.Text = CStr(fahrenheitTwo)
            lblFThree.Text = CStr(fahrenheitThree)
        Catch
            MessageBox.Show("Please enter a valid number. Any other character is not valid.")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
