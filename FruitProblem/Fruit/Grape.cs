using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Base;

namespace FruitProblem.Fruit
{
    public class Grape : BaseFruit
    {
        public Grape()
        {
            base.Weight = .011;     //Setting the default weight for a single grape to approximately 5 grams
            base.Price = .25;       //Setting the default price for a single grape to .25 cents
            MaxNumberPerVine = 5;   //Setting the default maximum number per vine to 5
        }

        #region Public Properties

        public int MaxNumberPerVine { get; set; }

        #endregion

        #region Public Static Methods

        public static Grape Create()
        {
            return new Grape();
        }

        #endregion
    }
}
