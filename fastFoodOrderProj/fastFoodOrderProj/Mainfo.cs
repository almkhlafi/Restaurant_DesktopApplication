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

    public partial class Mainfo : Form
    {

        public static Mainfo mainfo1;
        public String items;
        public String price;
        public String amount;
        public static double sum;

        public Mainfo()
        {
            InitializeComponent();
            mainfo1 = this;

        }

        public void loadforms(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form a = Form as Form;
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(a);
            this.mainPanel.Tag = a;
            a.Show();
        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            loadforms(new MenuItm());
            
        }

        private void foodIcon_Click(object sender, EventArgs e)
        {
            loadforms(new FoodForm());
            MenuItm.menu.Close();
        }

        private void coldDrincsIcon_Click(object sender, EventArgs e)
        {
            loadforms(new ColdDrinksForm());
            MenuItm.menu.Close();
        }

        private void DessertsIcon_Click(object sender, EventArgs e)
        {
            loadforms(new DessertsForm());
            MenuItm.menu.Close();
        }

        private void hotDrincsIcon_Click(object sender, EventArgs e)
        {
            loadforms(new HotDrinksForm());
            MenuItm.menu.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            AddressAndPaymentForm addressAndPaymentForm = new AddressAndPaymentForm();
            addressAndPaymentForm.Show();

        }
        private void Mainfo_Load(object sender, EventArgs e)
        {

            loadforms(new MenuItm());

        }
       
        private void btnOrderComfirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (mydataGridView.Rows[0] != null)
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.TableName = "OrderInfo";
                    dt.Columns.Add("Item");
                    dt.Columns.Add("Price");
                    dt.Columns.Add("No");
                    dt.Columns.Add("Total");
                    ds.Tables.Add(dt);
                    foreach (DataGridViewRow rw in mydataGridView.Rows)
                    {
                        DataRow row = ds.Tables["OrderInfo"].NewRow();
                        row["Item"] = rw.Cells[0].Value;
                        row["Price"] = rw.Cells[1].Value;
                        row["No"] = rw.Cells[2].Value;
                        ds.Tables["OrderInfo"].Rows.Add(row);
                    }
                    ds.WriteXml("../../orderinformationt.xml");
                    AddressAndPaymentForm addressAndPaymentForm = new AddressAndPaymentForm();
                    addressAndPaymentForm.Show();
                    this.Visible = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Select Order First","Alert!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {

            if (mydataGridView.Rows != null)
            {

                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    mydataGridView.Rows.Clear();
                    lblTotal.Text = "$ 0.0";
                    MessageBox.Show("All Orders Have Been Deleted");
                }
            }
            else if (mydataGridView.Rows[0] ==null) MessageBox.Show("Please Select Order To Delete", "Select To Delete", MessageBoxButtons.OK);
        }


        private void btnDeleteSelectedOrder_Click(object sender, EventArgs e)
        {
            if (mydataGridView.CurrentRow != null) 
                {
                    totalsum();
                    mydataGridView.Rows.Remove(mydataGridView.CurrentRow);
                }
            else MessageBox.Show("Please Select Order To Delete", "Select To Delete", MessageBoxButtons.OK);
            
        }

         public void totalsum()
        {
            try {
                double total = 0;
                foreach (DataGridViewRow item in mydataGridView.Rows)
                {
                    total += double.Parse(item.Cells[2].Value.ToString())*
                    double.Parse(item.Cells[1].Value.ToString().Replace("$","0"));
                
                
                lblTotal.Text = total.ToString("C1");
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps"+ ex, "An Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuIcon_Click_1(object sender, EventArgs e)
        {
            loadforms(new MenuItm());
           // MenuItm.menu.Close();
       //     DessertsForm.dessertsForm.Close();
            HotDrinksForm.hotDrinksForm.Close();
            //ColdDrinksForm.coldDrinksForm.Close();
            
        }
    }
} 