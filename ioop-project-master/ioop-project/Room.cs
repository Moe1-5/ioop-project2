using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ioop_project
{
    internal class Room
    {
        private int roomNumber;
        private int price;
        private string roomType;
        private string aminities;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCs"].ToString());
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public int Price { get => price; set => price = value; }
        public string RoomType{ get => roomType; set => roomType = value; }
        public string Aminities { get => aminities; set => aminities = value; }

        public Room (int roomNumber, int price, string roomType, string aminities)
        {
            this.roomNumber = roomNumber;
            this.price = price;
            this.roomType = roomType;
            this.aminities = aminities;
        }

        public string AddRoom()
        {
            string message = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO roomInfo(room number , price, room type, aminities) VALUES(@rn, @p, @rt @a)", con);
            cmd.Parameters.AddWithValue("@rn", roomNumber);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@rt", roomType);
            cmd.Parameters.AddWithValue("@a", aminities);
            con.Close();

            return "";


        }
        public string EditRoom()
        {
            string message = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO roomInfo(room number , price, room type, aminities) VALUES(@rn, @p, @rt @a)", con);
            cmd.Parameters.AddWithValue("@rn", roomNumber);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@rt", roomType);
            cmd.Parameters.AddWithValue("@a", aminities);
            con.Close();

            return "";


        }
        public string DeleteRoom()
        {
            string message = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO roomInfo(room number , price, room type, aminities) VALUES(@rn, @p, @rt @a)", con);
            cmd.Parameters.AddWithValue("@rn", roomNumber);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@rt", roomType);
            cmd.Parameters.AddWithValue("@a", aminities);
            con.Close();

            return "";

        }


    }

}
