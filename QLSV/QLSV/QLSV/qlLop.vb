Public Class qlLop
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblLOP"
    Dim table1 As String = "tblLOP"
    Private Sub qlLOP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Showdata()
        cmdLuu.Enabled = False
    End Sub

    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        txtMaKhoa.Text = ""
        txtMaLop.Text = ""
        txtTenLop.Text = ""
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
        Call CType(dgvDanhSachLop.DataSource, DataTable).Rows.Clear()
        Call Showdata()
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
        If MsgBox("Bạn có muốn xóa Lớp này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvDanhSachLop.DataSource, DataTable).Rows.Clear()
        Call Showdata()
    End Sub

    Private Sub cmdDong_Click(sender As Object, e As EventArgs) Handles cmdDong.Click
        Me.Close()
    End Sub
    Private Sub Insert()
        Dim insert As String = "INSERT INTO tblLOP  values ('" & txtMaKhoa.Text & "','" & txtMaLop.Text & "',N'" & txtTenLop.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("Lưu không thành công")
        End Try
    End Sub
    Private Sub Updatee()
        Dim Update As String = "UPDATE  tblLOP SET MaKhoa ='" & txtMaKhoa.Text & "',TenLop =N'" & txtTenLop.Text & "' where  MaLop ='" & txtMaLop.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblLOP WHERE MaLop='" & txtMaLop.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Showdata()
        dgvDanhSachLop.DataSource = kn.getdata(sql1, table1)
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachLop.CellClick
        Dim i As Integer
        i = dgvDanhSachLop.CurrentRow.Index
        txtMaKhoa.Text = dgvDanhSachLop.Item(0, i).Value
        txtMaLop.Text = dgvDanhSachLop.Item(1, i).Value
        txtTenLop.Text = dgvDanhSachLop.Item(2, i).Value
        Call sinhvien()
        Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
        Call sinhvien()
    End Sub
    Private Sub sinhvien()
        Dim sql2 As String = "select * from tblSINH_VIEN where MaLop ='" & txtMaLop.Text & "'"
        Dim table2 As String = "tblSINH_VIEN"
        dgvSinhVien.DataSource = kn.getdata(sql2, table2)
    End Sub
End Class