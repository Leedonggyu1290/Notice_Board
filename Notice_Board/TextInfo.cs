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
    class TextInfo
    {
        public string tvUserId { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string pastTitle { get; set; }
        public string pastText { get; set; }


        private string connString = ConfigurationManager.ConnectionStrings["NoticeBoardDB"].ConnectionString;

        public DataSet GetTextInfo()
        {
            string sql = "SELECT TITLE AS [제목], USER_ID AS [게시자 아이디] FROM dbo.Text_Info";
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

        public DataSet InputContents(string userID, string title)
        {
            string sql = $@"SELECT TITLE AS [제목], TEXT AS [내용], USER_ID AS [게시자 아이디]
                                FROM dbo.Text_Info
                                WHERE USER_ID = '{userID}' AND TITLE = '{title}'";
            DataSet ds = new DataSet();

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            return ds;
        }

        public void InsertText(string userID, string title, string text)
        {
            string sql = $@"INSERT INTO dbo.Text_Info (USER_ID, TITLE, TEXT)
                                VALUES ('{userID}', '{title}', '{text}')";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateText(string userID, string title, string text)
        {
            string sql = $@"UPDATE dbo.Text_Info
                                SET TITLE = '{title}'
                                , TEXT = '{text}'
                                WHERE USER_ID = '{userID}' AND TITLE = '{pastTitle}' AND TEXT = '{pastText}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            pastTitle = title;
            pastText = text;
        }

        public void DeleteText(string userID, string title)
        {
            string sql = $@"DELETE dbo.Text_Info
                                WHERE USER_ID = '{userID}' AND TITLE = '{title}'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }

    
}
