<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(131, 118)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(230, 204)
        Me.pictureBox1.TabIndex = 19
        Me.pictureBox1.TabStop = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(387, 216)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(49, 15)
        Me.label10.TabIndex = 18
        Me.label10.Text = "Liên hệ:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Blue
        Me.label8.Location = New System.Drawing.Point(442, 216)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(206, 15)
        Me.label8.TabIndex = 16
        Me.label8.Text = "Lenguyenhien.tsth23.01@gmail.com"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Green
        Me.label7.Location = New System.Drawing.Point(553, 177)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(122, 20)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Lê Nguyên Hiện"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Green
        Me.label3.Location = New System.Drawing.Point(387, 177)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(145, 19)
        Me.label3.TabIndex = 13
        Me.label3.Text = " Sinh viên thực hiện:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.Control
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Image = Global.QLSV.My.Resources.Resources.welcome
        Me.label1.Location = New System.Drawing.Point(227, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(341, 19)
        Me.label1.TabIndex = 11
        Me.label1.Text = "CHƯƠNG TRÌNH QUẢN LÍ ĐIỂM SINH VIÊN"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLSV.My.Resources.Resources.welcome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "about"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label10 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
End Class
