using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Notice_Board
{
    public class UserInfo
    {
        public string currentUserID { get; set; }
        public string userId { get; set; }
        public string userPassword { get; set; }
        public string userName { get; set; }
        public string userBirth { get; set; }
        public string userGender { get; set; }
        public string userEmail { get; set; }
        public string userPhoneNumber { get; set; }

        private int checkMaster = 1;

        public int currentMaster { get; set; }

        private string connString = ConfigurationManager.ConnectionStrings["NoticeBoardDB"].ConnectionString;

        public DataSet GetCurrentUserInfo()
        {
            SqlParameter paramID = new SqlParameter("@currentUserID", currentUserID);
            string sql = $@"SELECT USER_ID AS [아이디], USER_PWD AS [비밀번호], USER_NAME AS [이름],
                                   BIRTHDAY AS [생년월일], GENDER AS [성별], EMAIL AS [이메일],
                                   PHONE AS [휴대폰 번호]
                                FROM dbo.User_Info WHERE USER_ID = '{this.currentUserID}'";
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            return ds;
        }

        public DataSet GetAllUserInfo()
        {
            string sql = "SELECT * FROM dbo.User_Info";
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            return ds;
        }

        public bool CheckDuplicationID(string idText)
        {
            string sql = "SELECT USER_ID FROM dbo.User_Info";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (idText == dr["USER_ID"].ToString())
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }

                dr.Close();
                return true;
            }
        }

        public void InsertDB(string id, string password, string name, string birth, string gender,
            string email, string phoneNumber)
        {
            string sql = $@"INSERT INTO dbo.User_Info (USER_ID, USER_PWD, USER_NAME, BIRTHDAY, GENDER, EMAIL, PHONE, ISMASTER)
                            VALUES ('{id}', '{password}', '{name}', '{birth}', '{gender}',
                            '{email}', '{phoneNumber}', {this.checkMaster})";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public bool Login(string idText, string pwdText)
        {
            string sql = "SELECT USER_ID, USER_PWD FROM dbo.User_Info";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (idText == dr["USER_ID"].ToString() && pwdText == dr["USER_PWD"].ToString())
                    {
                        currentUserID = idText;
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }

                dr.Close();
                return false;
            }
        }

        public string SearchUserInfo(string nameText, string emailText)
        {
            string sql = "SELECT USER_ID, USER_NAME, EMAIL FROM dbo.User_Info";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (nameText == dr["USER_NAME"].ToString() && emailText == dr["EMAIL"].ToString())
                    {
                        return dr["USER_ID"].ToString();
                    }
                    else
                    {
                        continue;
                    }
                }

                dr.Close();
                return null;
            }
        }

        public string SearchUserInfo(string nameText, string emailText, string idText)
        {
            string sql = "SELECT USER_ID, USER_PWD, USER_NAME, EMAIL FROM dbo.User_Info";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (idText == dr["USER_ID"].ToString() && nameText == dr["USER_NAME"].ToString() &&
                        emailText == dr["EMAIL"].ToString())
                    {
                        return dr["USER_PWD"].ToString();
                    }
                    else
                    {
                        continue;
                    }
                }

                dr.Close();
                return null;
            }
        }

        public void UpdateData(string id, string password, string name, DateTime birth, string gender,
            string email, string phoneNumber)
        {
            string sql = $@"UPDATE dbo.User_Info
                                SET USER_ID = '{id}',
                                USER_PWD = '{password}',
                                USER_NAME = '{name}',
                                BIRTHDAY = CONVERT(char(10),
                                '{birth}', 120),
                                GENDER = '{gender}',
                                EMAIL = '{email}',
                                PHONE = '{phoneNumber}'
                                WHERE USER_ID = '{currentUserID}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                currentUserID = id;
            }
        }

        public void UpdateDataWithIDMaster(string secondID, string password, string name, DateTime birth, string gender,
            string email, string phoneNumber, string firstID)
        {
            string sql = $@"UPDATE dbo.User_Info
                                SET USER_ID = '{secondID}'
                                , USER_PWD = '{password}'
                                , USER_NAME = '{name}'
                                , BIRTHDAY = CONVERT(char(10), '{birth}', 120)
                                , GENDER = '{gender}'
                                , EMAIL = '{email}'
                                , PHONE = '{phoneNumber}'
                                WHERE USER_ID = '{firstID}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDataMaster(string password, string name, DateTime birth, string gender,
            string email, string phoneNumber, string id)
        {
            string sql = $@"UPDATE dbo.User_Info
                                SET USER_PWD = '{password}'
                                , USER_NAME = '{name}'
                                , BIRTHDAY = CONVERT(char(10), '{birth}', 120)
                                , GENDER = '{gender}'
                                , EMAIL = '{email}', PHONE = '{phoneNumber}'
                                WHERE USER_ID = '{id}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void CheckCurrentMaster(string userID)
        {
            string sql = $"SELECT ISMASTER FROM dbo.User_Info WHERE USER_ID = '{userID}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    currentMaster = Convert.ToInt32(dr["ISMASTER"].ToString());
                }
                dr.Close();
            }
        }

        public void DeleteUser(string userID)
        {
            string sql = $@"DELETE dbo.User_Info
                                WHERE USER_ID = '{userID}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
