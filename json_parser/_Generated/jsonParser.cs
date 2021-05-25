//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\jlips\Documents\Visual Studio 2017\Projects\antlr_test\antlr_test\json.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


	using antlr_test.Abstract;
	using antlr_test.Builders;

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class jsonParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, STRING=7, TRUE=8, FALSE=9, 
		IDENT=10, NUMBER=11, WHITESPACE=12;
	public const int
		RULE_compileUnit = 0, RULE_value = 1, RULE_object = 2, RULE_objectProperty = 3, 
		RULE_array = 4, RULE_literal = 5;
	public static readonly string[] ruleNames = {
		"compileUnit", "value", "object", "objectProperty", "array", "literal"
	};

	private static readonly string[] _LiteralNames = {
		null, "'{'", "','", "'}'", "':'", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "STRING", "TRUE", "FALSE", "IDENT", 
		"NUMBER", "WHITESPACE"
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

	public override string GrammarFileName { get { return "json.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static jsonParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}


		IValueBuilder _builder;

		public jsonParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public jsonParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class CompileUnitContext : ParserRuleContext {
		public ValueContext _value;
		public ITerminalNode Eof() { return GetToken(jsonParser.Eof, 0); }
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(Context, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << STRING) | (1L << TRUE) | (1L << FALSE) | (1L << NUMBER))) != 0)) {
				{
				{
				State = 12; _localctx._value = value();
				}
				}
				State = 17;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 18; Match(Eof);
			_builder = _localctx._value.builder;
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

	public partial class ValueContext : ParserRuleContext {
		public IValueBuilder builder;
		public ObjectContext _object;
		public ArrayContext _array;
		public LiteralContext _literal;
		public ObjectContext @object() {
			return GetRuleContext<ObjectContext>(0);
		}
		public ArrayContext array() {
			return GetRuleContext<ArrayContext>(0);
		}
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 2, RULE_value);
		try {
			State = 30;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 21; _localctx._object = @object();
				 _localctx.builder =  _localctx._object.builder; 
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 2);
				{
				State = 24; _localctx._array = array();
				 _localctx.builder =  _localctx._array.builder; 
				}
				break;
			case STRING:
			case TRUE:
			case FALSE:
			case NUMBER:
				EnterOuterAlt(_localctx, 3);
				{
				State = 27; _localctx._literal = literal();
				 _localctx.builder =  _localctx._literal.builder; 
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

	public partial class ObjectContext : ParserRuleContext {
		public IValueBuilder builder;
		public ObjectBuilder objBuilder = new ObjectBuilder();
		public ObjectPropertyContext[] objectProperty() {
			return GetRuleContexts<ObjectPropertyContext>();
		}
		public ObjectPropertyContext objectProperty(int i) {
			return GetRuleContext<ObjectPropertyContext>(i);
		}
		public ObjectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_object; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterObject(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitObject(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObject(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectContext @object() {
		ObjectContext _localctx = new ObjectContext(Context, State);
		EnterRule(_localctx, 4, RULE_object);

					_localctx.builder =  _localctx.objBuilder;
				
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32; Match(T__0);
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==STRING || _la==IDENT) {
				{
				State = 33; objectProperty();
				}
			}

			State = 40;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__1) {
				{
				{
				State = 36; Match(T__1);
				State = 37; objectProperty();
				}
				}
				State = 42;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 43; Match(T__2);
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

	public partial class ObjectPropertyContext : ParserRuleContext {
		public IToken key;
		public ValueContext _value;
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public ITerminalNode IDENT() { return GetToken(jsonParser.IDENT, 0); }
		public ITerminalNode STRING() { return GetToken(jsonParser.STRING, 0); }
		public ObjectPropertyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectProperty; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterObjectProperty(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitObjectProperty(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectProperty(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectPropertyContext objectProperty() {
		ObjectPropertyContext _localctx = new ObjectPropertyContext(Context, State);
		EnterRule(_localctx, 6, RULE_objectProperty);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			_localctx.key = TokenStream.LT(1);
			_la = TokenStream.LA(1);
			if ( !(_la==STRING || _la==IDENT) ) {
				_localctx.key = ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 46; Match(T__3);
			State = 47; _localctx._value = value();

				((ObjectContext)GetInvokingContext(2)).objBuilder.SetProperty((_localctx.key!=null?_localctx.key.Text:null), _localctx._value.builder);

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

	public partial class ArrayContext : ParserRuleContext {
		public IValueBuilder builder;
		public ValueContext a;
		public ValueContext b;
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public ArrayContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterArray(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitArray(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArray(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArrayContext array() {
		ArrayContext _localctx = new ArrayContext(Context, State);
		EnterRule(_localctx, 8, RULE_array);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			_localctx.builder =  new ArrayBuilder();
			State = 51; Match(T__4);
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << STRING) | (1L << TRUE) | (1L << FALSE) | (1L << NUMBER))) != 0)) {
				{
				State = 52; _localctx.a = value();
				 ((ArrayBuilder)_localctx.builder).Push(_localctx.a.builder); 
				}
			}

			State = 63;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__1) {
				{
				{
				State = 57; Match(T__1);
				State = 58; _localctx.b = value();
				 ((ArrayBuilder)_localctx.builder).Push(_localctx.b.builder); 
				}
				}
				State = 65;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 66; Match(T__5);
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

	public partial class LiteralContext : ParserRuleContext {
		public IValueBuilder builder;
		public IToken _NUMBER;
		public IToken _STRING;
		public ITerminalNode NUMBER() { return GetToken(jsonParser.NUMBER, 0); }
		public ITerminalNode STRING() { return GetToken(jsonParser.STRING, 0); }
		public ITerminalNode TRUE() { return GetToken(jsonParser.TRUE, 0); }
		public ITerminalNode FALSE() { return GetToken(jsonParser.FALSE, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		public override void EnterRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IjsonListener typedListener = listener as IjsonListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IjsonVisitor<TResult> typedVisitor = visitor as IjsonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 10, RULE_literal);
		try {
			State = 76;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 68; _localctx._NUMBER = Match(NUMBER);
				 _localctx.builder =  new ConstantBuilder(float.Parse((_localctx._NUMBER!=null?_localctx._NUMBER.Text:null)));	
				}
				break;
			case STRING:
				EnterOuterAlt(_localctx, 2);
				{
				State = 70; _localctx._STRING = Match(STRING);
				 _localctx.builder =  new ConstantBuilder((_localctx._STRING!=null?_localctx._STRING.Text:null).Substring(1,(_localctx._STRING!=null?_localctx._STRING.Text:null).Length-2));	
				}
				break;
			case TRUE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 72; Match(TRUE);
				 _localctx.builder =  new ConstantBuilder(true);	
				}
				break;
			case FALSE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 74; Match(FALSE);
				 _localctx.builder =  new ConstantBuilder(false); 
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

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\xE', 'Q', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\a', '\x2', 
		'\x10', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x13', '\v', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '!', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x5', '\x4', '%', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', 
		'\x4', ')', '\n', '\x4', '\f', '\x4', '\xE', '\x4', ',', '\v', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x5', '\x6', ':', '\n', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\a', '\x6', '@', '\n', '\x6', 
		'\f', '\x6', '\xE', '\x6', '\x43', '\v', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'O', '\n', '\a', '\x3', '\a', 
		'\x2', '\x2', '\b', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\x2', '\x3', 
		'\x4', '\x2', '\t', '\t', '\f', '\f', '\x2', 'T', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x4', ' ', '\x3', '\x2', '\x2', '\x2', '\x6', '\"', 
		'\x3', '\x2', '\x2', '\x2', '\b', '/', '\x3', '\x2', '\x2', '\x2', '\n', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\f', 'N', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '\x10', '\x5', '\x4', '\x3', '\x2', '\xF', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x13', '\x3', '\x2', '\x2', '\x2', '\x11', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '\x14', '\x3', '\x2', '\x2', '\x2', '\x13', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\x14', '\x15', '\a', '\x2', '\x2', '\x3', '\x15', '\x16', 
		'\b', '\x2', '\x1', '\x2', '\x16', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x18', '\x5', '\x6', '\x4', '\x2', '\x18', '\x19', '\b', '\x3', 
		'\x1', '\x2', '\x19', '!', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', 
		'\x5', '\n', '\x6', '\x2', '\x1B', '\x1C', '\b', '\x3', '\x1', '\x2', 
		'\x1C', '!', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\x5', '\f', 
		'\a', '\x2', '\x1E', '\x1F', '\b', '\x3', '\x1', '\x2', '\x1F', '!', '\x3', 
		'\x2', '\x2', '\x2', ' ', '\x17', '\x3', '\x2', '\x2', '\x2', ' ', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', ' ', '\x1D', '\x3', '\x2', '\x2', '\x2', '!', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\"', '$', '\a', '\x3', '\x2', '\x2', 
		'#', '%', '\x5', '\b', '\x5', '\x2', '$', '#', '\x3', '\x2', '\x2', '\x2', 
		'$', '%', '\x3', '\x2', '\x2', '\x2', '%', '*', '\x3', '\x2', '\x2', '\x2', 
		'&', '\'', '\a', '\x4', '\x2', '\x2', '\'', ')', '\x5', '\b', '\x5', '\x2', 
		'(', '&', '\x3', '\x2', '\x2', '\x2', ')', ',', '\x3', '\x2', '\x2', '\x2', 
		'*', '(', '\x3', '\x2', '\x2', '\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', 
		'+', '-', '\x3', '\x2', '\x2', '\x2', ',', '*', '\x3', '\x2', '\x2', '\x2', 
		'-', '.', '\a', '\x5', '\x2', '\x2', '.', '\a', '\x3', '\x2', '\x2', '\x2', 
		'/', '\x30', '\t', '\x2', '\x2', '\x2', '\x30', '\x31', '\a', '\x6', '\x2', 
		'\x2', '\x31', '\x32', '\x5', '\x4', '\x3', '\x2', '\x32', '\x33', '\b', 
		'\x5', '\x1', '\x2', '\x33', '\t', '\x3', '\x2', '\x2', '\x2', '\x34', 
		'\x35', '\b', '\x6', '\x1', '\x2', '\x35', '\x39', '\a', '\a', '\x2', 
		'\x2', '\x36', '\x37', '\x5', '\x4', '\x3', '\x2', '\x37', '\x38', '\b', 
		'\x6', '\x1', '\x2', '\x38', ':', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', 
		'\x2', ':', '\x41', '\x3', '\x2', '\x2', '\x2', ';', '<', '\a', '\x4', 
		'\x2', '\x2', '<', '=', '\x5', '\x4', '\x3', '\x2', '=', '>', '\b', '\x6', 
		'\x1', '\x2', '>', '@', '\x3', '\x2', '\x2', '\x2', '?', ';', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x43', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\x43', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x44', '\x45', '\a', '\b', '\x2', '\x2', '\x45', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x46', 'G', '\a', '\r', '\x2', '\x2', 'G', 'O', 
		'\b', '\a', '\x1', '\x2', 'H', 'I', '\a', '\t', '\x2', '\x2', 'I', 'O', 
		'\b', '\a', '\x1', '\x2', 'J', 'K', '\a', '\n', '\x2', '\x2', 'K', 'O', 
		'\b', '\a', '\x1', '\x2', 'L', 'M', '\a', '\v', '\x2', '\x2', 'M', 'O', 
		'\b', '\a', '\x1', '\x2', 'N', '\x46', '\x3', '\x2', '\x2', '\x2', 'N', 
		'H', '\x3', '\x2', '\x2', '\x2', 'N', 'J', '\x3', '\x2', '\x2', '\x2', 
		'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\t', '\x11', ' ', '$', '*', '\x39', '\x41', 'N',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
