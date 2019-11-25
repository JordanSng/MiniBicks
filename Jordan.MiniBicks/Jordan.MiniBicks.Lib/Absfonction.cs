using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Jordan.MiniBicks.Data;
using Jordan.MiniBicks.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Jordan.MiniBicks.Lib
{
    public class AbsFonction
    {
        public DataTable ListAbsences()
        {
            using (var bicksContext = new BicksContext())
            {
                var connectionString = bicksContext.Database.GetDbConnection().ConnectionString;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Absences",connectionString);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
