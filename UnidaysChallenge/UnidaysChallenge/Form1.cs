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

        Rules pricingRules;

        Shop example;

        public Form1() {
            InitializeComponent();
        }

        //Sets up the window
        private void Form1_Load(object sender, EventArgs e) {

            //sets a "Rules" object to be passed into the shop
            pricingRules = new Rules();

            //creates the shop object with the previously created rules
            example = new Shop(pricingRules, this);

            //sets up what products will be sold in the shop
            Inventory.Setup();

            //Writes out the instructions
            instructions_lbl.Text = "To add an item to your basket, click the respective buttons below." +
                "\n To remove an item from your basket, click on the item in the basket and then click 'Remove'";
        }

        //Adds the selected items to the basket (button clicks)
        private void addItemA_btn_Click(object sender, EventArgs e) {
            example.AddToBasket(Inventory.itemA);
        }
        private void addItemB_btn_Click(object sender, EventArgs e) {
            example.AddToBasket(Inventory.itemB);
        }
        private void addItemC_btn_Click(object sender, EventArgs e) {
            example.AddToBasket(Inventory.itemC);
        }
        private void addItemD_btn_Click(object sender, EventArgs e) {
            example.AddToBasket(Inventory.itemD);
        }
        private void addItemE_btn_Click(object sender, EventArgs e) {
            example.AddToBasket(Inventory.itemE);
        }

        /// <summary>
        /// Causes the list box to write out all of the items in the basket
        /// </summary>
        public void UpdateBasket(List<Item> basket) {

            //list boxes are done seperately to keep everything aligned 
            //longer named items would misalign the price section if only one box was used

            //resets the list boxes
            basketNames_box.Items.Clear();
            basketPrices_box.Items.Clear();

            //goes through each item in the basket and writes out its name and price
            foreach (Item i in basket) {
                basketNames_box.Items.Add(i.name);
                basketPrices_box.Items.Add("£" + i.price);
            }
        }

        /// <summary>
        /// Causes the total label to show the updated total
        /// </summary>
        /// <param name="total"></param>
        public void UpdateTotal(double total) {
            total_lbl.Text = "Your total is: £" + total;
        }

        //sets up the list boxes when an item is selected
        private void basketNames_box_SelectedIndexChanged(object sender, EventArgs e) {
            basketPrices_box.SelectedIndex = basketNames_box.SelectedIndex;
        }
        private void basketPrices_box_SelectedIndexChanged(object sender, EventArgs e) {
            basketNames_box.SelectedIndex = basketPrices_box.SelectedIndex;
        }

        //deals with removing items from the basket
        private void removeItem_btn_Click(object sender, EventArgs e) {

            //makes sure that an item was selected before removing it
            if (basketNames_box.SelectedIndex != -1)
                example.RemoveItem(basketNames_box.SelectedIndex);
            else
                MessageBox.Show("Please click on an item to remove first");
        }
    }
}
