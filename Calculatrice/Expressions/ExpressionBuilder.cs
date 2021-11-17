using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Expressions
{
    public class ExpressionBuilder
    {
        public ExpressionBuilder(int initial) { }

        public void Add(int n) { }
        public void Add(ExpressionBuilder e) { }

        public void Subtract(int n) { }
        public void Subtract(ExpressionBuilder e) { }

        public void Multiply(int n) { }
        public void Multiply(ExpressionBuilder e) { }

        public void Divide(int n) { }
        public void Divide(ExpressionBuilder e) { }

        public IExpression Build()
        {
            throw new NotImplementedException();
        }
    }
}
