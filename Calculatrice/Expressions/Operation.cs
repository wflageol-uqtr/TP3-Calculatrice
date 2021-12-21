using Calculatrice.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Expressions
{
    class Operation : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;
        private Operator op;

        public Operation(IExpression left, IExpression right, Operator op)
        {
            this.left = left;
            this.right = right;
            this.op = op;
        }

        public void Accept(IExpressionVisitor visitor)
        {
            left.Accept(visitor);
            right.Accept(visitor);
            visitor.Visit(op);
        }
    }
}
