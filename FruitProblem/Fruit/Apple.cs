using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Base;

namespace FruitProblem.Fruit
{
    /// <summary>
    /// We could expand the definition of this class if we wanted to account for 
    /// sub-types in a more formal way. For example, we could create a "GrannySmith" class
    /// which inherits from Apple but the value of that would really only be realized if there
    /// were additional characteristics of a GrannySmith that were important to us. Also, its important
    /// to be mindful of levels of inheritance. Once you get past one (maybe two), the value starts to become
    /// questionable; it becomes an inheritance vs. composition question, in my view, at that point.
    /// </summary>
    public class Apple : BaseFruit
    {
        public Apple() 
        {
            base.Weight = .15;  //Setting a default weight of .15 lbs
            base.Price = 1;     //Setting a default price of $1 per apple
            SubType = "Red";    //Setting a default sub-type of 'Red'
        }

        #region Public Properties

        /// <summary>
        /// For the purpose of this demo, I'm leaving this as a string; however,
        /// this could be implemented in a number of different ways. For example, 
        /// we could have this return an Enum of specific types.
        /// </summary>
        public string SubType { get; set; }

        #endregion

        #region Public Static Methods

        public static Apple Create()
        {
            return new Apple();
        }

        #endregion
    }
}
