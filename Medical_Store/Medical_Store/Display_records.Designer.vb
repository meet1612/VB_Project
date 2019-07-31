<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display_records))
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.lblcadila = New System.Windows.Forms.Label()
        Me.clogo = New System.Windows.Forms.PictureBox()
        Me.lbluser1 = New System.Windows.Forms.Label()
        Me.userlogo = New System.Windows.Forms.PictureBox()
        Me.btnfinish = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.DarkTurquoise
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(433, 137)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(462, 508)
        Me.grid1.TabIndex = 0
        '
        'lblcadila
        '
        Me.lblcadila.BackColor = System.Drawing.Color.Transparent
        Me.lblcadila.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcadila.Location = New System.Drawing.Point(175, 9)
        Me.lblcadila.Name = "lblcadila"
        Me.lblcadila.Size = New System.Drawing.Size(751, 101)
        Me.lblcadila.TabIndex = 36
        Me.lblcadila.Text = "Accenture Medical"
        Me.lblcadila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clogo
        '
        Me.clogo.BackColor = System.Drawing.Color.Transparent
        Me.clogo.Image = CType(resources.GetObject("clogo.Image"), System.Drawing.Image)
        Me.clogo.Location = New System.Drawing.Point(0, 1)
        Me.clogo.Name = "clogo"
        Me.clogo.Size = New System.Drawing.Size(151, 141)
        Me.clogo.TabIndex = 35
        Me.clogo.TabStop = False
        '
        'lbluser1
        '
        Me.lbluser1.AutoSize = True
        Me.lbluser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser1.ForeColor = System.Drawing.Color.Black
        Me.lbluser1.Location = New System.Drawing.Point(1033, 26)
        Me.lbluser1.Name = "lbluser1"
        Me.lbluser1.Size = New System.Drawing.Size(108, 33)
        Me.lbluser1.TabIndex = 34
        Me.lbluser1.Text = "Label1"
        '
        'userlogo
        '
        Me.userlogo.BackColor = System.Drawing.Color.Transparent
        Me.userlogo.Image = CType(resources.GetObject("userlogo.Image"), System.Drawing.Image)
        Me.userlogo.Location = New System.Drawing.Point(958, 9)
        Me.userlogo.Name = "userlogo"
        Me.userlogo.Size = New System.Drawing.Size(60, 58)
        Me.userlogo.TabIndex = 33
        Me.userlogo.TabStop = False
        '
        'btnfinish
        '
        Me.btnfinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinish.Location = New System.Drawing.Point(1066, 606)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(147, 39)
        Me.btnfinish.TabIndex = 37
        Me.btnfinish.Text = "Finish.."
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'Display_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1225, 657)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.lblcadila)
        Me.Controls.Add(Me.clogo)
        Me.Controls.Add(Me.lbluser1)
        Me.Controls.Add(Me.userlogo)
        Me.Controls.Add(Me.grid1)
        Me.Name = "Display_records"
        Me.Text = "Display_records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As DataGridView
    Friend WithEvents lblcadila As Label
    Friend WithEvents clogo As PictureBox
    Friend WithEvents lbluser1 As Label
    Friend WithEvents userlogo As PictureBox
    Friend WithEvents btnfinish As Button
End Class
