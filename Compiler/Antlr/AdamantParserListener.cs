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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AdamantParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IAdamantParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] AdamantParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] AdamantParser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.usingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingStatement([NotNull] AdamantParser.UsingStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.usingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingStatement([NotNull] AdamantParser.UsingStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] AdamantParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] AdamantParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceName([NotNull] AdamantParser.NamespaceNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceName([NotNull] AdamantParser.NamespaceNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.namespaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceMemberDeclaration([NotNull] AdamantParser.NamespaceMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.namespaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceMemberDeclaration([NotNull] AdamantParser.NamespaceMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceDeclaration([NotNull] AdamantParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceDeclaration([NotNull] AdamantParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDeclaration([NotNull] AdamantParser.TypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDeclaration([NotNull] AdamantParser.TypeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalDeclaration([NotNull] AdamantParser.GlobalDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalDeclaration([NotNull] AdamantParser.GlobalDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] AdamantParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] AdamantParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessModifier([NotNull] AdamantParser.AccessModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessModifier([NotNull] AdamantParser.AccessModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeModifier([NotNull] AdamantParser.TypeModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeModifier([NotNull] AdamantParser.TypeModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterList([NotNull] AdamantParser.TypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterList([NotNull] AdamantParser.TypeParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameter([NotNull] AdamantParser.TypeParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameter([NotNull] AdamantParser.TypeParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeBase([NotNull] AdamantParser.TypeBaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeBase([NotNull] AdamantParser.TypeBaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] AdamantParser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] AdamantParser.TypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArguments([NotNull] AdamantParser.TypeArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArguments([NotNull] AdamantParser.TypeArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] AdamantParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] AdamantParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.funcTypeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncTypeParameterList([NotNull] AdamantParser.FuncTypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.funcTypeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncTypeParameterList([NotNull] AdamantParser.FuncTypeParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.funcTypeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncTypeParameter([NotNull] AdamantParser.FuncTypeParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.funcTypeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncTypeParameter([NotNull] AdamantParser.FuncTypeParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.constExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstExpression([NotNull] AdamantParser.ConstExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.constExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstExpression([NotNull] AdamantParser.ConstExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeParameterConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterConstraintClause([NotNull] AdamantParser.TypeParameterConstraintClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeParameterConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterConstraintClause([NotNull] AdamantParser.TypeParameterConstraintClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ConstructorConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorConstraint([NotNull] AdamantParser.ConstructorConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ConstructorConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorConstraint([NotNull] AdamantParser.ConstructorConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeConstraint([NotNull] AdamantParser.TypeConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeConstraint([NotNull] AdamantParser.TypeConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeListParameterConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeListParameterConstraint([NotNull] AdamantParser.TypeListParameterConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeListParameterConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeListParameterConstraint([NotNull] AdamantParser.TypeListParameterConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.typeMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeMember([NotNull] AdamantParser.TypeMemberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.typeMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeMember([NotNull] AdamantParser.TypeMemberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] AdamantParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] AdamantParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] AdamantParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] AdamantParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.parameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterModifier([NotNull] AdamantParser.ParameterModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.parameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterModifier([NotNull] AdamantParser.ParameterModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor([NotNull] AdamantParser.ConstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor([NotNull] AdamantParser.ConstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorInitializer([NotNull] AdamantParser.ConstructorInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorInitializer([NotNull] AdamantParser.ConstructorInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] AdamantParser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] AdamantParser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.destructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDestructor([NotNull] AdamantParser.DestructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.destructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDestructor([NotNull] AdamantParser.DestructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod([NotNull] AdamantParser.MethodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod([NotNull] AdamantParser.MethodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodModifier([NotNull] AdamantParser.MethodModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodModifier([NotNull] AdamantParser.MethodModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.operatorOverload"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorOverload([NotNull] AdamantParser.OperatorOverloadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.operatorOverload"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorOverload([NotNull] AdamantParser.OperatorOverloadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.conversionMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversionMethod([NotNull] AdamantParser.ConversionMethodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.conversionMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversionMethod([NotNull] AdamantParser.ConversionMethodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperty([NotNull] AdamantParser.PropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperty([NotNull] AdamantParser.PropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] AdamantParser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] AdamantParser.MethodBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.overloadableOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverloadableOperator([NotNull] AdamantParser.OverloadableOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.overloadableOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverloadableOperator([NotNull] AdamantParser.OverloadableOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] AdamantParser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] AdamantParser.FieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldModifier([NotNull] AdamantParser.FieldModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldModifier([NotNull] AdamantParser.FieldModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarationStatement([NotNull] AdamantParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarationStatement([NotNull] AdamantParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LetDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLetDeclarationStatement([NotNull] AdamantParser.LetDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LetDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLetDeclarationStatement([NotNull] AdamantParser.LetDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UnsafeBlockStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnsafeBlockStatement([NotNull] AdamantParser.UnsafeBlockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnsafeBlockStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnsafeBlockStatement([NotNull] AdamantParser.UnsafeBlockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Block</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] AdamantParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Block</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] AdamantParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>EmptyStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement([NotNull] AdamantParser.EmptyStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EmptyStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement([NotNull] AdamantParser.EmptyStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] AdamantParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] AdamantParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] AdamantParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] AdamantParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ThrowStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] AdamantParser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ThrowStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] AdamantParser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] AdamantParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] AdamantParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] AdamantParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] AdamantParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ForeachStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeachStatement([NotNull] AdamantParser.ForeachStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ForeachStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeachStatement([NotNull] AdamantParser.ForeachStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DeleteStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteStatement([NotNull] AdamantParser.DeleteStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeleteStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteStatement([NotNull] AdamantParser.DeleteStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaration([NotNull] AdamantParser.VariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaration([NotNull] AdamantParser.VariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.letDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLetDeclaration([NotNull] AdamantParser.LetDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.letDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLetDeclaration([NotNull] AdamantParser.LetDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] AdamantParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] AdamantParser.ExpressionContext context);
}
} // namespace Adamant.Compiler.Antlr
