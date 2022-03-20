/*
 * File: Espresso\ExpressionException.cs
 * Espresso Version 1.1
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

namespace Espresso
{
    internal class ExpressionException : Exception
    {
        internal ExpressionException(string message) : base(message) { }

        internal ExpressionException(string message, Exception exception) : base(message, exception) { }
    }

}
