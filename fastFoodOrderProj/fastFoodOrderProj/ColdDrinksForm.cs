using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastFoodOrderProj
{

    public partial class ColdDrinksForm : Form
    {
        public double coldDrinks;
        public static ColdDrinksForm coldDrinksForm;
        public ColdDrinksForm()
        {
            InitializeComponent();
            coldDrinksForm = this;
        }
        public void  Additems(string name, double cost, string icon, double amount)
        {

            var a = new Pic.Compo()
            {
                Itemname = name,
                Cost = cost,
                Amount = amount,
                Icon = Image.FromFile("../../img/ColdDrinks/" + icon)
            };
            prudectsColdDrinksFlowLayoutPanel.Controls.Add(a);

            a.OnSelect += (zz, xx) =>
            {

                
                var co = (Pic.Compo)zz;
                Mainfo.mainfo1.mydataGridView.Rows.Add(
                 Mainfo.mainfo1.items = co.lblIttemName.Text.ToString(),
                 Mainfo.mainfo1.price = co.lblCost.Text.ToString(),
                 Mainfo.mainfo1.amount = co.amountUpDown.Value.ToString());
                Mainfo.mainfo1.totalsum();
            };
   
            {

            }
        }
        private void ColdDrinksForm_Shown(object sender, EventArgs e)
        {

            Additems("Dunkin Frozen Coff", 0.8, "dunkin-frozen-coffee.jpg",0);
            Additems("Dunkin Dced Coffee", 2.8, "dunkin-iced-coffee.jpg", 0);
            Additems("Moneygun Hot Toddy", 2.8, "moneygun-hot-toddy.jpg", 0);
            Additems("Panera IcedCaffe", 2.8, "panera-iced-caffe-latte.jpg", 0);
            Additems("Vanilla Iced", 2.8, "peets-vanilla-iced-latte.jpg", 0);
            Additems("Sonic Brew", 2.8, "sonic-original-cold-brew.jpg", 0);

        }
    }
}
