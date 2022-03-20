/*
 * File: Espresso\EspressoVisitor.cs
 * Espresso Version 1.0
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

using Antlr4.Runtime.Misc;

namespace Espresso.Grammar
{
    public class EspressoVisitor : EspressoBaseVisitor<double>
    {
   
        public override double VisitBinaryExpression(EspressoParser.BinaryExpressionContext context)
        {
            double left = Visit(context.left);
            double right = Visit(context.right);
            switch (context.type)
            {
                case BinaryOperatorType.MODULO:
                    return left % right;
                case BinaryOperatorType.MULTIPLICATION:
                    return left * right;
                case BinaryOperatorType.DIVISION:
                    return left / right;
                case BinaryOperatorType.ADDITION:
                    return left + right;
                case BinaryOperatorType.SUBTRACTION:
                    return left - right;
                case BinaryOperatorType.POWER:
                    return Math.Pow(left, right);
                case BinaryOperatorType.EXPONENTIAL:
                    return Convert.ToDouble(left.ToString() + "E" + right.ToString());
                default:
                    throw new NotSupportedException();
            }
        }

        public override double VisitUnaryExpression([NotNull] EspressoParser.UnaryExpressionContext context)
        {
            EspressoParser.ExpressionContext expression = context.expression();
            switch (context.type)
            {
                case UnaryOperatorType.POSITIVE:
                    return Visit(expression);
                case UnaryOperatorType.NEGATIVE:
                    return -1 * Visit(expression);
                case UnaryOperatorType.NOT:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }

        public override double VisitPrimaryExpression([NotNull] EspressoParser.PrimaryExpressionContext context)
        {
            switch (context.type)
            {
                case PrimaryExpressionType.PARENTHESES:
                    return Visit(context.expression(0));
                case PrimaryExpressionType.VALUE:
                    return VisitValue(context.value());
                case PrimaryExpressionType.FUNCTION:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }

        public override double VisitValue([NotNull] EspressoParser.ValueContext context)
        {
            switch (context.type)
            {
                case ValueType.NUMBER:
                    return  double.Parse(context.NUMBER().GetText(), System.Globalization.CultureInfo.InvariantCulture);
                case ValueType.TRUE:
                    throw new NotImplementedException();
                case ValueType.FALSE:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }

    }
}
