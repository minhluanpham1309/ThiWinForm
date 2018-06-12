using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    public class Cl_Databas : IDisposable
    {
        string ConnectionString = "Server=TAKEDA_PHAM; database=ThiASP; integrate sercurity=true";
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void Dispose()
        {
            if(cnn!=null)
                cnn.Dispose();
            if (cmd != null)
                cmd.Dispose();
            if (da != null)
                da.Dispose();
        }
        public Cl_Databas()
        {
            cnn = new SqlConnection(ConnectionString);
        }
        public DataTable GetDatatable(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandTimeout = 600;
                cmd.CommandType = type;
                cmd.Parameters.Clear();
                foreach (var pa in param)
                {
                    cmd.Parameters.Add(pa);
                }
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        public bool ExNonQuery(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandTimeout = 600;
                cmd.CommandType = type;
                cmd.Parameters.Clear();
                foreach (var pa in param)
                {
                    cmd.Parameters.Add(pa);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
    }
}
