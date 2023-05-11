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
    public partial class Clients : Form
    {
        private UserClass userClass2;
        public Clients(UserClass userClass)
        {
            InitializeComponent();
            this.userClass2 = userClass;
            clientname.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
            MySqlConnection con = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=ws_014");
            string query = "select *from `product`";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
            {

                DataSet dset = new DataSet();

                adpt.Fill(dset);

                dataGridView1.DataSource = dset.Tables[0];

            }

        }

        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void Clients_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Артикул";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Описание";
            dataGridView1.Columns[3].HeaderText = "Категория";
            dataGridView1.Columns[4].HeaderText = "Фото";
            dataGridView1.Columns[5].HeaderText = "Производитель";
            dataGridView1.Columns[6].HeaderText = "Цена";
            dataGridView1.Columns[7].HeaderText = "Скидка";
            dataGridView1.Columns[8].HeaderText = "Количество на складе";
            dataGridView1.Columns[9].HeaderText = "Ед. измерения";
            dataGridView1.Columns[10].HeaderText = "Поставщик";
            dataGridView1.Columns[11].HeaderText = "Макс. скидка";
            dataGridView1.DefaultCellStyle.Font = new Font("Downtown Regular", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Downtown Regular", 12);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуться к авторизации?",
           "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) ;
            {
                Autorization newform = new Autorization();
                newform.Show();
                this.Hide();
            }
        }

        private void Zakaz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сделать заказ?",
            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Zakaz newform = new Zakaz(userClass2);
                newform.Show();
                this.Hide();
            }
        }


    }
}