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
    public partial class Manager : Form
    {
        private UserClass userClass;
        public Manager(UserClass userClass)
        {
            InitializeComponent();
            this.userClass = userClass;
            managername.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
        }
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void Manager_Load(object sender, EventArgs e)
        {

            string strquery = "SELECT product.ProductArticleNumber, product.ProductName, product.ProductDescription, category.Category, product.ProductPhoto, manufacturer.ProductManufacturer, product.ProductCost, product.ProductDiscountAmount, product.ProductQuantityInStock, unitofmeasurement.UnitOfMeasurement, supplier.Supplier, product.ProductMaxDiscountAmount  FROM product JOIN category ON product.ProductCategory = category.idProductCategory JOIN manufacturer ON product.ProductManufacturer = manufacturer.idProductManufacturer JOIN unitofmeasurement ON product.UnitOfMeasurement = unitofmeasurement.idUnitOfMeasurement JOIN supplier ON product.ProductSupplier = supplier.idSupplier";
            MySqlCommand cmd = new MySqlCommand(strquery, db.GetConnection());

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
            "Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Autorization newform = new Autorization();
                newform.Show();
                this.Hide();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ProdList_Click(object sender, EventArgs e)
        {

        }
    }
}
