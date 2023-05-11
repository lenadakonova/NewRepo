using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PR_01
{
    public partial class Client : Form
    {
        private UserClass userClass;
        public Client(UserClass userClass)
        {
            InitializeComponent();
            this.userClass = userClass;
            clientname.Text = $"{userClass.UserSurname} {userClass.UserName} {userClass.UserPatronymic}";
        
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Manuf_Click(object sender, EventArgs e)
        {

        }

        private void ProductQuantity_Click(object sender, EventArgs e)
        {

        }

        private void ProductImage_Click(object sender, EventArgs e)
        {

        }

        private void PropuctName_Click(object sender, EventArgs e)
        {

        }

        private void Discription_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
           
        }
    }
}
