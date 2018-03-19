using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Connection
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        public SqlConnection open()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-9ON6P7E;Initial Catalog=QLKSDatabase;Integrated Security=True");
            conn.Open();
            return conn;
        }
        public void close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public DataTable executeQuery(String sql)
        {
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public Boolean insertQuery(String sql)
        {
            cmd = new SqlCommand(sql, conn);


            int row = cmd.ExecuteNonQuery();

            return row == 1 ? true : false;

        }
        public DataTable executeQuery(String sql, SqlParameter[] parameters)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public bool executeUpdate(String sql, SqlParameter[] parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(parameters);
                int row = cmd.ExecuteNonQuery();

                return (row == 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erorr: " + e.Message);
                throw e;
            }
        }
        public Boolean executeDelete(String sql)
        {
            cmd = new SqlCommand(sql, conn);


            int row = cmd.ExecuteNonQuery();

            return row == 1 ? true : false;
        }
    }
}
