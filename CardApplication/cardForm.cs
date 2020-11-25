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
        List<Birthday> Birthdays;
        Customers currentCustomer;
        Manfactor currentManfactor;
        List<newBorn> newBorns;
        List<Anniversary> anniversaries;
        public cardForm()
        {
            InitializeComponent();
            currentCustomer = new Customers();
            currentManfactor = new Manfactor();
            Birthdays = new List<Birthday>();
            newBorns = new List<newBorn>();
            anniversaries = new List<Anniversary>();
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
            variblelbl2.Visible = false;
            varibletxt2.Visible = false;
        }

        private void NewBornbtn_Click(object sender, EventArgs e)
        {
            CardBDbtn.Visible = false;
            CardNBbtn.Visible = true;
            CardAbtn.Visible = false;
            variblelbl.Text = "Date";
            variblelbl.Visible = true;
            varibletxt.Visible = true;
            variblelbl2.Text = "Parent Name";
            variblelbl2.Visible = true;
            varibletxt2.Visible = true;
        }

        private void Anniversarybtn_Click(object sender, EventArgs e)
        {
            CardBDbtn.Visible = false;
            CardNBbtn.Visible = false;
            CardAbtn.Visible = true;
            variblelbl.Text = "Year";
            variblelbl.Visible = true;
            varibletxt.Visible = true;
            variblelbl2.Visible = false;
            varibletxt2.Visible = false;
        }

        private void CardNBbtn_Click(object sender, EventArgs e)
        {
            var tempCard = new newBorn();
            tempCard.Customers = currentCustomer;
            tempCard.greeting = Greetingtxt.Text;
            tempCard.message = Messagetxt.Text;
            tempCard.Address = Addresstxt.Text;
            tempCard.Colour = colourtxt.Text;
            tempCard.date = Convert.ToDateTime(varibletxt.Text);
            tempCard.ParentName = varibletxt2.Text;
            tempCard.Reciver = Recipenettxt.Text;
            getManufactor();
            tempCard.Manfactor = currentManfactor;
            newBorns.Add(tempCard);
            sendToTicket();
            clearForm();
        }

        private void CardBDbtn_Click(object sender, EventArgs e)
        {
            var tempCard = new Birthday();
            tempCard.Customers = currentCustomer;
            tempCard.greeting = Greetingtxt.Text;
            tempCard.message = Messagetxt.Text;
            tempCard.Address = Addresstxt.Text;
            tempCard.Colour = colourtxt.Text;
            tempCard.age = Convert.ToInt32(varibletxt.Text);
            tempCard.Reciver = Recipenettxt.Text;
            getManufactor();
            tempCard.Manfactor = currentManfactor;
            Birthdays.Add(tempCard);
            sendToTicket();
            clearForm();
        }


        private void CardAbtn_Click(object sender, EventArgs e)
        {
            var tempCard = new Anniversary();
            tempCard.Customers = currentCustomer;
            tempCard.greeting = Greetingtxt.Text;
            tempCard.message = Messagetxt.Text;
            tempCard.Address = Addresstxt.Text;
            tempCard.Colour = colourtxt.Text;
            tempCard.years = Convert.ToInt32(varibletxt.Text);
            tempCard.Reciver = Recipenettxt.Text;
            getManufactor();
            tempCard.Manfactor = currentManfactor;
            anniversaries.Add(tempCard);
            sendToTicket();
            clearForm();
        }

        private void clearForm()
        {
            Greetingtxt.Text = "";
            Messagetxt.Text = "";
            Addresstxt.Text = "";
            varibletxt.Text = "";
            colourtxt.Text = "";
            ManufactorDD.Text = "";
            varibletxt2.Text = "";
            Recipenettxt.Text = "";
        }
        private void sendToTicket()
        {
            listCards.Items.Clear();
            foreach (Birthday Bcard in Birthdays)
            {
                listCards.Items.Add(Bcard.ToString());
            }
            foreach (newBorn Ncard in newBorns)
            {
                listCards.Items.Add(Ncard.ToString());
            }
            foreach (Anniversary Acard in anniversaries)
            {
                listCards.Items.Add(Acard.ToString());
            }
        }
        private void getManufactor()
        {
            string Name = ManufactorDD.Text;
            switch (Name)
            {
                case "Cards4U":
                    currentManfactor.ID = 1;
                    currentManfactor.Name = "Cards4U";
                    break;
                case "Cards-R-US":
                    currentManfactor.ID = 2;
                    currentManfactor.Name = "Cards-R-US";
                    break;
                case "CardMaker":
                    currentManfactor.ID = 3;
                    currentManfactor.Name = "CardMaker";
                    break;
                case "We heart Cards":
                    currentManfactor.ID = 4;
                    currentManfactor.Name = "We heart Cards";
                    break;
                default:
                    currentManfactor.ID = 5;
                    currentManfactor.Name = ManufactorDD.Text;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void listCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            double money = 0;
            money = money + anniversaries.Count * 1.75;
            money = money + Birthdays.Count * 0.75;
            money = money + newBorns.Count * 1.20;

            lblPrice.Text = Convert.ToString(money);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            Payment currentPayment = new Payment();

            currentPayment.CardNumber = cardNumbertxt.Text;
            currentPayment.expiryDate = Convert.ToDateTime(expiryDatetxt.Text);
            currentPayment.sortCode = Convert.ToInt32(SCtxt.Text);

            listCards.Items.Clear();

            Birthdays.Clear();
            newBorns.Clear();
            anniversaries.Clear();
            paymentSuccess();
        }
        private void paymentSuccess()
        {
            MessageBox.Show("Payment success");
            Application.Restart();
        }
    }
}
