Public Class qlMonHoc
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblMON"
    Dim table1 As String = "tblMON"

    Private Sub qlMonHoc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ShowData()
        cmdLuu.Enabled = False
    End Sub

    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        txtMaMH.Text = ""
        txtTenMH.Text = ""
        txtSoTin.Text = ""
        txtHocKi.Text = ""
        txtMaGV.Text = ""
        txtMaKhoa.Text = ""
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
        Call CType(dgvDanhSachmh.DataSource, DataTable).Rows.Clear()
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
        If MsgBox("Bạn có muốn xóa Môn Học này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvDanhSachmh.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdDong_Click(sender As Object, e As EventArgs) Handles cmdDong.Click
        Me.Close()
    End Sub

    Private Sub Insert()
        Dim insert As String = "INSERT INTO tblMON  values (N'" & txtMaMH.Text & "',N'" & txtTenMH.Text & "',N'" & txtSoTin.Text & "',N'" & txtMaGV.Text & "',N'" & txtHocKi.Text & "',N'" & txtMaKhoa.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("Lưu không thành công")
        End Try
    End Sub
    Private Sub Updatee()

        Dim Update As String = "UPDATE  tblMON SET TenMon =N'" & txtTenMH.Text & "',SoTin =N'" & txtSoTin.Text & "',MaGV =N'" & txtMaGV.Text & "',HocKi =N'" & txtHocKi.Text & "',MaKhoa =N'" & txtMaKhoa.Text & "' where  MaMon ='" & txtMaMH.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblMON WHERE MaMon='" & txtMaMH.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachmh.CellClick
        Dim i As Integer
        i = dgvDanhSachmh.CurrentRow.Index
        txtMaMH.Text = dgvDanhSachmh.Item(0, i).Value
        txtTenMH.Text = dgvDanhSachmh.Item(1, i).Value
        txtSoTin.Text = dgvDanhSachmh.Item(2, i).Value
        txtMaGV.Text = dgvDanhSachmh.Item(3, i).Value
        txtHocKi.Text = dgvDanhSachmh.Item(4, i).Value
        txtMaKhoa.Text = dgvDanhSachmh.Item(5, i).Value
        Call ketqua()
        Call CType(dgvDiem.DataSource, DataTable).Rows.Clear()
        Call ketqua()
    End Sub
    Private Sub ShowData()
        dgvDanhSachmh.DataSource = kn.getdata(sql1, table1)
    End Sub
    Private Sub ketqua()
        Dim sql2 As String = "select * from tblKET_QUA where MaMon ='" & txtMaMH.Text & "'"
        Dim table2 As String = "tblKET_QUA"

        dgvDiem.DataSource = kn.getdata(sql2, table2)
    End Sub
End Class