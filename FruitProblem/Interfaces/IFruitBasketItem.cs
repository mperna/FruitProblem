using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitProblem.Interfaces
{
    public interface IFruitBasketItem
    {
        int NumberToAdd { get; set; }
        IFruit Fruit { get; set; }
    }
}
