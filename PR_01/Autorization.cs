using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_01
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
           
        }
        private void enter_Click(object sender, EventArgs e)
        {
            String LoginUser = login.Text;
            String pasUser = password.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            {
                MySqlCommand command = new MySqlCommand("Select * from `user` Where `UserLogin` = @ul and `UserPassword` = @up", db.GetConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = pasUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)

                {
                    UserClass userClass =new UserClass(table.Rows[0]["UserSurname"].ToString(), table.Rows[0]["UserName"].ToString(),table.Rows[0]["UserPatronymic"].ToString());
                    MessageBox.Show("Добро пожаловать!");
                    string role = table.Rows[0]["UserRole"].ToString();
                    if (role == "1")
                    {
                        this.Hide();
                        Admin f1 = new Admin(userClass);
                        f1.Show();
                    }
                    else if (role == "2")
                    {
                        this.Hide();
                        Manager f2 = new Manager(userClass);
                        f2.Show();
                    }
                    else
                    {
                        this.Hide();
                        Clients f3 = new Clients(userClass);
                        f3.Show();
                    }

                }
                else MessageBox.Show("Такого пользователя не существует");
               

            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void readproduct_Click(object sender, EventArgs e)
        {
            UserClass userClass = new UserClass("Вы", "вошли ", "в роли гостя");
            this.Hide();
            Clients f3 = new Clients(userClass);
            f3.Show();
        }
    }
}
