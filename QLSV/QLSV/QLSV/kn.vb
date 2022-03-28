Imports System.Data.OleDb

Public Class kn
    Dim cnn As String = "Provider=SQLNCLI11;Data Source=DESKTOP-7UPT4UJ\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Quanlydiem"
    Dim ketnoi As New OleDbConnection(cnn)
    Dim dt As New DataSet
    Public Sub kn()
        'Tạo chuỗi két nối
        Try
            ketnoi.ConnectionString = cnn
            ketnoi.Open() 'mở kết nối
        Catch ex As Exception
            'MsgBox("Lỗi: " & ex.Message)
        End Try

    End Sub
    Public Function getdata(ByVal sql1 As String, ByVal table As String) As DataTable
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql1, cnn)
        da.Fill(dt, table)

        Return dt.Tables(table)
    End Function
End Class
