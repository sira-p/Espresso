/*
 * File: Grammar\Espresso.g4
 * Espresso Version 1.0
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */
 
grammar Espresso;

options {
	language= CSharp3;
}

@header {
#pragma warning disable 3021
using Espresso;
}

espresso: (statement+ | expression) EOF;

statement: OPEN_CURLY_BRACKET expression CLOSE_CURLY_BRACKET;

expression
	returns[object type]:

	// Parenthesis
	OPEN_PARENTHESIS expression CLOSE_PARENTHESIS {$type = PrimaryExpressionType.PARENTHESES;	
		} # PrimaryExpression

	/* Binary Expressions */
	// Modulo
	| left= expression PERCENT right= expression {$type = BinaryOperatorType.MODULO;
		} # BinaryExpression
	// Multiplication
	| left= expression ASTERISK right= expression {$type = BinaryOperatorType.MULTIPLICATION;
		} # BinaryExpression
	// Division
	| left= expression SLASH right= expression {$type = BinaryOperatorType.DIVISION;
		} # BinaryExpression
	// Unary Sign
	| PLUS expression	{$type = UnaryOperatorType.POSITIVE;} # UnaryExpression
	| MINUS expression	{$type = UnaryOperatorType.NEGATIVE;} # UnaryExpression
	// Addition
	| left= expression PLUS right= expression {$type = BinaryOperatorType.ADDITION;
		} # BinaryExpression
	// Subtraction
	| left= expression MINUS right= expression {$type = BinaryOperatorType.SUBTRACTION;
		} # BinaryExpression
	// Power
	| <assoc= right> left= expression CARET right= expression {$type = BinaryOperatorType.POWER;
		} # BinaryExpression
	// Exponential
	| <assoc= right> left= expression E right= expression {$type = BinaryOperatorType.EXPONENTIAL;
		} # BinaryExpression

	/* Primary Expression */
	// Function
	| id OPEN_PARENTHESIS expression (
		COMMA expression
	)* CLOSE_PARENTHESIS {$type = PrimaryExpressionType.FUNCTION;
		} # PrimaryExpression
	// Identifier
	| id {$type = PrimaryExpressionType.IDENTIFIER;} # PrimaryExpression
	// Value
	| value {$type = PrimaryExpressionType.VALUE;} # PrimaryExpression;

value
	returns[object type]:
	NUMBER	{$type = ValueType.NUMBER;}
	| TRUE	{$type = ValueType.TRUE;}
	| FALSE	{$type = ValueType.FALSE;};

id: NAME | OPEN_SQUARE_BRACKETS NAME CLOSE_SQUARE_BRACKETS;

TRUE: 'true';
FALSE: 'false';

NAME: LETTER+;
LETTER: [a-zA-Z];

NUMBER: DIGIT+ ('.' DIGIT+)?;
fragment DIGIT: [0-9];

// Overriding priority, function
OPEN_PARENTHESIS: '(';
CLOSE_PARENTHESIS: ')';
// Identifier; constants/ variable, Note: single letter identifier can be defined without brackets
OPEN_SQUARE_BRACKETS: '[';
CLOSE_SQUARE_BRACKETS: ']';
// Equation separation for system of equations
OPEN_CURLY_BRACKET: '{';
CLOSE_CURLY_BRACKET: '}';


COMMA: ',';
CARET: '^';
E: 'E';
PERCENT: '%';
ASTERISK: '*';
SLASH: '/';
PLUS: '+';
MINUS: '-';

WHITESPACE:
	(
		' '
		| '\r'
		| '\t'
		| '\u000C'
		| '\n'
	) -> channel(HIDDEN);

ANY: .;