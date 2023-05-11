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
   
    public partial class Zakaz : Form
        
    {
        private UserClass userClass1;
        public Zakaz(UserClass userClass)
        {
            InitializeComponent();
            this.userClass1 = userClass;
            ClientName.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
            MySqlConnection con = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=ws_014");

        }
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void Zakaz_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Orderproduct`", db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
              

               

            }
        }

        private void Zakazat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Qiantity.Text) || string.IsNullOrEmpty(FIO.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            DataRow row = table.NewRow();

            row["OrderProductID"] = DBNull.Value;
            row["ProductName"] = Name.Text;
            row["ClientsName"] = FIO.Text;
            row["Count"] = Qiantity.Text;
            row["OrderPosts"] = post.Text;
            table.Rows.Add(row);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            table.Clear();
            adapter.Fill(table);
            DialogResult result = MessageBox.Show("Заказ оформлен. Спасибо за покупку!", "Добавление заказа",
            MessageBoxButtons.OK);
           
          
           Clients newform = new Clients(userClass1);
           newform.ShowDialog();
           this.Close();

            

            table.Clear();
            adapter.Fill(table);
        }

    }


    } 
