using Calculatrice.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Expressions
{
    class Value : IExpression
    {
        private readonly int value;

        public Value(int value)
        {
            this.value = value;
        }

        public void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(value);
        }
    }
}
