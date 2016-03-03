Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS02946GD1.mssql.somee.com;packet size=4096;user id=PS02946_SQLLogin_1;pwd=3wyobz71j2;data source=PS02946GD1.mssql.somee.com;persist security info=False;initial catalog=PS02946GD1"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHAChHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS02946GD1.mssql.somee.com;packet size=4096;user id=PS02946_SQLLogin_1;pwd=3wyobz71j2;data source=PS02946GD1.mssql.somee.com;persist security info=False;initial catalog=PS02946GD1"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select loaiSANPHAM.MASP as 'Mã sản phẩm',loaiSANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',loaiSANPHAM.SOLUONG as 'Số lượng' from loaiSANPHAM ", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
