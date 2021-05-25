// Generated from c:\Users\jlips\Documents\Visual Studio 2017\Projects\antlr_test\antlr_test\json.g4 by ANTLR 4.7.1

	using antlr_test.Abstract;
	using antlr_test.Builders;
	namespace Math_so;

import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class jsonLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, STRING=7, TRUE=8, FALSE=9, 
		IDENT=10, NUMBER=11, WHITESPACE=12;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "STRING", "TRUE", "FALSE", 
		"IDENT", "NUMBER", "WHITESPACE", "IDENT_START", "IDENT_MID", "LETTER", 
		"DIGIT", "T", "R", "U", "E", "F", "A", "L", "S"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'{'", "','", "'}'", "':'", "'['", "']'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, null, "STRING", "TRUE", "FALSE", "IDENT", 
		"NUMBER", "WHITESPACE"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


		IValueBuilder _builder;


	public jsonLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "json.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\16\u009a\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3\b\7\bB\n\b"+
		"\f\b\16\bE\13\b\3\b\3\b\3\b\7\bJ\n\b\f\b\16\bM\13\b\3\b\5\bP\n\b\3\t\3"+
		"\t\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\13\3\13\7\13_\n\13\f\13\16\13"+
		"b\13\13\3\f\6\fe\n\f\r\f\16\ff\3\f\7\fj\n\f\f\f\16\fm\13\f\3\f\3\f\7\f"+
		"q\n\f\f\f\16\ft\13\f\5\fv\n\f\3\r\6\ry\n\r\r\r\16\rz\3\r\3\r\3\16\3\16"+
		"\5\16\u0081\n\16\3\17\3\17\5\17\u0085\n\17\3\20\3\20\3\21\3\21\3\22\3"+
		"\22\3\23\3\23\3\24\3\24\3\25\3\25\3\26\3\26\3\27\3\27\3\30\3\30\3\31\3"+
		"\31\2\2\32\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33"+
		"\2\35\2\37\2!\2#\2%\2\'\2)\2+\2-\2/\2\61\2\3\2\16\5\2\f\f\17\17))\5\2"+
		"\f\f\17\17$$\5\2\13\f\17\17\"\"\4\2C\\c|\4\2VVvv\4\2TTtt\4\2WWww\4\2G"+
		"Ggg\4\2HHhh\4\2CCcc\4\2NNnn\4\2UUuu\2\u0098\2\3\3\2\2\2\2\5\3\2\2\2\2"+
		"\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2"+
		"\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\3\63\3\2\2\2"+
		"\5\65\3\2\2\2\7\67\3\2\2\2\t9\3\2\2\2\13;\3\2\2\2\r=\3\2\2\2\17O\3\2\2"+
		"\2\21Q\3\2\2\2\23V\3\2\2\2\25\\\3\2\2\2\27u\3\2\2\2\31x\3\2\2\2\33\u0080"+
		"\3\2\2\2\35\u0084\3\2\2\2\37\u0086\3\2\2\2!\u0088\3\2\2\2#\u008a\3\2\2"+
		"\2%\u008c\3\2\2\2\'\u008e\3\2\2\2)\u0090\3\2\2\2+\u0092\3\2\2\2-\u0094"+
		"\3\2\2\2/\u0096\3\2\2\2\61\u0098\3\2\2\2\63\64\7}\2\2\64\4\3\2\2\2\65"+
		"\66\7.\2\2\66\6\3\2\2\2\678\7\177\2\28\b\3\2\2\29:\7<\2\2:\n\3\2\2\2;"+
		"<\7]\2\2<\f\3\2\2\2=>\7_\2\2>\16\3\2\2\2?C\7)\2\2@B\n\2\2\2A@\3\2\2\2"+
		"BE\3\2\2\2CA\3\2\2\2CD\3\2\2\2DF\3\2\2\2EC\3\2\2\2FP\7)\2\2GK\7$\2\2H"+
		"J\n\3\2\2IH\3\2\2\2JM\3\2\2\2KI\3\2\2\2KL\3\2\2\2LN\3\2\2\2MK\3\2\2\2"+
		"NP\7$\2\2O?\3\2\2\2OG\3\2\2\2P\20\3\2\2\2QR\5#\22\2RS\5%\23\2ST\5\'\24"+
		"\2TU\5)\25\2U\22\3\2\2\2VW\5+\26\2WX\5-\27\2XY\5/\30\2YZ\5\61\31\2Z[\5"+
		")\25\2[\24\3\2\2\2\\`\5\33\16\2]_\5\35\17\2^]\3\2\2\2_b\3\2\2\2`^\3\2"+
		"\2\2`a\3\2\2\2a\26\3\2\2\2b`\3\2\2\2ce\5!\21\2dc\3\2\2\2ef\3\2\2\2fd\3"+
		"\2\2\2fg\3\2\2\2gv\3\2\2\2hj\5!\21\2ih\3\2\2\2jm\3\2\2\2ki\3\2\2\2kl\3"+
		"\2\2\2ln\3\2\2\2mk\3\2\2\2nr\7\60\2\2oq\5!\21\2po\3\2\2\2qt\3\2\2\2rp"+
		"\3\2\2\2rs\3\2\2\2sv\3\2\2\2tr\3\2\2\2ud\3\2\2\2uk\3\2\2\2v\30\3\2\2\2"+
		"wy\t\4\2\2xw\3\2\2\2yz\3\2\2\2zx\3\2\2\2z{\3\2\2\2{|\3\2\2\2|}\b\r\2\2"+
		"}\32\3\2\2\2~\u0081\7a\2\2\177\u0081\5\37\20\2\u0080~\3\2\2\2\u0080\177"+
		"\3\2\2\2\u0081\34\3\2\2\2\u0082\u0085\5\33\16\2\u0083\u0085\5!\21\2\u0084"+
		"\u0082\3\2\2\2\u0084\u0083\3\2\2\2\u0085\36\3\2\2\2\u0086\u0087\t\5\2"+
		"\2\u0087 \3\2\2\2\u0088\u0089\4\62;\2\u0089\"\3\2\2\2\u008a\u008b\t\6"+
		"\2\2\u008b$\3\2\2\2\u008c\u008d\t\7\2\2\u008d&\3\2\2\2\u008e\u008f\t\b"+
		"\2\2\u008f(\3\2\2\2\u0090\u0091\t\t\2\2\u0091*\3\2\2\2\u0092\u0093\t\n"+
		"\2\2\u0093,\3\2\2\2\u0094\u0095\t\13\2\2\u0095.\3\2\2\2\u0096\u0097\t"+
		"\f\2\2\u0097\60\3\2\2\2\u0098\u0099\t\r\2\2\u0099\62\3\2\2\2\16\2CKO`"+
		"fkruz\u0080\u0084\3\2\3\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}