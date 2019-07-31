Imports System.Data
Imports System.Data.OleDb
Public Class delete_stock
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim i As Integer = 0
    Dim j As String
    Private Sub clearall()
        txtid1.Clear()
        txtname1.Clear()
        txtprice1.Clear()
        txtqty1.Clear()
        txtsearch1.Clear()
        txtsearch.Clear()
    End Sub
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
    Private Sub delete_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser1.Text = Me.Tag
        radname.Checked = True
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
        txtid1.ReadOnly = True
        txtname1.ReadOnly = True
        txtprice1.ReadOnly = True
        txtqty1.ReadOnly = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btndel.Click
        filldata("delete from medicine where ID='" & txtid1.Text & "'")
        MsgBox("Successfully deleted")
        clearall()
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

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Me.Close()
        home.Tag = lbluser1.Text
        home.Show()
    End Sub
End Class