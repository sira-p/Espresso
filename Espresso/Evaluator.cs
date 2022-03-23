/*
 * File: Espresso\Evaluator.cs
 * File Created: Tuesday, 22nd March 2022 12:44:52 pm
 * Last Modified: Wednesday, 23rd March 2022 9:44:33 pm
 * Last Modified: Wednesday, 23rd March 2022 9:44:33 pm
 * Last Modified: Wednesday, 23rd March 2022 9:44:33 pm
 */

using MathNet.Numerics;
using MathNet.Numerics.Statistics;

namespace Espresso
{
    public class Evaluator
    {


        public static double EvaluateFunction(string function_id, object[] args)
        {
            switch (function_id)
            {
                #region Trigonometry
                case "sin":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Sin((double)args[0]);

                case "cos":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Cos((double)args[0]);

                case "tan":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Tan((double)args[0]);
                    
                case "csc":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return 1 / Math.Sin((double)args[0]);

                case "sec":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return 1 / Math.Cos((double)args[0]);

                case "cot":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return 1 / Math.Tan((double)args[0]);

                case "asin":
                case "arcsin":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Asin((double)args[0]);

                case "acos":
                case "arccos":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Acos((double)args[0]);

                case "atan":
                case "arctan":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Atan((double)args[0]);

                case "acsc":
                case "arccsc":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Asin(1 / (double)args[0]);

                case "asec":
                case "arcsec":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Acos(1 / (double)args[0]);

                case "acot":
                case "arccot":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Atan(1 / (double)args[0]);

                case "sinh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Sinh((double)args[0]);

                case "cosh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Cosh((double)args[0]);

                case "tanh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Tanh((double)args[0]);
                    
                case "csch":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Csch((double)args[0]);

                case "sech":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Sech((double)args[0]);

                case "coth":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Coth((double)args[0]);

                case "asinh":
                case "arcsinh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Asinh((double)args[0]);

                case "acosh":
                case "arccosh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Acosh((double)args[0]);

                case "atanh":
                case "arctanh":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Atanh((double)args[0]);

                case "acsch":
                case "arccsch":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Acsch((double)args[0]);

                case "asech":
                case "arcsech":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Asech((double)args[0]);
                    
                case "acoth":
                case "arccoth":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Trig.Acoth((double)args[0]);
                #endregion

                #region Exponential
                case "exp":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Exp((double)args[0]);

                case "log":
                    switch (args.Length){
                        case 1:
                            return Math.Log10((double)args[0]);
                        case 2:
                            return Math.Log2((double)args[0]) / Math.Log2((double)args.GetValue(1));
                        default:
                            throw new ArgumentException(String.Format("Function {0} takes 1 or 2 arguments!", function_id));
                    }

                case "ln":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Log((double)args[0]);

                case "log2":
                    if (args.Length != 1)
                        throw new ArgumentException(String.Format("Function {0} takes 1 argument!", function_id));
                    return Math.Log2((double)args[0]);
                #endregion

                #region Statistics
                case "max":
                    return ArrayStatistics.Maximum(Array.ConvertAll<object, double>(args, x => (double)x));
                case "min":
                    return ArrayStatistics.Minimum(Array.ConvertAll<object, double>(args, x => (double)x));
                case "range":
                    double[] double_args = Array.ConvertAll<object, double>(args, x => (double)x);
                    return ArrayStatistics.Maximum(double_args) - ArrayStatistics.Minimum(double_args);
                case "avg":
                case "average":
                case "mean":
                    return ArrayStatistics.Mean(Array.ConvertAll<object, double>(args, x => (double)x));
                case "geomean":
                    return ArrayStatistics.GeometricMean(Array.ConvertAll<object, double>(args, x => (double)x));
                case "harmean":
                    return ArrayStatistics.HarmonicMean(Array.ConvertAll<object, double>(args, x => (double)x));
                case "med":
                    return ArrayStatistics.MedianInplace(Array.ConvertAll<object, double>(args, x => (double)x));
                case "percentile":
                case "quartile":
                #endregion

                case "ceil":
                case "floor":
                case "factorize":
                case "sort_ascending":
                case "sort_descending":
                case "get_item":
                case "matrix":
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException(); // Custom functions planned for the future
            }
        }

        public static object EvaluateIdentifier(string id){
            switch(id){
                case "e": return Math.E;
                case "pi":
                case "π": return Math.PI;
                default:
                    throw new NotImplementedException();;
            }
        }
    }
}