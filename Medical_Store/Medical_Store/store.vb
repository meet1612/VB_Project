Imports System.Data
Imports System.Data.OleDb
Public Class store
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
    Dim j As String
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
    Dim cnn1 As New OleDbConnection
    Dim cmd1 As New OleDbCommand
    Dim da1 As New OleDbDataAdapter
    Dim ds1 As New DataSet
    Dim dt1 As DataTable

    Private Sub getdata1(ByVal query1 As String)
        cnn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd1.Connection = cnn1
        cmd1.CommandText = query1
        da1.SelectCommand = cmd1
        da1.Fill(ds1)
        dt1 = ds1.Tables(0)
    End Sub
    Private Sub filldata1(ByVal query1 As String)
        cnn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd1.Connection = cnn1
        cmd1.CommandText = query1
        cnn1.Open()
        cmd1.ExecuteNonQuery()
        cnn1.Close()
    End Sub
    Private Sub clearall()
        txtid1.Clear()
        txtname1.Clear()
        txtqty.Clear()
        txtprice1.Clear()
        txtsearch.Text = ""
        txtsearch1.Text = ""
    End Sub
    Private Sub addnames()
        Dim autocomp As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            autocomp.Add(dt.Rows(i)(1))
        Next
        txtsearch1.AutoCompleteCustomSource = autocomp
    End Sub
    Private Sub addid()
        Dim autocomp As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            autocomp.Add(dt.Rows(i)(0))
        Next
        txtsearch.AutoCompleteCustomSource = autocomp
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldata("delete * from temp_tbl")
        lbluser1.Text = Me.Tag
        Log_in.Hide()
        radname.Checked = True
        lbluser1.Text = Me.Tag
        getdata("select * from medicine")
        addid()
        addnames()
        txtid1.ReadOnly = True
        txtname1.ReadOnly = True
        txtprice1.ReadOnly = True
        lblquantity.Visible = False
        txtqty.Visible = False
        btnbill.Visible = False
        btncheck.Visible = False
        btnaddbill.Visible = False
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        'FOR ID'
        Dim flag As Integer = 0


        If radid.Checked = True Then
            If txtsearch.Text = "" Then
                MsgBox("PLEASE ENTER THE ID")
            Else
                ds.Clear()
                getdata("select * from medicine where ID='" & txtsearch.Text & "'")
                If dt.Rows.Count = 1 Then
                    txtid1.Text = dt.Rows(0)(0)
                    txtname1.Text = dt.Rows(0)(1)
                    txtprice1.Text = dt.Rows(0)(3)
                    lblquantity.Visible = True
                    txtqty.Visible = True
                    btnbill.Visible = False
                    btncheck.Visible = True

                Else
                    MsgBox("Record Not Found")
                    lblquantity.Visible = False
                    txtqty.Visible = False
                    btnbill.Visible = False
                    btncheck.Visible = False
                End If
            End If

        Else
            If txtsearch1.Text = "" Then
                MsgBox("PLEASE ENTER THE NAME")
            Else
                ds.Clear()
                getdata("select * from medicine where M_name='" & txtsearch1.Text & "'")
                If dt.Rows.Count = 1 Then
                    txtid1.Text = dt.Rows(0)(0)
                    txtname1.Text = dt.Rows(0)(1)
                    txtprice1.Text = dt.Rows(0)(3)
                    lblquantity.Visible = True
                    txtqty.Visible = True
                    btnbill.Visible = False
                    btncheck.Visible = True
                    btnaddbill.Visible = False
                Else
                    MsgBox("Record Not Found")
                    lblquantity.Visible = False
                    txtqty.Visible = False
                    btnbill.Visible = False
                    btncheck.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub radid_CheckedChanged(sender As Object, e As EventArgs) Handles radid.CheckedChanged
        If radid.Checked = True Then
            txtsearch.Visible = True
            txtsearch1.Visible = False
        End If

    End Sub

    Private Sub radname_CheckedChanged(sender As Object, e As EventArgs) Handles radname.CheckedChanged
        If radname.Checked = True Then
            txtsearch.Visible = False
            txtsearch1.Visible = True
        End If
    End Sub


    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Me.Close()
        home.Tag = lbluser1.Text
        home.Show()
    End Sub

    Dim id As String

    Private Sub btnbill_Click(sender As Object, e As EventArgs) Handles btnbill.Click
        Dim str As String
        Dim qty As Integer
        ds1.Clear()
        getdata1("select * from temp_tbl")
        For i As Integer = 0 To dt1.Rows.Count - 1
            str = dt1.Rows(i)(0)
            ds.Clear()
            getdata("select * from medicine where ID='" & str & "'")
            If dt.Rows.Count = 1 Then
                qty = dt.Rows(0)(2) - dt1.Rows(i)(2)
                filldata("update medicine set Quantity=" & qty & " where ID='" & str & "'")
            End If
        Next

        MsgBox("Added into bill and Stock updated.")
        bill_form.Show()
        Me.Hide()
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        If txtqty.Text = "" Then
            MsgBox("Please enter quantity.")

        Else
            If txtqty.Text = 0 Then
                MsgBox("Quantity should not be Zero. ")
            Else

                If CInt(txtqty.Text) <= dt.Rows(0)(2) Then
                    btnbill.Visible = False
                    btnaddbill.Visible = True


                Else

                    MsgBox("Quantity out of stock." + " CURRENT STOCK IS-->" + dt.Rows(0)(2).ToString)
                    btnbill.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnaddbill_Click(sender As Object, e As EventArgs) Handles btnaddbill.Click
        Dim flag As Integer = 0
        Dim qty As Integer = 0
        btnbill.Visible = True

        ds1.Clear()
        getdata1("select * from temp_tbl")
        If dt1.Rows.Count >= 1 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If txtid1.Text = dt1.Rows(i)(0) Then


                    qty = CInt(txtqty.Text) + dt1.Rows(i)(2)
                        filldata1("update temp_tbl set [qty]=" & qty & " where [ID]='" & txtid1.Text & "'")
                        flag = 1
                    End If

            Next
        End If
        If flag = 0 Then
            filldata1("insert into temp_tbl values('" & txtid1.Text & "','" & txtname1.Text & "'," & txtqty.Text & "," & txtprice1.Text & ")")

        End If
        clearall()
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not Allowed.")
        End If
    End Sub
End Class