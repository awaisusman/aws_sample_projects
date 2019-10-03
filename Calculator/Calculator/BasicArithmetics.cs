using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
    public class BasicArithmetics : IArithmetics
    {
        private int _num1;
        private int _num2;
        private int _result;

        public BasicArithmetics()
        {
            _num1 = 0;
            _num2 = 0;
        }

        public int GetResult() {
            return _result;
        }

        private void InitializeNumbers(OperationType operationType, int num1, int num2)
        {

        }

        public double Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Minus(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Plus(int num1, int num2)
        {
            InitializeNumbers(OperationType.Plus, num1, num2);
            _result = num1 + num2;
            return _result;
        }
    }
}
