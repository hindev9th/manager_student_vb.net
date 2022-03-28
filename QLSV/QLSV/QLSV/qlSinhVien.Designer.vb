<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qlSinhVien
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
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.cmdThem = New System.Windows.Forms.Button()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdXoa = New System.Windows.Forms.Button()
        Me.cmdDong = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtNoiSinh = New System.Windows.Forms.TextBox()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.cmdLuu = New System.Windows.Forms.Button()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grThongtin = New System.Windows.Forms.GroupBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtTmsv = New System.Windows.Forms.TextBox()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grThongtin.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Location = New System.Drawing.Point(126, 297)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.Size = New System.Drawing.Size(731, 238)
        Me.dgvSinhVien.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txtMaSV
        '
        Me.txtMaSV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaSV.Location = New System.Drawing.Point(129, 17)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(176, 27)
        Me.txtMaSV.TabIndex = 2
        '
        'cmdThem
        '
        Me.cmdThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdThem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdThem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdThem.Location = New System.Drawing.Point(126, 213)
        Me.cmdThem.Name = "cmdThem"
        Me.cmdThem.Size = New System.Drawing.Size(123, 44)
        Me.cmdThem.TabIndex = 3
        Me.cmdThem.Text = "Thêm"
        Me.cmdThem.UseVisualStyleBackColor = False
        '
        'cmdSua
        '
        Me.cmdSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSua.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(426, 213)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(123, 44)
        Me.cmdSua.TabIndex = 4
        Me.cmdSua.Text = "Sửa"
        Me.cmdSua.UseVisualStyleBackColor = False
        '
        'cmdXoa
        '
        Me.cmdXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdXoa.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdXoa.Location = New System.Drawing.Point(578, 213)
        Me.cmdXoa.Name = "cmdXoa"
        Me.cmdXoa.Size = New System.Drawing.Size(123, 44)
        Me.cmdXoa.TabIndex = 5
        Me.cmdXoa.Text = "Xóa"
        Me.cmdXoa.UseVisualStyleBackColor = False
        '
        'cmdDong
        '
        Me.cmdDong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDong.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdDong.Location = New System.Drawing.Point(734, 213)
        Me.cmdDong.Name = "cmdDong"
        Me.cmdDong.Size = New System.Drawing.Size(123, 44)
        Me.cmdDong.TabIndex = 6
        Me.cmdDong.Text = "Đóng"
        Me.cmdDong.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Họ và Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Giới Tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ngày Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nơi Sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mã Lớp"
        '
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(129, 51)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(176, 27)
        Me.txtHoTen.TabIndex = 12
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNgaySinh.Location = New System.Drawing.Point(498, 17)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(184, 27)
        Me.txtNgaySinh.TabIndex = 14
        '
        'txtNoiSinh
        '
        Me.txtNoiSinh.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNoiSinh.Location = New System.Drawing.Point(498, 51)
        Me.txtNoiSinh.Name = "txtNoiSinh"
        Me.txtNoiSinh.Size = New System.Drawing.Size(184, 27)
        Me.txtNoiSinh.TabIndex = 15
        '
        'txtMaLop
        '
        Me.txtMaLop.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaLop.Location = New System.Drawing.Point(498, 88)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.Size = New System.Drawing.Size(184, 27)
        Me.txtMaLop.TabIndex = 16
        '
        'cmdLuu
        '
        Me.cmdLuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLuu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdLuu.Location = New System.Drawing.Point(277, 213)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(123, 44)
        Me.cmdLuu.TabIndex = 17
        Me.cmdLuu.Text = "Lưu"
        Me.cmdLuu.UseVisualStyleBackColor = False
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(129, 90)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(176, 27)
        Me.cbGioiTinh.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(398, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Quản Lý Sinh Viên"
        '
        'grThongtin
        '
        Me.grThongtin.Controls.Add(Me.cbGioiTinh)
        Me.grThongtin.Controls.Add(Me.txtMaLop)
        Me.grThongtin.Controls.Add(Me.txtNoiSinh)
        Me.grThongtin.Controls.Add(Me.txtNgaySinh)
        Me.grThongtin.Controls.Add(Me.txtHoTen)
        Me.grThongtin.Controls.Add(Me.Label6)
        Me.grThongtin.Controls.Add(Me.Label5)
        Me.grThongtin.Controls.Add(Me.Label4)
        Me.grThongtin.Controls.Add(Me.Label3)
        Me.grThongtin.Controls.Add(Me.Label2)
        Me.grThongtin.Controls.Add(Me.txtMaSV)
        Me.grThongtin.Controls.Add(Me.Label1)
        Me.grThongtin.Location = New System.Drawing.Point(126, 67)
        Me.grThongtin.Name = "grThongtin"
        Me.grThongtin.Size = New System.Drawing.Size(731, 126)
        Me.grThongtin.TabIndex = 23
        Me.grThongtin.TabStop = False
        Me.grThongtin.Visible = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimKiem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(370, 269)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(122, 23)
        Me.btnTimKiem.TabIndex = 25
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtTmsv
        '
        Me.txtTmsv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTmsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTmsv.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTmsv.Location = New System.Drawing.Point(126, 269)
        Me.txtTmsv.Name = "txtTmsv"
        Me.txtTmsv.Size = New System.Drawing.Size(238, 23)
        Me.txtTmsv.TabIndex = 21
        Me.txtTmsv.Text = "Nhập mã sinh viên để tìm "
        '
        'qlSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 603)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.grThongtin)
        Me.Controls.Add(Me.txtTmsv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdLuu)
        Me.Controls.Add(Me.cmdDong)
        Me.Controls.Add(Me.cmdXoa)
        Me.Controls.Add(Me.cmdSua)
        Me.Controls.Add(Me.cmdThem)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Name = "qlSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sinh Viên"
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grThongtin.ResumeLayout(False)
        Me.grThongtin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents cmdThem As Button
    Friend WithEvents cmdSua As Button
    Friend WithEvents cmdXoa As Button
    Friend WithEvents cmdDong As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtNoiSinh As TextBox
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents cmdLuu As Button
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grThongtin As GroupBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtTmsv As TextBox
End Class
