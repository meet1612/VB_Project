<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class store
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(store))
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.radid = New System.Windows.Forms.RadioButton()
        Me.radname = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch1 = New System.Windows.Forms.TextBox()
        Me.lblcadila = New System.Windows.Forms.Label()
        Me.clogo = New System.Windows.Forms.PictureBox()
        Me.lbluser1 = New System.Windows.Forms.Label()
        Me.userlogo = New System.Windows.Forms.PictureBox()
        Me.txtid1 = New System.Windows.Forms.TextBox()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.txtprice1 = New System.Windows.Forms.TextBox()
        Me.lblid1 = New System.Windows.Forms.Label()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.lblprice1 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.btnfinish = New System.Windows.Forms.Button()
        Me.btnbill = New System.Windows.Forms.Button()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnaddbill = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteCustomSource.AddRange(New String() {"M01", "M02", "M03", "M04", "M05", "M06", "M07", "M08", "M09", "M10", "M11", "M12", "M13", "M14", "M15", "M16", "M17", "M18", "M19", "M20", "M21", "M22", "M23", "M24", "M25", "M26", "M27", "M28", "M29", "M30", "M31", "M32", "M33", "M34", "M35", "M36", "M37", "M38", "M39", "M40", "M41", "M42", "M43", "M44", "M45", "M46", "M47", "M48", "M49", "M50"})
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(259, 243)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(215, 29)
        Me.txtsearch.TabIndex = 4
        '
        'radid
        '
        Me.radid.AutoSize = True
        Me.radid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radid.Location = New System.Drawing.Point(52, 42)
        Me.radid.Name = "radid"
        Me.radid.Size = New System.Drawing.Size(110, 24)
        Me.radid.TabIndex = 5
        Me.radid.TabStop = True
        Me.radid.Text = "Product Id"
        Me.radid.UseVisualStyleBackColor = True
        '
        'radname
        '
        Me.radname.AutoSize = True
        Me.radname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radname.Location = New System.Drawing.Point(52, 84)
        Me.radname.Name = "radname"
        Me.radname.Size = New System.Drawing.Size(140, 24)
        Me.radname.TabIndex = 6
        Me.radname.TabStop = True
        Me.radname.Text = "Product Name"
        Me.radname.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radname)
        Me.GroupBox1.Controls.Add(Me.radid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 125)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Searching With.."
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(297, 309)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(147, 39)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search.."
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch1
        '
        Me.txtsearch1.AutoCompleteCustomSource.AddRange(New String() {"Calpole", "Combiflam", "Neurobion forte", "Ecosprin-75", "Sorbitrate", "Uprise-D3", "Nurokind Plus", "LTK-25", "Caldikind Plus", "Imdur", "Disprin", "Lanoxin", "Amlokind", "Betaloc-25", "Aldactone", "Crosin", "Vicks vaporub", "Vicks action 500", "Vicks cough drops", "Vicks inhaler", "Metacin", "Micromol", "Mypol", "Neomol", "Paracetamol", "Nimesulide", "Pentazocine", "Calamine Lotion", "Adapalene", "Amlip tablet", "Amcold syrup", "Cipcal", "Rentaloc", "Vometil", "8x shampoo", "Acivir tablet", " Advent tablet", "Ciplar tablet", "Fluka", "HB Set tablet", "Hipres tablet", "Levolin", "Metolar injection", "Montair lc tablet", "Novamox", "Novamox drops", "Oflox TZ tablet", "Nova tablet", "Omnigel Spray", "Omnix syrup"})
        Me.txtsearch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtsearch1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch1.Location = New System.Drawing.Point(259, 244)
        Me.txtsearch1.Name = "txtsearch1"
        Me.txtsearch1.Size = New System.Drawing.Size(215, 29)
        Me.txtsearch1.TabIndex = 18
        '
        'lblcadila
        '
        Me.lblcadila.BackColor = System.Drawing.Color.Transparent
        Me.lblcadila.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadila.Location = New System.Drawing.Point(174, 9)
        Me.lblcadila.Name = "lblcadila"
        Me.lblcadila.Size = New System.Drawing.Size(751, 101)
        Me.lblcadila.TabIndex = 28
        Me.lblcadila.Text = "Accenture Medical"
        Me.lblcadila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clogo
        '
        Me.clogo.BackColor = System.Drawing.Color.Transparent
        Me.clogo.Image = CType(resources.GetObject("clogo.Image"), System.Drawing.Image)
        Me.clogo.Location = New System.Drawing.Point(-1, 1)
        Me.clogo.Name = "clogo"
        Me.clogo.Size = New System.Drawing.Size(151, 141)
        Me.clogo.TabIndex = 27
        Me.clogo.TabStop = False
        '
        'lbluser1
        '
        Me.lbluser1.AutoSize = True
        Me.lbluser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser1.ForeColor = System.Drawing.Color.Black
        Me.lbluser1.Location = New System.Drawing.Point(1032, 27)
        Me.lbluser1.Name = "lbluser1"
        Me.lbluser1.Size = New System.Drawing.Size(108, 33)
        Me.lbluser1.TabIndex = 26
        Me.lbluser1.Text = "Label1"
        '
        'userlogo
        '
        Me.userlogo.BackColor = System.Drawing.Color.Transparent
        Me.userlogo.Image = CType(resources.GetObject("userlogo.Image"), System.Drawing.Image)
        Me.userlogo.Location = New System.Drawing.Point(957, 9)
        Me.userlogo.Name = "userlogo"
        Me.userlogo.Size = New System.Drawing.Size(60, 58)
        Me.userlogo.TabIndex = 25
        Me.userlogo.TabStop = False
        '
        'txtid1
        '
        Me.txtid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid1.Location = New System.Drawing.Point(259, 427)
        Me.txtid1.Name = "txtid1"
        Me.txtid1.Size = New System.Drawing.Size(215, 29)
        Me.txtid1.TabIndex = 29
        '
        'txtname1
        '
        Me.txtname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname1.Location = New System.Drawing.Point(259, 482)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(215, 29)
        Me.txtname1.TabIndex = 30
        '
        'txtprice1
        '
        Me.txtprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice1.Location = New System.Drawing.Point(259, 544)
        Me.txtprice1.Name = "txtprice1"
        Me.txtprice1.Size = New System.Drawing.Size(215, 29)
        Me.txtprice1.TabIndex = 31
        '
        'lblid1
        '
        Me.lblid1.AutoSize = True
        Me.lblid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid1.Location = New System.Drawing.Point(141, 429)
        Me.lblid1.Name = "lblid1"
        Me.lblid1.Size = New System.Drawing.Size(91, 25)
        Me.lblid1.TabIndex = 32
        Me.lblid1.Text = "ID      :-"
        Me.lblid1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname1.Location = New System.Drawing.Point(138, 486)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(94, 25)
        Me.lblname1.TabIndex = 33
        Me.lblname1.Text = "Name :-"
        '
        'lblprice1
        '
        Me.lblprice1.AutoSize = True
        Me.lblprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice1.Location = New System.Drawing.Point(145, 548)
        Me.lblprice1.Name = "lblprice1"
        Me.lblprice1.Size = New System.Drawing.Size(88, 25)
        Me.lblprice1.TabIndex = 34
        Me.lblprice1.Text = "Price :-"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(868, 178)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(215, 29)
        Me.txtqty.TabIndex = 35
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(677, 180)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(185, 25)
        Me.lblquantity.TabIndex = 36
        Me.lblquantity.Text = "Enter Quantity :-"
        '
        'btnfinish
        '
        Me.btnfinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinish.Location = New System.Drawing.Point(1047, 561)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(147, 39)
        Me.btnfinish.TabIndex = 37
        Me.btnfinish.Text = "Back.."
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'btnbill
        '
        Me.btnbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbill.Location = New System.Drawing.Point(1015, 391)
        Me.btnbill.Name = "btnbill"
        Me.btnbill.Size = New System.Drawing.Size(147, 39)
        Me.btnbill.TabIndex = 38
        Me.btnbill.Text = "Generate Bill"
        Me.btnbill.UseVisualStyleBackColor = True
        '
        'btncheck
        '
        Me.btncheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheck.Location = New System.Drawing.Point(870, 233)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(147, 39)
        Me.btncheck.TabIndex = 39
        Me.btncheck.Text = "Check!"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'btnaddbill
        '
        Me.btnaddbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddbill.Location = New System.Drawing.Point(837, 391)
        Me.btnaddbill.Name = "btnaddbill"
        Me.btnaddbill.Size = New System.Drawing.Size(147, 39)
        Me.btnaddbill.TabIndex = 40
        Me.btnaddbill.Text = "Add To Bill"
        Me.btnaddbill.UseVisualStyleBackColor = True
        '
        'store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1246, 636)
        Me.Controls.Add(Me.btnaddbill)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.btnbill)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.txtid1)
        Me.Controls.Add(Me.txtname1)
        Me.Controls.Add(Me.txtprice1)
        Me.Controls.Add(Me.lblid1)
        Me.Controls.Add(Me.lblname1)
        Me.Controls.Add(Me.lblprice1)
        Me.Controls.Add(Me.lblcadila)
        Me.Controls.Add(Me.clogo)
        Me.Controls.Add(Me.lbluser1)
        Me.Controls.Add(Me.userlogo)
        Me.Controls.Add(Me.txtsearch1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsearch)
        Me.Name = "store"
        Me.Text = "store"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents radid As RadioButton
    Friend WithEvents radname As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch1 As TextBox
    Friend WithEvents lblcadila As Label
    Friend WithEvents clogo As PictureBox
    Friend WithEvents lbluser1 As Label
    Friend WithEvents userlogo As PictureBox
    Friend WithEvents txtid1 As TextBox
    Friend WithEvents txtname1 As TextBox
    Friend WithEvents txtprice1 As TextBox
    Friend WithEvents lblid1 As Label
    Friend WithEvents lblname1 As Label
    Friend WithEvents lblprice1 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblquantity As Label
    Friend WithEvents btnfinish As Button
    Friend WithEvents btnbill As Button
    Friend WithEvents btncheck As Button
    Friend WithEvents btnaddbill As Button
End Class
