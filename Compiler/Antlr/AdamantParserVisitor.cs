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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AdamantParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IAdamantParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] AdamantParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.usingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsingStatement([NotNull] AdamantParser.UsingStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] AdamantParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceName([NotNull] AdamantParser.NamespaceNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.namespaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceMemberDeclaration([NotNull] AdamantParser.NamespaceMemberDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceDeclaration([NotNull] AdamantParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDeclaration([NotNull] AdamantParser.TypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalDeclaration([NotNull] AdamantParser.GlobalDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute([NotNull] AdamantParser.AttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessModifier([NotNull] AdamantParser.AccessModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeModifier([NotNull] AdamantParser.TypeModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameterList([NotNull] AdamantParser.TypeParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameter([NotNull] AdamantParser.TypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeBase([NotNull] AdamantParser.TypeBaseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] AdamantParser.TypeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArguments([NotNull] AdamantParser.TypeArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] AdamantParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.funcTypeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameterList([NotNull] AdamantParser.FuncTypeParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.funcTypeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameter([NotNull] AdamantParser.FuncTypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.constExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstExpression([NotNull] AdamantParser.ConstExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameterConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameterConstraintClause([NotNull] AdamantParser.TypeParameterConstraintClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConstructorConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorConstraint([NotNull] AdamantParser.ConstructorConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeConstraint([NotNull] AdamantParser.TypeConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeListParameterConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeListParameterConstraint([NotNull] AdamantParser.TypeListParameterConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeMember([NotNull] AdamantParser.TypeMemberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] AdamantParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] AdamantParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.parameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterModifier([NotNull] AdamantParser.ParameterModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructor([NotNull] AdamantParser.ConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorInitializer([NotNull] AdamantParser.ConstructorInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentList([NotNull] AdamantParser.ArgumentListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.destructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDestructor([NotNull] AdamantParser.DestructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod([NotNull] AdamantParser.MethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodModifier([NotNull] AdamantParser.MethodModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.operatorOverload"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorOverload([NotNull] AdamantParser.OperatorOverloadContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.conversionMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConversionMethod([NotNull] AdamantParser.ConversionMethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperty([NotNull] AdamantParser.PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] AdamantParser.MethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.overloadableOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOverloadableOperator([NotNull] AdamantParser.OverloadableOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitField([NotNull] AdamantParser.FieldContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldModifier([NotNull] AdamantParser.FieldModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationStatement([NotNull] AdamantParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LetDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetDeclarationStatement([NotNull] AdamantParser.LetDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnsafeBlockStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsafeBlockStatement([NotNull] AdamantParser.UnsafeBlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Block</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] AdamantParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EmptyStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] AdamantParser.EmptyStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionStatement([NotNull] AdamantParser.ExpressionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] AdamantParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ThrowStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThrowStatement([NotNull] AdamantParser.ThrowStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] AdamantParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] AdamantParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForeachStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachStatement([NotNull] AdamantParser.ForeachStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeleteStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeleteStatement([NotNull] AdamantParser.DeleteStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] AdamantParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.letDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetDeclaration([NotNull] AdamantParser.LetDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] AdamantParser.ExpressionContext context);
}
} // namespace Adamant.Compiler.Antlr
