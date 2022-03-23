/*
 * File: Grammar\Espresso.g4
 * File Created: Saturday, 19th March 2022 12:55:00 am
 * Last Modified: Wednesday, 23rd March 2022 9:44:04 pm
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

grammar Espresso;

options {
	language= CSharp;
}

@header {
#pragma warning disable 3021
using Espresso;
}

espresso: expression (SEMICOLON expression)* SEMICOLON? EOF;

expression
	returns[object type]:

	// Parenthesis
	OPEN_PARENTHESIS expression CLOSE_PARENTHESIS {$type = PrimaryExpressionType.PARENTHESES;	
		} # PrimaryExpression

	// Power
	| <assoc= right> left= expression CARET right= expression {$type = BinaryOperatorType.POWER;
		} # BinaryExpression
	// Exponential
	| <assoc= right> left= expression E right= expression {$type = BinaryOperatorType.EXPONENTIAL;
		} # BinaryExpression
	// Modulo
	| left= expression PERCENT right= expression {$type = BinaryOperatorType.MODULO;
		} # BinaryExpression
	// Percent
	| expression PERCENT {$type = UnaryOperatorType.PERCENT;} # UnaryExpression
	// Factorial
	| expression EXCLAMATION {$type = UnaryOperatorType.FACTORIAL;} # UnaryExpression
	// Multiplication
	| left= expression (ASTERISK | MUL) right= expression {$type = BinaryOperatorType.MULTIPLICATION;
		} # BinaryExpression
	// Division
	| left= expression (SLASH | DIV) right= expression {$type = BinaryOperatorType.DIVISION;
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

	// Function
	| id OPEN_PARENTHESIS (
		expression?
		| expression (COMMA expression)*
	) CLOSE_PARENTHESIS {$type = PrimaryExpressionType.FUNCTION;
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

id: NAME (NUMBER | NAME)*;

TRUE: 'true';
FALSE: 'false';

E: 'E';

NAME: (LETTER | UNDERSCORE | PI) +;
LETTER: [a-zA-Z];

NUMBER: (DIGIT+ (DOT DIGIT+)?) | DOT DIGIT+;
DOT: '.';
fragment DIGIT: [0-9];

// Overriding priority, function
OPEN_PARENTHESIS: '(';
CLOSE_PARENTHESIS: ')';
// Units
OPEN_SQUARE_BRACKETS: '[';
CLOSE_SQUARE_BRACKETS: ']';
// Arrays
OPEN_CURLY_BRACKET: '{';
CLOSE_CURLY_BRACKET: '}';
// Separating expression
SEMICOLON: ';';

ASTERISK: '*';
COMMA: ',';
CARET: '^';
DIV: '÷';
EXCLAMATION: '!';
MINUS: '-' | '−';
MUL: '×';
PERCENT: '%';
PLUS: '+';
SLASH: '/';
VBAR: '|';

UNDERSCORE: '_';
PI: 'π';

WHITESPACE:
	(
		' '
		| '\r'
		| '\t'
		| '\u000C'
		| '\n'
	) -> channel(HIDDEN);

ANY: .;