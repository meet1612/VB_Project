Imports System.Data
Imports System.Data.OleDb
Public Class insertdata
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
    Private Sub clearall()
        txtid1.Clear()
        txtname1.Clear()
        txtprice1.Clear()
        txtqty1.Clear()
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Dim flag As Integer = 0
        ds.Clear()
        getdata("Select * From medicine")
        For i As Integer = 0 To dt.Rows.Count - 1
            If txtid1.Text = dt.Rows(i)(0) Then
                flag = 1
            End If
            If txtname1.Text = dt.Rows(i)(1) Then
                flag = 2
            End If
        Next
        If txtid1.Text = "" Or txtname1.Text = "" Or txtprice1.Text = "" Or txtqty1.Text = "" Then
            MsgBox("Please fillup all the fields")

        Else
            If flag = 0 Then
                If txtprice1.Text = 0 Or txtqty1.Text = 0 Then
                    MsgBox("Price/Quantity should not be Zero. ")
                Else
                    filldata("insert into medicine values('" & txtid1.Text & "','" & txtname1.Text & "'," & txtqty1.Text & "," & txtprice1.Text & ")")
                    MsgBox("Successfully Inserted")
                    clearall()
                End If
            ElseIf flag = 1 Then
                MsgBox("DUPLICATION OF ID")
            Else
                MsgBox("DUPLICATION OF NAME")
            End If
        End If

    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Me.Close()
        home.Show()
    End Sub

    Private Sub insertdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser1.Text = Me.Tag
    End Sub

    Private Sub txtprice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not allowed")
        End If
    End Sub

    Private Sub txtqty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not allowed")
        End If
    End Sub
End Class