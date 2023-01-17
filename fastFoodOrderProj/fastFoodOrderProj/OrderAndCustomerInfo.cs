using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace fastFoodOrderProj
{
    public partial class OrderAndCustomerInfo : Form
    {
        public static OrderAndCustomerInfo orderAndCustomerInfo;
        public OrderAndCustomerInfo()
        {
            InitializeComponent();
            orderAndCustomerInfo = this;
            
        }


        private void OrderAndCustomerInfo_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml("../../orderinformationt.xml");
            dataGridViewLoadXmlFil.DataSource = ds.Tables[0];
            DataSet address = new DataSet();
            address.ReadXml("../../informationts.xml");
            dataGridViewLoadCInof.DataSource = address.Tables[0];
            totalsum();
        }


        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewLoadCInof.Rows[0].Cells[0].Value == null)
                {

                    MessageBox.Show("Please File You informagtion first");
                }
              
                else
                    MessageBox.Show("Your Order hes been Sent ");
            }

            catch (Exception ex) {
                MessageBox.Show("Check Your info And order");
            }
            

}

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            if (dataGridViewLoadCInof.Rows != null)
            {

                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    dataGridViewLoadCInof.Rows.Clear();
                    MessageBox.Show("All Orders Have Been Deleted");
                }
            }
            else MessageBox.Show("Please Select Order To Delete", "Select To Delete", MessageBoxButtons.OK);
        }
        private void btnDeletOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoadXmlFil.CurrentRow != null)
            {
               
                dataGridViewLoadXmlFil.Rows.Remove(dataGridViewLoadXmlFil.CurrentRow);
                totalsum();
            }
            else MessageBox.Show("Please Select Order To Delete", "Select To Delete", MessageBoxButtons.OK);
        }

        private void btninfoPqage_Click(object sender, EventArgs e)
        {
            AddressAndPaymentForm addressAndPaymentForm = new AddressAndPaymentForm();
            this.Close();
            addressAndPaymentForm.Show();
        
        }

        private void btnDeleteSelectedOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoadCInof.CurrentRow != null)
            
                dataGridViewLoadCInof.Rows.Remove(dataGridViewLoadCInof.CurrentRow);
            
            else MessageBox.Show("Please Select customer To Delete", "Select To Delete", MessageBoxButtons.OK);
        }

        public void totalsum()
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow item in dataGridViewLoadXmlFil.Rows)
                {
                    total += double.Parse(item.Cells[2].Value.ToString()) *
                    double.Parse(item.Cells[1].Value.ToString().Replace("$", "0"));
                    totalPrice.Text = total.ToString("C1");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps" + ex, "An Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


