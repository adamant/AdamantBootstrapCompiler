//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AdamantParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Adamant.Compiler.Antlr {
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class AdamantParser : Parser {
	public const int
		SingleLineDocComment=1, BlockDocComment=2, SingleLineComment=3, BlockComment=4, 
		PreprocessorLine=5, Whitespace=6, Newline=7, PreprocessorSkippedSection=8, 
		Using=9, Namespace=10, Class=11, New=12, Operator=13, This=14, Return=15, 
		Uninitialized=16, Implicit=17, Explicit=18, Conversion=19, Public=20, 
		Private=21, Protected=22, Safe=23, Unsafe=24, Own=25, Mutable=26, BooleanLiteral=27, 
		NullLiteral=28, Identifier=29, EscapedIdentifier=30, Semicolon=31, Colon=32, 
		Dot=33, LeftBrace=34, RightBrace=35, LeftAngle=36, RightAngle=37, LeftBracket=38, 
		RightBracket=39, Asterisk=40, AtSign=41, AddressOf=42, Returns=43, Coalesce=44, 
		IsNull=45, Equal=46, NotEqual=47, Unknown=48;
	public const int
		RULE_compilationUnit = 0, RULE_usingStatement = 1, RULE_namespaceName = 2, 
		RULE_namespaceMemberDeclaration = 3, RULE_namespaceDeclaration = 4;
	public static readonly string[] ruleNames = {
		"compilationUnit", "usingStatement", "namespaceName", "namespaceMemberDeclaration", 
		"namespaceDeclaration"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, "'using'", "'namespace'", 
		"'class'", "'new'", "'operator'", "'this'", "'return'", "'uninitialized'", 
		"'implicit'", "'explicit'", "'conversion'", "'public'", "'private'", "'protected'", 
		"'safe'", "'unsafe'", "'own'", "'mut'", null, "'null'", null, null, "';'", 
		"':'", "'.'", "'{'", "'}'", "'<'", "'>'", "'['", "']'", "'*'", "'@'", 
		"'&'", "'->'", "'??'", "'?'", "'=='", "'!='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SingleLineDocComment", "BlockDocComment", "SingleLineComment", 
		"BlockComment", "PreprocessorLine", "Whitespace", "Newline", "PreprocessorSkippedSection", 
		"Using", "Namespace", "Class", "New", "Operator", "This", "Return", "Uninitialized", 
		"Implicit", "Explicit", "Conversion", "Public", "Private", "Protected", 
		"Safe", "Unsafe", "Own", "Mutable", "BooleanLiteral", "NullLiteral", "Identifier", 
		"EscapedIdentifier", "Semicolon", "Colon", "Dot", "LeftBrace", "RightBrace", 
		"LeftAngle", "RightAngle", "LeftBracket", "RightBracket", "Asterisk", 
		"AtSign", "AddressOf", "Returns", "Coalesce", "IsNull", "Equal", "NotEqual", 
		"Unknown"
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

	public override string GrammarFileName { get { return "AdamantParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public AdamantParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompilationUnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(AdamantParser.Eof, 0); }
		public UsingStatementContext[] usingStatement() {
			return GetRuleContexts<UsingStatementContext>();
		}
		public UsingStatementContext usingStatement(int i) {
			return GetRuleContext<UsingStatementContext>(i);
		}
		public NamespaceMemberDeclarationContext[] namespaceMemberDeclaration() {
			return GetRuleContexts<NamespaceMemberDeclarationContext>();
		}
		public NamespaceMemberDeclarationContext namespaceMemberDeclaration(int i) {
			return GetRuleContext<NamespaceMemberDeclarationContext>(i);
		}
		public CompilationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilationUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.EnterCompilationUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.ExitCompilationUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAdamantParserVisitor<TResult> typedVisitor = visitor as IAdamantParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompilationUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompilationUnitContext compilationUnit() {
		CompilationUnitContext _localctx = new CompilationUnitContext(Context, State);
		EnterRule(_localctx, 0, RULE_compilationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Using) {
				{
				{
				State = 10; usingStatement();
				}
				}
				State = 15;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Namespace) {
				{
				{
				State = 16; namespaceMemberDeclaration();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 22; Match(Eof);
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

	public partial class UsingStatementContext : ParserRuleContext {
		public NamespaceNameContext namespaceName() {
			return GetRuleContext<NamespaceNameContext>(0);
		}
		public UsingStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_usingStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.EnterUsingStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.ExitUsingStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAdamantParserVisitor<TResult> typedVisitor = visitor as IAdamantParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUsingStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UsingStatementContext usingStatement() {
		UsingStatementContext _localctx = new UsingStatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_usingStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; Match(Using);
			State = 25; namespaceName();
			State = 26; Match(Semicolon);
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

	public partial class NamespaceNameContext : ParserRuleContext {
		public ITerminalNode[] Identifier() { return GetTokens(AdamantParser.Identifier); }
		public ITerminalNode Identifier(int i) {
			return GetToken(AdamantParser.Identifier, i);
		}
		public NamespaceNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.EnterNamespaceName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.ExitNamespaceName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAdamantParserVisitor<TResult> typedVisitor = visitor as IAdamantParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNamespaceName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceNameContext namespaceName() {
		NamespaceNameContext _localctx = new NamespaceNameContext(Context, State);
		EnterRule(_localctx, 4, RULE_namespaceName);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28; Match(Identifier);
			State = 33;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Dot) {
				{
				{
				State = 29; Match(Dot);
				State = 30; Match(Identifier);
				}
				}
				State = 35;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
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

	public partial class NamespaceMemberDeclarationContext : ParserRuleContext {
		public NamespaceDeclarationContext namespaceDeclaration() {
			return GetRuleContext<NamespaceDeclarationContext>(0);
		}
		public NamespaceMemberDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceMemberDeclaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.EnterNamespaceMemberDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.ExitNamespaceMemberDeclaration(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAdamantParserVisitor<TResult> typedVisitor = visitor as IAdamantParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNamespaceMemberDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceMemberDeclarationContext namespaceMemberDeclaration() {
		NamespaceMemberDeclarationContext _localctx = new NamespaceMemberDeclarationContext(Context, State);
		EnterRule(_localctx, 6, RULE_namespaceMemberDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 36; namespaceDeclaration();
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

	public partial class NamespaceDeclarationContext : ParserRuleContext {
		public NamespaceNameContext namespaceName() {
			return GetRuleContext<NamespaceNameContext>(0);
		}
		public UsingStatementContext[] usingStatement() {
			return GetRuleContexts<UsingStatementContext>();
		}
		public UsingStatementContext usingStatement(int i) {
			return GetRuleContext<UsingStatementContext>(i);
		}
		public NamespaceMemberDeclarationContext[] namespaceMemberDeclaration() {
			return GetRuleContexts<NamespaceMemberDeclarationContext>();
		}
		public NamespaceMemberDeclarationContext namespaceMemberDeclaration(int i) {
			return GetRuleContext<NamespaceMemberDeclarationContext>(i);
		}
		public NamespaceDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceDeclaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.EnterNamespaceDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAdamantParserListener typedListener = listener as IAdamantParserListener;
			if (typedListener != null) typedListener.ExitNamespaceDeclaration(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAdamantParserVisitor<TResult> typedVisitor = visitor as IAdamantParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNamespaceDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceDeclarationContext namespaceDeclaration() {
		NamespaceDeclarationContext _localctx = new NamespaceDeclarationContext(Context, State);
		EnterRule(_localctx, 8, RULE_namespaceDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; Match(Namespace);
			State = 39; namespaceName();
			State = 40; Match(LeftBrace);
			State = 44;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Using) {
				{
				{
				State = 41; usingStatement();
				}
				}
				State = 46;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 50;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Namespace) {
				{
				{
				State = 47; namespaceMemberDeclaration();
				}
				}
				State = 52;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 53; Match(RightBrace);
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

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x32:\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\a\x2\xE\n\x2\f\x2\xE"+
		"\x2\x11\v\x2\x3\x2\a\x2\x14\n\x2\f\x2\xE\x2\x17\v\x2\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\a\x4\"\n\x4\f\x4\xE\x4%\v\x4\x3\x5"+
		"\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\a\x6-\n\x6\f\x6\xE\x6\x30\v\x6\x3\x6\a"+
		"\x6\x33\n\x6\f\x6\xE\x6\x36\v\x6\x3\x6\x3\x6\x3\x6\x2\x2\a\x2\x4\x6\b"+
		"\n\x2\x2\x39\x2\xF\x3\x2\x2\x2\x4\x1A\x3\x2\x2\x2\x6\x1E\x3\x2\x2\x2\b"+
		"&\x3\x2\x2\x2\n(\x3\x2\x2\x2\f\xE\x5\x4\x3\x2\r\f\x3\x2\x2\x2\xE\x11\x3"+
		"\x2\x2\x2\xF\r\x3\x2\x2\x2\xF\x10\x3\x2\x2\x2\x10\x15\x3\x2\x2\x2\x11"+
		"\xF\x3\x2\x2\x2\x12\x14\x5\b\x5\x2\x13\x12\x3\x2\x2\x2\x14\x17\x3\x2\x2"+
		"\x2\x15\x13\x3\x2\x2\x2\x15\x16\x3\x2\x2\x2\x16\x18\x3\x2\x2\x2\x17\x15"+
		"\x3\x2\x2\x2\x18\x19\a\x2\x2\x3\x19\x3\x3\x2\x2\x2\x1A\x1B\a\v\x2\x2\x1B"+
		"\x1C\x5\x6\x4\x2\x1C\x1D\a!\x2\x2\x1D\x5\x3\x2\x2\x2\x1E#\a\x1F\x2\x2"+
		"\x1F \a#\x2\x2 \"\a\x1F\x2\x2!\x1F\x3\x2\x2\x2\"%\x3\x2\x2\x2#!\x3\x2"+
		"\x2\x2#$\x3\x2\x2\x2$\a\x3\x2\x2\x2%#\x3\x2\x2\x2&\'\x5\n\x6\x2\'\t\x3"+
		"\x2\x2\x2()\a\f\x2\x2)*\x5\x6\x4\x2*.\a$\x2\x2+-\x5\x4\x3\x2,+\x3\x2\x2"+
		"\x2-\x30\x3\x2\x2\x2.,\x3\x2\x2\x2./\x3\x2\x2\x2/\x34\x3\x2\x2\x2\x30"+
		".\x3\x2\x2\x2\x31\x33\x5\b\x5\x2\x32\x31\x3\x2\x2\x2\x33\x36\x3\x2\x2"+
		"\x2\x34\x32\x3\x2\x2\x2\x34\x35\x3\x2\x2\x2\x35\x37\x3\x2\x2\x2\x36\x34"+
		"\x3\x2\x2\x2\x37\x38\a%\x2\x2\x38\v\x3\x2\x2\x2\a\xF\x15#.\x34";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Adamant.Compiler.Antlr
