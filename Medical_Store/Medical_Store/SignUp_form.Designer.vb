<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp_form))
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.txtmo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnclo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(733, 129)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(298, 31)
        Me.txtuser.TabIndex = 1
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.SystemColors.Control
        Me.lbluser.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(371, 129)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(149, 31)
        Me.lbluser.TabIndex = 3
        Me.lbluser.Text = "User Name"
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(733, 203)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(298, 31)
        Me.txtpwd.TabIndex = 2
        '
        'lblpwd
        '
        Me.lblpwd.BackColor = System.Drawing.SystemColors.Control
        Me.lblpwd.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd.Location = New System.Drawing.Point(371, 203)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(152, 31)
        Me.lblpwd.TabIndex = 5
        Me.lblpwd.Text = "  Password"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Re-enter Password"
        '
        'txtre
        '
        Me.txtre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtre.Location = New System.Drawing.Point(733, 274)
        Me.txtre.Name = "txtre"
        Me.txtre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtre.Size = New System.Drawing.Size(298, 31)
        Me.txtre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Birth Date"
        '
        'dp1
        '
        Me.dp1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp1.Location = New System.Drawing.Point(733, 348)
        Me.dp1.Name = "dp1"
        Me.dp1.Size = New System.Drawing.Size(298, 31)
        Me.dp1.TabIndex = 4
        Me.dp1.Value = New Date(2018, 4, 3, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 31)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gender"
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.BackColor = System.Drawing.Color.Transparent
        Me.rad1.Checked = True
        Me.rad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1.ForeColor = System.Drawing.Color.Red
        Me.rad1.Location = New System.Drawing.Point(733, 417)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(94, 35)
        Me.rad1.TabIndex = 5
        Me.rad1.TabStop = True
        Me.rad1.Text = "Male"
        Me.rad1.UseVisualStyleBackColor = False
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.BackColor = System.Drawing.Color.Transparent
        Me.rad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad2.ForeColor = System.Drawing.Color.Red
        Me.rad2.Location = New System.Drawing.Point(895, 417)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(128, 35)
        Me.rad2.TabIndex = 6
        Me.rad2.Text = "Female"
        Me.rad2.UseVisualStyleBackColor = False
        '
        'txtmo
        '
        Me.txtmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmo.Location = New System.Drawing.Point(733, 482)
        Me.txtmo.MaxLength = 10
        Me.txtmo.Name = "txtmo"
        Me.txtmo.Size = New System.Drawing.Size(298, 31)
        Me.txtmo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mobile No"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(499, 579)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Sign Up"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnclo
        '
        Me.btnclo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnclo.Location = New System.Drawing.Point(777, 579)
        Me.btnclo.Name = "btnclo"
        Me.btnclo.Size = New System.Drawing.Size(254, 43)
        Me.btnclo.TabIndex = 9
        Me.btnclo.Text = "Close"
        Me.btnclo.UseVisualStyleBackColor = False
        '
        'SignUp_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1217, 657)
        Me.Controls.Add(Me.btnclo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtmo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rad2)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lbluser)
        Me.Name = "SignUp_form"
        Me.Text = "SignUp_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtuser As TextBox
    Friend WithEvents lbluser As Label
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents lblpwd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dp1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents rad2 As RadioButton
    Friend WithEvents txtmo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnclo As Button
End Class
