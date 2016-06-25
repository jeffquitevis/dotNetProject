using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormFileStore.Model;
using System.Data;

namespace FormFileStore
{
    class DataStoreDatabase : IDataStore
    {

        private string connectionString = @"Data Source=JEFFSTEPHEN\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public DataStoreDatabase()
        {
            
        }

        public void AddPerson(Person person)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                ;
                SqlDataAdapter insert = new SqlDataAdapter();
                insert.InsertCommand = new SqlCommand("Insert into Person (PersonId,FirstName,LastName) Values (@Id,@Fname,@Lname)",connection);
                insert.InsertCommand.Parameters.AddWithValue("@Id",person.Id);
                insert.InsertCommand.Parameters.AddWithValue("@Fname", person.FirstName);
                insert.InsertCommand.Parameters.AddWithValue("@Lname", person.LastName);
                insert.InsertCommand.ExecuteNonQuery();

            }
       
        }

        public Person SearchPerson(long id)
        {
            Person tempPerson = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

              
               
                connection.Open();               
                SqlDataAdapter select = new SqlDataAdapter();
                select.SelectCommand = new SqlCommand("Select * from Person WHERE PersonID = @Id",connection);
                select.SelectCommand.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = select.SelectCommand.ExecuteReader();
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         tempPerson = new Person((long) Convert.ToUInt64(reader["PersonID"].ToString()),reader["FirstName"].ToString(),reader["LastName"].ToString());
                    }
                   
                }
                
                reader.Close();

            }

            return tempPerson;
        }

        public void DeletePerson(long id)
        {
          
        }
    }
}
