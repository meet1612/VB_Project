Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser1.Text = Me.Tag
        btndisplay.Visible = False
        btnins.Visible = False
        btnlog.Visible = False
        btnremove.Visible = False
        btnstore.Visible = False
        btnupdate.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Me.hide()
        Display_records.Tag = lbluser1.Text
        Display_records.Show()
    End Sub



    Private Sub btnmenu_MouseHover(sender As Object, e As EventArgs) Handles btnmenu.MouseHover
        btndisplay.Visible = True
        btnins.Visible = True
        btnlog.Visible = True
        btnremove.Visible = True
        btnstore.Visible = True
        btnupdate.Visible = True
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        btndisplay.Visible = False
        btnins.Visible = False
        btnlog.Visible = False
        btnremove.Visible = False
        btnstore.Visible = False
        btnupdate.Visible = False
    End Sub

    Private Sub btnstore_Click(sender As Object, e As EventArgs) Handles btnstore.Click
        store.Tag = lbluser1.Text
        Me.Hide()
        store.Show()
    End Sub

    Private Sub btnins_Click(sender As Object, e As EventArgs) Handles btnins.Click
        insertdata.Tag = lbluser1.Text
        Me.Hide()
        insertdata.show()
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Master.Show()
        Me.Close()
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        delete_stock.Tag = lbluser1.Text
        delete_stock.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Stock_update.Tag = lbluser1.Text
        Me.Hide()
        Stock_update.Show()
    End Sub
End Class