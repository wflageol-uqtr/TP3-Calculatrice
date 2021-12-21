using Calculatrice.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Visitors
{
    public class CalculateVisitor : IExpressionVisitor
    {
        private Stack<int> stack = new Stack<int>();

        public int Result => stack.Peek();

        public void Visit(Operator op)
        {
            int right = stack.Pop();
            int left = stack.Pop();

            int result = 0;
            switch(op)
            {
                case Operator.Add:
                    result = left + right;
                    break;
                case Operator.Subtract:
                    result = left - right;
                    break;
                case Operator.Multiply:
                    result = left * right;
                    break;
                case Operator.Divide:
                    result = left / right;
                    break;
            }

            stack.Push(result);
        }

        public void Visit(int value)
        {
            stack.Push(value);
        }
    }
}
