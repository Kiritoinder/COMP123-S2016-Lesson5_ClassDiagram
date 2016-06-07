using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson5
{
    public class Card
    {
        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }
        public string Suit { get; set; }

        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
