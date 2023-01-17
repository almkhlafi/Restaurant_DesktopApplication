using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastFoodOrderProj.Pic
{

    public partial class Compo : UserControl
    {
        private double _cost;
        private double _amount;
        public static Compo compo;

        public event EventHandler OnSelect = null;
        public Compo()
        {
            InitializeComponent();
            compo = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void myItemspictureBox_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
        public string Itemname { get => lblIttemName.Text; set => lblIttemName.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C1").Replace("US$", "$"); } }
        public double Amount { get => _amount; set { _amount = value; amountUpDown.ToString(); }}
        public Image Icon { get => myItemspictureBox.Image; set => myItemspictureBox.Image = value; }

       
    } 
}
 
    
