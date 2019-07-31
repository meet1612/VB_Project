<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bill_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bill_form))
        Me.lblcadila = New System.Windows.Forms.Label()
        Me.clogo = New System.Windows.Forms.PictureBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcus = New System.Windows.Forms.Label()
        Me.txtcus = New System.Windows.Forms.TextBox()
        Me.txtmo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstno = New System.Windows.Forms.ListBox()
        Me.lstdes = New System.Windows.Forms.ListBox()
        Me.lstqty = New System.Windows.Forms.ListBox()
        Me.lstprice = New System.Windows.Forms.ListBox()
        Me.lsttot = New System.Windows.Forms.ListBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcadila
        '
        Me.lblcadila.BackColor = System.Drawing.Color.Transparent
        Me.lblcadila.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadila.Location = New System.Drawing.Point(1341, 152)
        Me.lblcadila.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcadila.Name = "lblcadila"
        Me.lblcadila.Size = New System.Drawing.Size(513, 75)
        Me.lblcadila.TabIndex = 9
        Me.lblcadila.Text = "Accenture Medical"
        Me.lblcadila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clogo
        '
        Me.clogo.BackColor = System.Drawing.Color.Transparent
        Me.clogo.Image = CType(resources.GetObject("clogo.Image"), System.Drawing.Image)
        Me.clogo.Location = New System.Drawing.Point(1671, 17)
        Me.clogo.Margin = New System.Windows.Forms.Padding(4)
        Me.clogo.Name = "clogo"
        Me.clogo.Size = New System.Drawing.Size(168, 145)
        Me.clogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.clogo.TabIndex = 8
        Me.clogo.TabStop = False
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.DarkTurquoise
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttitle.Location = New System.Drawing.Point(13, 13)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txttitle.Multiline = True
        Me.txttitle.Name = "txttitle"
        Me.txttitle.ReadOnly = True
        Me.txttitle.Size = New System.Drawing.Size(309, 106)
        Me.txttitle.TabIndex = 10
        Me.txttitle.Text = "Accenture Medical Store" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "102, scarlet highlights complex," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Near paldi cross road," &
    " ahemdabad-380007." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone :-079-2558970 , Mobile :-9090899765" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email:-Accenture_" &
    "medical@gmail.com"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(881, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 52)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Accenture Medical"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1261, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 98)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'lblcus
        '
        Me.lblcus.AutoSize = True
        Me.lblcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcus.Location = New System.Drawing.Point(-1, 124)
        Me.lblcus.Name = "lblcus"
        Me.lblcus.Size = New System.Drawing.Size(186, 25)
        Me.lblcus.TabIndex = 31
        Me.lblcus.Text = "Customer Name:"
        '
        'txtcus
        '
        Me.txtcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcus.Location = New System.Drawing.Point(191, 126)
        Me.txtcus.Name = "txtcus"
        Me.txtcus.Size = New System.Drawing.Size(204, 26)
        Me.txtcus.TabIndex = 1
        '
        'txtmo
        '
        Me.txtmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmo.Location = New System.Drawing.Point(578, 126)
        Me.txtmo.MaxLength = 10
        Me.txtmo.Name = "txtmo"
        Me.txtmo.Size = New System.Drawing.Size(204, 26)
        Me.txtmo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Mobile No:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 34)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(567, 34)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(632, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 34)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(725, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 34)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Unit Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(827, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 34)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(60, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 517)
        Me.Label8.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(629, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 517)
        Me.Label9.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(722, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 517)
        Me.Label10.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(827, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 517)
        Me.Label11.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(948, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 517)
        Me.Label12.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-1, 589)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(959, 10)
        Me.Label13.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(1, 693)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(958, 10)
        Me.Label14.TabIndex = 46
        '
        'lstno
        '
        Me.lstno.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lstno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstno.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstno.FormattingEnabled = True
        Me.lstno.ItemHeight = 32
        Me.lstno.Location = New System.Drawing.Point(25, 213)
        Me.lstno.Name = "lstno"
        Me.lstno.Size = New System.Drawing.Size(29, 352)
        Me.lstno.TabIndex = 47
        '
        'lstdes
        '
        Me.lstdes.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lstdes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstdes.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstdes.FormattingEnabled = True
        Me.lstdes.ItemHeight = 32
        Me.lstdes.Location = New System.Drawing.Point(76, 213)
        Me.lstdes.Name = "lstdes"
        Me.lstdes.Size = New System.Drawing.Size(547, 352)
        Me.lstdes.TabIndex = 48
        '
        'lstqty
        '
        Me.lstqty.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lstqty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstqty.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstqty.FormattingEnabled = True
        Me.lstqty.ItemHeight = 32
        Me.lstqty.Location = New System.Drawing.Point(648, 213)
        Me.lstqty.Name = "lstqty"
        Me.lstqty.Size = New System.Drawing.Size(68, 352)
        Me.lstqty.TabIndex = 49
        '
        'lstprice
        '
        Me.lstprice.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lstprice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstprice.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprice.FormattingEnabled = True
        Me.lstprice.ItemHeight = 32
        Me.lstprice.Location = New System.Drawing.Point(738, 213)
        Me.lstprice.Name = "lstprice"
        Me.lstprice.Size = New System.Drawing.Size(83, 352)
        Me.lstprice.TabIndex = 50
        '
        'lsttot
        '
        Me.lsttot.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lsttot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsttot.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsttot.FormattingEnabled = True
        Me.lsttot.ItemHeight = 32
        Me.lsttot.Location = New System.Drawing.Point(843, 213)
        Me.lsttot.Name = "lsttot"
        Me.lsttot.Size = New System.Drawing.Size(99, 352)
        Me.lsttot.TabIndex = 51
        '
        'btnprint
        '
        Me.btnprint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(1081, 618)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(115, 44)
        Me.btnprint.TabIndex = 3
        Me.btnprint.Text = "Print.."
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(427, 613)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(196, 25)
        Me.lbltotal.TabIndex = 54
        Me.lbltotal.Text = "TOTAL AMOUNT:"
        '
        'lblamount
        '
        Me.lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(856, 613)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(86, 25)
        Me.lblamount.TabIndex = 55
        Me.lblamount.Text = "00"
        '
        'bill_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lsttot)
        Me.Controls.Add(Me.lstprice)
        Me.Controls.Add(Me.lstqty)
        Me.Controls.Add(Me.lstdes)
        Me.Controls.Add(Me.lstno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcus)
        Me.Controls.Add(Me.lblcus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.lblcadila)
        Me.Controls.Add(Me.clogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bill_form"
        Me.Text = "bill_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcadila As Label
    Friend WithEvents clogo As PictureBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblcus As Label
    Friend WithEvents txtcus As TextBox
    Friend WithEvents txtmo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lstno As ListBox
    Friend WithEvents lstdes As ListBox
    Friend WithEvents lstqty As ListBox
    Friend WithEvents lstprice As ListBox
    Friend WithEvents lsttot As ListBox
    Friend WithEvents btnprint As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblamount As Label
End Class
