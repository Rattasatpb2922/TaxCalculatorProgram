Public Class HomePage
    Dim salary, vat, sum As String

    Private Sub HomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Form4.Close()
        Form6.Close()

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Try
            salary = CSng(TextBox1.Text)
            If Form6.Label3.Text <> 0 Or Form6.Label6.Text <> 0 Or Form6.Label4.Text <> 0 Or Form6.Label7.Text <> 0 Or Form6.Label5.Text <> 0 Or Form6.Label8.Text <> 0 Then
                If salary <= Form6.Label3.Text Then
                    vat = Form6.Label6.Text
                ElseIf salary <= Form6.Label4.Text Then
                    vat = Form6.Label7.Text
                ElseIf salary > Form6.Label5.Text Then
                    vat = Form6.Label8.Text
                Else
                    vat = 0
                End If
                sum = (salary * vat) / 100
                Form1.TextBox2.Text = sum
                Form1.Show()
                Form1.TextBox1.Text = vat
                Form1.Show()
                Me.Close()

            Else
                If salary <= 10000 Then
                    vat = 0
                ElseIf salary <= 15000 Then
                    vat = 7%
                ElseIf salary > 15000 Then
                    vat = 12%

                Else
                    vat = 0

                End If
                sum = (salary * vat) / 100
                Form1.TextBox2.Text = sum
                Form1.Show()
                Form1.TextBox1.Text = vat
                Form1.Show()
                Me.Close()

            End If
           
        Catch ex As Exception
            MessageBox.Show("กรุณาใส่ตัวเลข")
            TextBox1.Text = ("")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
      


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
            Form1.Close()
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form6.Close()
        End If
        TextBox1.Text = ("")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form6.Close()
    End Sub
End Class
