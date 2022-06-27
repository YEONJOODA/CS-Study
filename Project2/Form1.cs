using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "mydb";

            // 데이터베이스 커넥션
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            // 데이터 공급 리스트 생성
            List<User> users = new List<User>();

            try
            {
                // 데이터베이스 접속
                conn.Open();


                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user2`";

                MySqlDataReader reader = cmd.ExecuteReader();

                // 결과 리스트 생성
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);


                    users.Add(user);
                }
            }
            catch(Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // 데이터베이스 종료
                conn.Close();
            }

            // 데이터그리드뷰 데이터 공급
            dataGridView1.DataSource = users;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = nAge.Text.ToString();


            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "mydb";

            // 데이터베이스 커넥션
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `user2` VALUES ('{uid}', '{name}', '{hp}', {age})";

                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("Insert 완료", "데이터가 저장되었습니다.");
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }
    }
}