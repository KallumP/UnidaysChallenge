using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnidaysChallenge {
    public partial class Form1 : Form {

        List<Item> basket;
        Shop example = new Shop();

        public Form1() {
            InitializeComponent();
        }

        //Sets up the window
        private void Form1_Load(object sender, EventArgs e) {



            //Sets up the basket to be used
            basket = new List<Item>();

            Inventory.Setup();

            //Writes out the instructions
            instructions_lbl.Text = "To add an item to your basket, click the respective buttons below." +
                "\n To remove an item from your basket, click on the item in the basket and then click 'Remove'";
        }

        //Adds the selected items to the basket (button clicks)
        private void addItemA_btn_Click(object sender, EventArgs e) {
            AddToBasket(Inventory.itemA);
        }
        private void addItemB_btn_Click(object sender, EventArgs e) {
            AddToBasket(Inventory.itemB);
        }
        private void addItemC_btn_Click(object sender, EventArgs e) {
            AddToBasket(Inventory.itemC);
        }
        private void addItemD_btn_Click(object sender, EventArgs e) {
            AddToBasket(Inventory.itemD);
        }
        private void addItemE_btn_Click(object sender, EventArgs e) {
            AddToBasket(Inventory.itemE);
        }

        /// <summary>
        /// Adds the item that was clicked on to the basket
        /// </summary>
        /// <param name="toAdd"></param>
        void AddToBasket(Item toAdd) {
            basket.Add(toAdd);
            UpdateBasket();
        }

        /// <summary>
        /// Causes the list box to write out all of the items in the basket
        /// </summary>
        void UpdateBasket() {

            //list boxes are done seperately to keep everything aligned 
            //longer named items would misalign the price section if only one box was used

            //resets the list boxes
            basketNames_listBox.Items.Clear();
            basketPrices_listBox.Items.Clear();

            //goes through each item in the basket and writes out its name and price
            foreach (Item i in basket) {
                basketNames_listBox.Items.Add(i.name);
                basketPrices_listBox.Items.Add(i.price);
            }
            


        }

        void CalculateTotalPrice() {

        }
    }
}
