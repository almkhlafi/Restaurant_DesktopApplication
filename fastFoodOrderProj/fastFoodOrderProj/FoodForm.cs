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
    public partial class FoodForm : Form
    {
        public static FoodForm foodForm;
        public double food;

        public FoodForm()
        {
            InitializeComponent();
            foodForm = this;
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
            prudectsFlowLayoutPanel.Controls.Add(a);


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

        private void FoodForm_Shwn(object sender, EventArgs e)
        {

            Additems("checkers Fries", 2.8, "checkers-seasoned-fries.jpg", 0);
            Additems("Annes Pretzel", 3.4, "auntie-annes-pretzel.jpg", 0);
            Additems("CheeseBurger", 3.2, "cheeseburger.jpg", 0);
            Additems("dog haus mex", 5.8, "dog-haus-t-mex.jpg", 0);
            Additems("Chicken Sandwich", 4.0, "chickensandwich.jpg", 0);
            Additems("Jack Tacos ", 5.0, "jack-in-the-box-tacos.jpg", 0);
            Additems("mashburger", 5.0, "mashburger.jpg", 0);
            Additems("Panda Chicken", 5.0, "panda-express-kung-pao-chicken.jpg", 0);
            Additems("Kung Chicken", 5.0, "panda-express-orange-chicken.jpg", 0);
            Additems("Pepperoni Pizza", 5.0, "pepperonipizza.jpg", 0);
            Additems("Wreck Sandwich", 5.0, "potbelly-the-wreck-sandwich.jpg", 0);
            Additems("Subsham", 1.5, "subsham.jpg", 0);
            Additems("SubwayTurkey", 5.9, "subwayturkeysub.jpg", 0);
            Additems("Taco Bell", 2.0, "taco-bell-crunchy-taco-best.jpg", 0);
            Additems("Whata Burger", 5.0, "whataburger-burger.jpg", 0);
            Additems("Poke Nachos", 3.5, "yard-house-poke-nachos.jpg", 0);

        }
    }

}
