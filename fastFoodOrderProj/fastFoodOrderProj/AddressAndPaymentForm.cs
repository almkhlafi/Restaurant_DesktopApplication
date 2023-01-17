using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fastFoodOrderProj
{
    public partial class AddressAndPaymentForm : Form
    {

        public AddressAndPaymentForm()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainfo mainfo = new Mainfo();
            this.Close();
            mainfo.Show();

            /*DataSet ds = new DataSet();
            ds.ReadXml("../../orderinformationt.xml");
            Mainfo.mainfo1.mydataGridView.DataSource = ds.Tables[0];*/
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {

            string fullName = this.textFullName.Text;
            string phoneNumberStr = this.textBoxPhoneNumber.Text;
            string email = this.textBoxEmail.Text;
            string home = this.textBoxHome.Text;
            string city = this.textBoxCity.Text;
            string area = this.textBoxArea.Text;
            string apartmentInfo = this.textBoxAptInfo.Text;
            string orderNotes = this.richTextBoxOrderNote.Text;
            string paymentMethod = "";
            bool vali = true;
            errorProviderAddressAndPaymentForm.Clear();

            if (fullName.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textFullName, "Please enter your full name.");
            else if (phoneNumberStr.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxPhoneNumber, "Please enter your phonenumber.");

            else if (email.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxEmail, "Please enter your email.");
            else if (home.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxHome, "Please enter your home.");
            else if (city.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxCity, "Please enter your city.");
            else if (area.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxArea, "Please enter your area.");
            else if (apartmentInfo.Length < 1)
                errorProviderAddressAndPaymentForm.SetError(textBoxAptInfo, "Please enter your apartment information.");

            
            else if ((radioButtonCridet.Checked == false) && (radioButtonCash.Checked == false))
            {
                   
                vali = false;
                errorProviderAddressAndPaymentForm.SetError(radioButtonCridet, "You should select a payment method.");
            }
            
            else
            {

                if (radioButtonCash.Checked)
                {

                    paymentMethod = "Pay Cash";
                }
                else if (radioButtonCridet.Checked)
                {

                    paymentMethod = "Credit Card";
                }
                try
                {
                    XDocument information = new XDocument(
                     new XDeclaration("1.0", "utf-8", "yes"),
                     new XComment("informations xml"),
                         new XElement("userInformations",
                    new XElement("information",
                                 new XElement("FullName", fullName),
                                 new XElement("PhoneNumber", phoneNumberStr),
                                 new XElement("Email", email),
                                 new XElement("Home", home),
                                  new XElement("City", city),
                                   new XElement("Area", area),
                                    new XElement("ApartmentInfo", apartmentInfo),
                                     new XElement("OrderNotes", orderNotes),
                                    new XElement("PaymentMethod", paymentMethod),
                                    new XElement("PaymentMethod", paymentMethod))
                                     ));

                    information.Save(@"../../informationts.xml");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Confirmation error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                OrderAndCustomerInfo orderAndCustomerInfo = new OrderAndCustomerInfo();
                orderAndCustomerInfo.Show();
                this.Close();

            }

        }

        private void AddressAndPaymentForm_Load(object sender, EventArgs e)
        {
             
        }
    }
}



  