Public Class qlNguoidung
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblLOGIN"
    Dim table1 As String = "tblLOGIN"
    Private Sub frQLTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
        cmdLuu.Enabled = False
    End Sub
    Private Sub dgvLogin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogin.CellClick
        Dim i As Integer
        i = dgvLogin.CurrentRow.Index
        txtTenDN.Text = dgvLogin.Item(0, i).Value
        txtMatKhau.Text = dgvLogin.Item(1, i).Value
        txtHoTen.Text = dgvLogin.Item(2, i).Value
        txtGioiTinh.Text = dgvLogin.Item(3, i).Value
        txtPhone.Text = dgvLogin.Item(4, i).Value
    End Sub
    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox2.Visible = True
        txtTenDN.Focus()
        txtTenDN.Text = ""
        txtMatKhau.Text = ""
        n = 1
    End Sub

    Private Sub cmdLuu_Click(sender As Object, e As EventArgs) Handles cmdLuu.Click
        cmdThem.Enabled = True
        cmdLuu.Enabled = False
        cmdSua.Enabled = True
        cmdXoa.Enabled = True
        GroupBox2.Visible = False
        If n = 1 Then
            Call Insert()
        ElseIf n = 2 Then
            Call Updatee()
        End If
        Call CType(dgvLogin.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdSua_Click(sender As Object, e As EventArgs) Handles cmdSua.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox2.Visible = True
        n = 2
    End Sub

    Private Sub cmdXoa_Click(sender As Object, e As EventArgs) Handles cmdXoa.Click
        If MsgBox("Bạn có muốn xóa Người dùng này ?", vbOKCancel, "Thông báo") = vbOK Then
            Call Delete()
        End If
        Call CType(dgvLogin.DataSource, DataTable).Rows.Clear()
        Call ShowData()
    End Sub

    Private Sub cmdThoat_Click(sender As Object, e As EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub

    Private Sub ShowData()
        dgvLogin.DataSource = kn.getdata(sql1, table1)
    End Sub
    Private Sub Insert()
        Dim insert As String = "INSERT INTO tblLOGIN  values (N'" & txtTenDN.Text & "',N'" & txtMatKhau.Text & "',N'" & txtHoTen.Text & "',N'" & txtGioiTinh.Text & "','" & txtPhone.Text & "')"
        Try
            kn.getdata(insert, table1)
            MessageBox.Show("Lưu thành công")
        Catch ex As Exception
            MessageBox.Show("Lưu không thành công")
        End Try
    End Sub
    Private Sub Updatee()
        Dim Update As String = "UPDATE  tblLOGIN SET MatKhau =N'" & txtMatKhau.Text & "',HoTen =N'" & txtHoTen.Text & "',GioiTinh ='" & txtGioiTinh.Text & "',Phone ='" & txtPhone.Text & "' where  TenDN =N'" & txtTenDN.Text & "'"
        Try
            kn.getdata(Update, table1)
            MessageBox.Show("Sửa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblLOGIN WHERE TenDN =N'" & txtTenDN.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub
End Class