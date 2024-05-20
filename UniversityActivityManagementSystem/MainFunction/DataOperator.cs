using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityActivityManagementSystem
{
    class DataOperator
    {
        private static string connString = "Data Source=47.115.202.144;Database=db_UAMS;UID=sa;Pwd=021014_yyf;";
        public static SqlConnection connection = new SqlConnection(connString);

        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int num = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return num; //返回结果中的第一行第一列
        }

        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result; //返回受影响的行数
        }

        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }
    }
}
