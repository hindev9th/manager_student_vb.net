Public Class frlogin
    Dim kn As New kn()
    Private Sub cmdDangNhap_Click(sender As Object, e As EventArgs) Handles cmdDangNhap.Click
        DN()
    End Sub
    Private Sub cmdThoat_Click(sender As Object, e As EventArgs) Handles cmdThoat.Click
        End
    End Sub
    Private Sub txtTenDN_Click(sender As Object, e As EventArgs) Handles txtTenDN.Click
        txtTenDN.Text = ""
    End Sub

    Private Sub txtMatKhau_Click(sender As Object, e As EventArgs) Handles txtMatKhau.Click
        txtMatKhau.UseSystemPasswordChar = True
        txtMatKhau.Text = ""
    End Sub
    Private Sub ID_KeyPress(sender As System.Object, e As System.EventArgs) Handles txtTenDN.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            txtMatKhau.Focus()
            txtMatKhau.UseSystemPasswordChar = True
            txtMatKhau.Text = ""
        End If
    End Sub
    Private Sub pass_KeyPress(sender As System.Object, e As System.EventArgs) Handles txtMatKhau.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            Call cmdDangNhap_Click(sender, e)
        End If
    End Sub
    Private Sub DN()
        Dim sql1 As String = "Select * From tblLOGIN where TenDN='" & txtTenDN.Text & "' and MatKhau ='" & txtMatKhau.Text & "'"
        Dim table1 As String = "tblLOGIN"
        Dim kn As New kn()
        kn.kn()

        If kn.getdata(sql1, table1).Rows.Count > 0 Then
            MessageBox.Show("Đăng nhập vào hệ thống !", "Thông Báo!")
            frmain.mnDangNhap.Enabled = False
            frmain.mnDangXuat.Enabled = True
            frmain.mnGiang.Enabled = True
            frmain.mnKhoa.Enabled = True
            frmain.mnLop.Enabled = True
            frmain.mnMonHoc.Enabled = True
            frmain.mnQLNgưoiDung.Enabled = True
            frmain.mnSinhVien.Enabled = True
            frmain.mnĐiem.Enabled = True
            Me.Close()
        Else
            If txtTenDN.Text = "" And txtMatKhau.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Tài Khoản và Mật Khẩu!!", "Thông Báo!")
                txtTenDN.Focus()
            ElseIf txtTenDN.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Tài Khoản !!", "Thông Báo!")
                txtTenDN.Focus()
            ElseIf (txtMatKhau.Text = "") Then
                MessageBox.Show("Bạn chưa nhập Mạt Khẩu !!", "Thông Báo!")
                txtMatKhau.Focus()
            Else
                MessageBox.Show("Sai Tài Khoản hoặc Mật Kkhẩu - vui lòng nhập lại !!", "Thông Báo!")
                txtTenDN.Focus()
            End If
        End If
    End Sub

    Private Sub frlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
