<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frlogin))
        Me.txtTenDN = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.cmdDangNhap = New System.Windows.Forms.Button()
        Me.cmdThoat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenDN
        '
        Me.txtTenDN.BackColor = System.Drawing.Color.LightGray
        Me.txtTenDN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTenDN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenDN.ForeColor = System.Drawing.Color.White
        Me.txtTenDN.Location = New System.Drawing.Point(3, 17)
        Me.txtTenDN.Name = "txtTenDN"
        Me.txtTenDN.Size = New System.Drawing.Size(294, 26)
        Me.txtTenDN.TabIndex = 2
        Me.txtTenDN.Text = "Tên Đăng Nhập"
        Me.txtTenDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMatKhau
        '
        Me.txtMatKhau.BackColor = System.Drawing.Color.LightGray
        Me.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMatKhau.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMatKhau.ForeColor = System.Drawing.Color.White
        Me.txtMatKhau.Location = New System.Drawing.Point(3, 18)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(294, 26)
        Me.txtMatKhau.TabIndex = 3
        Me.txtMatKhau.Text = "Mật Khẩu"
        Me.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdDangNhap
        '
        Me.cmdDangNhap.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDangNhap.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdDangNhap.ForeColor = System.Drawing.Color.White
        Me.cmdDangNhap.Location = New System.Drawing.Point(56, 247)
        Me.cmdDangNhap.Name = "cmdDangNhap"
        Me.cmdDangNhap.Size = New System.Drawing.Size(300, 60)
        Me.cmdDangNhap.TabIndex = 4
        Me.cmdDangNhap.Text = "Đăng Nhập"
        Me.cmdDangNhap.UseVisualStyleBackColor = False
        '
        'cmdThoat
        '
        Me.cmdThoat.BackColor = System.Drawing.Color.Red
        Me.cmdThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdThoat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmdThoat.ForeColor = System.Drawing.Color.White
        Me.cmdThoat.Location = New System.Drawing.Point(156, 348)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(100, 31)
        Me.cmdThoat.TabIndex = 5
        Me.cmdThoat.Text = "Thoát"
        Me.cmdThoat.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.txtTenDN)
        Me.Panel1.Location = New System.Drawing.Point(56, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 60)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.txtMatKhau)
        Me.Panel2.Location = New System.Drawing.Point(56, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 60)
        Me.Panel2.TabIndex = 9
        '
        'frlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(400, 430)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.cmdDangNhap)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập hệ thống"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTenDN As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents cmdDangNhap As Button
    Friend WithEvents cmdThoat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
