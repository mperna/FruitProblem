using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Base;

namespace FruitProblem.Fruit
{
    public class Pear : BaseFruit
    {
        public Pear()
        {
            base.Weight = .5;   //Setting the default weight of a pear to 1/2 lb.
            base.Price = 2;     //Setting the default price of a pear to $2 (we've got the good pears!)
            Shape = "Rounded";  //Setting the default shape of our pears
        }

        #region Public Properties

        public string Shape { get; set; }

        #endregion

        #region Public Static Methods

        public static Pear Create()
        {
            return new Pear();
        }

        #endregion
    }
}
