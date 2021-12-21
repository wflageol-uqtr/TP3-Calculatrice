using Calculatrice.Expressions;
using Calculatrice.Visitors;
using System;
using System.Linq;

namespace Calculatrice
{
    public class Calculator
    {
        public int Calculate(string input)
        {
            var tokens = input.Split(' ');
            var builder = new ExpressionBuilder(int.Parse(tokens[0]));

            var nextOperator = "";
            foreach(var token in tokens.Skip(1))
            {
                try
                {
                    int v = int.Parse(token);
                    switch (nextOperator)
                    {
                        case "+":
                            builder.Add(v);
                            break;
                        case "-":
                            builder.Subtract(v);
                            break;
                        case "*":
                            builder.Multiply(v);
                            break;
                        case "/":
                            builder.Divide(v);
                            break;
                        default:
                            throw new ArgumentException();
                    }
                } catch (FormatException) 
                {
                    nextOperator = token;
                }
            }

            return Calculate(builder.Build());
        }

        public int Calculate(IExpression expr)
        {
            var visitor = new CalculateVisitor();
            Visit(expr, visitor);

            return visitor.Result;
        }

        public void Visit(IExpression expr, IExpressionVisitor visitor) 
        {
            expr.Accept(visitor);
        }
    }
}
