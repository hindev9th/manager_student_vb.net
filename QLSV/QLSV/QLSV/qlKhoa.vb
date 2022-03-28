Public Class qlKhoa
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblKHOA"
    Dim table1 As String = "tblKHOA"
    Private Sub qlKhoa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ShowData()
        cmdLuu.Enabled = False
    End Sub

    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        txtMaKhoa.Text = ""
        txtTenKhoa.Text = ""
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
            Call updatee()
        End If
        Call CType(dgvDanhSachKhoa.DataSource, DataTable).Rows.Clear()
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
        If MsgBox("Bạn có muốn xóa Khoa này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvDanhSachKhoa.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdDong_Click(sender As Object, e As EventArgs) Handles cmdDong.Click
        Me.Close()
    End Sub

    Private Sub Insert()
        Dim insert As String = "INSERT INTO tblKHOA  values ('" & txtMaKhoa.Text & "',N'" & txtTenKhoa.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("Lưu không thành công")
        End Try
    End Sub
    Private Sub updatee()
        Dim Update As String = "UPDATE  tblKHOA SET TenKhoa =N'" & txtTenKhoa.Text & "' where  MaKhoa ='" & txtMaKhoa.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblKHOA WHERE MaKhoa ='" & txtMaKhoa.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub ShowData()
        dgvDanhSachKhoa.DataSource = kn.getdata(sql1, table1)
    End Sub
    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKhoa.CellClick
        Dim i As Integer
        i = dgvDanhSachKhoa.CurrentRow.Index
        txtMaKhoa.Text = dgvDanhSachKhoa.Item(0, i).Value
        txtTenKhoa.Text = dgvDanhSachKhoa.Item(1, i).Value
        Call lop()
        Call CType(dgvLop.DataSource, DataTable).Rows.Clear()
        Call lop()
    End Sub
    Private Sub lop()
        Dim sql2 As String = "select * from tblLOP Where MaKhoa ='" & txtMaKhoa.Text & "'"
        Dim table2 As String = "tblLOP"
        dgvLop.DataSource = kn.getdata(sql2, table2)
    End Sub
End Class