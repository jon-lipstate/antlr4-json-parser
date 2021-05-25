// Generated from c:\Users\jlips\Documents\Visual Studio 2017\Projects\antlr_test\antlr_test\json.g4 by ANTLR 4.7.1

	using antlr_test.Abstract;
	using antlr_test.Builders;
	namespace Math_so;

import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class jsonParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, STRING=7, TRUE=8, FALSE=9, 
		IDENT=10, NUMBER=11, WHITESPACE=12;
	public static final int
		RULE_compileUnit = 0, RULE_value = 1, RULE_object = 2, RULE_objectProperty = 3, 
		RULE_array = 4, RULE_literal = 5;
	public static final String[] ruleNames = {
		"compileUnit", "value", "object", "objectProperty", "array", "literal"
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

	@Override
	public String getGrammarFileName() { return "json.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }


		IValueBuilder _builder;

	public jsonParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class CompileUnitContext extends ParserRuleContext {
		public ValueContext value;
		public TerminalNode EOF() { return getToken(jsonParser.EOF, 0); }
		public List<ValueContext> value() {
			return getRuleContexts(ValueContext.class);
		}
		public ValueContext value(int i) {
			return getRuleContext(ValueContext.class,i);
		}
		public CompileUnitContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_compileUnit; }
	}

	public final CompileUnitContext compileUnit() throws RecognitionException {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_compileUnit);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(15);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << STRING) | (1L << TRUE) | (1L << FALSE) | (1L << NUMBER))) != 0)) {
				{
				{
				setState(12);
				((CompileUnitContext)_localctx).value = value();
				}
				}
				setState(17);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(18);
			match(EOF);
			_builder = ((CompileUnitContext)_localctx).value.builder;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ValueContext extends ParserRuleContext {
		public IValueBuilder builder;
		public ObjectContext object;
		public ArrayContext array;
		public LiteralContext literal;
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public ArrayContext array() {
			return getRuleContext(ArrayContext.class,0);
		}
		public LiteralContext literal() {
			return getRuleContext(LiteralContext.class,0);
		}
		public ValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_value; }
	}

	public final ValueContext value() throws RecognitionException {
		ValueContext _localctx = new ValueContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_value);
		try {
			setState(30);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__0:
				enterOuterAlt(_localctx, 1);
				{
				setState(21);
				((ValueContext)_localctx).object = object();
				 ((ValueContext)_localctx).builder =  ((ValueContext)_localctx).object.builder; 
				}
				break;
			case T__4:
				enterOuterAlt(_localctx, 2);
				{
				setState(24);
				((ValueContext)_localctx).array = array();
				 ((ValueContext)_localctx).builder =  ((ValueContext)_localctx).array.builder; 
				}
				break;
			case STRING:
			case TRUE:
			case FALSE:
			case NUMBER:
				enterOuterAlt(_localctx, 3);
				{
				setState(27);
				((ValueContext)_localctx).literal = literal();
				 ((ValueContext)_localctx).builder =  ((ValueContext)_localctx).literal.builder; 
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectContext extends ParserRuleContext {
		public IValueBuilder builder;
		public ObjectBuilder objBuilder = new ObjectBuilder();
		public List<ObjectPropertyContext> objectProperty() {
			return getRuleContexts(ObjectPropertyContext.class);
		}
		public ObjectPropertyContext objectProperty(int i) {
			return getRuleContext(ObjectPropertyContext.class,i);
		}
		public ObjectContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_object; }
	}

	public final ObjectContext object() throws RecognitionException {
		ObjectContext _localctx = new ObjectContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_object);

					((ObjectContext)_localctx).builder =  _localctx.objBuilder;
				
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(32);
			match(T__0);
			setState(34);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==STRING || _la==IDENT) {
				{
				setState(33);
				objectProperty();
				}
			}

			setState(40);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__1) {
				{
				{
				setState(36);
				match(T__1);
				setState(37);
				objectProperty();
				}
				}
				setState(42);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(43);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectPropertyContext extends ParserRuleContext {
		public Token key;
		public ValueContext value;
		public ValueContext value() {
			return getRuleContext(ValueContext.class,0);
		}
		public TerminalNode IDENT() { return getToken(jsonParser.IDENT, 0); }
		public TerminalNode STRING() { return getToken(jsonParser.STRING, 0); }
		public ObjectPropertyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_objectProperty; }
	}

	public final ObjectPropertyContext objectProperty() throws RecognitionException {
		ObjectPropertyContext _localctx = new ObjectPropertyContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_objectProperty);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			((ObjectPropertyContext)_localctx).key = _input.LT(1);
			_la = _input.LA(1);
			if ( !(_la==STRING || _la==IDENT) ) {
				((ObjectPropertyContext)_localctx).key = (Token)_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(46);
			match(T__3);
			setState(47);
			((ObjectPropertyContext)_localctx).value = value();

				((ObjectContext)getInvokingContext(2)).objBuilder.SetProperty((((ObjectPropertyContext)_localctx).key!=null?((ObjectPropertyContext)_localctx).key.getText():null), ((ObjectPropertyContext)_localctx).value.builder);

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArrayContext extends ParserRuleContext {
		public IValueBuilder builder;
		public ValueContext a;
		public ValueContext b;
		public List<ValueContext> value() {
			return getRuleContexts(ValueContext.class);
		}
		public ValueContext value(int i) {
			return getRuleContext(ValueContext.class,i);
		}
		public ArrayContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_array; }
	}

	public final ArrayContext array() throws RecognitionException {
		ArrayContext _localctx = new ArrayContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_array);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			((ArrayContext)_localctx).builder =  new ArrayBuilder();
			setState(51);
			match(T__4);
			setState(55);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << STRING) | (1L << TRUE) | (1L << FALSE) | (1L << NUMBER))) != 0)) {
				{
				setState(52);
				((ArrayContext)_localctx).a = value();
				 ((ArrayBuilder)_localctx.builder).Push(((ArrayContext)_localctx).a.builder); 
				}
			}

			setState(63);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__1) {
				{
				{
				setState(57);
				match(T__1);
				setState(58);
				((ArrayContext)_localctx).b = value();
				 ((ArrayBuilder)_localctx.builder).Push(((ArrayContext)_localctx).b.builder); 
				}
				}
				setState(65);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(66);
			match(T__5);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LiteralContext extends ParserRuleContext {
		public IValueBuilder builder;
		public Token NUMBER;
		public Token STRING;
		public TerminalNode NUMBER() { return getToken(jsonParser.NUMBER, 0); }
		public TerminalNode STRING() { return getToken(jsonParser.STRING, 0); }
		public TerminalNode TRUE() { return getToken(jsonParser.TRUE, 0); }
		public TerminalNode FALSE() { return getToken(jsonParser.FALSE, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_literal; }
	}

	public final LiteralContext literal() throws RecognitionException {
		LiteralContext _localctx = new LiteralContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_literal);
		try {
			setState(76);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NUMBER:
				enterOuterAlt(_localctx, 1);
				{
				setState(68);
				((LiteralContext)_localctx).NUMBER = match(NUMBER);
				 ((LiteralContext)_localctx).builder =  new ConstantBuilder(float.Parse((((LiteralContext)_localctx).NUMBER!=null?((LiteralContext)_localctx).NUMBER.getText():null)));	
				}
				break;
			case STRING:
				enterOuterAlt(_localctx, 2);
				{
				setState(70);
				((LiteralContext)_localctx).STRING = match(STRING);
				 ((LiteralContext)_localctx).builder =  new ConstantBuilder((((LiteralContext)_localctx).STRING!=null?((LiteralContext)_localctx).STRING.getText():null).Substring(1,(((LiteralContext)_localctx).STRING!=null?((LiteralContext)_localctx).STRING.getText():null).Length-2));	
				}
				break;
			case TRUE:
				enterOuterAlt(_localctx, 3);
				{
				setState(72);
				match(TRUE);
				 ((LiteralContext)_localctx).builder =  new ConstantBuilder(true);	
				}
				break;
			case FALSE:
				enterOuterAlt(_localctx, 4);
				{
				setState(74);
				match(FALSE);
				 ((LiteralContext)_localctx).builder =  new ConstantBuilder(false); 
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\16Q\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\3\2\7\2\20\n\2\f\2\16\2\23\13\2\3\2"+
		"\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\5\3!\n\3\3\4\3\4\5\4%\n\4"+
		"\3\4\3\4\7\4)\n\4\f\4\16\4,\13\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3"+
		"\6\3\6\3\6\5\6:\n\6\3\6\3\6\3\6\3\6\7\6@\n\6\f\6\16\6C\13\6\3\6\3\6\3"+
		"\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\5\7O\n\7\3\7\2\2\b\2\4\6\b\n\f\2\3\4\2"+
		"\t\t\f\f\2T\2\21\3\2\2\2\4 \3\2\2\2\6\"\3\2\2\2\b/\3\2\2\2\n\64\3\2\2"+
		"\2\fN\3\2\2\2\16\20\5\4\3\2\17\16\3\2\2\2\20\23\3\2\2\2\21\17\3\2\2\2"+
		"\21\22\3\2\2\2\22\24\3\2\2\2\23\21\3\2\2\2\24\25\7\2\2\3\25\26\b\2\1\2"+
		"\26\3\3\2\2\2\27\30\5\6\4\2\30\31\b\3\1\2\31!\3\2\2\2\32\33\5\n\6\2\33"+
		"\34\b\3\1\2\34!\3\2\2\2\35\36\5\f\7\2\36\37\b\3\1\2\37!\3\2\2\2 \27\3"+
		"\2\2\2 \32\3\2\2\2 \35\3\2\2\2!\5\3\2\2\2\"$\7\3\2\2#%\5\b\5\2$#\3\2\2"+
		"\2$%\3\2\2\2%*\3\2\2\2&\'\7\4\2\2\')\5\b\5\2(&\3\2\2\2),\3\2\2\2*(\3\2"+
		"\2\2*+\3\2\2\2+-\3\2\2\2,*\3\2\2\2-.\7\5\2\2.\7\3\2\2\2/\60\t\2\2\2\60"+
		"\61\7\6\2\2\61\62\5\4\3\2\62\63\b\5\1\2\63\t\3\2\2\2\64\65\b\6\1\2\65"+
		"9\7\7\2\2\66\67\5\4\3\2\678\b\6\1\28:\3\2\2\29\66\3\2\2\29:\3\2\2\2:A"+
		"\3\2\2\2;<\7\4\2\2<=\5\4\3\2=>\b\6\1\2>@\3\2\2\2?;\3\2\2\2@C\3\2\2\2A"+
		"?\3\2\2\2AB\3\2\2\2BD\3\2\2\2CA\3\2\2\2DE\7\b\2\2E\13\3\2\2\2FG\7\r\2"+
		"\2GO\b\7\1\2HI\7\t\2\2IO\b\7\1\2JK\7\n\2\2KO\b\7\1\2LM\7\13\2\2MO\b\7"+
		"\1\2NF\3\2\2\2NH\3\2\2\2NJ\3\2\2\2NL\3\2\2\2O\r\3\2\2\2\t\21 $*9AN";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}