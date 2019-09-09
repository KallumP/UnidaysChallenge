using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidaysChallenge {

    /// <summary>
    /// A struct used to store what will be sold in the shop
    /// </summary>
    static class Inventory {

        public static Item itemA;
        public static Item itemB;
        public static Item itemC;
        public static Item itemD;
        public static Item itemE;

        /// <summary>
        /// Creates and sets up the items that can be added and removed from the basket
        /// </summary>
        public static void Setup() {
            //prices and names were taken directly from the Unidays' github page (https://github.com/MyUNiDAYS/tech-placement-challenge)
            itemA = new Item(8.00, "A");
            itemB = new Item(12.00, "B");
            itemC = new Item(4.00, "C");
            itemD = new Item(7.00, "D");
            itemE = new Item(5.00, "E");
        }
    }
}
