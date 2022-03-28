<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnHeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDangNhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnQLNgưoiDung = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDanhMuc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnKhoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMonHoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnGiang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnQuanLy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSinhVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnĐiem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTroGiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnHeThong, Me.mnDanhMuc, Me.mnQuanLy, Me.mnTroGiup})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnHeThong
        '
        Me.mnHeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDangNhap, Me.mnQLNgưoiDung, Me.mnDangXuat, Me.ToolStripMenuItem2, Me.mnExit})
        Me.mnHeThong.Name = "mnHeThong"
        Me.mnHeThong.Size = New System.Drawing.Size(70, 20)
        Me.mnHeThong.Text = "&Hệ Thống"
        '
        'mnDangNhap
        '
        Me.mnDangNhap.Name = "mnDangNhap"
        Me.mnDangNhap.Size = New System.Drawing.Size(206, 22)
        Me.mnDangNhap.Text = "Đăng nhập"
        '
        'mnQLNgưoiDung
        '
        Me.mnQLNgưoiDung.Enabled = False
        Me.mnQLNgưoiDung.Name = "mnQLNgưoiDung"
        Me.mnQLNgưoiDung.Size = New System.Drawing.Size(206, 22)
        Me.mnQLNgưoiDung.Text = "QL Người dùng"
        '
        'mnDangXuat
        '
        Me.mnDangXuat.Enabled = False
        Me.mnDangXuat.Name = "mnDangXuat"
        Me.mnDangXuat.Size = New System.Drawing.Size(206, 22)
        Me.mnDangXuat.Text = "Đăng xuất"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripMenuItem2.Text = "______________________"
        '
        'mnExit
        '
        Me.mnExit.Name = "mnExit"
        Me.mnExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnExit.Size = New System.Drawing.Size(206, 22)
        Me.mnExit.Text = "E&xit"
        '
        'mnDanhMuc
        '
        Me.mnDanhMuc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnKhoa, Me.mnLop, Me.mnMonHoc, Me.mnGiang})
        Me.mnDanhMuc.Name = "mnDanhMuc"
        Me.mnDanhMuc.Size = New System.Drawing.Size(73, 20)
        Me.mnDanhMuc.Text = "&Danh Mục"
        '
        'mnKhoa
        '
        Me.mnKhoa.Enabled = False
        Me.mnKhoa.Name = "mnKhoa"
        Me.mnKhoa.Size = New System.Drawing.Size(132, 22)
        Me.mnKhoa.Text = "Khoa"
        '
        'mnLop
        '
        Me.mnLop.Enabled = False
        Me.mnLop.Name = "mnLop"
        Me.mnLop.Size = New System.Drawing.Size(132, 22)
        Me.mnLop.Text = "Lớp"
        '
        'mnMonHoc
        '
        Me.mnMonHoc.Enabled = False
        Me.mnMonHoc.Name = "mnMonHoc"
        Me.mnMonHoc.Size = New System.Drawing.Size(132, 22)
        Me.mnMonHoc.Text = "Môn Học"
        '
        'mnGiang
        '
        Me.mnGiang.Enabled = False
        Me.mnGiang.Name = "mnGiang"
        Me.mnGiang.Size = New System.Drawing.Size(132, 22)
        Me.mnGiang.Text = "Giảng viên"
        '
        'mnQuanLy
        '
        Me.mnQuanLy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSinhVien, Me.mnĐiem})
        Me.mnQuanLy.Name = "mnQuanLy"
        Me.mnQuanLy.Size = New System.Drawing.Size(61, 20)
        Me.mnQuanLy.Text = "&Quản Lý"
        '
        'mnSinhVien
        '
        Me.mnSinhVien.Enabled = False
        Me.mnSinhVien.Name = "mnSinhVien"
        Me.mnSinhVien.Size = New System.Drawing.Size(126, 22)
        Me.mnSinhVien.Text = "Sinh Viên"
        '
        'mnĐiem
        '
        Me.mnĐiem.Enabled = False
        Me.mnĐiem.Name = "mnĐiem"
        Me.mnĐiem.Size = New System.Drawing.Size(126, 22)
        Me.mnĐiem.Text = "Điểm"
        '
        'mnTroGiup
        '
        Me.mnTroGiup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.mnAbout})
        Me.mnTroGiup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mnTroGiup.Name = "mnTroGiup"
        Me.mnTroGiup.Size = New System.Drawing.Size(62, 20)
        Me.mnTroGiup.Text = "&Trợ giúp"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Enabled = False
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem3.Text = "================="
        '
        'mnAbout
        '
        Me.mnAbout.Name = "mnAbout"
        Me.mnAbout.Size = New System.Drawing.Size(176, 22)
        Me.mnAbout.Text = "&About"
        '
        'frmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 603)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sinh Viên"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnHeThong As ToolStripMenuItem
    Friend WithEvents mnDanhMuc As ToolStripMenuItem
    Friend WithEvents mnKhoa As ToolStripMenuItem
    Friend WithEvents mnLop As ToolStripMenuItem
    Friend WithEvents mnMonHoc As ToolStripMenuItem
    Friend WithEvents mnQuanLy As ToolStripMenuItem
    Friend WithEvents mnSinhVien As ToolStripMenuItem
    Friend WithEvents mnĐiem As ToolStripMenuItem
    Friend WithEvents mnTroGiup As ToolStripMenuItem
    Friend WithEvents mnExit As ToolStripMenuItem
    Friend WithEvents mnAbout As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents mnQLNgưoiDung As ToolStripMenuItem
    Friend WithEvents mnDangXuat As ToolStripMenuItem
    Friend WithEvents mnGiang As ToolStripMenuItem
    Friend WithEvents mnDangNhap As ToolStripMenuItem
End Class
