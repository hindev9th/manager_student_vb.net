<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qlDiem
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdLuu = New System.Windows.Forms.Button()
        Me.txtDiemTK = New System.Windows.Forms.TextBox()
        Me.txtDiemThi = New System.Windows.Forms.TextBox()
        Me.txtDiem = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDong = New System.Windows.Forms.Button()
        Me.cmdXoa = New System.Windows.Forms.Button()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdThem = New System.Windows.Forms.Button()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.txtMaMH = New System.Windows.Forms.TextBox()
        Me.txtMalop = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHanhKiem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHocKi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(397, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Quản Lý Điểm"
        '
        'cmdLuu
        '
        Me.cmdLuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLuu.Location = New System.Drawing.Point(274, 234)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(123, 44)
        Me.cmdLuu.TabIndex = 37
        Me.cmdLuu.Text = "Lưu"
        Me.cmdLuu.UseVisualStyleBackColor = False
        '
        'txtDiemTK
        '
        Me.txtDiemTK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiemTK.Location = New System.Drawing.Point(558, 84)
        Me.txtDiemTK.Name = "txtDiemTK"
        Me.txtDiemTK.Size = New System.Drawing.Size(184, 23)
        Me.txtDiemTK.TabIndex = 36
        '
        'txtDiemThi
        '
        Me.txtDiemThi.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiemThi.Location = New System.Drawing.Point(558, 56)
        Me.txtDiemThi.Name = "txtDiemThi"
        Me.txtDiemThi.Size = New System.Drawing.Size(184, 23)
        Me.txtDiemThi.TabIndex = 35
        '
        'txtDiem
        '
        Me.txtDiem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiem.Location = New System.Drawing.Point(558, 28)
        Me.txtDiem.Name = "txtDiem"
        Me.txtDiem.Size = New System.Drawing.Size(184, 23)
        Me.txtDiem.TabIndex = 34
        '
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(189, 59)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(176, 23)
        Me.txtHoTen.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(461, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Điểm TK      :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(462, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Điểm Thi      :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Điểm             :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Mã môn học   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Họ và Tên      :"
        '
        'cmdDong
        '
        Me.cmdDong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDong.Location = New System.Drawing.Point(734, 234)
        Me.cmdDong.Name = "cmdDong"
        Me.cmdDong.Size = New System.Drawing.Size(123, 44)
        Me.cmdDong.TabIndex = 27
        Me.cmdDong.Text = "Đóng"
        Me.cmdDong.UseVisualStyleBackColor = False
        '
        'cmdXoa
        '
        Me.cmdXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXoa.Location = New System.Drawing.Point(578, 234)
        Me.cmdXoa.Name = "cmdXoa"
        Me.cmdXoa.Size = New System.Drawing.Size(123, 44)
        Me.cmdXoa.TabIndex = 26
        Me.cmdXoa.Text = "Xóa"
        Me.cmdXoa.UseVisualStyleBackColor = False
        '
        'cmdSua
        '
        Me.cmdSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(424, 234)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(123, 44)
        Me.cmdSua.TabIndex = 25
        Me.cmdSua.Text = "Sửa"
        Me.cmdSua.UseVisualStyleBackColor = False
        '
        'cmdThem
        '
        Me.cmdThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThem.Location = New System.Drawing.Point(123, 234)
        Me.cmdThem.Name = "cmdThem"
        Me.cmdThem.Size = New System.Drawing.Size(123, 44)
        Me.cmdThem.TabIndex = 24
        Me.cmdThem.Text = "Thêm"
        Me.cmdThem.UseVisualStyleBackColor = False
        '
        'txtMaSV
        '
        Me.txtMaSV.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaSV.Location = New System.Drawing.Point(189, 31)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(176, 23)
        Me.txtMaSV.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Mã Sinh Viên :"
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Location = New System.Drawing.Point(79, 300)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.Size = New System.Drawing.Size(841, 238)
        Me.dgvSinhVien.TabIndex = 40
        '
        'txtMaMH
        '
        Me.txtMaMH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaMH.Location = New System.Drawing.Point(189, 115)
        Me.txtMaMH.Name = "txtMaMH"
        Me.txtMaMH.Size = New System.Drawing.Size(176, 23)
        Me.txtMaMH.TabIndex = 41
        '
        'txtMalop
        '
        Me.txtMalop.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMalop.Location = New System.Drawing.Point(189, 87)
        Me.txtMalop.Name = "txtMalop"
        Me.txtMalop.Size = New System.Drawing.Size(176, 23)
        Me.txtMalop.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Mã Lớp            :"
        '
        'txtHanhKiem
        '
        Me.txtHanhKiem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHanhKiem.Location = New System.Drawing.Point(558, 112)
        Me.txtHanhKiem.Name = "txtHanhKiem"
        Me.txtHanhKiem.Size = New System.Drawing.Size(184, 23)
        Me.txtHanhKiem.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(462, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Hạnh Kiểm :"
        '
        'txtHocKi
        '
        Me.txtHocKi.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHocKi.Location = New System.Drawing.Point(558, 140)
        Me.txtHocKi.Name = "txtHocKi"
        Me.txtHocKi.Size = New System.Drawing.Size(184, 23)
        Me.txtHocKi.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(462, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Học Kì          :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHocKi)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtHanhKiem)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMalop)
        Me.GroupBox1.Controls.Add(Me.txtDiemTK)
        Me.GroupBox1.Controls.Add(Me.txtMaMH)
        Me.GroupBox1.Controls.Add(Me.txtDiemThi)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaSV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDiem)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 187)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'qlDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 603)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdLuu)
        Me.Controls.Add(Me.cmdDong)
        Me.Controls.Add(Me.cmdXoa)
        Me.Controls.Add(Me.cmdSua)
        Me.Controls.Add(Me.cmdThem)
        Me.Name = "qlDiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý điểm"
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents cmdLuu As Button
    Friend WithEvents txtDiemTK As TextBox
    Friend WithEvents txtDiemThi As TextBox
    Friend WithEvents txtDiem As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdDong As Button
    Friend WithEvents cmdXoa As Button
    Friend WithEvents cmdSua As Button
    Friend WithEvents cmdThem As Button
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents txtMaMH As TextBox
    Friend WithEvents txtMalop As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHanhKiem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHocKi As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
