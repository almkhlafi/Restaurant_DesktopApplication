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
    public partial class DessertsForm : Form 
    {
        public static DessertsForm dessertsForm;
    
    
         public DessertsForm()
        {
            InitializeComponent();
            dessertsForm = this;
        }
        public void Additems(string name, double cost, string icon, double amount)
        {

            var a = new Pic.Compo()
            {
                Itemname = name,
                Cost = cost,
                Amount = amount,
                Icon = Image.FromFile("../../img/Food/" + icon)
            };
            prudectsDessertsFlowLayoutPanel.Controls.Add(a);


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

        private void DessertsForm_Shown(object sender, EventArgs e)
        {
            Additems("Apple Berry", 2.8, "10-minute-apple-berry-crumble.jpeg", 0);
            Additems("Almond Cake", 2.8, "almond-and-date-cake.jpeg", 0);
            Additems("Strawberry Roulade", 2.8, "almond-strawberry-roulade.jpeg", 0);
            Additems("Amaretto Tart", 2.8, "amaretto-tart.jpeg", 0);
            Additems("Angel Cake", 2.8, "angel-food-cake.jpg", 0);
            Additems("Aniseed Chocolate", 2.8, "aniseed-and-chocolate-parfait.jpeg", 0);
            Additems("Apple Torte", 2.8, "apple-and-almond-torte.jpeg", 0);
            Additems("Apple Butterscotch", 2.8, "apple-and-butterscotch.jpeg", 0);
            Additems("Cinnamon Custard", 2.8, "apple-cinnamon-custard.jpeg", 0);
            Additems("Baked lemon Meringue ", 2.8, "baked-lemon-meringue-pie.jpeg", 0);
            Additems("Forest Trifles", 2.8, "black-forest-trifles.jpeg", 0);
            Additems("Chocolate Bullets", 2.8, "chocolate-bullets.jpeg", 0);
            Additems("Maltesers Tiramisu", 2.8, "maltesers-tiramisu.jpeg", 0);
            Additems("Mocha-Log", 2.8, "mocha-log.jpeg", 0);
            Additems("Napoleon", 2.8, "napoleon.jpeg", 0);
            Additems("Fried Ice Cream", 2.8, "not-so-fried-ice-cream.jpeg", 0);
            Additems("Roasted Strawberry", 2.8, "roasted-strawberry-crumble.jpeg", 0);
            Additems("snickers Rolls", 2.8, "snickers-rolls.jpeg", 0);
            Additems("Sticky Pudding", 2.8, "sticky-date-pudding.jpeg", 0);
        }
    }
}
