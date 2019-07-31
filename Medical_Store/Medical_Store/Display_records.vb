Imports System.Data
Imports System.Data.OleDb
Public Class Display_records
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
    Private Sub Display_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser1.Text = Me.Tag
        getdata("select * from medicine")
        grid1.DataSource = dt
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Me.Close()
        home.Show()
    End Sub
End Class