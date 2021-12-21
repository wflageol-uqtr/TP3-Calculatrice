using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Expressions
{
    public class ExpressionBuilder
    {
        private IExpression tree;

        public ExpressionBuilder(int initial) 
        {
            tree = new Value(initial);
        }

        public void Add(int n) => tree = new Operation(tree, new Value(n), Operator.Add);
        public void Add(ExpressionBuilder e) => tree = new Operation(tree, e.Build(), Operator.Add);

        public void Subtract(int n) => tree = new Operation(tree, new Value(n), Operator.Subtract);
        public void Subtract(ExpressionBuilder e) => tree = new Operation(tree, e.Build(), Operator.Subtract);

        public void Multiply(int n) => tree = new Operation(tree, new Value(n), Operator.Multiply);
        public void Multiply(ExpressionBuilder e) => tree = new Operation(tree, e.Build(), Operator.Multiply);

        public void Divide(int n) => tree = new Operation(tree, new Value(n), Operator.Divide);
        public void Divide(ExpressionBuilder e) => tree = new Operation(tree, e.Build(), Operator.Divide);

        public IExpression Build() => tree;
    }
}
