/*
 * File: Espresso\EspressoType.cs
 * Espresso Version 1.0
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

namespace Espresso
{
    public enum BinaryOperatorType 
    {
        MODULO,
        MULTIPLICATION,
        DIVISION,
        ADDITION,
        SUBTRACTION,
        POWER,
        EXPONENTIAL,
    }

    public enum UnaryOperatorType
    {
        NEGATIVE,
        POSITIVE,
        NOT,
    }

    public enum PrimaryExpressionType
    {
        PARENTHESES,
        FUNCTION,
        IDENTIFIER,
        VALUE,
    }

    public enum ValueType
    {
        NUMBER,
        TRUE,
        FALSE,
    }
}
