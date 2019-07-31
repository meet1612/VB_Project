Imports System.Data
Imports System.Data.OleDb
Public Class forgot
    Dim cnn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim str As String = Me.Tag
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As DataTable
    Private Sub filldata(ByVal query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
    Private Sub getdata(ByVal query As String)
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Vb_project\Cadila_medicalshope.accdb"
        cmd.Connection = cnn
        cmd.CommandText = query
        da.SelectCommand = cmd
        da.Fill(ds)
        dt = ds.Tables(0)
    End Sub
    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        str = Me.Tag
        Dim flag As Integer = 0
        If txtnew.Text = "" Or txtre.Text = "" Then
            flag = 1
        End If
        If txtnew.Text <> txtre.Text Then
            flag = 2
        End If
        If flag = 0 Then
            filldata("update signup_tbl set [Password]='" & txtnew.Text & "'where [UserName]='" & str & "'")
            Label3.Visible = False
            getdata("select * from signup_tbl")
            Me.Close()
            Log_in.Show()
        ElseIf flag = 1 Then
            MsgBox("Please fill up the field")
        ElseIf flag = 2 Then
            Label3.Visible = True
            Label3.Text = "Sorry, Mismatch Password"
        End If
        txtre.Text = ""
        txtnew.Text = ""
    End Sub

    Private Sub forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        str = Me.Tag
        Label3.Visible = False
    End Sub

    Private Sub txtnew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnew.KeyPress
        Label3.Visible = False
    End Sub
End Class