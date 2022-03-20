/*
 * File: Espresso\Expression.cs
 * Espresso Version 1.1
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

using Antlr4.Runtime;
using Espresso.Grammar;

namespace Espresso
{
    public class Expression
    {
        public readonly string InitialExpression;
        public EspressoParser.ExpressionContext? ParsedExpression { get; private set; }
        public string Error { get; private set; }

        public Expression(string expression)
        {
            if (String.IsNullOrEmpty(expression))
            {
                throw new ArgumentNullException(nameof(expression), "Expression cannot be empty!");
            }

            InitialExpression = expression;
            Error = "";
        }

        public static EspressoParser.ExpressionContext Compile(string expression)
        {
            ICharStream stream = new AntlrInputStream(expression);
            ITokenSource lexer = new EspressoLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            EspressoParser parser = new (tokens);
            EspressoParser.ExpressionContext context = parser.expression();
            return context;
        }

        public bool HasError()
        {
            if (ParsedExpression is null)
            {
                try { ParsedExpression = Compile(InitialExpression); }
                catch (Exception ex) { Error = String.Format("{0}: {1}", ex, ex.Message); }
            }
            return ! String.IsNullOrEmpty(Error);
        }

        public double Eval()
        {
            if (HasError())
            {
                throw new ExpressionException(Error);
            }

            return new EspressoVisitor().Visit(ParsedExpression);
        }
    }
}