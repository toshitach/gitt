using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BOL;
using System.Data;

namespace DAL
{
    public class StudentDal
    {
        public static List<Student> GetAll()
        {
            List<Student> stud = new List<Student>();
            //connection string

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patil\source\repos\MVCcrud\crudfrontend\App_Data\bandu.mdf;Integrated Security=True";
            IDbConnection con = new SqlConnection(conString);
            string query = "select * from Bandya";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);
            try
            {
                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int rollNo = int.Parse(reader["rollno"].ToString());
                    string name = reader["name"].ToString();
                    int age = int.Parse(reader["age"].ToString());

                    stud.Add(new Student() {RollNo=rollNo,Name=name,Age=age });
                    
                }
                reader.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return stud;
        }
    }
}
