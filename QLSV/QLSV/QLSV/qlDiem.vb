Public Class qlDiem
    Dim n As Integer
    Dim kn As New kn()
    Dim sql1 As String = "select * from tblKET_QUA"
    Dim table1 As String = "tblKET_QUA"
    Private Sub qlDiem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ShowData()
        cmdLuu.Enabled = False
    End Sub

    Private Sub cmdThem_Click(sender As Object, e As EventArgs) Handles cmdThem.Click
        cmdLuu.Enabled = True
        cmdThem.Enabled = False
        cmdSua.Enabled = False
        cmdXoa.Enabled = False
        GroupBox1.Visible = True
        txtMaSV.Focus()
        txtMaSV.Text = ""
        txtHoTen.Text = ""
        txtMaMH.Text = ""
        txtDiem.Text = ""
        txtDiemThi.Text = ""
        txtDiemTK.Text = ""
        txtHanhKiem.Text = ""
        txtHocKi.Text = ""
        n = 1
    End Sub

    Private Sub cmdLuu_Click(sender As Object, e As EventArgs) Handles cmdLuu.Click
        If Val(txtDiem.Text) < 0 Or Val(txtDiem.Text) > 10 And Val(txtDiemThi.Text) < 0 Or Val(txtDiemThi.Text) > 10 And Val(txtDiemTK.Text) < 0 Or Val(txtDiemTK.Text) > 10 Then
            MsgBox("Điểm của sinh viên chỉ đc 0 đến 10 vui lòng kiểm tra lại!", MsgBoxStyle.Information, "Thông báo")
        Else
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
            Call CType(dgvSinhVien.DataSource, DataTable).Rows.Clear()
            Call ShowData()
        End If
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
        If Val(txtDiem.Text) And Val(txtDiemThi.Text) And Val(txtDiemTK.Text) >= 0 Or Val(txtDiem.Text) And Val(txtDiemThi.Text) And Val(txtDiemTK.Text) <= 10 Then
            Dim insert As String = "INSERT INTO tblKET_QUA  values ('" & txtMaSV.Text & "',N'" & txtHoTen.Text & "','" & txtMalop.Text & "','" & txtMaMH.Text & "','" & txtDiem.Text & "','" & txtDiemThi.Text & "','" & txtDiemTK.Text & "',N'" & txtHanhKiem.Text & "','" & txtHocKi.Text & "')"
            Try
                kn.getdata(insert, table1)
                MessageBox.Show("Lưu thành công")
            Catch ex As Exception
                MessageBox.Show("Không tìm thấy sinh viên này!")
            End Try
        Else
            MsgBox("Điểm của sinh viên chỉ được phép >=0 và <=10!", vbOK, "Thông báo")
        End If

    End Sub
    Private Sub Updatee()
        If Val(txtDiem.Text) And Val(txtDiemThi.Text) And Val(txtDiemTK.Text) >= 0 Or Val(txtDiem.Text) And Val(txtDiemThi.Text) And Val(txtDiemTK.Text) <= 10 Then
            Dim Update As String = "UPDATE tblKET_QUA SET HoTen =N'" & txtHoTen.Text & "',MaLop ='" & txtMalop.Text & "',MaMon ='" & txtMaMH.Text & "',DiemTB ='" & txtDiem.Text & "',DiemThi ='" & txtDiemThi.Text & "',DiemTongKet ='" & txtDiemTK.Text & "',HanhKiem =N'" & txtHanhKiem.Text & "',HocKi ='" & txtHocKi.Text & "' where  MaSV ='" & txtMaSV.Text & "'"
            Try
                kn.getdata(Update, table1)
                MessageBox.Show("Sửa Thanh Cong")
            Catch ex As Exception
                MessageBox.Show("Loi")
            End Try
        Else
            MsgBox("Điểm của sinh viên chỉ được phép >=0 và <=10!", vbOK, "Thông báo")
        End If
    End Sub
    Private Sub Delete()
        Dim delete As String = "DELETE from tblKET_QUA WHERE MaSV='" & txtMaSV.Text & "'"
        Try
            kn.getdata(delete, table1)
            MessageBox.Show("Xoa Thanh Cong")
        Catch ex As Exception
            MessageBox.Show("Loi")
        End Try
    End Sub

    Private Sub dgvSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSinhVien.CellClick
        Dim i As Integer
        i = dgvSinhVien.CurrentRow.Index
        txtMaSV.Text = dgvSinhVien.Item(0, i).Value
        txtHoTen.Text = dgvSinhVien.Item(1, i).Value
        txtMalop.Text = dgvSinhVien.Item(2, i).Value
        txtMaMH.Text = dgvSinhVien.Item(3, i).Value
        txtDiem.Text = dgvSinhVien.Item(4, i).Value
        txtDiemThi.Text = dgvSinhVien.Item(5, i).Value
        txtDiemTK.Text = dgvSinhVien.Item(5, i).Value
        txtHanhKiem.Text = dgvSinhVien.Item(7, i).Value
        txtHocKi.Text = dgvSinhVien.Item(8, i).Value
    End Sub
    Private Sub ShowData()
        dgvSinhVien.DataSource = kn.getdata(sql1, table1)
    End Sub

    Private Sub txtDiemTK_Click(sender As Object, e As EventArgs) Handles txtDiemTK.Click
        txtDiemTK.Text = (Val(txtDiem.Text) + Val(txtDiemThi.Text)) / 2
    End Sub

    Private Sub txtHanhKiem_Click(sender As Object, e As EventArgs) Handles txtHanhKiem.Click
        If Val(txtDiemTK.Text) >= 8 Then
            txtHanhKiem.Text = "Giỏi"
        ElseIf Val(txtDiemTK.Text) >= 7 Then
            txtHanhKiem.Text = "Khá"
        ElseIf Val(txtDiemTK.Text) >= 5 Then
            txtHanhKiem.Text = "Trung bình"
        ElseIf Val(txtDiemTK.Text) >= 3 Then
            txtHanhKiem.Text = "Kém"
        Else
            txtHanhKiem.Text = "Yếu kém"
        End If
    End Sub
End Class