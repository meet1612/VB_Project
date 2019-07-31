Imports System.Data
Imports System.Data.OleDb
Public Class Log_in
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
    Dim j As Integer = 0
    Private Sub getdata(ByVal query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
        da.SelectCommand = cmd
        da.Fill(ds)
        dt = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ds.Clear()
        getdata("select * from signup_tbl where UserName='" & txtuser.Text & "'")
        If dt.Rows.Count = 1 Then
            If txtpwd.Text = dt.Rows(0)(1) Then
                txtpwd.Text = ""
                txtuser.Text = ""
                home.Tag = dt.Rows(0)(0)
                Me.Hide()
                home.Show()
            Else
                txtpwd.Text = ""
                txtuser.Text = ""
                lblmsg.Text = "* Invalid Username And Password"
                lblmsg.ForeColor = Color.Red
            End If
        Else
            txtpwd.Text = ""
            txtuser.Text = ""
            lblmsg.Text = "* Invalid Username And Password."
            lblmsg.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnfor_Click(sender As Object, e As EventArgs) Handles btnfor.Click
        ds.Clear()
        If txtuser.Text = "" Then
            MsgBox("Please enter username.")
        End If
        getdata("select * from signup_tbl where UserName='" & txtuser.Text & "'")
        If dt.Rows.Count = 1 Then
            forgot.Tag = txtuser.Text
            Me.Close()
            forgot.Show()
        End If
    End Sub

    Private Sub Log_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata("select * from signup_tbl")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Master.Show()
        Me.Close()
    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        lblmsg.Text = ""
    End Sub
End Class