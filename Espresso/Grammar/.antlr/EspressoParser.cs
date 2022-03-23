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
		TRUE=1, FALSE=2, E=3, NAME=4, LETTER=5, NUMBER=6, DOT=7, OPEN_PARENTHESIS=8, 
		CLOSE_PARENTHESIS=9, OPEN_SQUARE_BRACKETS=10, CLOSE_SQUARE_BRACKETS=11, 
		OPEN_CURLY_BRACKET=12, CLOSE_CURLY_BRACKET=13, SEMICOLON=14, ASTERISK=15, 
		COMMA=16, CARET=17, DIV=18, EXCLAMATION=19, MINUS=20, MUL=21, PERCENT=22, 
		PLUS=23, SLASH=24, VBAR=25, UNDERSCORE=26, PI=27, WHITESPACE=28, ANY=29;
	public const int
		RULE_espresso = 0, RULE_expression = 1, RULE_value = 2, RULE_id = 3;
	public static readonly string[] ruleNames = {
		"espresso", "expression", "value", "id"
	};

	private static readonly string[] _LiteralNames = {
		null, "'true'", "'false'", "'E'", null, null, null, "'.'", "'('", "')'", 
		"'['", "']'", "'{'", "'}'", "';'", "'*'", "','", "'^'", "'\u00C3\u00B7'", 
		"'!'", null, "'\u00C3\u2014'", "'%'", "'+'", "'/'", "'|'", "'_'", "'\u00CF\u20AC'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "TRUE", "FALSE", "E", "NAME", "LETTER", "NUMBER", "DOT", "OPEN_PARENTHESIS", 
		"CLOSE_PARENTHESIS", "OPEN_SQUARE_BRACKETS", "CLOSE_SQUARE_BRACKETS", 
		"OPEN_CURLY_BRACKET", "CLOSE_CURLY_BRACKET", "SEMICOLON", "ASTERISK", 
		"COMMA", "CARET", "DIV", "EXCLAMATION", "MINUS", "MUL", "PERCENT", "PLUS", 
		"SLASH", "VBAR", "UNDERSCORE", "PI", "WHITESPACE", "ANY"
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
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode Eof() { return GetToken(EspressoParser.Eof, 0); }
		public ITerminalNode[] SEMICOLON() { return GetTokens(EspressoParser.SEMICOLON); }
		public ITerminalNode SEMICOLON(int i) {
			return GetToken(EspressoParser.SEMICOLON, i);
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
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 8; expression(0);
			State = 13;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 9; Match(SEMICOLON);
					State = 10; expression(0);
					}
					} 
				}
				State = 15;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			}
			State = 17;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 16; Match(SEMICOLON);
				}
			}

			State = 19; Match(Eof);
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
		public ITerminalNode CARET() { return GetToken(EspressoParser.CARET, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode E() { return GetToken(EspressoParser.E, 0); }
		public ITerminalNode PERCENT() { return GetToken(EspressoParser.PERCENT, 0); }
		public ITerminalNode ASTERISK() { return GetToken(EspressoParser.ASTERISK, 0); }
		public ITerminalNode MUL() { return GetToken(EspressoParser.MUL, 0); }
		public ITerminalNode SLASH() { return GetToken(EspressoParser.SLASH, 0); }
		public ITerminalNode DIV() { return GetToken(EspressoParser.DIV, 0); }
		public ITerminalNode PLUS() { return GetToken(EspressoParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(EspressoParser.MINUS, 0); }
		public BinaryExpressionContext(ExpressionContext context) { CopyFrom(context); }
	}
	public partial class UnaryExpressionContext : ExpressionContext {
		public ITerminalNode PLUS() { return GetToken(EspressoParser.PLUS, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode MINUS() { return GetToken(EspressoParser.MINUS, 0); }
		public ITerminalNode PERCENT() { return GetToken(EspressoParser.PERCENT, 0); }
		public ITerminalNode EXCLAMATION() { return GetToken(EspressoParser.EXCLAMATION, 0); }
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
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 59;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 22; Match(OPEN_PARENTHESIS);
				State = 23; expression(0);
				State = 24; Match(CLOSE_PARENTHESIS);
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.PARENTHESES;	
						
				}
				break;
			case 2:
				{
				_localctx = new UnaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 27; Match(PLUS);
				State = 28; expression(7);
				((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.POSITIVE;
				}
				break;
			case 3:
				{
				_localctx = new UnaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 31; Match(MINUS);
				State = 32; expression(6);
				((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.NEGATIVE;
				}
				break;
			case 4:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 35; id();
				State = 36; Match(OPEN_PARENTHESIS);
				State = 48;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
				case 1:
					{
					State = 38;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TRUE) | (1L << FALSE) | (1L << NAME) | (1L << NUMBER) | (1L << OPEN_PARENTHESIS) | (1L << MINUS) | (1L << PLUS))) != 0)) {
						{
						State = 37; expression(0);
						}
					}

					}
					break;
				case 2:
					{
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
					}
					break;
				}
				State = 50; Match(CLOSE_PARENTHESIS);
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.FUNCTION;
						
				}
				break;
			case 5:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 53; id();
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.IDENTIFIER;
				}
				break;
			case 6:
				{
				_localctx = new PrimaryExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 56; value();
				((PrimaryExpressionContext)_localctx).type =  PrimaryExpressionType.VALUE;
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 104;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 102;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
					case 1:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 61;
						if (!(Precpred(Context, 14))) throw new FailedPredicateException(this, "Precpred(Context, 14)");
						State = 62; Match(CARET);
						State = 63; ((BinaryExpressionContext)_localctx).right = expression(14);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.POWER;
						          		
						}
						break;
					case 2:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 66;
						if (!(Precpred(Context, 13))) throw new FailedPredicateException(this, "Precpred(Context, 13)");
						State = 67; Match(E);
						State = 68; ((BinaryExpressionContext)_localctx).right = expression(13);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.EXPONENTIAL;
						          		
						}
						break;
					case 3:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 71;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 72; Match(PERCENT);
						State = 73; ((BinaryExpressionContext)_localctx).right = expression(13);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.MODULO;
						          		
						}
						break;
					case 4:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 76;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 77;
						_la = TokenStream.LA(1);
						if ( !(_la==ASTERISK || _la==MUL) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 78; ((BinaryExpressionContext)_localctx).right = expression(10);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.MULTIPLICATION;
						          		
						}
						break;
					case 5:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 81;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 82;
						_la = TokenStream.LA(1);
						if ( !(_la==DIV || _la==SLASH) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 83; ((BinaryExpressionContext)_localctx).right = expression(9);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.DIVISION;
						          		
						}
						break;
					case 6:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 86;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 87; Match(PLUS);
						State = 88; ((BinaryExpressionContext)_localctx).right = expression(6);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.ADDITION;
						          		
						}
						break;
					case 7:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 91;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 92; Match(MINUS);
						State = 93; ((BinaryExpressionContext)_localctx).right = expression(5);
						((BinaryExpressionContext)_localctx).type =  BinaryOperatorType.SUBTRACTION;
						          		
						}
						break;
					case 8:
						{
						_localctx = new UnaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 96;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 97; Match(PERCENT);
						((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.PERCENT;
						}
						break;
					case 9:
						{
						_localctx = new UnaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 99;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 100; Match(EXCLAMATION);
						((UnaryExpressionContext)_localctx).type =  UnaryOperatorType.FACTORIAL;
						}
						break;
					}
					} 
				}
				State = 106;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
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
		EnterRule(_localctx, 4, RULE_value);
		try {
			State = 113;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 107; Match(NUMBER);
				_localctx.type =  ValueType.NUMBER;
				}
				break;
			case TRUE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 109; Match(TRUE);
				_localctx.type =  ValueType.TRUE;
				}
				break;
			case FALSE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 111; Match(FALSE);
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
		public ITerminalNode[] NAME() { return GetTokens(EspressoParser.NAME); }
		public ITerminalNode NAME(int i) {
			return GetToken(EspressoParser.NAME, i);
		}
		public ITerminalNode[] NUMBER() { return GetTokens(EspressoParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(EspressoParser.NUMBER, i);
		}
		public IdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_id; } }
	}

	[RuleVersion(0)]
	public IdContext id() {
		IdContext _localctx = new IdContext(Context, State);
		EnterRule(_localctx, 6, RULE_id);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 115; Match(NAME);
			State = 119;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 116;
					_la = TokenStream.LA(1);
					if ( !(_la==NAME || _la==NUMBER) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					} 
				}
				State = 121;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			}
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
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 14);
		case 1: return Precpred(Context, 13);
		case 2: return Precpred(Context, 12);
		case 3: return Precpred(Context, 9);
		case 4: return Precpred(Context, 8);
		case 5: return Precpred(Context, 5);
		case 6: return Precpred(Context, 4);
		case 7: return Precpred(Context, 11);
		case 8: return Precpred(Context, 10);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1F', '}', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\xE', '\n', '\x2', '\f', 
		'\x2', '\xE', '\x2', '\x11', '\v', '\x2', '\x3', '\x2', '\x5', '\x2', 
		'\x14', '\n', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x5', '\x3', ')', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\a', '\x3', '.', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x31', 
		'\v', '\x3', '\x5', '\x3', '\x33', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '>', '\n', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\a', '\x3', 'i', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 'l', '\v', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x5', '\x4', 't', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\a', '\x5', 'x', '\n', '\x5', '\f', '\x5', '\xE', '\x5', '{', '\v', '\x5', 
		'\x3', '\x5', '\x2', '\x3', '\x4', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', 
		'\x5', '\x4', '\x2', '\x11', '\x11', '\x17', '\x17', '\x4', '\x2', '\x14', 
		'\x14', '\x1A', '\x1A', '\x4', '\x2', '\x6', '\x6', '\b', '\b', '\x2', 
		'\x8E', '\x2', '\n', '\x3', '\x2', '\x2', '\x2', '\x4', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x6', 's', '\x3', '\x2', '\x2', '\x2', '\b', 'u', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\xF', '\x5', '\x4', '\x3', '\x2', '\v', '\f', 
		'\a', '\x10', '\x2', '\x2', '\f', '\xE', '\x5', '\x4', '\x3', '\x2', '\r', 
		'\v', '\x3', '\x2', '\x2', '\x2', '\xE', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x13', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x12', '\x14', '\a', '\x10', '\x2', 
		'\x2', '\x13', '\x12', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x15', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x16', '\a', '\x2', '\x2', '\x3', '\x16', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x18', '\b', '\x3', '\x1', '\x2', '\x18', '\x19', '\a', 
		'\n', '\x2', '\x2', '\x19', '\x1A', '\x5', '\x4', '\x3', '\x2', '\x1A', 
		'\x1B', '\a', '\v', '\x2', '\x2', '\x1B', '\x1C', '\b', '\x3', '\x1', 
		'\x2', '\x1C', '>', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', 
		'\x19', '\x2', '\x2', '\x1E', '\x1F', '\x5', '\x4', '\x3', '\t', '\x1F', 
		' ', '\b', '\x3', '\x1', '\x2', ' ', '>', '\x3', '\x2', '\x2', '\x2', 
		'!', '\"', '\a', '\x16', '\x2', '\x2', '\"', '#', '\x5', '\x4', '\x3', 
		'\b', '#', '$', '\b', '\x3', '\x1', '\x2', '$', '>', '\x3', '\x2', '\x2', 
		'\x2', '%', '&', '\x5', '\b', '\x5', '\x2', '&', '\x32', '\a', '\n', '\x2', 
		'\x2', '\'', ')', '\x5', '\x4', '\x3', '\x2', '(', '\'', '\x3', '\x2', 
		'\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', ')', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '*', '/', '\x5', '\x4', '\x3', '\x2', '+', ',', '\a', 
		'\x12', '\x2', '\x2', ',', '.', '\x5', '\x4', '\x3', '\x2', '-', '+', 
		'\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', 
		'-', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x30', '\x33', '\x3', '\x2', '\x2', '\x2', '\x31', '/', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '(', '\x3', '\x2', '\x2', '\x2', '\x32', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', '\x2', '\x2', '\x34', 
		'\x35', '\a', '\v', '\x2', '\x2', '\x35', '\x36', '\b', '\x3', '\x1', 
		'\x2', '\x36', '>', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\x5', 
		'\b', '\x5', '\x2', '\x38', '\x39', '\b', '\x3', '\x1', '\x2', '\x39', 
		'>', '\x3', '\x2', '\x2', '\x2', ':', ';', '\x5', '\x6', '\x4', '\x2', 
		';', '<', '\b', '\x3', '\x1', '\x2', '<', '>', '\x3', '\x2', '\x2', '\x2', 
		'=', '\x17', '\x3', '\x2', '\x2', '\x2', '=', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '=', '!', '\x3', '\x2', '\x2', '\x2', '=', '%', '\x3', '\x2', '\x2', 
		'\x2', '=', '\x37', '\x3', '\x2', '\x2', '\x2', '=', ':', '\x3', '\x2', 
		'\x2', '\x2', '>', 'j', '\x3', '\x2', '\x2', '\x2', '?', '@', '\f', '\x10', 
		'\x2', '\x2', '@', '\x41', '\a', '\x13', '\x2', '\x2', '\x41', '\x42', 
		'\x5', '\x4', '\x3', '\x10', '\x42', '\x43', '\b', '\x3', '\x1', '\x2', 
		'\x43', 'i', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\f', '\xF', 
		'\x2', '\x2', '\x45', '\x46', '\a', '\x5', '\x2', '\x2', '\x46', 'G', 
		'\x5', '\x4', '\x3', '\xF', 'G', 'H', '\b', '\x3', '\x1', '\x2', 'H', 
		'i', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\f', '\xE', '\x2', '\x2', 
		'J', 'K', '\a', '\x18', '\x2', '\x2', 'K', 'L', '\x5', '\x4', '\x3', '\xF', 
		'L', 'M', '\b', '\x3', '\x1', '\x2', 'M', 'i', '\x3', '\x2', '\x2', '\x2', 
		'N', 'O', '\f', '\v', '\x2', '\x2', 'O', 'P', '\t', '\x2', '\x2', '\x2', 
		'P', 'Q', '\x5', '\x4', '\x3', '\f', 'Q', 'R', '\b', '\x3', '\x1', '\x2', 
		'R', 'i', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\f', '\n', '\x2', '\x2', 
		'T', 'U', '\t', '\x3', '\x2', '\x2', 'U', 'V', '\x5', '\x4', '\x3', '\v', 
		'V', 'W', '\b', '\x3', '\x1', '\x2', 'W', 'i', '\x3', '\x2', '\x2', '\x2', 
		'X', 'Y', '\f', '\a', '\x2', '\x2', 'Y', 'Z', '\a', '\x19', '\x2', '\x2', 
		'Z', '[', '\x5', '\x4', '\x3', '\b', '[', '\\', '\b', '\x3', '\x1', '\x2', 
		'\\', 'i', '\x3', '\x2', '\x2', '\x2', ']', '^', '\f', '\x6', '\x2', '\x2', 
		'^', '_', '\a', '\x16', '\x2', '\x2', '_', '`', '\x5', '\x4', '\x3', '\a', 
		'`', '\x61', '\b', '\x3', '\x1', '\x2', '\x61', 'i', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x63', '\f', '\r', '\x2', '\x2', '\x63', '\x64', '\a', 
		'\x18', '\x2', '\x2', '\x64', 'i', '\b', '\x3', '\x1', '\x2', '\x65', 
		'\x66', '\f', '\f', '\x2', '\x2', '\x66', 'g', '\a', '\x15', '\x2', '\x2', 
		'g', 'i', '\b', '\x3', '\x1', '\x2', 'h', '?', '\x3', '\x2', '\x2', '\x2', 
		'h', '\x44', '\x3', '\x2', '\x2', '\x2', 'h', 'I', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'N', '\x3', '\x2', '\x2', '\x2', 'h', 'S', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'X', '\x3', '\x2', '\x2', '\x2', 'h', ']', '\x3', '\x2', '\x2', 
		'\x2', 'h', '\x62', '\x3', '\x2', '\x2', '\x2', 'h', '\x65', '\x3', '\x2', 
		'\x2', '\x2', 'i', 'l', '\x3', '\x2', '\x2', '\x2', 'j', 'h', '\x3', '\x2', 
		'\x2', '\x2', 'j', 'k', '\x3', '\x2', '\x2', '\x2', 'k', '\x5', '\x3', 
		'\x2', '\x2', '\x2', 'l', 'j', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\a', 
		'\b', '\x2', '\x2', 'n', 't', '\b', '\x4', '\x1', '\x2', 'o', 'p', '\a', 
		'\x3', '\x2', '\x2', 'p', 't', '\b', '\x4', '\x1', '\x2', 'q', 'r', '\a', 
		'\x4', '\x2', '\x2', 'r', 't', '\b', '\x4', '\x1', '\x2', 's', 'm', '\x3', 
		'\x2', '\x2', '\x2', 's', 'o', '\x3', '\x2', '\x2', '\x2', 's', 'q', '\x3', 
		'\x2', '\x2', '\x2', 't', '\a', '\x3', '\x2', '\x2', '\x2', 'u', 'y', 
		'\a', '\x6', '\x2', '\x2', 'v', 'x', '\t', '\x4', '\x2', '\x2', 'w', 'v', 
		'\x3', '\x2', '\x2', '\x2', 'x', '{', '\x3', '\x2', '\x2', '\x2', 'y', 
		'w', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\x3', '\x2', '\x2', '\x2', 
		'z', '\t', '\x3', '\x2', '\x2', '\x2', '{', 'y', '\x3', '\x2', '\x2', 
		'\x2', '\f', '\xF', '\x13', '(', '/', '\x32', '=', 'h', 'j', 's', 'y',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
