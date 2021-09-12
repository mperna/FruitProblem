using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Interfaces;

namespace FruitProblem.Basket
{
    public class FruitBasket
    {
        private int _runningCount = 0;
        private double _runningCost = 0;
        private double _runningWeight = 0;

        private List<IFruitBasketItem> _basket = new List<IFruitBasketItem>();

        #region Public Properties

        public int Count { get { return _runningCount; } }
        public double TotalCost { get { return _runningCost; } }
        public double TotalWeight { get { return _runningWeight; } }

        #endregion

        #region Public Methods

        public void Add(IFruit fruit, int numberToAdd)
        {
            _basket.Add(FruitBasketItem.Create(fruit, numberToAdd));

            _runningCount += numberToAdd;
            _runningCost += (fruit.Price * numberToAdd);
            _runningWeight += (fruit.Weight * numberToAdd); 
        }

        #endregion
    }
}
