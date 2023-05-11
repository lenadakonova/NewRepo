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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace PR_01
{
    
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
     
        }
        DB db = new DB();
        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            private void Add_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select * from `product`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }   

        private void BAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `product` (`ProductPhoto`) VALUES ( @ProductPhoto, );", db.GetConnection());
            command.Parameters.Add("@ProductPhoto", MySqlDbType.VarChar).Value = namePhoto.Text;
            if (checkUser())
            {
                return;
            }
            else if (string.IsNullOrEmpty(Article.Text) || string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Discription.Text) || string.IsNullOrEmpty(Category.Text)
            || string.IsNullOrEmpty(Manuf.Text) || string.IsNullOrEmpty(Price.Text) || string.IsNullOrEmpty(Discount.Text) || string.IsNullOrEmpty(Qiantity.Text)
            ||  string.IsNullOrEmpty(MaxDiscount.Text) || string.IsNullOrEmpty(Suplier.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            DataRow row = table.NewRow();

            row["ProductArticleNumber"] = Article.Text;
            row["ProductName"] = Name.Text;
            row["ProductDescription"] = Discription.Text;
            row["ProductCategory"] = Category.Text;
            row["ProductManufacturer"] = Manuf.Text;
            row["ProductCost"] = Price.Text;
            row["ProductDiscountAmount"] = Discount.Text;
            row["ProductQuantityInStock"] = Qiantity.Text;
            row["ProductMaxDiscountAmount"] = MaxDiscount.Text;
            row["ProductSupplier"] = Suplier.Text;
            row["UnitOfMeasurement"] = Edizm.Text;



            table.Rows.Add(row);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            table.Clear();
            adapter.Fill(table);
            DialogResult result = MessageBox.Show("Товар успешно добавлен", "Добавление",
            MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
              
            }



            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }

            this.Close();
        }
        public Boolean checkUser()
        {
            DB dB = new DB();
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

           // MySqlCommand cmd = new MySqlCommand("Select * From 'product' where 'ProductArticleNumber'=@art", db.GetConnection());
            //cmd.Parameters.Add("@art", MySqlDbType.VarChar).Value = Article.Text;

           // adapter.SelectCommand = cmd;
            //adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой товар уже есть!");
                return true;

            }
            else
            {
                return false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Suplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zagruz_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.png, *.jpg, *jpeg)|*.png, *.jpg, *jpeg|All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Photo.ImageLocation = op.FileName;
                namePhoto.Text = op.FileName;
            }
        }

        private void namePhoto_Click(object sender, EventArgs e)
        {

        }
    }
    
}
