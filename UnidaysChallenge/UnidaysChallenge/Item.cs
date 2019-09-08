using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidaysChallenge {

    /// <summary>
    /// Class used to store information about different products in a store
    /// </summary>
    struct Item {

        /// <summary>
        /// The name of the item to be displayed
        /// </summary>
        public string name { get; }

        /// <summary>
        /// The price of the item 
        /// </summary>
        public double price { get; }

        /// <summary>
        /// Constructor takes the price and the name to setup the item object
        /// </summary>
        /// <param name="_price">The price of the item</param>
        /// <param name="_name">The name of the item</param>
        public Item(double _price, string _name) {
            price = _price;
            name = _name;
        }
    }
}
