using Calculatrice;
using Calculatrice.Expressions;
using Calculatrice.Visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatriceTests
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CalculateSimpleString()
        {
            Assert.AreEqual(11, calculator.Calculate("7 + 4"));
        }

        [TestMethod]
        public void CalculateLongString()
        {
            Assert.AreEqual(2, calculator.Calculate("3 * 5 - 7 + 2 / 5"));
        }

        // Facultatif, pour points bonus!
        [TestMethod]
        public void CalculateComplexString()
        {
            Assert.AreEqual(8, calculator.Calculate("3 * (7 - 5) + (10 / 5)"));
        }

        [TestMethod]
        public void CalculateSimpleExpression()
        {
            // Arrange
            var builder = new ExpressionBuilder(7);
            builder.Add(4);
            var expression = builder.Build();

            // Act
            int result = calculator.Calculate(expression);

            // Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void CalculateLongExpression()
        {
            // Arrange
            var builder = new ExpressionBuilder(3);
            builder.Multiply(5);
            builder.Subtract(7);
            builder.Add(2);
            builder.Divide(5);
            var expr = builder.Build();

            // Act 
            int result = calculator.Calculate(expr);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculateComplexExpression()
        {
            // Arrange
            var subtractBuilder = new ExpressionBuilder(7);
            subtractBuilder.Subtract(5);

            var divideBuilder = new ExpressionBuilder(10);
            divideBuilder.Divide(5);

            var builder = new ExpressionBuilder(3);
            builder.Multiply(subtractBuilder);
            builder.Add(divideBuilder);
            var expr = builder.Build();

            // Act
            int result = calculator.Calculate(expr);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void VisitCalculateSimple()
        {
            // Arrange
            var builder = new ExpressionBuilder(7);
            builder.Add(4);

            var visitor = new CalculateVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual(11, visitor.Result);
        }

        [TestMethod]
        public void VisitCalculateLong()
        {
            // Arrange
            var builder = new ExpressionBuilder(3);
            builder.Multiply(5);
            builder.Subtract(7);
            builder.Add(2);
            builder.Divide(5);

            var visitor = new CalculateVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual(2, visitor.Result);
        }

        [TestMethod]
        public void VisitCalculateComplex()
        {
            // Arrange
            var subtractBuilder = new ExpressionBuilder(7);
            subtractBuilder.Subtract(5);

            var divideBuilder = new ExpressionBuilder(10);
            divideBuilder.Divide(5);

            var builder = new ExpressionBuilder(3);
            builder.Multiply(subtractBuilder);
            builder.Add(divideBuilder);

            var visitor = new CalculateVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual(8, visitor.Result);
        }

        [TestMethod]
        public void VisitPrintSimple()
        {
            // Arrange
            var builder = new ExpressionBuilder(7);
            builder.Add(4);

            var visitor = new PrintVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual("7 + 4", visitor.ToString());
        }

        [TestMethod]
        public void PrintCalculateLong()
        {
            // Arrange
            var builder = new ExpressionBuilder(3);
            builder.Multiply(5);
            builder.Subtract(7);
            builder.Add(2);
            builder.Divide(5);

            var visitor = new PrintVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual("3 * 5 - 7 + 2 / 5", visitor.ToString());
        }

        [TestMethod]
        public void PrintCalculateComplex()
        {
            // Arrange
            var subtractBuilder = new ExpressionBuilder(7);
            subtractBuilder.Subtract(5);

            var divideBuilder = new ExpressionBuilder(10);
            divideBuilder.Divide(5);

            var builder = new ExpressionBuilder(3);
            builder.Multiply(subtractBuilder);
            builder.Add(divideBuilder);

            var visitor = new PrintVisitor();
            var expr = builder.Build();

            // Act
            calculator.Visit(expr, visitor);

            // Assert
            Assert.AreEqual("3 * (7 - 5) + (10 / 5)", visitor.ToString());
        }
    }
}
