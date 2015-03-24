using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EducationInstitute.PublicClasses
{
    class DeleteData
    {
        public void DeleteDetails(String storedProcedure, SqlConnection sqlConnection, String stringValue, String parameter)
        {
            SqlCommand command = new SqlCommand(storedProcedure, sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(stringValue, parameter);
            command.ExecuteNonQuery();
        }
    }
}
