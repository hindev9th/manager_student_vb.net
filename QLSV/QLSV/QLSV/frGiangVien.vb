Public Class frGiangVien
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblGIANG_VIEN"
    Dim table1 As String = "tblGIANG_VIEN"

    Private Sub frGiangVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ShowData()
        cmdLuu.Enabled = False
    End Sub

    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        txtMaGV.Focus()
        txtMaGV.Text = ""
        txtTenGV.Text = ""
        txtGioiTinh.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPhanLoaiGV.Text = ""
        n = 1
    End Sub

    Private Sub cmdLuu_Click(sender As Object, e As EventArgs) Handles cmdLuu.Click
        cmdThem.Enabled = True
        cmdLuu.Enabled = False
        cmdSua.Enabled = True
        cmdXoa.Enabled = True
        GroupBox1.Visible = False
        If n = 1 Then
            Call Insert()
        ElseIf n = 2 Then
            Call Updatee()
        End If
        Call CType(dgvGiangVien.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdSua_Click(sender As Object, e As EventArgs) Handles cmdSua.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        n = 2
    End Sub

    Private Sub cmdXoa_Click(sender As Object, e As EventArgs) Handles cmdXoa.Click
        If MsgBox("Bạn có muốn xóa giảng viên này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvGiangVien.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdDong_Click(sender As Object, e As EventArgs) Handles cmdDong.Click
        Me.Close()
    End Sub
    Private Sub ShowData()
        dgvGiangVien.DataSource = kn.getdata(sql1, table1)
    End Sub

    Private Sub dgvGiangVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiangVien.CellClick
        Dim i As Integer
        i = dgvGiangVien.CurrentRow.Index
        txtMaGV.Text = dgvGiangVien.Item(0, i).Value
        txtTenGV.Text = dgvGiangVien.Item(1, i).Value
        txtGioiTinh.Text = dgvGiangVien.Item(2, i).Value
        txtPhone.Text = dgvGiangVien.Item(3, i).Value
        txtEmail.Text = dgvGiangVien.Item(4, i).Value
        txtPhanLoaiGV.Text = dgvGiangVien.Item(5, i).Value
    End Sub
    Private Sub Insert()
        Dim insert As String = "INSERT INTO tblGIANG_VIEN  values (N'" & txtMaGV.Text & "',N'" & txtTenGV.Text & "',N'" & txtGioiTinh.Text & "',N'" & txtPhone.Text & "',N'" & txtEmail.Text & "',N'" & txtPhanLoaiGV.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("loi!")
        End Try
    End Sub
    Private Sub Updatee()
        Dim Update As String = "UPDATE tblGIANG_VIEN SET TenGV =N'" & txtTenGV.Text & "',GioiTinh =N'" & txtGioiTinh.Text & "',Phone =N'" & txtPhone.Text & "',Email =N'" & txtEmail.Text & "',PhanLoaiGV =N'" & txtPhanLoaiGV.Text & "' where  MaGV ='" & txtMaGV.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblGIANG_VIEN WHERE MaGV='" & txtMaGV.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
End Class