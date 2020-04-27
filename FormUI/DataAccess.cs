using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FormUI.Properties.Settings.DatabaseConnectionString")))
            {
                var output = connection.Query<Person>( $"select * from People where LastName = '{ lastName }'").ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber,string cnp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FormUI.Properties.Settings.DatabaseConnectionString")))
            {
                //Person newPerson = new Person {FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber,CNP=cnp });

                connection.Execute("dbo.Procedure_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber,@cnp", people);

            }
        }

        public List<Person> DeletePerson(string cnp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FormUI.Properties.Settings.DatabaseConnectionString")))
            {
                //Person newPerson = new Person {CNP=cnp,FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();
                people=connection.Query<Person>($"select * from People where CNP = '{ cnp }'").ToList();
                connection.Execute("dbo.Procedure_Remove @cnp", people);
                return people;

            }
        }
        public List<Person> UpdatePerson(string cnp, string lastName, string firstName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FormUI.Properties.Settings.DatabaseConnectionString")))
            {

                Person newPerson = new Person { CNP = cnp, FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();
                people = connection.Query<Person>($"select * from People where CNP='{cnp}'").ToList();

                foreach (Person i in people)
                {
                    i.LastName = lastName;
                    i.FirstName = firstName;
                    i.EmailAddress = emailAddress;
                    i.PhoneNumber = phoneNumber;
                }
                connection.Execute("dbo.Procedure_Update2  @cnp,@lastName,@firstName, @emailAddress, @phoneNumber", people);

                return people;
       
            
                   
 
            


            }
        }

    }
}
