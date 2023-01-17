
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
    public partial class MenuItm : Form
    {

        public double menus;
        public static MenuItm menu;
       
        public MenuItm()
        {
            InitializeComponent();
            menu = this;
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
            prudectsMenuFlowLayoutPanel.Controls.Add(a);

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
            //Food
           
            
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

                //Desserts

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
            Additems("Sticky Pudding", 2.8, "sticky-date-pudding.jpeg",0);

                //ColdDrinks

                
            Additems("Dunkin Frozen Coff", 0.8, "dunkin-frozen-coffee.jpg",0);
            Additems("Dunkin Dced Coffee", 2.8, "dunkin-iced-coffee.jpg", 0);
            Additems("Moneygun Hot Toddy", 2.8, "moneygun-hot-toddy.jpg", 0);
            Additems("Panera IcedCaffe", 2.8, "panera-iced-caffe-latte.jpg", 0);
            Additems("Vanilla Iced", 2.8, "peets-vanilla-iced-latte.jpg", 0);
            Additems("Sonic Brew", 2.8, "sonic-original-cold-brew.jpg", 0);

               
                //HotDrinks
                
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


        public void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || textSearch.Text.Trim().Length == 0)
            {
                foreach (var item in prudectsMenuFlowLayoutPanel.Controls)
                {
                    var comp = (Pic.Compo)item;
                    comp.Visible = comp.lblIttemName.Text.ToLower().Contains(textSearch.Text.Trim().ToLower());
                }
                this.textSearch.Clear();
            }
       
        }

    }
}