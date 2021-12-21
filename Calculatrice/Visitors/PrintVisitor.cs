using Calculatrice.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Visitors
{
    public class PrintVisitor : IExpressionVisitor
    {
        private Stack<IExpression> stack = new Stack<IExpression>();

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void Visit(Operator op)
        {
            throw new NotImplementedException();
        }

        public void Visit(int value)
        {
            throw new NotImplementedException();
        }
    }
}
