using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Base;

namespace FruitProblem.Fruit
{
    public class Orange : BaseFruit
    {
        public Orange()
        {
            base.Weight = .625; //Setting the default weight of an individual orange (these are big oranges)
            base.Price = 1;     //Setting the default price of an individual orange to $1
            Texture = "Smooth"; //Setting the default texture of our oranges
        }

        #region Public Properties

        public string Texture { get; set; }

        #endregion

        #region Public Static Methods

        public static Orange Create()
        {
            return new Orange();
        }

        #endregion
    }
}
