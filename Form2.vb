Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "admin" And TextBox1.Text = "admin" Then
            Form3.Show()
            Me.Close()

        ElseIf TextBox2.Text <> "admin" And TextBox1.Text = "admin" Then
            MsgBox("ผู้ใช้ไม่ถูกต้อง")
        ElseIf TextBox2.Text = "admin" And TextBox1.Text <> "admin" Then
            MsgBox("รหัสผ่านไม่ถูกต้อง")
        Else
            MsgBox("ผู้ใช้และรหัสผ่านไม่ถูกต้อง")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class