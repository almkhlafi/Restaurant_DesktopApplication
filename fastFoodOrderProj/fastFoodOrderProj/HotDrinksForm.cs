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
    public partial class HotDrinksForm : Form
    {
        public static HotDrinksForm hotDrinksForm;
        public HotDrinksForm()
        {
            InitializeComponent();
            hotDrinksForm = this;
        }
        public void Additems(string name, double cost, string icon, double amount)
        {

            var a = new Pic.Compo()
            {
                Itemname = name,
                Cost = cost,
                Amount = amount,
                Icon = Image.FromFile("../../img/HotDrinks/" + icon)
            };
            prudectsHotDrinksFlowLayoutPanel.Controls.Add(a);


            a.OnSelect += (zz, xx) =>
            {
                var co = (Pic.Compo)zz;
                Mainfo.mainfo1.mydataGridView.Rows.Add(
                Mainfo.mainfo1.items = co.lblIttemName.Text.ToString(),
                Mainfo.mainfo1.price = co.lblCost.Text.ToString(),
                Mainfo.mainfo1.amount = co.amountUpDown.Value.ToString());
                Mainfo.mainfo1.totalsum();
            };

        }
        private void HotDrinksForm_Shown(object sender, EventArgs e)
        {

            Additems("Hot Chocolate", 0.8, "Hot-Chocolate-1-of-5.jpg", 0);
            Additems("Hot Chocolate", 1.0, "Hot-Chocolate-2-of-5.jpg", 0);
            Additems("White Hot Chocolate.jpeg", 2.8, "hot-chocolate.jpeg", 0);
            Additems("Hot Penicillin", 1.0, "hot-penicillin.jpg", 0);
            Additems("Hot Turmeric", 2.3, "hot-turmeric-latte.jpg", 0);
            Additems("Irishcoffee Backbar", 0.8, "irishcoffee_backbar.jpg", 0);
            Additems("Irishcoffee Drinkwell", 6.8, "irishcoffee_drinkwell.jpg", 0);
            Additems("Irishcoffee VCC", 4.8, "irishcoffee_VCC.jpg", 0);
            Additems("La-Vida Mocha", 3.0, "la-vida-mocha.jpg", 0);
            Additems("Matcha Latte", 2, "matcha-latte.jpg", 0);
            Additems("Peppermint Chocolate", 1.0, "peppermint-hot-chocolate.jpeg", 0);
            Additems("Choc Chocolate", 5.8, "white-choc-hot-chocolate.jpg", 0);
        }

        
    }
}
