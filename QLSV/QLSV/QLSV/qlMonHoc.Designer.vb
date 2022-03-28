<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qlMonHoc
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
        Me.dgvDanhSachmh = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHocKi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaGV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoTin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTenMH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaMH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvDiem = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachmh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(416, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 26)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Quản Lý Môn Học"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdLuu)
        Me.GroupBox4.Controls.Add(Me.cmdDong)
        Me.GroupBox4.Controls.Add(Me.cmdXoa)
        Me.GroupBox4.Controls.Add(Me.cmdSua)
        Me.GroupBox4.Controls.Add(Me.cmdThem)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(805, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 494)
        Me.GroupBox4.TabIndex = 50
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
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachmh)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(312, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 310)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh Sách Môn Học"
        '
        'dgvDanhSachmh
        '
        Me.dgvDanhSachmh.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvDanhSachmh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDanhSachmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachmh.Location = New System.Drawing.Point(6, 19)
        Me.dgvDanhSachmh.Name = "dgvDanhSachmh"
        Me.dgvDanhSachmh.Size = New System.Drawing.Size(465, 285)
        Me.dgvDanhSachmh.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaKhoa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHocKi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaGV)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSoTin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtTenMH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaMH)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 495)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKhoa.Location = New System.Drawing.Point(88, 298)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(176, 27)
        Me.txtMaKhoa.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Mã Khoa"
        '
        'txtHocKi
        '
        Me.txtHocKi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHocKi.Location = New System.Drawing.Point(88, 254)
        Me.txtHocKi.Name = "txtHocKi"
        Me.txtHocKi.Size = New System.Drawing.Size(176, 27)
        Me.txtHocKi.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Học Kì"
        '
        'txtMaGV
        '
        Me.txtMaGV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaGV.Location = New System.Drawing.Point(88, 211)
        Me.txtMaGV.Name = "txtMaGV"
        Me.txtMaGV.Size = New System.Drawing.Size(176, 27)
        Me.txtMaGV.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Mã GV"
        '
        'txtSoTin
        '
        Me.txtSoTin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSoTin.Location = New System.Drawing.Point(88, 169)
        Me.txtSoTin.Name = "txtSoTin"
        Me.txtSoTin.Size = New System.Drawing.Size(176, 27)
        Me.txtSoTin.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Số Tín"
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
        'txtTenMH
        '
        Me.txtTenMH.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenMH.Location = New System.Drawing.Point(88, 122)
        Me.txtTenMH.Name = "txtTenMH"
        Me.txtTenMH.Size = New System.Drawing.Size(176, 27)
        Me.txtTenMH.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tên Môn"
        '
        'txtMaMH
        '
        Me.txtMaMH.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaMH.Location = New System.Drawing.Point(88, 71)
        Me.txtMaMH.Name = "txtMaMH"
        Me.txtMaMH.Size = New System.Drawing.Size(176, 27)
        Me.txtMaMH.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Mã Môn"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvDiem)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(312, 391)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(477, 179)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Điểm"
        '
        'dgvDiem
        '
        Me.dgvDiem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiem.Location = New System.Drawing.Point(6, 19)
        Me.dgvDiem.Name = "dgvDiem"
        Me.dgvDiem.Size = New System.Drawing.Size(465, 151)
        Me.dgvDiem.TabIndex = 23
        '
        'qlMonHoc
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
        Me.Name = "qlMonHoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý môn học"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachmh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvDanhSachmh As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSoTin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTenMH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaMH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvDiem As DataGridView
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHocKi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaGV As TextBox
    Friend WithEvents Label4 As Label
End Class
