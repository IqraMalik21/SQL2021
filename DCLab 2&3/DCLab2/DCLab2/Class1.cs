using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;



namespace DCLab2
{
    class DataFunctions
    {
        public DataTable getData(string SQL)
        {
            DataTable DT = new DataTable();
            string conStr = "Data Source=DESKTOP-9FMS3P9\\MSSQLSERVER01;Initial Catalog=DCNewDatabase1;Integrated Security=True";
            SqlConnection ConObj = new SqlConnection(conStr);
            ConObj.Open();
            SqlDataAdapter da = new SqlDataAdapter(SQL, ConObj);
            da.Fill(DT);
            ConObj.Close();
            return DT;
        }

        public DataTable Manipulation(string SQL)
        {
            DataTable DT = new DataTable();
            string conStr = "Data Source=DESKTOP-9FMS3P9\\MSSQLSERVER01;Initial Catalog=DCNewDatabase1;Integrated Security=True";
            SqlConnection ConObj = new SqlConnection(conStr);
            ConObj.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = ConObj;
            com.CommandText = SQL;
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student;", ConObj);
            da.Fill(DT);
            ConObj.Close();
            return DT;

        }
        public bool InsertData(string SQL_Insert)
        {
            string conStr = "Data Source = DESKTOP - 9FMS3P9\\MSSQLSERVER01; Initial Catalog = DCNewDatabase1; Integrated Security = True";
            SqlConnection ConObj = new SqlConnection(conStr);
            ConObj.Open();
            SqlCommand cmd = new SqlCommand(SQL_Insert, ConObj);
            int rowsAffected = 0;
            rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;

            }
            else return false;
        }

    }
}