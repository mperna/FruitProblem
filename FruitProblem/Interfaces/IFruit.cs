using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitProblem.Interfaces
{
    public interface IFruit
    {
        string Color { get; set; }
        double Weight { get; set; }
        double Price { get; }
    }
}
