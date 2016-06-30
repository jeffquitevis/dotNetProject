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


        public void AddPerson(Person person)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlDataAdapter insert = new SqlDataAdapter();
                insert.InsertCommand = new SqlCommand(@"INSERT INTO Person (PersonId,FirstName,LastName) VALUES (@Id,@Fname,@Lname)",connection);            
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
                using (SqlDataAdapter select = new SqlDataAdapter())
                {
                    select.SelectCommand = new SqlCommand(@"SELECT * from Person WHERE PersonID = @Id", connection);
                    select.SelectCommand.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = select.SelectCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tempPerson = new Person((long)Convert.ToUInt64(reader["PersonID"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString());
                            }

                        }
                    }
              
                }          

            }

            return tempPerson;
        }

        public void DeletePerson(long id)
        {
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlDataAdapter delete = new SqlDataAdapter())
                {
                    delete.DeleteCommand = new SqlCommand(@"DELETE  from Person WHERE PersonID = @Id", connection);
                    delete.DeleteCommand.Parameters.AddWithValue("@Id", id);
                    delete.DeleteCommand.ExecuteReader();
                }            

            }

        }

        public HashSet<Person> GetAll()
        {
            HashSet<Person> tempSet = new HashSet<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                using (SqlDataAdapter selectAll = new SqlDataAdapter())
                {
                    selectAll.SelectCommand = new SqlCommand("SELECT * FROM Person",connection);

                    using (SqlDataReader reader = selectAll.SelectCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tempSet.Add(new Person((long)Convert.ToUInt64(reader["PersonID"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString()));
                            }

                        }
                    }              
                      
                }
            }

            return tempSet;

        }
    }
}
