using CryptSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    internal class WeddingClient
    {
        internal static List<DishesData> listDishes = new List<DishesData>();
        internal static List<ServicesData> listServices = new List<ServicesData>();
        internal static List<ShiftData> listShifts = new List<ShiftData>();
        internal static List<LobbyTypeData> listLobbyTypes = new List<LobbyTypeData>();
        internal static List<LobbyData> listLobbies = new List<LobbyData>();
        
        internal static Random rand = new Random();

    //    internal static string sqlConnectionString = ConfigurationManager.AppSettings.Get("An");

        internal static string sqlConnectionString = ConfigurationManager.AppSettings.Get("conString");

        public static string client_id;
        public static short client_priority;
        public static bool Logged_in(string tk, string mk)
        {
            string commandtext = "select top 1 Id, Pw, Priority from ACCOUNT where Username=@username";
            using (SqlConnection sql = new SqlConnection(sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand command = new SqlCommand(commandtext, sql))
                {
                    command.Parameters.AddWithValue("@username", tk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("After avatar");
                        if (reader.Read())
                        {
                            //if (act.pw == reader["pw"].ToString())
                            if (mk == reader["pw"].ToString() || Crypter.CheckPassword(mk, reader["pw"].ToString()))
                            {
                                bool skip = false;
                                if (mk == reader["pw"].ToString())
                                {
                                    using (SqlCommand changepass = new SqlCommand("update top (1) ACCOUNT set Pw = @pw where Id = @id", sql))
                                    {
                                        changepass.Parameters.AddWithValue("@pw", Crypter.Blowfish.Crypt(mk));
                                        changepass.Parameters.AddWithValue("@id", reader["id"].ToString());
                                        reader.Close();
                                        changepass.ExecuteNonQuery();
                                        skip = true;
                                        return false;
                                    }
                                }
                                if (!skip)
                                {
                                    string id = reader["id"].ToString();
                                    string str_id = id;
                                    while (id.Length < 19) id = '0' + id;
                                    client_id = id;
                                    client_priority = (short)reader["priority"];
                                    return true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong password");
                                return false;
                            } // wrong password

                        }
                        else
                        {
                            MessageBox.Show("Wrong username");
                            return false;
                        } // wrong username
                    } 
                }
                MessageBox.Show("Cannot connect to Database");
                return false;
            }
        }
        internal static Int64 NextInt64(Random rand)
        {
            var buffer = new byte[sizeof(Int64)];
            rand.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        private static bool check_existed_username(string v)
        {
            string commandtext = "select top 1 Id from ACCOUNT where Username=@username";
            using (SqlConnection sql = new SqlConnection(sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand command = new SqlCommand(commandtext, sql))
                {
                    command.Parameters.AddWithValue("@username", v);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else return false;
                    }
                }
            }
        }

        internal static long GetNewACCOUNTSId()
        {
            Int64 randomid = 0;
            while (randomid <= 0 || check_existed_id(randomid))
            {
                randomid = NextInt64(rand);
            }
            return randomid;
        }

        internal static long GetNewIdFromTable(string tableKey)
        {
            if (tableKey.Length > 2) throw new Exception("Table key is too long");
            Int64 randomid = 0;
            while (randomid <= 0 || check_existed_id(randomid, tableKey))
            {
                randomid = NextInt64(rand);
            }
            return randomid;
        }

        private static bool check_existed_id(long randomid, string key)
        {
            if (randomid > 0)
            {
                switch (key)
                {
                    case "LT":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("LOBBY_TYPE", "IdLobbyType", idStr);
                        }
                    case "LO":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("LOBBY", "IdLobby", idStr);
                        }
                    case "SH":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("SHIFT", "IdShift", idStr);
                        }
                    case "WD":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("WEDDING_INFOR", "IdWedding", idStr);
                        }
                    case "MN":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("MENU", "IdDishes", idStr);
                        }
                    case "SV":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("SERVICE", "IdService", idStr);
                        }
                    case "BI":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("BILL", "IdBill", idStr);
                        }
                    case "RR":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("REVENUE_REPORT", "IdReport", idStr);
                        }
                    case "PA":
                        {
                            string idStr = key + randomid.ToString().PadLeft(19, '0');
                            return check_existed_id("PARAMETER", "IdParameter", idStr);
                        }
                    default:
                        throw new Exception("Unknown table key");
                }
            }
            else
            {
                return true;
            }
        }

        private static bool check_existed_id(string table, string idColumn, string key)
        {
            Console.WriteLine(key);
            Console.WriteLine(key.PadLeft(19, '0'));
            string commandtext = "select top 1 * from " + table + " where " + idColumn + "=@id";
            using (SqlConnection sql = new SqlConnection(sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand command = new SqlCommand(commandtext, sql))
                {
                    command.Parameters.AddWithValue("@id", key.PadLeft(19, '0'));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else return false;
                    }
                }
            }
        }

        private static bool check_existed_id(long randomid)
        {
            if (randomid > 0)
            {
                string commandtext = "select top 1 Id from ACCOUNT where Id=@id";
                using (SqlConnection sql = new SqlConnection(sqlConnectionString))
                {
                    sql.Open();
                    using (SqlCommand command = new SqlCommand(commandtext, sql))
                    {
                        command.Parameters.AddWithValue("@id", randomid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
