Public Class qlSinhVien
    Dim gt As String
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblSINH_VIEN"
    Dim table1 As String = "tblSINH_VIEN"
    Private Sub qlsv_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ShowData()
        cmdLuu.Enabled = False
    End Sub
    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        grThongtin.Visible = True

        txtMaSV.Focus()
        txtMaSV.Text = ""
        txtHoTen.Text = ""
        cbGioiTinh.Text = ""
        txtNgaySinh.Text = ""
        txtNoiSinh.Text = ""
        txtMaLop.Text = ""
        n = 1
    End Sub
    Private Sub cmdLuu_Click_1(sender As Object, e As EventArgs) Handles cmdLuu.Click
        cmdThem.Enabled = True
        cmdLuu.Enabled = False
        cmdSua.Enabled = True
        cmdXoa.Enabled = True
        grThongtin.Visible = False
        If n = 1 Then
            Call Insert()
        ElseIf n = 2 Then
            Call Updatee()
        End If
        Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub
    Private Sub cmdSua_Click(sender As Object, e As EventArgs) Handles cmdSua.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        grThongtin.Visible = True
        n = 2
    End Sub
    Private Sub cmdXoa_Click(sender As Object, e As EventArgs) Handles cmdXoa.Click
        If MsgBox("Bạn có muốn xóa sinh viên này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub
    Private Sub cmdDong_Click(sender As Object, e As EventArgs) Handles cmdDong.Click
        Me.Close()
    End Sub

    Private Sub Insert()
        If cbGioiTinh.SelectedItem = "Nam" Then
            gt = "Nam"
        ElseIf cbGioiTinh.SelectedItem = "Nữ" Then
            gt = "Nữ"
        Else
            MsgBox("Vui lòng chọn giới tính cho sinh viên")
        End If
        Dim insert As String = "INSERT INTO tblSINH_VIEN  values (N'" & txtMaSV.Text & "',N'" & txtHoTen.Text & "', N'" & txtNgaySinh.Text & "', N'" & gt & "', N'" & txtNoiSinh.Text & "' , N'" & txtMaLop.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("Lưu không thành công")
        End Try
    End Sub
    Private Sub Updatee()
        If cbGioiTinh.SelectedItem = "Nam" Then
            gt = "Nam"
        ElseIf cbGioiTinh.SelectedItem = "Nữ" Then
            gt = "Nữ"
        End If
        Dim Update As String = "UPDATE  tblSINH_VIEN SET HoTen =N'" & txtHoTen.Text & "',NgaySinh =N'" & txtNgaySinh.Text & "',GioiTinh =N'" & gt & "',DiaChi =N'" & txtNoiSinh.Text & "',MaLop =N'" & txtMaLop.Text & "' where  MaSv =N'" & txtMaSV.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblSINH_VIEN WHERE MaSv=N'" & txtMaSV.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Lỗi!.Hãy xóa điểm của sinh viên này trước")
        End Try
    End Sub
    Private Sub ShowData()
        dgvSinhVien.DataSource = kn.getdata(sql1, table1)
    End Sub

    Private Sub dgvSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSinhVien.CellClick
        Dim i As Integer
        i = dgvSinhVien.CurrentRow.Index
        txtMaSV.Text = dgvSinhVien.Item(0, i).Value
        txtHoTen.Text = dgvSinhVien.Item(1, i).Value
        txtNgaySinh.Text = dgvSinhVien.Item(2, i).Value
        cbGioiTinh.Text = dgvSinhVien.Item(3, i).Value
        txtNoiSinh.Text = dgvSinhVien.Item(4, i).Value
        txtMaLop.Text = dgvSinhVien.Item(5, i).Value
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs)
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
    End Sub
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Tim()
        If txtTmsv.Text = "" Then
            Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
            Call ShowData()
        End If
    End Sub

    Private Sub txtTmsv_Click(sender As Object, e As EventArgs) Handles txtTmsv.Click
        txtTmsv.Text = ""
        If txtTmsv.Text = "" Then
            Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
            Call ShowData()
        End If
    End Sub
    Private Sub Tim()
        Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
        Dim sql2 As String = "select * from tblSINH_VIEN where MASV ='" & txtTmsv.Text & "'"
        dgvSinhVien.DataSource = kn.getdata(sql2, table1)
    End Sub

    Private Sub txtTmsv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTmsv.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            Call Tim()
            If txtTmsv.Text = "" Then
                Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
                Call ShowData()
            End If
        End If
    End Sub
End Class