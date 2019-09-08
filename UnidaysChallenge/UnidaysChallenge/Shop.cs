using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidaysChallenge {
    class Shop {

        Rules pricingRules;

        public List<Item> basket;

        Form1 window;

        double totalPrice;

        /// <summary>
        /// Constructor sets up the shop
        /// </summary>
        /// <param name="_pricingRules">The discount rules</param>
        /// <param name="_window">An instance of the shop window</param>
        public Shop(Rules _pricingRules, Form1 _window) {

            //sets up a way for the shop to communicate with the main window
            window = _window;

            //Sets up the basket to be used in the shop
            basket = new List<Item>();
        }

        /// <summary>
        /// Adds the item that was clicked on to the basket
        /// </summary>
        /// <param name="toAdd">The "item" object to be added</param>
        public void AddToBasket(Item toAdd) {

            //adds the selected item to the basket
            basket.Add(toAdd);

            //redraws the basket GUI
            window.UpdateBasket(basket);

            //adds up the total
            CalculateTotalPrice();
        }

        /// <summary>
        /// Calculates the total price based on what's in the basket (including discounts)
        /// </summary>
        void CalculateTotalPrice() {

            //resets the price
            totalPrice = 0;

            //goes throught each item in the basket and adds the price onto the total price
            foreach (Item i in basket) 
                totalPrice += i.price;

            //applies the discounts
            totalPrice = pricingRules.CheckDiscounts(basket, totalPrice);

            //redraws the total label
            window.UpdateTotal(totalPrice);
        }

        /// <summary>
        /// Removes the selected item from the basket
        /// </summary>
        /// <param name="selectedIndex">The index of the item from the list box</param>
        public void RemoveItem(int selectedIndex) {

            //removes the item from the basket
            basket.RemoveAt(selectedIndex);
            window.UpdateBasket(basket);
            CalculateTotalPrice();
        }
    }
}
