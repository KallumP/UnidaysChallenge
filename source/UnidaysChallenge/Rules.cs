using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidaysChallenge {


    /// <summary>
    /// A struct used to store what discounts will be applied
    /// </summary>
    struct Rules {

        double totalPrice;
        Form1 window;


        /// <summary>
        /// Applies the discounts to the totalPrice
        /// </summary>
        /// <param name="basket">The basket to be checked for discounts</param>
        /// <param name="_totalPrice">The current totalprice</param>
        /// <param name="_window">An instance of the window</param>
        /// <returns></returns>
        public double CheckDiscounts(List<Item> basket, double _totalPrice, Form1 _window) {

            //sets up an instance of the window to give access to window methods
            window = _window;

            //records the total price to be worked with
            totalPrice = _totalPrice;

            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int eCount = 0;

            //loops through each of the items in the basket
            for (int i = 0; i < basket.Count; i++) {

                //counts how many "itemB"s there are
                if (basket[i].name == Inventory.itemB.name)
                    bCount++;

                //counts how many "itemC"s there are
                if (basket[i].name == Inventory.itemC.name)
                    cCount++;

                //counts how many "itemD"s there are
                if (basket[i].name == Inventory.itemD.name)
                    dCount++;

                //counts how many "itemE"s there are
                if (basket[i].name == Inventory.itemE.name)
                    eCount++;
            }

            //calculates the different discounts
            BDiscount(bCount);
            CDiscount(cCount);
            DDiscount(dCount);
            EDiscount(eCount);

            //checks to see if there was anything in the basket, or if there was a cost of over £50
            if (totalPrice != 0 && totalPrice < 50)

                //shows a delivery charge
                window.UpdateDelivery(true);
            else

                //shows no delivery charge
                window.UpdateDelivery(false);


            return totalPrice;
        }

        /// <summary>
        /// Calcualtes the discounts to be applied for the "ItemB"s in the basket
        /// </summary>
        /// <param name="bCount">The amount of "ItemB"s in the basket</param>
        /// <returns></returns>
        void BDiscount(int bCount) {

            int remainder;

            //checks to see how many B deals cannot be made (the remainder)
            Math.DivRem(bCount, 2, out remainder);

            //gets rid of the count that doesnt get the discount
            bCount -= remainder;

            //removes the bItems (to be discounted)'s prices from the total
            totalPrice -= Inventory.itemB.price * bCount;

            //adds on the dicounted prices to the total
            totalPrice += 20 * bCount / 2;
        }

        /// <summary>
        /// Calculates the discounts to be applied for the "ItemC"s in the basket
        /// </summary>
        /// <param name="cCount">The amount of "ItemC"s in the basket</param>
        /// <returns></returns>
        void CDiscount(int cCount) {

            int remainder;

            //checks to see how many C deals cannot be made (the remainder)
            Math.DivRem(cCount, 3, out remainder);

            //gets rid of the count that doesnt get the discount
            cCount -= remainder;

            //removes the cItems (to be discounted)'s prices from the total
            totalPrice -= Inventory.itemC.price * cCount;

            //adds on the dicounted prices to the total
            totalPrice += 10 * cCount / 3;
        }

        /// <summary>
        /// Calculates the discounts to be applied for the "ItemD"s in the basket
        /// </summary>
        /// <param name="dCount">The amount of "ItemC"s in the basket</param>
        void DDiscount(int dCount) {

            int remainder;

            //checks to see how many D deals cannot be made (the remainder)
            Math.DivRem(dCount, 2, out remainder);

            //gets rid of the count that doesnt get the discount
            dCount -= remainder;

            //removes the prie of half of the dItems
            totalPrice -= Inventory.itemD.price * dCount / 2;
        }

        /// <summary>
        /// Calculates the discounts to be applied for the "ItemE"s in the basket
        /// </summary>
        /// <param name="eCount">The amount of "ItemE"s in the basket</param>
        void EDiscount(int eCount) {

            int remainder;

            //checks to see how many E deals cannot be made (the remainder)
            Math.DivRem(eCount, 3, out remainder);

            //gets rid of the count that doesnt get the discount
            eCount -= remainder;

            //removes the cItems (to be discounted)'s prices from the total
            totalPrice -= Inventory.itemE.price * eCount;

            //adds on the dicounted prices to the total
            totalPrice += 10 * eCount / 3;
        }

    }
}
