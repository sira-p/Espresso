/*
 * File: Espresso\EspressoVisitor.cs
 * File Created: Saturday, 19th March 2022 1:19:51 am
 * Last Modified: Wednesday, 23rd March 2022 9:44:14 pm
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

using Antlr4.Runtime.Misc;
using MathNet.Numerics;

namespace Espresso.Grammar
{
    public class EspressoVisitor : EspressoBaseVisitor<object>
    {
   
        public override object VisitBinaryExpression(EspressoParser.BinaryExpressionContext context)
        {
            double left = (double) Visit(context.left);
            double right = (double) Visit(context.right);
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

        public override object VisitUnaryExpression([NotNull] EspressoParser.UnaryExpressionContext context)
        {
            EspressoParser.ExpressionContext expression = context.expression();
            switch (context.type)
            {
                case UnaryOperatorType.POSITIVE:
                    return (double) Visit(expression);
                case UnaryOperatorType.NEGATIVE:
                    return -1 * (double) Visit(expression);
                case UnaryOperatorType.PERCENT:
                    return (double) Visit(expression) / 100;
                case UnaryOperatorType.FACTORIAL:
                    return SpecialFunctions.Factorial((int) Visit(expression));
                case UnaryOperatorType.NOT:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }

        public override object VisitPrimaryExpression([NotNull] EspressoParser.PrimaryExpressionContext context)
        {
            switch (context.type)
            {
                case PrimaryExpressionType.PARENTHESES:
                    return Visit(context.expression(0));
                case PrimaryExpressionType.VALUE:
                    return Visit(context.value());
                case PrimaryExpressionType.FUNCTION:
                    object[] Args = context.expression().Select(x => Visit(x)).ToArray();
                    try {
                        return Evaluator.EvaluateFunction(context.id().GetText(), Args);
                    } catch (InvalidCastException){
                        throw new ArgumentException(String.Format("Function {0} received incorrect argument type.", context.id().GetText()));
                    }
                case PrimaryExpressionType.IDENTIFIER:
                    return Evaluator.EvaluateIdentifier(context.id().GetText());
                default:
                    throw new NotSupportedException();
            }
        }

        public override object VisitValue([NotNull] EspressoParser.ValueContext context)
        {
            switch (context.type)
            {
                case ValueType.NUMBER:
                    return double.Parse(context.NUMBER().GetText(), System.Globalization.CultureInfo.InvariantCulture);
                case ValueType.TRUE:
                    return true;
                case ValueType.FALSE:
                    return false;
                default:
                    throw new NotSupportedException();
            }
        }

    }
}
