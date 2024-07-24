using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IdentityModel.Protocols.WSTrust;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace ioop_project
{
    internal class User
    {
        private string firstName;
        private string lastName;
        private int phone;
        private int id;
        private string email;
        private string password;
        private string username;


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public int ID { get => id; set => id = value; }

        public string First_Name { get => firstName; set => firstName = value; }
        public string Last_Name { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }

        public string Username { get => username; set => username = value; }

        public User (string firstName, string lastName, int phone, int id, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.id = id;
            this.email = email;
            this.password = password; // add it in the databaase.....
        }

        public User (string username)
        {
            this.username = username; 
        }

        public string SignUp ()
        {

            string warn = string.Empty;
            warn = string.IsNullOrWhiteSpace(firstName) ? "Please fill the firstname\n" : string.Empty;
            warn += string.IsNullOrWhiteSpace(lastName) ? "Please fill the lastname\n" : string.Empty;
            warn += string.IsNullOrWhiteSpace(email) ? "Please fill the email\n" : string.Empty;
            warn += string.IsNullOrWhiteSpace(password) ? "Please fill the password\n" : string.Empty;
            warn += phone == 0 ? "Please fill the phone number\n" : string.Empty;

            if (!string.IsNullOrEmpty(warn))
            {
                return warn.Trim(); // Trim to remove any trailing newline characters
            }

            string message;
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SignUp(firstName, lasttName, Email, Phone) VALUES(@fir, @las, @em, @ph) ", con);
                cmd.Parameters.AddWithValue("@fir", firstName);
                cmd.Parameters.AddWithValue("@las", lastName);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@ph", phone);
                int i = cmd.ExecuteNonQuery();
                message = i > 0 ? "Registeration Succesful" : "Unable To Success";
            }
            catch (Exception ex){
                message = "An error accurred :" + ex.Message;
            }

            con.Close();

            return message; 
        }

        public static void logIn(User user)
        {
            string message = string.Empty;
            user.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SignUp WHERE id =@identifier", user.con);
            cmd.Parameters.AddWithValue("@identifier", user.id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                int dbId = reader.GetInt32(0);
                string dbFirstName = reader.GetString(1);
                string dbLastName = reader.GetString(2);
                string dbPassword = reader.GetString(3);

                if (dbId == user.id && user.password == dbPassword && $"{dbFirstName}{dbLastName}" == user.username)
                {
                    //Form form = new Form();
                    //form.ShowDialog();
                    
                    
                }
                {

                }
                // write here the login process--
                // you should get the password and first&lastname as the username
            }
        }

}
