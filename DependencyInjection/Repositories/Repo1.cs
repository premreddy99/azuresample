using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Microsoft.Data.SqlClient;
namespace Repositories
{
    public class Repo1: IRepo
    {
        private readonly IDbConnection _connection;
        public Repo1(IDbConnection connection) { 
            _connection = connection; 
        }

        public async Task<List<Student>> getAll()
        {
            List<Student> students = new List<Student>();

            _connection.Open();

            string query = "SELECT * FROM student";

            SqlCommand cmd = new SqlCommand(query, (SqlConnection)_connection);
            using (SqlDataReader reader =await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    Student student = new Student()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = Convert.ToString(reader["name"]),
                        email = Convert.ToString(reader["email"])
                    };
                    students.Add(student);
                }
            }
            return students;
        }
    }
}
