using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/0621
 * 이름 : 김연주
 * 내용 : 데이터베이스 프로그래밍 실습
 */
namespace Ch10
{
    internal class _2_Insert
    {
        static void Main1(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "mydb";

            //데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                // 데이터베이스 접속
                conn.Open();
                Console.WriteLine("접속 성공...");

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `user1` VALUES ('c101', '김유신', '010-1234-1010', 27)";
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료...");
            }
        }
    }
}
