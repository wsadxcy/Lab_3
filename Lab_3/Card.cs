using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    /**
     * <summary>
     * This class creates an object that represents a playing card
     * </summary>
     * 
     * @class Card
     */
    class Card
    {
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }
        public string Suit { get; set; }

        /**
         * <summary>
         * This constructor takes two paramaters: face and suit to instantiate a Card object
         * </summary>
         * 
         * @constructor Card
         * @ param {int} face
         * @ param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
