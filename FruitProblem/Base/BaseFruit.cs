using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Interfaces;

namespace FruitProblem.Base
{
    public abstract class BaseFruit : IFruit
    {
        #region Public Properties

        public string Color { get; set; }

        //Weight is assumpted to be in pounds
        public double Weight { get; set; }

        //Price is assumed to be in dollars
        public double Price { get; internal set; }

        #endregion
    }
}
