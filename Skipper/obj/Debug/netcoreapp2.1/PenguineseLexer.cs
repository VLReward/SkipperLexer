//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\AMD\Skipper\Skipper\Penguinese.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Skipper {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PenguineseLexer : Lexer {
	public const int
		NUMERAL=1, OPERATOR=2, PLUS=3, COND=4, SepCOND=5, TERM=6, COM=7, OP=8, 
		CP=9, OBR=10, CBR=11, OCB=12, CCB=13, DEC=14, EQUALS=15, COL=16, IF=17, 
		RENE=18, THEN=19, WHILE=20, FOR=21, FUNC=22, MAIN=23, DOUBLE=24, CHARACTER=25, 
		TEXT=26, NUMBER=27, ARRAYOF=28, BOOLEAN=29, HALT=30, RETURN=31, READ=32, 
		WRITE=33, LETTER=34, CHAR=35, WORD=36, STRING=37, WHITESPACE=38;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LOWERCASE", "UPPERCASE", "NUMERAL", "OPERATOR", "PLUS", "COND", "SepCOND", 
		"TERM", "COM", "OP", "CP", "OBR", "CBR", "OCB", "CCB", "DEC", "EQUALS", 
		"COL", "IF", "RENE", "THEN", "WHILE", "FOR", "FUNC", "MAIN", "DOUBLE", 
		"CHARACTER", "TEXT", "NUMBER", "ARRAYOF", "BOOLEAN", "HALT", "RETURN", 
		"READ", "WRITE", "LETTER", "CHAR", "WORD", "STRING", "WHITESPACE"
	};


	public PenguineseLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'+'", null, null, "';'", "','", "'('", "')'", "'['", 
		"']'", "'{'", "'}'", "'.'", "'='", "':'", "'if'", "'rene'", "'then'", 
		"'while'", "'for'", "'func'", "'main'", "'double'", "'character'", "'text'", 
		"'number'", "'arrayof'", "'boolean'", "'NOOT NOOT'", "'regresar'", "'imprimirVar'", 
		"'escribirVar'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMERAL", "OPERATOR", "PLUS", "COND", "SepCOND", "TERM", "COM", 
		"OP", "CP", "OBR", "CBR", "OCB", "CCB", "DEC", "EQUALS", "COL", "IF", 
		"RENE", "THEN", "WHILE", "FOR", "FUNC", "MAIN", "DOUBLE", "CHARACTER", 
		"TEXT", "NUMBER", "ARRAYOF", "BOOLEAN", "HALT", "RETURN", "READ", "WRITE", 
		"LETTER", "CHAR", "WORD", "STRING", "WHITESPACE"
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

	public override string GrammarFileName { get { return "Penguinese.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2(\x128\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x4\x6\x4Y\n\x4\r\x4\xE\x4Z\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\am"+
		"\n\a\x3\b\x3\b\x3\b\x3\b\x5\bs\n\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f"+
		"\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3"+
		"\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3"+
		"\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3"+
		"\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3"+
		"\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3"+
		"\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3"+
		"\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!"+
		"\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3"+
		"\"\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3"+
		"$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3%\x3%\x5%\x106\n%\x3&\x3&\x3&\x3&\x3\'"+
		"\x3\'\x3\'\a\'\x10F\n\'\f\'\xE\'\x112\v\'\x3(\x3(\a(\x116\n(\f(\xE(\x119"+
		"\v(\x3(\x3(\x3)\x3)\x5)\x11F\n)\x3)\x3)\x6)\x123\n)\r)\xE)\x124\x3)\x3"+
		")\x3\x117\x2\x2*\x3\x2\x2\x5\x2\x2\a\x2\x3\t\x2\x4\v\x2\x5\r\x2\x6\xF"+
		"\x2\a\x11\x2\b\x13\x2\t\x15\x2\n\x17\x2\v\x19\x2\f\x1B\x2\r\x1D\x2\xE"+
		"\x1F\x2\xF!\x2\x10#\x2\x11%\x2\x12\'\x2\x13)\x2\x14+\x2\x15-\x2\x16/\x2"+
		"\x17\x31\x2\x18\x33\x2\x19\x35\x2\x1A\x37\x2\x1B\x39\x2\x1C;\x2\x1D=\x2"+
		"\x1E?\x2\x1F\x41\x2 \x43\x2!\x45\x2\"G\x2#I\x2$K\x2%M\x2&O\x2\'Q\x2(\x3"+
		"\x2\a\x3\x2\x63|\x3\x2\x43\\\x3\x2\x32;\x5\x2,-//\x31\x31\x4\x2\v\v\""+
		"\"\x136\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15"+
		"\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2"+
		"\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2"+
		"\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-"+
		"\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2"+
		"\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2"+
		"\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2"+
		"\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2"+
		"M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x3S\x3\x2\x2\x2\x5U\x3\x2"+
		"\x2\x2\aX\x3\x2\x2\x2\t\\\x3\x2\x2\x2\v^\x3\x2\x2\x2\rl\x3\x2\x2\x2\xF"+
		"r\x3\x2\x2\x2\x11t\x3\x2\x2\x2\x13v\x3\x2\x2\x2\x15x\x3\x2\x2\x2\x17z"+
		"\x3\x2\x2\x2\x19|\x3\x2\x2\x2\x1B~\x3\x2\x2\x2\x1D\x80\x3\x2\x2\x2\x1F"+
		"\x82\x3\x2\x2\x2!\x84\x3\x2\x2\x2#\x86\x3\x2\x2\x2%\x88\x3\x2\x2\x2\'"+
		"\x8A\x3\x2\x2\x2)\x8D\x3\x2\x2\x2+\x92\x3\x2\x2\x2-\x97\x3\x2\x2\x2/\x9D"+
		"\x3\x2\x2\x2\x31\xA1\x3\x2\x2\x2\x33\xA6\x3\x2\x2\x2\x35\xAB\x3\x2\x2"+
		"\x2\x37\xB2\x3\x2\x2\x2\x39\xBC\x3\x2\x2\x2;\xC1\x3\x2\x2\x2=\xC8\x3\x2"+
		"\x2\x2?\xD0\x3\x2\x2\x2\x41\xD8\x3\x2\x2\x2\x43\xE2\x3\x2\x2\x2\x45\xEB"+
		"\x3\x2\x2\x2G\xF7\x3\x2\x2\x2I\x105\x3\x2\x2\x2K\x107\x3\x2\x2\x2M\x110"+
		"\x3\x2\x2\x2O\x113\x3\x2\x2\x2Q\x122\x3\x2\x2\x2ST\t\x2\x2\x2T\x4\x3\x2"+
		"\x2\x2UV\t\x3\x2\x2V\x6\x3\x2\x2\x2WY\t\x4\x2\x2XW\x3\x2\x2\x2YZ\x3\x2"+
		"\x2\x2ZX\x3\x2\x2\x2Z[\x3\x2\x2\x2[\b\x3\x2\x2\x2\\]\t\x5\x2\x2]\n\x3"+
		"\x2\x2\x2^_\a-\x2\x2_\f\x3\x2\x2\x2`\x61\a?\x2\x2\x61m\a@\x2\x2\x62\x63"+
		"\a?\x2\x2\x63m\a?\x2\x2\x64\x65\a>\x2\x2\x65m\a?\x2\x2\x66m\a>\x2\x2g"+
		"h\a@\x2\x2hm\a?\x2\x2im\a@\x2\x2jk\a#\x2\x2km\a?\x2\x2l`\x3\x2\x2\x2l"+
		"\x62\x3\x2\x2\x2l\x64\x3\x2\x2\x2l\x66\x3\x2\x2\x2lg\x3\x2\x2\x2li\x3"+
		"\x2\x2\x2lj\x3\x2\x2\x2m\xE\x3\x2\x2\x2no\a(\x2\x2os\a(\x2\x2pq\a~\x2"+
		"\x2qs\a~\x2\x2rn\x3\x2\x2\x2rp\x3\x2\x2\x2s\x10\x3\x2\x2\x2tu\a=\x2\x2"+
		"u\x12\x3\x2\x2\x2vw\a.\x2\x2w\x14\x3\x2\x2\x2xy\a*\x2\x2y\x16\x3\x2\x2"+
		"\x2z{\a+\x2\x2{\x18\x3\x2\x2\x2|}\a]\x2\x2}\x1A\x3\x2\x2\x2~\x7F\a_\x2"+
		"\x2\x7F\x1C\x3\x2\x2\x2\x80\x81\a}\x2\x2\x81\x1E\x3\x2\x2\x2\x82\x83\a"+
		"\x7F\x2\x2\x83 \x3\x2\x2\x2\x84\x85\a\x30\x2\x2\x85\"\x3\x2\x2\x2\x86"+
		"\x87\a?\x2\x2\x87$\x3\x2\x2\x2\x88\x89\a<\x2\x2\x89&\x3\x2\x2\x2\x8A\x8B"+
		"\ak\x2\x2\x8B\x8C\ah\x2\x2\x8C(\x3\x2\x2\x2\x8D\x8E\at\x2\x2\x8E\x8F\a"+
		"g\x2\x2\x8F\x90\ap\x2\x2\x90\x91\ag\x2\x2\x91*\x3\x2\x2\x2\x92\x93\av"+
		"\x2\x2\x93\x94\aj\x2\x2\x94\x95\ag\x2\x2\x95\x96\ap\x2\x2\x96,\x3\x2\x2"+
		"\x2\x97\x98\ay\x2\x2\x98\x99\aj\x2\x2\x99\x9A\ak\x2\x2\x9A\x9B\an\x2\x2"+
		"\x9B\x9C\ag\x2\x2\x9C.\x3\x2\x2\x2\x9D\x9E\ah\x2\x2\x9E\x9F\aq\x2\x2\x9F"+
		"\xA0\at\x2\x2\xA0\x30\x3\x2\x2\x2\xA1\xA2\ah\x2\x2\xA2\xA3\aw\x2\x2\xA3"+
		"\xA4\ap\x2\x2\xA4\xA5\a\x65\x2\x2\xA5\x32\x3\x2\x2\x2\xA6\xA7\ao\x2\x2"+
		"\xA7\xA8\a\x63\x2\x2\xA8\xA9\ak\x2\x2\xA9\xAA\ap\x2\x2\xAA\x34\x3\x2\x2"+
		"\x2\xAB\xAC\a\x66\x2\x2\xAC\xAD\aq\x2\x2\xAD\xAE\aw\x2\x2\xAE\xAF\a\x64"+
		"\x2\x2\xAF\xB0\an\x2\x2\xB0\xB1\ag\x2\x2\xB1\x36\x3\x2\x2\x2\xB2\xB3\a"+
		"\x65\x2\x2\xB3\xB4\aj\x2\x2\xB4\xB5\a\x63\x2\x2\xB5\xB6\at\x2\x2\xB6\xB7"+
		"\a\x63\x2\x2\xB7\xB8\a\x65\x2\x2\xB8\xB9\av\x2\x2\xB9\xBA\ag\x2\x2\xBA"+
		"\xBB\at\x2\x2\xBB\x38\x3\x2\x2\x2\xBC\xBD\av\x2\x2\xBD\xBE\ag\x2\x2\xBE"+
		"\xBF\az\x2\x2\xBF\xC0\av\x2\x2\xC0:\x3\x2\x2\x2\xC1\xC2\ap\x2\x2\xC2\xC3"+
		"\aw\x2\x2\xC3\xC4\ao\x2\x2\xC4\xC5\a\x64\x2\x2\xC5\xC6\ag\x2\x2\xC6\xC7"+
		"\at\x2\x2\xC7<\x3\x2\x2\x2\xC8\xC9\a\x63\x2\x2\xC9\xCA\at\x2\x2\xCA\xCB"+
		"\at\x2\x2\xCB\xCC\a\x63\x2\x2\xCC\xCD\a{\x2\x2\xCD\xCE\aq\x2\x2\xCE\xCF"+
		"\ah\x2\x2\xCF>\x3\x2\x2\x2\xD0\xD1\a\x64\x2\x2\xD1\xD2\aq\x2\x2\xD2\xD3"+
		"\aq\x2\x2\xD3\xD4\an\x2\x2\xD4\xD5\ag\x2\x2\xD5\xD6\a\x63\x2\x2\xD6\xD7"+
		"\ap\x2\x2\xD7@\x3\x2\x2\x2\xD8\xD9\aP\x2\x2\xD9\xDA\aQ\x2\x2\xDA\xDB\a"+
		"Q\x2\x2\xDB\xDC\aV\x2\x2\xDC\xDD\a\"\x2\x2\xDD\xDE\aP\x2\x2\xDE\xDF\a"+
		"Q\x2\x2\xDF\xE0\aQ\x2\x2\xE0\xE1\aV\x2\x2\xE1\x42\x3\x2\x2\x2\xE2\xE3"+
		"\at\x2\x2\xE3\xE4\ag\x2\x2\xE4\xE5\ai\x2\x2\xE5\xE6\at\x2\x2\xE6\xE7\a"+
		"g\x2\x2\xE7\xE8\au\x2\x2\xE8\xE9\a\x63\x2\x2\xE9\xEA\at\x2\x2\xEA\x44"+
		"\x3\x2\x2\x2\xEB\xEC\ak\x2\x2\xEC\xED\ao\x2\x2\xED\xEE\ar\x2\x2\xEE\xEF"+
		"\at\x2\x2\xEF\xF0\ak\x2\x2\xF0\xF1\ao\x2\x2\xF1\xF2\ak\x2\x2\xF2\xF3\a"+
		"t\x2\x2\xF3\xF4\aX\x2\x2\xF4\xF5\a\x63\x2\x2\xF5\xF6\at\x2\x2\xF6\x46"+
		"\x3\x2\x2\x2\xF7\xF8\ag\x2\x2\xF8\xF9\au\x2\x2\xF9\xFA\a\x65\x2\x2\xFA"+
		"\xFB\at\x2\x2\xFB\xFC\ak\x2\x2\xFC\xFD\a\x64\x2\x2\xFD\xFE\ak\x2\x2\xFE"+
		"\xFF\at\x2\x2\xFF\x100\aX\x2\x2\x100\x101\a\x63\x2\x2\x101\x102\at\x2"+
		"\x2\x102H\x3\x2\x2\x2\x103\x106\x5\x3\x2\x2\x104\x106\x5\x5\x3\x2\x105"+
		"\x103\x3\x2\x2\x2\x105\x104\x3\x2\x2\x2\x106J\x3\x2\x2\x2\x107\x108\a"+
		"$\x2\x2\x108\x109\x5I%\x2\x109\x10A\a$\x2\x2\x10AL\x3\x2\x2\x2\x10B\x10F"+
		"\x5\x3\x2\x2\x10C\x10F\x5\x5\x3\x2\x10D\x10F\x5\a\x4\x2\x10E\x10B\x3\x2"+
		"\x2\x2\x10E\x10C\x3\x2\x2\x2\x10E\x10D\x3\x2\x2\x2\x10F\x112\x3\x2\x2"+
		"\x2\x110\x10E\x3\x2\x2\x2\x110\x111\x3\x2\x2\x2\x111N\x3\x2\x2\x2\x112"+
		"\x110\x3\x2\x2\x2\x113\x117\a$\x2\x2\x114\x116\v\x2\x2\x2\x115\x114\x3"+
		"\x2\x2\x2\x116\x119\x3\x2\x2\x2\x117\x118\x3\x2\x2\x2\x117\x115\x3\x2"+
		"\x2\x2\x118\x11A\x3\x2\x2\x2\x119\x117\x3\x2\x2\x2\x11A\x11B\a$\x2\x2"+
		"\x11BP\x3\x2\x2\x2\x11C\x123\t\x6\x2\x2\x11D\x11F\a\xF\x2\x2\x11E\x11D"+
		"\x3\x2\x2\x2\x11E\x11F\x3\x2\x2\x2\x11F\x120\x3\x2\x2\x2\x120\x123\a\f"+
		"\x2\x2\x121\x123\a\xF\x2\x2\x122\x11C\x3\x2\x2\x2\x122\x11E\x3\x2\x2\x2"+
		"\x122\x121\x3\x2\x2\x2\x123\x124\x3\x2\x2\x2\x124\x122\x3\x2\x2\x2\x124"+
		"\x125\x3\x2\x2\x2\x125\x126\x3\x2\x2\x2\x126\x127\b)\x2\x2\x127R\x3\x2"+
		"\x2\x2\r\x2Zlr\x105\x10E\x110\x117\x11E\x122\x124\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Skipper
