﻿Public Class Master
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Me.Hide()
        Log_in.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsign.Click
        Me.Hide()
        SignUp_form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class