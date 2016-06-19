﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date: June 10, 2016
* Date Modified: June 10, 2016
* Description: Deal a card
* Version: 0.0.1
*/

namespace COMP213_S2016_Lesson5
{
    /**
 * <summary>
 * This class creates an object that represents a playing card
 * </summary>
 * 
 * @class Card
 */
    public class Card
    {
        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++
        public Faces Face { get; set; }
        public Suits Suit { get; set; }
            /**
             * <summary>
             * This constructor takes two paramaters: face and suit to instantiate a Card object
             * </summary>
             * 
             * @constructor Card
             * @ param {Faces} face
             * @ param {Suits} suit
             */
        public Card(Faces face, Suits suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
