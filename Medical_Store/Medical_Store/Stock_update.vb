Imports System.Data
Imports System.Data.OleDb
Public Class Stock_update
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
        txtsearch.Clear()
        txtsearch1.Clear()
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtid1.Text = "" Or txtname1.Text = "" Or txtprice1.Text = "" Or txtqty1.Text = "" Then
            MsgBox("Please search item.")
        Else
            If txtprice1.Text = 0 Or txtqty1.Text = 0 Then
                MsgBox("Price/Quantity should not be Zero. ")
            Else
                filldata("update medicine set M_name='" & txtname1.Text & "',Quantity=" & txtqty1.Text & ",Price=" & txtprice1.Text & " where ID='" & txtid1.Text & "'")
                MsgBox("Successfully Updated.")
                clearall()
            End If
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If radid.Checked = True Then
            ds.Clear()
            getdata("select * from medicine where ID='" & txtsearch.Text & "'")
            If dt.Rows.Count = 1 Then

                txtid1.ReadOnly = True
                txtid1.Text = dt.Rows(0)(0)
                txtname1.Text = dt.Rows(0)(1)
                txtqty1.Text = dt.Rows(0)(2)
                txtprice1.Text = dt.Rows(0)(3)
            Else
                txtsearch.Clear()
                GroupBox1.Visible = False
                MsgBox("Record Not Found")
            End If

        Else
            ds.Clear()
            getdata("select * from medicine where M_name='" & txtsearch1.Text & "'")
            If dt.Rows.Count = 1 Then

                txtid1.ReadOnly = True
                txtid1.Text = dt.Rows(0)(0)
                txtname1.Text = dt.Rows(0)(1)
                txtqty1.Text = dt.Rows(0)(2)
                txtprice1.Text = dt.Rows(0)(3)
            Else
                txtsearch1.Clear()

                MsgBox("Record Not Found")
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

    Private Sub Stock_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser1.Text = Me.Tag
        radname.Checked = True

        ds.Clear()
        getdata("select * from medicine")
        Dim autocomp As New AutoCompleteStringCollection

        For i As Integer = 0 To dt.Rows.Count - 1
            autocomp.Add(dt.Rows(i)(1))
        Next
        txtsearch1.AutoCompleteCustomSource = autocomp
        Dim autocomp1 As New AutoCompleteStringCollection

        For i As Integer = 0 To dt.Rows.Count - 1
            autocomp1.Add(dt.Rows(i)(0))
        Next
        txtsearch.AutoCompleteCustomSource = autocomp1
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Me.Close()
        home.Show()
    End Sub

    Private Sub txtprice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not Allowed.")
        End If
    End Sub


    Private Sub txtqty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Not Allowed.")
        End If

    End Sub
End Class