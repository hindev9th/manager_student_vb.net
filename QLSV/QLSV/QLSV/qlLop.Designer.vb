<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qlLop
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdLuu = New System.Windows.Forms.Button()
        Me.cmdDong = New System.Windows.Forms.Button()
        Me.cmdXoa = New System.Windows.Forms.Button()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdThem = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachLop = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTenLop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(418, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Quản Lý Lớp"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdLuu)
        Me.GroupBox4.Controls.Add(Me.cmdDong)
        Me.GroupBox4.Controls.Add(Me.cmdXoa)
        Me.GroupBox4.Controls.Add(Me.cmdSua)
        Me.GroupBox4.Controls.Add(Me.cmdThem)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(805, 54)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 494)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lựa chọn"
        '
        'cmdLuu
        '
        Me.cmdLuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLuu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdLuu.Location = New System.Drawing.Point(30, 97)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(123, 44)
        Me.cmdLuu.TabIndex = 38
        Me.cmdLuu.Text = "Lưu"
        Me.cmdLuu.UseVisualStyleBackColor = False
        '
        'cmdDong
        '
        Me.cmdDong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDong.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdDong.Location = New System.Drawing.Point(30, 382)
        Me.cmdDong.Name = "cmdDong"
        Me.cmdDong.Size = New System.Drawing.Size(123, 44)
        Me.cmdDong.TabIndex = 28
        Me.cmdDong.Text = "Đóng"
        Me.cmdDong.UseVisualStyleBackColor = False
        '
        'cmdXoa
        '
        Me.cmdXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdXoa.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdXoa.Location = New System.Drawing.Point(30, 242)
        Me.cmdXoa.Name = "cmdXoa"
        Me.cmdXoa.Size = New System.Drawing.Size(123, 44)
        Me.cmdXoa.TabIndex = 27
        Me.cmdXoa.Text = "Xóa"
        Me.cmdXoa.UseVisualStyleBackColor = False
        '
        'cmdSua
        '
        Me.cmdSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSua.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(30, 169)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(123, 44)
        Me.cmdSua.TabIndex = 26
        Me.cmdSua.Text = "Sửa"
        Me.cmdSua.UseVisualStyleBackColor = False
        '
        'cmdThem
        '
        Me.cmdThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdThem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdThem.Location = New System.Drawing.Point(30, 31)
        Me.cmdThem.Name = "cmdThem"
        Me.cmdThem.Size = New System.Drawing.Size(123, 44)
        Me.cmdThem.TabIndex = 25
        Me.cmdThem.Text = "Thêm"
        Me.cmdThem.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachLop)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(312, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 298)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh Sách Lớp"
        '
        'dgvDanhSachLop
        '
        Me.dgvDanhSachLop.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvDanhSachLop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLop.Location = New System.Drawing.Point(6, 19)
        Me.dgvDanhSachLop.Name = "dgvDanhSachLop"
        Me.dgvDanhSachLop.Size = New System.Drawing.Size(464, 268)
        Me.dgvDanhSachLop.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTenLop)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtMaLop)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaKhoa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 495)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'txtTenLop
        '
        Me.txtTenLop.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenLop.Location = New System.Drawing.Point(88, 169)
        Me.txtTenLop.Name = "txtTenLop"
        Me.txtTenLop.Size = New System.Drawing.Size(176, 27)
        Me.txtTenLop.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Tên Lớp"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(280, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 527)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtMaLop
        '
        Me.txtMaLop.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaLop.Location = New System.Drawing.Point(88, 122)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.Size = New System.Drawing.Size(176, 27)
        Me.txtMaLop.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Mã Lớp"
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKhoa.Location = New System.Drawing.Point(88, 71)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(176, 27)
        Me.txtMaKhoa.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Mã Khoa"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvSinhVien)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(310, 357)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(478, 191)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sinh Viên"
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Location = New System.Drawing.Point(8, 19)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.Size = New System.Drawing.Size(464, 164)
        Me.dgvSinhVien.TabIndex = 23
        '
        'qlLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 603)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "qlLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý lớp"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachLop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmdLuu As Button
    Friend WithEvents cmdDong As Button
    Friend WithEvents cmdXoa As Button
    Friend WithEvents cmdSua As Button
    Friend WithEvents cmdThem As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvDanhSachLop As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenLop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvSinhVien As DataGridView
End Class
