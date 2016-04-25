Public Class Form4
    Dim a, z, x, c, v, b, n As String
    Dim aa As String
  
 



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            z = CSng(TextBox1.Text)
            x = CSng(TextBox2.Text)
            c = CSng(TextBox3.Text)
            v = CSng(TextBox4.Text)
            b = CSng(TextBox6.Text)
            a = 0
            If TextBox1.Text <> ("") And TextBox3.Text <> ("") And TextBox2.Text <> ("") And TextBox4.Text <> ("") And TextBox3.Text <> ("") Then

                If TextBox1.Text <> ("") Then
                    aa = TextBox1.Text
                    Form6.Label3.Text = aa
                    Form6.Show()

                End If

                If TextBox3.Text <> ("") Then
                    aa = TextBox3.Text
                    Form6.Label6.Text = aa
                    Form6.Show()

                End If
                If TextBox2.Text <> ("") Then
                    aa = TextBox2.Text
                    Form6.Label4.Text = aa
                    Form6.Label5.Text = aa
                    Form6.Show()

                End If
                If TextBox4.Text <> ("") Then
                    aa = TextBox4.Text
                    Form6.Label7.Text = aa
                    Form6.Show()

                End If
                If TextBox6.Text <> ("") Then
                    aa = TextBox6.Text
                    Form6.Label8.Text = aa
                    Form6.Show()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาใส่ตัวเลข")
            TextBox1.Text = ("")
            TextBox3.Text = ("")
            TextBox2.Text = ("")
            TextBox4.Text = ("")
            TextBox6.Text = ("")

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class