using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Visitors
{
    public class CalculateVisitor : IExpressionVisitor
    {
        public int Result { get; set; }
    }
}
