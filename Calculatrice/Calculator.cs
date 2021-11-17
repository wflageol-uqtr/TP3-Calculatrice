using Calculatrice.Expressions;
using Calculatrice.Visitors;
using System;

namespace Calculatrice
{
    public class Calculator
    {
        public int Calculate(string input)
        {
            throw new NotImplementedException();
        }

        public int Calculate(IExpression expr)
        {
            throw new NotImplementedException();
        }

        public void Visit(IExpression expr, IExpressionVisitor visitor) { }
    }
}
