//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from d:\Users\garng\source\repos\Espresso\Espresso\Grammar\Espresso.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


#pragma warning disable 3021
using Espresso;

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class EspressoParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		TRUE=1, FALSE=2, E=3, NAME=4, LETTER=5, NUMBER=6, OPEN_PARENTHESIS=7, 
		CLOSE_PARENTHESIS=8, OPEN_SQUARE_BRACKETS=9, CLOSE_SQUARE_BRACKETS=10, 
		OPEN_CURLY_BRACKET=11, CLOSE_CURLY_BRACKET=12, COMMA=13, CARET=14, PERCENT=15, 
		ASTERISK=16, SLASH=17, PLUS=18, MINUS=19, WHITESPACE=20, ANY=21;
	public const int
		RULE_espresso = 0, RULE_statement = 1, RULE_expression = 2, RULE_value = 3, 
		RULE_id = 4;
	public static readonly string[] ruleNames = {
		"espresso", "statement", "expression", "value", "id"
	};

	private static readonly string[] _LiteralNames = {
		null, "'true'", "'false'", "'E'", null, null, null, "'('", "')'", "'['", 
		"']'", "'{'", "'}'", "','", "'^'", "'%'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "TRUE", "FALSE", "E", "NAME", "LETTER", "NUMBER", "OPEN_PARENTHESIS", 
		"CLOSE_PARENTHESIS", "OPEN_SQUARE_BRACKETS", "CLOSE_SQUARE_BRACKETS", 
		"OPEN_CURLY_BRACKET", "CLOSE_CURLY_BRACKET", "COMMA", "CARET", "PERCENT", 
		"ASTERISK", "SLASH", "PLUS", "MINUS", "WHITESPACE", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Espresso.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static EspressoParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public EspressoParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public EspressoParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class EspressoContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(EspressoParser.Eof, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public EspressoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_espresso; } }
	}

	[RuleVersion(0)]
	public EspressoContext espresso() {
		EspressoContext _localctx = new EspressoContext(Context, State);
		EnterRule(_localctx, 0, RULE_espresso);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_CURLY_BRACKET:
				{
				State = 11;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 10; statement();
					}
					}
					State = 13;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==OPEN_CURLY_BRACKET );
				}
				break;
			case TRUE:
			case FALSE:
			case NAME:
			case NUMBER:
			case OPEN_PARENTHESIS:
			case OPEN_SQUARE_BRACKETS:
			case PLUS:
			case MINUS:
				{
				State = 15; expression(0);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 18; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public ITerminalNode OPEN_CURLY_BRACKET() { return GetToken(EspressoParser.OPEN_CURLY_BRACKET, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode CLOSE_CURLY_BRACKET() { return GetToken(EspressoParser.CLOSE_CURLY_BRACKET, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; Match(OPEN_CURLY_BRACKET);
			State = 21; expression(0);
			State = 22; Match(CLOSE_CURLY_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public object type;
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
			this.type = context.type;
		}
	}
	public partial class PrimaryExpressionContext : ExpressionContext {
		public ITerminalNode OPEN_PARENTHESIS() { return GetToken(EspressoParser.OPEN_PARENTHESIS, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode CLOSE_PARENTHESIS() { return GetToken(EspressoParser.CLOSE_PARENTHESIS, 0); }
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public ITerminalNode[] COMMA() { return GetTokens(EspressoParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(EspressoParser.COMMA, i);
		}
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public PrimaryExpressionContext(ExpressionContext context) { CopyFrom(context); }
	}
	public partial class BinaryExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ExpressionContext right;
		public ITerminalNode PERCENT() { return GetToken(EspressoParser.PERCENT, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ASTERISK() { return GetToken(EspressoParser.ASTERISK, 0); }
		public ITerminalNode SLASH() { return GetToken(EspressoParser.SLASH, 0); }
		public ITerminalNode PLUS() { return GetToken(EspressoParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(EspressoParser.MINUS, 0); }
		public ITerminalNode CARET() { return GetToken(EspressoParser.CARET, 0); }
		public ITerminalNode E() { return GetToken(EspressoParser.E, 0); }
		public BinaryExpressionContext(ExpressionContext context) { CopyFrom(context); }
	}
	public partial class UnaryExpressionContext : ExpressionContext {
		public ITerminalNode PLUS() { return GetToken(EspressoParser.PLUS, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode MINUS() { return GetToken(EspressoParser.MINUS, 0); }
		public UnaryExpressionContext(ExpressionContext context) { CopyFrom(context); }
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 57;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 25; Match(OPEN_PARENTHESIS);
				State = 26; expression(0);
				State = 27; Match(CLOSE_PARENTHESIS);
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.PARENTHESES;	
						
				}
				break;
			case 2:
				{
				_localctx = new UnaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 30; Match(PLUS);
				State = 31; expression(9);
				((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.POSITIVE;
				}
				break;
			case 3:
				{
				_localctx = new UnaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 34; Match(MINUS);
				State = 35; expression(8);
				((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.NEGATIVE;
				}
				break;
			case 4:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 38; id();
				State = 39; Match(OPEN_PARENTHESIS);
				State = 40; expression(0);
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 41; Match(COMMA);
					State = 42; expression(0);
					}
					}
					State = 47;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 48; Match(CLOSE_PARENTHESIS);
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.FUNCTION;
						
				}
				break;
			case 5:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 51; id();
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.IDENTIFIER;
				}
				break;
			case 6:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 54; value();
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.VALUE;
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 96;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,5,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 94;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
					case 1:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 59;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 60; Match(PERCENT);
						State = 61; ((BinaryExpressionContext)_localctx).right = expression(13);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.MODULO;
						          		
						}
						break;
					case 2:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 64;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 65; Match(ASTERISK);
						State = 66; ((BinaryExpressionContext)_localctx).right = expression(12);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.MULTIPLICATION;
						          		
						}
						break;
					case 3:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 69;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 70; Match(SLASH);
						State = 71; ((BinaryExpressionContext)_localctx).right = expression(11);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.DIVISION;
						          		
						}
						break;
					case 4:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 74;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 75; Match(PLUS);
						State = 76; ((BinaryExpressionContext)_localctx).right = expression(8);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.ADDITION;
						          		
						}
						break;
					case 5:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 79;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 80; Match(MINUS);
						State = 81; ((BinaryExpressionContext)_localctx).right = expression(7);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.SUBTRACTION;
						          		
						}
						break;
					case 6:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 84;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 85; Match(CARET);
						State = 86; ((BinaryExpressionContext)_localctx).right = expression(5);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.POWER;
						          		
						}
						break;
					case 7:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 89;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 90; Match(E);
						State = 91; ((BinaryExpressionContext)_localctx).right = expression(4);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.EXPONENTIAL;
						          		
						}
						break;
					}
					} 
				}
				State = 98;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,5,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public object type;
		public ITerminalNode NUMBER() { return GetToken(EspressoParser.NUMBER, 0); }
		public ITerminalNode TRUE() { return GetToken(EspressoParser.TRUE, 0); }
		public ITerminalNode FALSE() { return GetToken(EspressoParser.FALSE, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 6, RULE_value);
		try {
			State = 105;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 99; Match(NUMBER);
				_localctx.type =  ValueType.NUMBER;
				}
				break;
			case TRUE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 101; Match(TRUE);
				_localctx.type =  ValueType.TRUE;
				}
				break;
			case FALSE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 103; Match(FALSE);
				_localctx.type =  ValueType.FALSE;
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdContext : ParserRuleContext {
		public ITerminalNode NAME() { return GetToken(EspressoParser.NAME, 0); }
		public ITerminalNode OPEN_SQUARE_BRACKETS() { return GetToken(EspressoParser.OPEN_SQUARE_BRACKETS, 0); }
		public ITerminalNode CLOSE_SQUARE_BRACKETS() { return GetToken(EspressoParser.CLOSE_SQUARE_BRACKETS, 0); }
		public IdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_id; } }
	}

	[RuleVersion(0)]
	public IdContext id() {
		IdContext _localctx = new IdContext(Context, State);
		EnterRule(_localctx, 8, RULE_id);
		try {
			State = 111;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NAME:
				EnterOuterAlt(_localctx, 1);
				{
				State = 107; Match(NAME);
				}
				break;
			case OPEN_SQUARE_BRACKETS:
				EnterOuterAlt(_localctx, 2);
				{
				State = 108; Match(OPEN_SQUARE_BRACKETS);
				State = 109; Match(NAME);
				State = 110; Match(CLOSE_SQUARE_BRACKETS);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 12);
		case 1: return Precpred(Context, 11);
		case 2: return Precpred(Context, 10);
		case 3: return Precpred(Context, 7);
		case 4: return Precpred(Context, 6);
		case 5: return Precpred(Context, 5);
		case 6: return Precpred(Context, 4);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x17', 't', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x3', '\x2', '\x6', '\x2', '\xE', '\n', '\x2', '\r', 
		'\x2', '\xE', '\x2', '\xF', '\x3', '\x2', '\x5', '\x2', '\x13', '\n', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\a', '\x4', '.', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x31', 
		'\v', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '<', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\a', '\x4', '\x61', '\n', '\x4', '\f', '\x4', '\xE', 
		'\x4', '\x64', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', 'l', '\n', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', 
		'r', '\n', '\x6', '\x3', '\x6', '\x2', '\x3', '\x6', '\a', '\x2', '\x4', 
		'\x6', '\b', '\n', '\x2', '\x2', '\x2', '\x80', '\x2', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '\x16', '\x3', '\x2', '\x2', '\x2', '\x6', 
		';', '\x3', '\x2', '\x2', '\x2', '\b', 'k', '\x3', '\x2', '\x2', '\x2', 
		'\n', 'q', '\x3', '\x2', '\x2', '\x2', '\f', '\xE', '\x5', '\x4', '\x3', 
		'\x2', '\r', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\x13', '\x5', '\x6', '\x4', '\x2', '\x12', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x12', '\x11', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\a', '\x2', '\x2', '\x3', 
		'\x15', '\x3', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\a', '\r', 
		'\x2', '\x2', '\x17', '\x18', '\x5', '\x6', '\x4', '\x2', '\x18', '\x19', 
		'\a', '\xE', '\x2', '\x2', '\x19', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x1A', '\x1B', '\b', '\x4', '\x1', '\x2', '\x1B', '\x1C', '\a', '\t', 
		'\x2', '\x2', '\x1C', '\x1D', '\x5', '\x6', '\x4', '\x2', '\x1D', '\x1E', 
		'\a', '\n', '\x2', '\x2', '\x1E', '\x1F', '\b', '\x4', '\x1', '\x2', '\x1F', 
		'<', '\x3', '\x2', '\x2', '\x2', ' ', '!', '\a', '\x14', '\x2', '\x2', 
		'!', '\"', '\x5', '\x6', '\x4', '\v', '\"', '#', '\b', '\x4', '\x1', '\x2', 
		'#', '<', '\x3', '\x2', '\x2', '\x2', '$', '%', '\a', '\x15', '\x2', '\x2', 
		'%', '&', '\x5', '\x6', '\x4', '\n', '&', '\'', '\b', '\x4', '\x1', '\x2', 
		'\'', '<', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x5', '\n', '\x6', '\x2', 
		')', '*', '\a', '\t', '\x2', '\x2', '*', '/', '\x5', '\x6', '\x4', '\x2', 
		'+', ',', '\a', '\xF', '\x2', '\x2', ',', '.', '\x5', '\x6', '\x4', '\x2', 
		'-', '+', '\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '/', '-', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x30', '\x32', '\x3', '\x2', '\x2', '\x2', '\x31', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\a', '\n', '\x2', '\x2', 
		'\x33', '\x34', '\b', '\x4', '\x1', '\x2', '\x34', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x36', '\x5', '\n', '\x6', '\x2', '\x36', '\x37', 
		'\b', '\x4', '\x1', '\x2', '\x37', '<', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x39', '\x5', '\b', '\x5', '\x2', '\x39', ':', '\b', '\x4', '\x1', '\x2', 
		':', '<', '\x3', '\x2', '\x2', '\x2', ';', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', ';', ' ', '\x3', '\x2', '\x2', '\x2', ';', '$', '\x3', '\x2', '\x2', 
		'\x2', ';', '(', '\x3', '\x2', '\x2', '\x2', ';', '\x35', '\x3', '\x2', 
		'\x2', '\x2', ';', '\x38', '\x3', '\x2', '\x2', '\x2', '<', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '=', '>', '\f', '\xE', '\x2', '\x2', '>', '?', '\a', 
		'\x11', '\x2', '\x2', '?', '@', '\x5', '\x6', '\x4', '\xF', '@', '\x41', 
		'\b', '\x4', '\x1', '\x2', '\x41', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'\x42', '\x43', '\f', '\r', '\x2', '\x2', '\x43', '\x44', '\a', '\x12', 
		'\x2', '\x2', '\x44', '\x45', '\x5', '\x6', '\x4', '\xE', '\x45', '\x46', 
		'\b', '\x4', '\x1', '\x2', '\x46', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'G', 'H', '\f', '\f', '\x2', '\x2', 'H', 'I', '\a', '\x13', '\x2', '\x2', 
		'I', 'J', '\x5', '\x6', '\x4', '\r', 'J', 'K', '\b', '\x4', '\x1', '\x2', 
		'K', '\x61', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\f', '\t', '\x2', 
		'\x2', 'M', 'N', '\a', '\x14', '\x2', '\x2', 'N', 'O', '\x5', '\x6', '\x4', 
		'\n', 'O', 'P', '\b', '\x4', '\x1', '\x2', 'P', '\x61', '\x3', '\x2', 
		'\x2', '\x2', 'Q', 'R', '\f', '\b', '\x2', '\x2', 'R', 'S', '\a', '\x15', 
		'\x2', '\x2', 'S', 'T', '\x5', '\x6', '\x4', '\t', 'T', 'U', '\b', '\x4', 
		'\x1', '\x2', 'U', '\x61', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\f', 
		'\a', '\x2', '\x2', 'W', 'X', '\a', '\x10', '\x2', '\x2', 'X', 'Y', '\x5', 
		'\x6', '\x4', '\a', 'Y', 'Z', '\b', '\x4', '\x1', '\x2', 'Z', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '[', '\\', '\f', '\x6', '\x2', '\x2', '\\', 
		']', '\a', '\x5', '\x2', '\x2', ']', '^', '\x5', '\x6', '\x4', '\x6', 
		'^', '_', '\b', '\x4', '\x1', '\x2', '_', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '`', '=', '\x3', '\x2', '\x2', '\x2', '`', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '`', 'G', '\x3', '\x2', '\x2', '\x2', '`', 'L', '\x3', '\x2', 
		'\x2', '\x2', '`', 'Q', '\x3', '\x2', '\x2', '\x2', '`', 'V', '\x3', '\x2', 
		'\x2', '\x2', '`', '[', '\x3', '\x2', '\x2', '\x2', '\x61', '\x64', '\x3', 
		'\x2', '\x2', '\x2', '\x62', '`', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x63', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x64', '\x62', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', 
		'\b', '\x2', '\x2', '\x66', 'l', '\b', '\x5', '\x1', '\x2', 'g', 'h', 
		'\a', '\x3', '\x2', '\x2', 'h', 'l', '\b', '\x5', '\x1', '\x2', 'i', 'j', 
		'\a', '\x4', '\x2', '\x2', 'j', 'l', '\b', '\x5', '\x1', '\x2', 'k', '\x65', 
		'\x3', '\x2', '\x2', '\x2', 'k', 'g', '\x3', '\x2', '\x2', '\x2', 'k', 
		'i', '\x3', '\x2', '\x2', '\x2', 'l', '\t', '\x3', '\x2', '\x2', '\x2', 
		'm', 'r', '\a', '\x6', '\x2', '\x2', 'n', 'o', '\a', '\v', '\x2', '\x2', 
		'o', 'p', '\a', '\x6', '\x2', '\x2', 'p', 'r', '\a', '\f', '\x2', '\x2', 
		'q', 'm', '\x3', '\x2', '\x2', '\x2', 'q', 'n', '\x3', '\x2', '\x2', '\x2', 
		'r', '\v', '\x3', '\x2', '\x2', '\x2', '\n', '\xF', '\x12', '/', ';', 
		'`', '\x62', 'k', 'q',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
