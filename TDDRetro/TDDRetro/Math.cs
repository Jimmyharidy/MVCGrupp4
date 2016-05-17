using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TDDRetro
{
    public class Math
    {
        public double CountSquare(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var correctString = input.Replace(",", ".").Replace(" ", "");
            double number = double.Parse(correctString);
            var result = number * number;
            return result;

        }
    }
}
