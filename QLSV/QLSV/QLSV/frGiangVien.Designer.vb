<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frGiangVien
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPhanLoaiGV = New System.Windows.Forms.TextBox()
        Me.txtTenGV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaGV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dgvGiangVien = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdLuu = New System.Windows.Forms.Button()
        Me.cmdDong = New System.Windows.Forms.Button()
        Me.cmdXoa = New System.Windows.Forms.Button()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdThem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGiangVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtGioiTinh)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtPhanLoaiGV)
        Me.GroupBox1.Controls.Add(Me.txtTenGV)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaGV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 187)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Giới tính"
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGioiTinh.Location = New System.Drawing.Point(194, 105)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(176, 27)
        Me.txtGioiTinh.TabIndex = 42
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(575, 46)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(184, 27)
        Me.txtPhone.TabIndex = 41
        '
        'txtPhanLoaiGV
        '
        Me.txtPhanLoaiGV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPhanLoaiGV.Location = New System.Drawing.Point(575, 102)
        Me.txtPhanLoaiGV.Name = "txtPhanLoaiGV"
        Me.txtPhanLoaiGV.Size = New System.Drawing.Size(184, 27)
        Me.txtPhanLoaiGV.TabIndex = 35
        '
        'txtTenGV
        '
        Me.txtTenGV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenGV.Location = New System.Drawing.Point(194, 77)
        Me.txtTenGV.Name = "txtTenGV"
        Me.txtTenGV.Size = New System.Drawing.Size(176, 27)
        Me.txtTenGV.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(479, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Phân loại GV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Số điện thoại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Họ và Tên      "
        '
        'txtMaGV
        '
        Me.txtMaGV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaGV.Location = New System.Drawing.Point(194, 49)
        Me.txtMaGV.Name = "txtMaGV"
        Me.txtMaGV.Size = New System.Drawing.Size(176, 27)
        Me.txtMaGV.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Mã giảng viên "
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(575, 74)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 27)
        Me.txtEmail.TabIndex = 34
        '
        'dgvGiangVien
        '
        Me.dgvGiangVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGiangVien.Location = New System.Drawing.Point(90, 300)
        Me.dgvGiangVien.Name = "dgvGiangVien"
        Me.dgvGiangVien.Size = New System.Drawing.Size(841, 238)
        Me.dgvGiangVien.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(408, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 26)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Quản Lý Giang Viên"
        '
        'cmdLuu
        '
        Me.cmdLuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLuu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdLuu.Location = New System.Drawing.Point(285, 234)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(123, 44)
        Me.cmdLuu.TabIndex = 55
        Me.cmdLuu.Text = "Lưu"
        Me.cmdLuu.UseVisualStyleBackColor = False
        '
        'cmdDong
        '
        Me.cmdDong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDong.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdDong.Location = New System.Drawing.Point(745, 234)
        Me.cmdDong.Name = "cmdDong"
        Me.cmdDong.Size = New System.Drawing.Size(123, 44)
        Me.cmdDong.TabIndex = 54
        Me.cmdDong.Text = "Đóng"
        Me.cmdDong.UseVisualStyleBackColor = False
        '
        'cmdXoa
        '
        Me.cmdXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdXoa.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdXoa.Location = New System.Drawing.Point(589, 234)
        Me.cmdXoa.Name = "cmdXoa"
        Me.cmdXoa.Size = New System.Drawing.Size(123, 44)
        Me.cmdXoa.TabIndex = 53
        Me.cmdXoa.Text = "Xóa"
        Me.cmdXoa.UseVisualStyleBackColor = False
        '
        'cmdSua
        '
        Me.cmdSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSua.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(435, 234)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(123, 44)
        Me.cmdSua.TabIndex = 52
        Me.cmdSua.Text = "Sửa"
        Me.cmdSua.UseVisualStyleBackColor = False
        '
        'cmdThem
        '
        Me.cmdThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdThem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdThem.Location = New System.Drawing.Point(134, 234)
        Me.cmdThem.Name = "cmdThem"
        Me.cmdThem.Size = New System.Drawing.Size(123, 44)
        Me.cmdThem.TabIndex = 51
        Me.cmdThem.Text = "Thêm"
        Me.cmdThem.UseVisualStyleBackColor = False
        '
        'frGiangVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 603)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGiangVien)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdLuu)
        Me.Controls.Add(Me.cmdDong)
        Me.Controls.Add(Me.cmdXoa)
        Me.Controls.Add(Me.cmdSua)
        Me.Controls.Add(Me.cmdThem)
        Me.Name = "frGiangVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GiangVien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGiangVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtPhanLoaiGV As TextBox
    Friend WithEvents txtTenGV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaGV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dgvGiangVien As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdLuu As Button
    Friend WithEvents cmdDong As Button
    Friend WithEvents cmdXoa As Button
    Friend WithEvents cmdSua As Button
    Friend WithEvents cmdThem As Button
End Class
