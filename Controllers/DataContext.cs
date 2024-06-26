﻿using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace WebApplication3.Controllers
{
    //Class dùng để chạy mấy cái procedure trên SQLServer
    public class DataContext
    {
        private SqlConnection _connection;

        public DataContext()
        {
            _connection = new SqlConnection("Data Source=.;Initial Catalog=QLATTP;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public int insertGiayChungNhan_CoSo(string tencoso, string diachi, string loaihinh, string giayphepkd, DateOnly ngaycap, string loaithucpham, string hinhanh)
        {
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = " execute insertGiayChungNhan_CoSo null,@ten,@diachi,@loaihinh,@giayphep,@ngaycap,@loaithucpham,@hinhanh"; //null la IdChuCoSo
            
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar);
            cmd.Parameters["@ten"].Value = tencoso;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            cmd.Parameters["@diachi"].Value = diachi;
            cmd.Parameters.Add("@loaihinh", SqlDbType.NVarChar);
            cmd.Parameters["@loaihinh"].Value = loaihinh;
            cmd.Parameters.Add("@giayphep", SqlDbType.VarChar);
            cmd.Parameters["@giayphep"].Value = giayphepkd;
            cmd.Parameters.Add("@ngaycap", SqlDbType.Date);
            cmd.Parameters["@ngaycap"].Value = ngaycap;
            cmd.Parameters.Add("@loaithucpham", SqlDbType.NVarChar);
            cmd.Parameters["@loaithucpham"].Value = loaithucpham;
            cmd.Parameters.Add("@hinhanh", SqlDbType.VarChar);
            cmd.Parameters["@hinhanh"].Value = hinhanh;
            _connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int result = (int) dataReader.GetInt64(0);
            _connection.Close();
            return result;
        }
    }
}
