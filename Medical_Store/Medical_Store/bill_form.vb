Imports System.Data
Imports System.Data.OleDb
Public Class bill_form
    Dim id As String
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
    Dim i As Integer = 1
    Dim price As Double
    Dim qty As Integer

    Dim tot, tot1 As Double


    Private Sub bill_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttitle.Select(0, 0)
        getdata("select * from temp_tbl")
        tot1 = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            lstno.Items.Add(i + 1)
            lstdes.Items.Add(dt.Rows(i)(1))
            lstqty.Items.Add(dt.Rows(i)(2))
            lstprice.Items.Add(dt.Rows(i)(3))
            price = dt.Rows(i)(3)
            qty = dt.Rows(i)(2)
            tot = price * qty
            lsttot.Items.Add(tot)
            tot1 += tot
        Next

        lblamount.Text = tot1

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If txtcus.Text = "" Or txtmo.Text = "" Then
            MsgBox("Please fill up the fields")
        Else
            Dim t As Double = CDbl(lblamount.Text)
            Dim d1 As Date = Now()
            MsgBox("Bill generated ..THANK YOU.. VISIT AGAIN!!!")
            filldata("insert into bill_tbl values('" & txtcus.Text & "'," & t & ",'" & d1 & "')")
            filldata("delete * from temp_tbl")
            Me.Close()
            store.Close()
            home.Show()
        End If

    End Sub

    Private Sub txtcus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcus.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not Allowed.")
        End If
    End Sub



    Private Sub txtmo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not Allowed.")
        End If
    End Sub


End Class