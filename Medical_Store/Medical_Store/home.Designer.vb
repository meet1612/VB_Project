<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.lblcadila = New System.Windows.Forms.Label()
        Me.lbluser1 = New System.Windows.Forms.Label()
        Me.btnins = New System.Windows.Forms.Button()
        Me.btnstore = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.clogo = New System.Windows.Forms.PictureBox()
        Me.userlogo = New System.Windows.Forms.PictureBox()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcadila
        '
        Me.lblcadila.BackColor = System.Drawing.Color.Transparent
        Me.lblcadila.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadila.Location = New System.Drawing.Point(175, 10)
        Me.lblcadila.Name = "lblcadila"
        Me.lblcadila.Size = New System.Drawing.Size(751, 101)
        Me.lblcadila.TabIndex = 7
        Me.lblcadila.Text = "Accenture Medical"
        Me.lblcadila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbluser1
        '
        Me.lbluser1.AutoSize = True
        Me.lbluser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser1.ForeColor = System.Drawing.Color.Black
        Me.lbluser1.Location = New System.Drawing.Point(1033, 27)
        Me.lbluser1.Name = "lbluser1"
        Me.lbluser1.Size = New System.Drawing.Size(108, 33)
        Me.lbluser1.TabIndex = 5
        Me.lbluser1.Text = "Label1"
        '
        'btnins
        '
        Me.btnins.BackColor = System.Drawing.Color.GreenYellow
        Me.btnins.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnins.Location = New System.Drawing.Point(528, 327)
        Me.btnins.Name = "btnins"
        Me.btnins.Size = New System.Drawing.Size(342, 53)
        Me.btnins.TabIndex = 3
        Me.btnins.Text = "INSERT DATA"
        Me.btnins.UseVisualStyleBackColor = False
        '
        'btnstore
        '
        Me.btnstore.BackColor = System.Drawing.Color.GreenYellow
        Me.btnstore.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstore.Location = New System.Drawing.Point(528, 267)
        Me.btnstore.Name = "btnstore"
        Me.btnstore.Size = New System.Drawing.Size(342, 53)
        Me.btnstore.TabIndex = 2
        Me.btnstore.Text = "STORE"
        Me.btnstore.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.Lime
        Me.btnmenu.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(528, 208)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(342, 53)
        Me.btnmenu.TabIndex = 10
        Me.btnmenu.Text = "MENU"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.GreenYellow
        Me.btnupdate.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(528, 386)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(342, 53)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.Text = "STOCK UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.GreenYellow
        Me.btnremove.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(528, 445)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(342, 53)
        Me.btnremove.TabIndex = 5
        Me.btnremove.Text = "REMOVE DATA"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.GreenYellow
        Me.btnlog.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.Location = New System.Drawing.Point(528, 563)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(342, 53)
        Me.btnlog.TabIndex = 7
        Me.btnlog.Text = "LOG OUT"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'btndisplay
        '
        Me.btndisplay.BackColor = System.Drawing.Color.GreenYellow
        Me.btndisplay.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.Location = New System.Drawing.Point(528, 504)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(342, 53)
        Me.btndisplay.TabIndex = 6
        Me.btndisplay.Text = "DISPLAY"
        Me.btndisplay.UseVisualStyleBackColor = False
        '
        'clogo
        '
        Me.clogo.BackColor = System.Drawing.Color.Transparent
        Me.clogo.Image = CType(resources.GetObject("clogo.Image"), System.Drawing.Image)
        Me.clogo.Location = New System.Drawing.Point(0, 2)
        Me.clogo.Name = "clogo"
        Me.clogo.Size = New System.Drawing.Size(151, 141)
        Me.clogo.TabIndex = 6
        Me.clogo.TabStop = False
        '
        'userlogo
        '
        Me.userlogo.BackColor = System.Drawing.Color.Transparent
        Me.userlogo.Image = CType(resources.GetObject("userlogo.Image"), System.Drawing.Image)
        Me.userlogo.Location = New System.Drawing.Point(958, 10)
        Me.userlogo.Name = "userlogo"
        Me.userlogo.Size = New System.Drawing.Size(60, 58)
        Me.userlogo.TabIndex = 4
        Me.userlogo.TabStop = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 671)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnstore)
        Me.Controls.Add(Me.btnins)
        Me.Controls.Add(Me.lblcadila)
        Me.Controls.Add(Me.clogo)
        Me.Controls.Add(Me.lbluser1)
        Me.Controls.Add(Me.userlogo)
        Me.Name = "home"
        Me.Text = "home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcadila As Label
    Friend WithEvents clogo As PictureBox
    Friend WithEvents lbluser1 As Label
    Friend WithEvents userlogo As PictureBox
    Friend WithEvents btnins As Button
    Friend WithEvents btnstore As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents btndisplay As Button
End Class
