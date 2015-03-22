using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EducationInstitute.PublicClasses
{
    class DBConnection
    {
        public SqlConnection sqlConnection = null;

        public void DbConnectionMethod()
        {
            String connectionString = @"Data Source=DISNICHARUKA\DISNICHARUKA;Initial Catalog=EDU_INS_MGT_DB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
    }
}
