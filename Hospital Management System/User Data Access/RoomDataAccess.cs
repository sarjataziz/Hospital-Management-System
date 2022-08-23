using Hospital_Management_System.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hospital_Management_System.User_Data_Access
{
    internal class RoomDataAccess : DataAccess
    {
        public List<Room> GetRoomsDetails()
        {
            try
            {
                string sql = "select * from Room";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Room> rooms = new List<Room>();

                while (sqlDataReader.Read())
                {
                    Room room = new Room();

                    room.Room_ID = (int)sqlDataReader["room_id"];
                    room.Room_No = (int)sqlDataReader["room_no"];
                    room.Room_Type = sqlDataReader["room_type"].ToString();
                    room.Room_Cost = (int)sqlDataReader["room_cost"];
                    room.Patient_ID = (int)sqlDataReader["fk_p_id"];

                    rooms.Add(room);
                }
                return rooms;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool AddRoomDetails(Room roomID)
        {
            try
            {
                string sql = "insert into Room (room_no, room_type, room_cost, fk_p_id) values (@room_no, @room_type, @room_cost, @fk_p_id)";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@room_no", roomID.Room_No);
                sqlCommand.Parameters.AddWithValue("@room_type", roomID.Room_Type);
                sqlCommand.Parameters.AddWithValue("@room_cost", roomID.Room_Cost);
                sqlCommand.Parameters.AddWithValue("@fk_p_id", roomID.Patient_ID);

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRoomDetails(int Room_ID)
        {
            try
            {
                string sql = "delete from Room where room_id = " + Room_ID;

                int result = this.ExecuteQuery(sql);

                if (result > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
        }

        public Room GetRoomByID(int roomID)
        {
            try
            {
                string sql = "select * from Room where room_id = " + roomID;

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Room room = new Room();

                    room.Room_ID = (int)sqlDataReader["room_id"];
                    room.Room_No = (int)sqlDataReader["room_no"];
                    room.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    room.Room_Cost = (int)sqlDataReader["room_cost"];
                    room.Room_Type = sqlDataReader["room_type"].ToString();

                    return room;
                }

                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public List<Room> GetRoomInSearch(string search)
        {
            try
            {
                List<Room> rooms = new List<Room>();

                string sql = "select * from Room where room_id like '" + search + "%' or room_no like '" + search + "%' or room_type like '" + search + "%'";

                SqlDataReader sqlDataReader = this.GetData(sql);

                while (sqlDataReader.Read())
                {
                    Room room = new Room();

                    room.Room_ID = (int)sqlDataReader["room_id"];
                    room.Room_No = (int)sqlDataReader["room_no"];
                    room.Patient_ID = (int)sqlDataReader["fk_p_id"];
                    room.Room_Cost = (int)sqlDataReader["room_cost"];
                    room.Room_Type = sqlDataReader["room_type"].ToString();

                    rooms.Add(room);
                }

                return rooms;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public bool GetRoomUpdate(Room roomID)
        {
            try
            {
                string sql = "update Room set room_no = @room_no, room_type = @room_type, room_cost = @room_cost, fk_p_id = @fk_p_id where room_id = @room_id";

                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@room_no", roomID.Room_No);
                sqlCommand.Parameters.AddWithValue("@room_type", roomID.Room_Type);
                sqlCommand.Parameters.AddWithValue("@room_cost", roomID.Room_Cost);
                sqlCommand.Parameters.AddWithValue("@fk_p_id", roomID.Patient_ID);
                sqlCommand.Parameters.AddWithValue("@room_id", roomID.Room_ID);

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
        }

        public List<Room> GetRoomDetails()
        {
            try
            {
                string sql = "select room_id, room_no, room_type, room_cost from Room";

                SqlDataReader sqlDataReader = this.GetData(sql);

                List<Room> rooms = new List<Room>();

                while (sqlDataReader.Read())
                {
                    Room room = new Room();

                    room.Room_ID = (int)sqlDataReader["room_id"];
                    room.Room_No = (int)sqlDataReader["room_no"];
                    room.Room_Type = sqlDataReader["room_type"].ToString();
                    room.Room_Cost = (int)sqlDataReader["room_cost"];

                    rooms.Add(room);
                }
                return rooms;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
