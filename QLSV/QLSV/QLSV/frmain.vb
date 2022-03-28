Public Class frmain
    Private Sub mnHeThong_Click(sender As Object, e As EventArgs) Handles mnHeThong.Click

    End Sub

    Private Sub mnSinhVien_Click(sender As Object, e As EventArgs) Handles mnSinhVien.Click
        qlSinhVien.Show()
    End Sub

    Private Sub mnĐiem_Click(sender As Object, e As EventArgs) Handles mnĐiem.Click
        qlDiem.Show()
    End Sub
    Private Sub mnKhoa_Click(sender As Object, e As EventArgs) Handles mnKhoa.Click
        qlKhoa.Show()
    End Sub

    Private Sub mnLop_Click(sender As Object, e As EventArgs) Handles mnLop.Click
        qlLop.Show()
    End Sub

    Private Sub mnMonHoc_Click(sender As Object, e As EventArgs) Handles mnMonHoc.Click
        qlMonHoc.Show()
    End Sub

    Private Sub mnAbout_Click(sender As Object, e As EventArgs) Handles mnAbout.Click
        about.Show()
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        End
    End Sub

    Private Sub frmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnQLNgườiDùng_Click(sender As Object, e As EventArgs) Handles mnQLNgưoiDung.Click
        qlNguoidung.Show()
    End Sub
    Private Sub mnDangXuat_Click(sender As Object, e As EventArgs) Handles mnDangXuat.Click
        mnDangNhap.Enabled = True
        mnDangXuat.Enabled = False
        mnGiang.Enabled = False
        mnKhoa.Enabled = False
        mnLop.Enabled = False
        mnMonHoc.Enabled = False
        mnQLNgưoiDung.Enabled = False
        mnSinhVien.Enabled = False
        mnĐiem.Enabled = False
    End Sub

    Private Sub mnGiang_Click(sender As Object, e As EventArgs) Handles mnGiang.Click
        frGiangVien.Show()
    End Sub
    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnDangNhap.Click
        frlogin.Show()
    End Sub
End Class
