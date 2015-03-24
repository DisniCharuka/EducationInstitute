using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EducationInstitute.PublicClasses
{
    class PopulateData
    {
        public DataTable PopulateDetails(string stordProcedure, SqlConnection sqlConnection, SqlDataReader rs)
        {
            SqlCommand command = new SqlCommand(stordProcedure, sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            rs.Close();
            return dt;
        }
    }
}
