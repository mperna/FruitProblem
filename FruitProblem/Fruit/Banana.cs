using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Base;

namespace FruitProblem.Fruit
{
    public class Banana : BaseFruit
    {
        public Banana()
        {
            base.Weight = .33;  //Setting the default weight of one banana to 1/3 lb
            base.Price = 1.5;   //Setting the default cost of one banana is $1.50
            Length = 5;         //Setting a default lenght of a banana to 5 inches
        }

        #region Public Properties

        /// <summary>
        /// I'm going to make the assumption here that we're measuring this length
        /// as a number (inches, etc.)
        /// </summary>
        public int Length { get; set; }

        #endregion

        #region Public Static Methods

        public static Banana Create()
        {
            return new Banana();
        }

        #endregion
    }
}
