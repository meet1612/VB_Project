Imports System.Data
Imports System.Data.OleDb
Public Class SignUp_form
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Private Sub getdata(ByVal query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
        da.SelectCommand = cmd
        da.Fill(ds)
        dt = ds.Tables(0)
    End Sub
    Private Sub filldata(ByVal query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim flag As Integer = 0
        Dim d1 As Date = dp1.Value.ToShortDateString
        Dim d2 As Date = Now()
        Dim s1 As String = txtmo.Text
        Dim gender As String
        getdata("select * from signup_tbl")
        For i As Integer = 0 To dt.Rows.Count - 1
            If txtuser.Text = dt.Rows(i)(0) Then
                flag = 2
            End If
        Next
        If txtuser.Text = "" Or txtre.Text = "" Or txtpwd.Text = "" Or txtmo.Text = "" Then
            flag = 1
        End If
        If txtpwd.Text <> txtre.Text Then
            MsgBox("Mismatch password")
            flag = 1
        End If
        If d1 > d2 Then
            MsgBox("Date should me smaller than today.")
            flag = 1
        End If
        If rad1.Checked = True Then
            gender = rad1.Text
        Else
            gender = rad2.Text
        End If
        If s1.Length < 10 Then
            MsgBox("Mobile no should be in 10 digit")
            flag = 1
        End If
        If flag = 0 Then
            filldata("insert into signup_tbl values('" & txtuser.Text & "','" & txtpwd.Text & "','" & d1 & "','" & gender & "'," & txtmo.Text & ") ")
            MsgBox("signup successfully")
            Me.Close()
            Log_in.Show()
        ElseIf flag = 2 Then
            MsgBox("Username is already exists.")

        Else
            MsgBox("please fillup the field")
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("NOT ALLOWED")
        End If
    End Sub

    Private Sub btnclo_Click(sender As Object, e As EventArgs) Handles btnclo.Click
        Me.Close()
        Master.Show()
    End Sub


End Class