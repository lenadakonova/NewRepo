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
    public partial class ManagerList : Form
    {
        private UserClass userClass1;
        public ManagerList(UserClass userClass)
        {
            InitializeComponent();

            this.userClass1 = userClass;
            managername.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
            MySqlConnection con = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=ws_014");

            string query = "select *from `orderproduct`";

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
        private void ManagerList_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `orderproduct`", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Заказ";
            dataGridView1.Columns[1].HeaderText = "Название продукта";
            dataGridView1.Columns[2].HeaderText = "Имя заказчика";
            dataGridView1.Columns[3].HeaderText = "Количество";
            dataGridView1.Columns[4].HeaderText = "Пункт выдачи";
            dataGridView1.DefaultCellStyle.Font = new Font("Downtown Regular", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Downtown Regular", 12);


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Manager f = new Manager(userClass1);
            f.Show();
            this.Hide();
        }
    }
}
