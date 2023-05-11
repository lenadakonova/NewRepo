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
    public partial class Admin : Form
    {
        private UserClass userClass1;
        public Admin(UserClass userClass)
        {
            InitializeComponent();


            this.userClass1 = userClass;
            adminname.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
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
     

        private void Admin_Load(object sender, EventArgs e)
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

       

        private void Add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить товар?",
             "Подтвердите добавление",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Add newform = new Add();
                newform.ShowDialog();

            }

            table.Clear();
            adapter.Fill(table);
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную(ые) строку(и)?",
            "Подтвердите удаление",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                MySqlCommandBuilder cd = new MySqlCommandBuilder(adapter);
                adapter.Update(table);
                table.Clear();
                adapter.Fill(table);

            }
            }

        private void edit_Click(object sender, EventArgs e)
        {
            DialogResult resuit = MessageBox.Show("Вы уверены, что хотите сохранить измененения?",
                                                      "Подтвердите сохранения", MessageBoxButtons.YesNo);
            if(resuit == DialogResult.Yes)
            {
                table = (DataTable)dataGridView1.DataSource;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                if(dataGridView1.SelectedRows.Count ==0)
                {
                    MessageBox.Show("Обязательно для заполнения");
                }
            }adapter.Update(table);
            table.Clear();
            adapter.Fill(table);
            dataGridView1.Refresh();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуться?",
            "Подтвердите операцию",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Autorization newform = new Autorization();
                newform.ShowDialog();

            }

            table.Clear();
            adapter.Fill(table);
        }
 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void adminname_Click(object sender, EventArgs e)
        {

        }
    }
}
