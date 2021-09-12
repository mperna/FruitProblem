using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Interfaces;

namespace FruitProblem.Basket
{
    public class FruitBasketItem : IFruitBasketItem
    {
        public FruitBasketItem(IFruit fruit, int numberToAdd)
        {
            Fruit = fruit;
            NumberToAdd = numberToAdd;
        }

        #region Public Properties

        public int NumberToAdd { get; set; }
        public IFruit Fruit { get; set; }

        #endregion

        #region Public Static Methods

        public static FruitBasketItem Create(IFruit fruit, int numberToAdd)
        {
            return new FruitBasketItem(fruit, numberToAdd);
        }

        #endregion
    }
}
