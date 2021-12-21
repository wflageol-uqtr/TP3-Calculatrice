using Calculatrice.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Visitors
{
    public interface IExpressionVisitor
    {
        void Visit(Operator op);
        void Visit(int value);
    }
}
