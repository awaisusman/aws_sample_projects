﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
    public interface IArithmetics
    {
        int Plus(int num1, int num2);
        int Minus(int num1, int num2);
        int Multiply(int num1, int num2);
        double Divide(int num1, int num2);
    }
}
