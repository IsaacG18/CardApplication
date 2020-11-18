using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardApplication;

namespace CardApplication
{
    public partial class cardForm : Form
    {
        Customers currentCustomer;
        public cardForm()
        {
            InitializeComponent();
            currentCustomer = new Customers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var tempCard = new Card();
            currentCustomer.FirstName = SendFNametxt.Text;
            currentCustomer.LastName = SendLNametxt.Text;
            currentCustomer.Email = SendEmailtxt.Text;
            currentCustomer.ID = rand.Next(1000, 9999);

            MessageBox.Show("Sender Created", "Card", MessageBoxButtons.OK);
            displaySender();
        }


            private void displaySender(){
            Sendlbl.Text = currentCustomer.FirstName + " " + currentCustomer.LastName;
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManufactorDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardBDbtn.Visible = true;
            CardNBbtn.Visible = false;
            CardAbtn.Visible = false;
            variblelbl.Text = "Age";
            variblelbl.Visible = true;
            varibletxt.Visible = true;
        }

        private void NewBornbtn_Click(object sender, EventArgs e)
        {
            CardBDbtn.Visible = false;
            CardNBbtn.Visible = true;
            CardAbtn.Visible = false;
            variblelbl.Text = "Date";
            variblelbl.Visible = true;
            varibletxt.Visible = true;
        }

        private void Anniversarybtn_Click(object sender, EventArgs e)
        {
            CardBDbtn.Visible = false;
            CardNBbtn.Visible = false;
            CardAbtn.Visible = true;
            variblelbl.Text = "Year";
            variblelbl.Visible = true;
            varibletxt.Visible = true;
        }

        private void CardNBbtn_Click(object sender, EventArgs e)
        {

        }

        private void CardBDbtn_Click(object sender, EventArgs e)
        {

        }

        private void CardAbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
