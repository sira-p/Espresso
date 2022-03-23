/*
 * File: TestProject\Program.cs
 * File Created: Saturday, 19th March 2022 12:35:10 am
 * Last Modified: Wednesday, 23rd March 2022 9:30:41 pm
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

using System.Diagnostics;
using Espresso;
using MathNet.Numerics;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Quick Start */
            Expression expression = new("3E2+3*2^(1+1)");
            double result = (double) expression.Evaluate();
            Debug.Assert(result == 312);


            #region Values
            /* Integer */
            Debug.Assert((double)new Expression("2").Evaluate() == 2);
            Debug.Assert((double)new Expression("(2)").Evaluate() == 2);

            /* Float */
            Debug.Assert((double)new Expression("2.1").Evaluate() == 2.1);
            Debug.Assert((double)new Expression(".5").Evaluate() == .5);
            Debug.Assert((double)new Expression("(2.1)").Evaluate() == 2.1);
            Debug.Assert((double)new Expression("(.5)").Evaluate() == 0.5);
            Debug.Assert((double)new Expression("1+2.1").Evaluate() == 3.1);

            /* Exponential */
            Debug.Assert((double)new Expression("2E3E2").Evaluate() == 2E300);
            Debug.Assert((double)new Expression("(2E2)").Evaluate() == 200);

            /* Boolean */
            Debug.Assert((bool)new Expression("true").Evaluate() == true);
            Debug.Assert((bool)new Expression("false").Evaluate() == false);
            #endregion

            #region Basic Arithmetic Operation
            #region Binary
            /* Power (Exponentiation) */
            Debug.Assert((double)new Expression("2^3").Evaluate() == 8);
            Debug.Assert((double)new Expression("2^3^2").Evaluate() == 512);

            /* Modulo */
            Debug.Assert((double)new Expression("4%3").Evaluate() == 1);

            /* Multiplication */
            Debug.Assert((double)new Expression("3*2").Evaluate() == 6);

            /* Division */
            Debug.Assert((double)new Expression("10/3").Evaluate() == (double)10 / 3);

            /* Addition */
            Debug.Assert((double)new Expression("4+3").Evaluate() == 7);

            /* Subtraction */
            Debug.Assert((double)new Expression("4-3").Evaluate() == 1);

            /* Integration Test*/
            Debug.Assert((double)new Expression("5+1-2*3/4%5").Evaluate()
                == (double)new Expression("5+(1-(2*(3/(4%5))))").Evaluate());

            #endregion

            #region Unary
            /* Positive/Negative sign */
            Debug.Assert((double)new Expression("+1+-1").Evaluate() == 0);
            Debug.Assert((double)new Expression("(-1)").Evaluate() == -1);
            Debug.Assert((double)new Expression("2E-1").Evaluate() == 2E-1);
            Debug.Assert((double)new Expression("2^-1").Evaluate() == 0.5);
            #endregion
            #endregion

            #region Unary
            /* Percent */
            Debug.Assert((double)new Expression("40%").Evaluate() == 0.4);
            Debug.Assert((double)new Expression("+40%").Evaluate() == 0.4);
            Debug.Assert((double)new Expression("(40%)").Evaluate() == 0.4);
            Debug.Assert((double)new Expression(".5%").Evaluate() == 0.005);
            Debug.Assert((double)new Expression("4%*100").Evaluate() == 4);
            #endregion

            #region Function
            // Expression my_expression = new ("E(5)");
            // Cannot use E or E#number as function ID, it recognizes as exponential notation; need to fix :(
            #region Trigonometry
            Debug.Assert((double)new Expression("sin(50)").Evaluate() == Trig.Sin(50));
            Debug.Assert((double)new Expression("cos(50)").Evaluate() == Trig.Cos(50));
            Debug.Assert((double)new Expression("tan(50)").Evaluate() == Trig.Tan(50));
            Debug.Assert((double)new Expression("csc(50)").Evaluate() == Trig.Csc(50));
            Debug.Assert((double)new Expression("sec(50)").Evaluate() == Trig.Sec(50));
            Debug.Assert((double)new Expression("cot(50)").Evaluate() == Trig.Cot(50));

            Debug.Assert((double)new Expression("asin(0.5)").Evaluate() == Trig.Asin(0.5));
            Debug.Assert((double)new Expression("acos(0.5)").Evaluate() == Trig.Acos(0.5));
            Debug.Assert((double)new Expression("atan(0.5)").Evaluate() == Trig.Atan(0.5));
            Debug.Assert((double)new Expression("acsc(1.5)").Evaluate() == Trig.Acsc(1.5));
            Debug.Assert((double)new Expression("asec(1.5)").Evaluate() == Trig.Asec(1.5));
            Debug.Assert((double)new Expression("acot(1.5)").Evaluate() == Trig.Acot(1.5));
            Debug.Assert((double)new Expression("arcsin(0.5)").Evaluate() == Trig.Asin(0.5));
            Debug.Assert((double)new Expression("arccos(0.5)").Evaluate() == Trig.Acos(0.5));
            Debug.Assert((double)new Expression("arctan(0.5)").Evaluate() == Trig.Atan(0.5));
            Debug.Assert((double)new Expression("arccsc(1.5)").Evaluate() == Trig.Acsc(1.5));
            Debug.Assert((double)new Expression("arcsec(1.5)").Evaluate() == Trig.Asec(1.5));
            Debug.Assert((double)new Expression("arccot(1.5)").Evaluate() == Trig.Acot(1.5));
            
            Debug.Assert((double)new Expression("sinh(50)").Evaluate() == Trig.Sinh(50));
            Debug.Assert((double)new Expression("cosh(50)").Evaluate() == Trig.Cosh(50));
            Debug.Assert((double)new Expression("tanh(50)").Evaluate() == Trig.Tanh(50));
            Debug.Assert((double)new Expression("csch(50)").Evaluate() == Trig.Csch(50));
            Debug.Assert((double)new Expression("sech(50)").Evaluate() == Trig.Sech(50));
            Debug.Assert((double)new Expression("coth(50)").Evaluate() == Trig.Coth(50));
            
            Debug.Assert((double)new Expression("asinh(0.5)").Evaluate() == Trig.Asinh(0.5));
            Debug.Assert((double)new Expression("acosh(1)").Evaluate() == Trig.Acosh(1));
            Debug.Assert((double)new Expression("atanh(0.5)").Evaluate() == Trig.Atanh(0.5));
            Debug.Assert((double)new Expression("acsch(1.5)").Evaluate() == Trig.Acsch(1.5));
            Debug.Assert((double)new Expression("asech(1)").Evaluate() == Trig.Asech(1));
            Debug.Assert((double)new Expression("acoth(1.5)").Evaluate() == Trig.Acoth(1.5));
            Debug.Assert((double)new Expression("arcsinh(0.5)").Evaluate() == Trig.Asinh(0.5));
            Debug.Assert((double)new Expression("arccosh(1)").Evaluate() == Trig.Acosh(1));
            Debug.Assert((double)new Expression("arctanh(0.5)").Evaluate() == Trig.Atanh(0.5));
            Debug.Assert((double)new Expression("arccsch(1.5)").Evaluate() == Trig.Acsch(1.5));
            Debug.Assert((double)new Expression("arcsech(1)").Evaluate() == Trig.Asech(1));
            Debug.Assert((double)new Expression("arccoth(1.5)").Evaluate() == Trig.Acoth(1.5));
            #endregion
            
            #region Exponential
            /* Exp */
            Debug.Assert((double)new Expression("exp(1)").Evaluate() == Math.E);
            Debug.Assert((double)new Expression("exp(2)").Evaluate() == Math.Exp(2));

            /* Log10 */
            Debug.Assert((double)new Expression("log(10)").Evaluate() == 1);
            Debug.Assert((double)new Expression("log(27)").Evaluate() == Math.Log10(27));

            /* Ln */
            Debug.Assert((double)new Expression("ln(12)").Evaluate() == Math.Log(12));
            Debug.Assert((double)new Expression("ln(e)").Evaluate() == 1);

            /* Log2 */
            Debug.Assert((double)new Expression("log2(1)").Evaluate() == 0);
            Debug.Assert((double)new Expression("log2(21)").Evaluate() == Math.Log2(21));
            #endregion

            #region Statistics
            #endregion

            #endregion
        
            #region Constants
            Debug.Assert((double)new Expression("e").Evaluate() == Math.E);
            Debug.Assert((double)new Expression("pi").Evaluate() == Math.PI);
            Debug.Assert((double)new Expression("π").Evaluate() == Math.PI);
            Debug.Assert((double)new Expression("log2(21)").Evaluate() == Math.Log2(21));
            #endregion
        }
    }
}