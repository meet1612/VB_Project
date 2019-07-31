<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class insertdata
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insertdata))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtid1 = New System.Windows.Forms.TextBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.lblquan1 = New System.Windows.Forms.Label()
        Me.txtprice1 = New System.Windows.Forms.TextBox()
        Me.txtqty1 = New System.Windows.Forms.TextBox()
        Me.lblid1 = New System.Windows.Forms.Label()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.lblprice1 = New System.Windows.Forms.Label()
        Me.lblcadila = New System.Windows.Forms.Label()
        Me.lbluser1 = New System.Windows.Forms.Label()
        Me.clogo = New System.Windows.Forms.PictureBox()
        Me.userlogo = New System.Windows.Forms.PictureBox()
        Me.btnfinish = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtid1)
        Me.GroupBox2.Controls.Add(Me.btninsert)
        Me.GroupBox2.Controls.Add(Me.txtname1)
        Me.GroupBox2.Controls.Add(Me.lblquan1)
        Me.GroupBox2.Controls.Add(Me.txtprice1)
        Me.GroupBox2.Controls.Add(Me.txtqty1)
        Me.GroupBox2.Controls.Add(Me.lblid1)
        Me.GroupBox2.Controls.Add(Me.lblname1)
        Me.GroupBox2.Controls.Add(Me.lblprice1)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(386, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 429)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insert"
        '
        'txtid1
        '
        Me.txtid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid1.Location = New System.Drawing.Point(194, 80)
        Me.txtid1.Name = "txtid1"
        Me.txtid1.Size = New System.Drawing.Size(215, 29)
        Me.txtid1.TabIndex = 1
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(160, 351)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(147, 39)
        Me.btninsert.TabIndex = 5
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'txtname1
        '
        Me.txtname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname1.Location = New System.Drawing.Point(194, 135)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(215, 29)
        Me.txtname1.TabIndex = 2
        '
        'lblquan1
        '
        Me.lblquan1.AutoSize = True
        Me.lblquan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquan1.Location = New System.Drawing.Point(45, 258)
        Me.lblquan1.Name = "lblquan1"
        Me.lblquan1.Size = New System.Drawing.Size(122, 25)
        Me.lblquan1.TabIndex = 20
        Me.lblquan1.Text = "Quantity :-"
        '
        'txtprice1
        '
        Me.txtprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice1.Location = New System.Drawing.Point(194, 197)
        Me.txtprice1.Name = "txtprice1"
        Me.txtprice1.Size = New System.Drawing.Size(215, 29)
        Me.txtprice1.TabIndex = 3
        '
        'txtqty1
        '
        Me.txtqty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty1.Location = New System.Drawing.Point(194, 258)
        Me.txtqty1.Name = "txtqty1"
        Me.txtqty1.Size = New System.Drawing.Size(215, 29)
        Me.txtqty1.TabIndex = 4
        '
        'lblid1
        '
        Me.lblid1.AutoSize = True
        Me.lblid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid1.Location = New System.Drawing.Point(76, 82)
        Me.lblid1.Name = "lblid1"
        Me.lblid1.Size = New System.Drawing.Size(91, 25)
        Me.lblid1.TabIndex = 13
        Me.lblid1.Text = "ID      :-"
        Me.lblid1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname1.Location = New System.Drawing.Point(73, 139)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(94, 25)
        Me.lblname1.TabIndex = 14
        Me.lblname1.Text = "Name :-"
        '
        'lblprice1
        '
        Me.lblprice1.AutoSize = True
        Me.lblprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice1.Location = New System.Drawing.Point(80, 201)
        Me.lblprice1.Name = "lblprice1"
        Me.lblprice1.Size = New System.Drawing.Size(88, 25)
        Me.lblprice1.TabIndex = 16
        Me.lblprice1.Text = "Price :-"
        '
        'lblcadila
        '
        Me.lblcadila.BackColor = System.Drawing.Color.Transparent
        Me.lblcadila.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadila.Location = New System.Drawing.Point(175, 7)
        Me.lblcadila.Name = "lblcadila"
        Me.lblcadila.Size = New System.Drawing.Size(751, 101)
        Me.lblcadila.TabIndex = 25
        Me.lblcadila.Text = "Accenture Medical"
        Me.lblcadila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbluser1
        '
        Me.lbluser1.AutoSize = True
        Me.lbluser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser1.ForeColor = System.Drawing.Color.Black
        Me.lbluser1.Location = New System.Drawing.Point(1033, 24)
        Me.lbluser1.Name = "lbluser1"
        Me.lbluser1.Size = New System.Drawing.Size(108, 33)
        Me.lbluser1.TabIndex = 23
        Me.lbluser1.Text = "Label1"
        '
        'clogo
        '
        Me.clogo.BackColor = System.Drawing.Color.Transparent
        Me.clogo.Image = CType(resources.GetObject("clogo.Image"), System.Drawing.Image)
        Me.clogo.Location = New System.Drawing.Point(2, -4)
        Me.clogo.Name = "clogo"
        Me.clogo.Size = New System.Drawing.Size(151, 141)
        Me.clogo.TabIndex = 24
        Me.clogo.TabStop = False
        '
        'userlogo
        '
        Me.userlogo.BackColor = System.Drawing.Color.Transparent
        Me.userlogo.Image = CType(resources.GetObject("userlogo.Image"), System.Drawing.Image)
        Me.userlogo.Location = New System.Drawing.Point(958, 7)
        Me.userlogo.Name = "userlogo"
        Me.userlogo.Size = New System.Drawing.Size(60, 58)
        Me.userlogo.TabIndex = 22
        Me.userlogo.TabStop = False
        '
        'btnfinish
        '
        Me.btnfinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinish.Location = New System.Drawing.Point(1039, 652)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(147, 39)
        Me.btnfinish.TabIndex = 6
        Me.btnfinish.Text = "Finish.."
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'insertdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1210, 703)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.lblcadila)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.clogo)
        Me.Controls.Add(Me.lbluser1)
        Me.Controls.Add(Me.userlogo)
        Me.Name = "insertdata"
        Me.Text = "insertdata"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtid1 As TextBox
    Friend WithEvents btninsert As Button
    Friend WithEvents txtname1 As TextBox
    Friend WithEvents lblquan1 As Label
    Friend WithEvents txtprice1 As TextBox
    Friend WithEvents txtqty1 As TextBox
    Friend WithEvents lblid1 As Label
    Friend WithEvents lblname1 As Label
    Friend WithEvents lblprice1 As Label
    Friend WithEvents lblcadila As Label
    Friend WithEvents clogo As PictureBox
    Friend WithEvents lbluser1 As Label
    Friend WithEvents userlogo As PictureBox
    Friend WithEvents btnfinish As Button
End Class
