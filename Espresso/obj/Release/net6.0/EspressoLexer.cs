//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Users\garng\source\repos\Espresso\Espresso\Grammar\Espresso.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Espresso.Grammar {

#pragma warning disable 3021
using Espresso;

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class EspressoLexer : Lexer {
	public const int
		TRUE=1, FALSE=2, NAME=3, LETTER=4, NUMBER=5, OPEN_PARENTHESIS=6, CLOSE_PARENTHESIS=7, 
		OPEN_SQUARE_BRACKETS=8, CLOSE_SQUARE_BRACKETS=9, OPEN_CURLY_BRACKET=10, 
		CLOSE_CURLY_BRACKET=11, COMMA=12, CARET=13, E=14, PERCENT=15, ASTERISK=16, 
		SLASH=17, PLUS=18, MINUS=19, WHITESPACE=20, ANY=21;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"TRUE", "FALSE", "NAME", "LETTER", "NUMBER", "DIGIT", "OPEN_PARENTHESIS", 
		"CLOSE_PARENTHESIS", "OPEN_SQUARE_BRACKETS", "CLOSE_SQUARE_BRACKETS", 
		"OPEN_CURLY_BRACKET", "CLOSE_CURLY_BRACKET", "COMMA", "CARET", "E", "PERCENT", 
		"ASTERISK", "SLASH", "PLUS", "MINUS", "WHITESPACE", "ANY"
	};


	public EspressoLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'true'", "'false'", null, null, null, "'('", "')'", "'['", "']'", 
		"'{'", "'}'", "','", "'^'", "'E'", "'%'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "TRUE", "FALSE", "NAME", "LETTER", "NUMBER", "OPEN_PARENTHESIS", 
		"CLOSE_PARENTHESIS", "OPEN_SQUARE_BRACKETS", "CLOSE_SQUARE_BRACKETS", 
		"OPEN_CURLY_BRACKET", "CLOSE_CURLY_BRACKET", "COMMA", "CARET", "E", "PERCENT", 
		"ASTERISK", "SLASH", "PLUS", "MINUS", "WHITESPACE", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x17r\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x4\x6\x4<\n\x4\r\x4\xE\x4=\x3\x5\x3\x5\x3\x6"+
		"\x6\x6\x43\n\x6\r\x6\xE\x6\x44\x3\x6\x3\x6\x6\x6I\n\x6\r\x6\xE\x6J\x5"+
		"\x6M\n\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f"+
		"\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12"+
		"\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16"+
		"\x3\x16\x3\x17\x3\x17\x2\x2\x2\x18\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v"+
		"\x2\a\r\x2\x2\xF\x2\b\x11\x2\t\x13\x2\n\x15\x2\v\x17\x2\f\x19\x2\r\x1B"+
		"\x2\xE\x1D\x2\xF\x1F\x2\x10!\x2\x11#\x2\x12%\x2\x13\'\x2\x14)\x2\x15+"+
		"\x2\x16-\x2\x17\x3\x2\x5\x4\x2\x43\\\x63|\x3\x2\x32;\x5\x2\v\f\xE\xF\""+
		"\"t\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2"+
		"\x2\x2\v\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2"+
		"\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B"+
		"\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2"+
		"#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3"+
		"\x2\x2\x2\x2-\x3\x2\x2\x2\x3/\x3\x2\x2\x2\x5\x34\x3\x2\x2\x2\a;\x3\x2"+
		"\x2\x2\t?\x3\x2\x2\x2\v\x42\x3\x2\x2\x2\rN\x3\x2\x2\x2\xFP\x3\x2\x2\x2"+
		"\x11R\x3\x2\x2\x2\x13T\x3\x2\x2\x2\x15V\x3\x2\x2\x2\x17X\x3\x2\x2\x2\x19"+
		"Z\x3\x2\x2\x2\x1B\\\x3\x2\x2\x2\x1D^\x3\x2\x2\x2\x1F`\x3\x2\x2\x2!\x62"+
		"\x3\x2\x2\x2#\x64\x3\x2\x2\x2%\x66\x3\x2\x2\x2\'h\x3\x2\x2\x2)j\x3\x2"+
		"\x2\x2+l\x3\x2\x2\x2-p\x3\x2\x2\x2/\x30\av\x2\x2\x30\x31\at\x2\x2\x31"+
		"\x32\aw\x2\x2\x32\x33\ag\x2\x2\x33\x4\x3\x2\x2\x2\x34\x35\ah\x2\x2\x35"+
		"\x36\a\x63\x2\x2\x36\x37\an\x2\x2\x37\x38\au\x2\x2\x38\x39\ag\x2\x2\x39"+
		"\x6\x3\x2\x2\x2:<\x5\t\x5\x2;:\x3\x2\x2\x2<=\x3\x2\x2\x2=;\x3\x2\x2\x2"+
		"=>\x3\x2\x2\x2>\b\x3\x2\x2\x2?@\t\x2\x2\x2@\n\x3\x2\x2\x2\x41\x43\x5\r"+
		"\a\x2\x42\x41\x3\x2\x2\x2\x43\x44\x3\x2\x2\x2\x44\x42\x3\x2\x2\x2\x44"+
		"\x45\x3\x2\x2\x2\x45L\x3\x2\x2\x2\x46H\a\x30\x2\x2GI\x5\r\a\x2HG\x3\x2"+
		"\x2\x2IJ\x3\x2\x2\x2JH\x3\x2\x2\x2JK\x3\x2\x2\x2KM\x3\x2\x2\x2L\x46\x3"+
		"\x2\x2\x2LM\x3\x2\x2\x2M\f\x3\x2\x2\x2NO\t\x3\x2\x2O\xE\x3\x2\x2\x2PQ"+
		"\a*\x2\x2Q\x10\x3\x2\x2\x2RS\a+\x2\x2S\x12\x3\x2\x2\x2TU\a]\x2\x2U\x14"+
		"\x3\x2\x2\x2VW\a_\x2\x2W\x16\x3\x2\x2\x2XY\a}\x2\x2Y\x18\x3\x2\x2\x2Z"+
		"[\a\x7F\x2\x2[\x1A\x3\x2\x2\x2\\]\a.\x2\x2]\x1C\x3\x2\x2\x2^_\a`\x2\x2"+
		"_\x1E\x3\x2\x2\x2`\x61\aG\x2\x2\x61 \x3\x2\x2\x2\x62\x63\a\'\x2\x2\x63"+
		"\"\x3\x2\x2\x2\x64\x65\a,\x2\x2\x65$\x3\x2\x2\x2\x66g\a\x31\x2\x2g&\x3"+
		"\x2\x2\x2hi\a-\x2\x2i(\x3\x2\x2\x2jk\a/\x2\x2k*\x3\x2\x2\x2lm\t\x4\x2"+
		"\x2mn\x3\x2\x2\x2no\b\x16\x2\x2o,\x3\x2\x2\x2pq\v\x2\x2\x2q.\x3\x2\x2"+
		"\x2\a\x2=\x44JL\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Espresso.Grammar
