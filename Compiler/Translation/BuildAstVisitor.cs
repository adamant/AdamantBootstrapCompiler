﻿using System;
using System.Collections.Generic;
using System.Linq;
using Adamant.Compiler.Antlr;
using Adamant.Compiler.Ast;
using Adamant.Compiler.Ast.Declarations;
using Adamant.Compiler.Ast.Expressions;
using Adamant.Compiler.Ast.Members;
using Adamant.Compiler.Ast.Statements;
using Adamant.Compiler.Ast.Types;
using Antlr4.Runtime.Tree;
using Type = Adamant.Compiler.Ast.Type;

namespace Adamant.Compiler.Translation
{
	public class BuildAstVisitor : AdamantParserBaseVisitor<Node>
	{
		private readonly UsingContext usingContext;
		private readonly QualifiedName currentNamespace;

		public BuildAstVisitor()
		{
			usingContext = new UsingContext();
			currentNamespace = QualifiedName.None;
		}

		public BuildAstVisitor(UsingContext usingContext, QualifiedName currentNamespace)
		{
			this.usingContext = usingContext;
			this.currentNamespace = currentNamespace;
		}

		public override Node Visit(IParseTree tree)
		{
			throw new NotSupportedException("Generic visit methods should not be called.");
		}

		public override Node VisitChildren(IRuleNode node)
		{
			throw new NotSupportedException("Generic visit methods should not be called.");
		}

		public override Node VisitTerminal(ITerminalNode node)
		{
			throw new NotSupportedException("Generic visit methods should not be called.");
		}

		public override Node VisitErrorNode(IErrorNode node)
		{
			throw new NotSupportedException("Generic visit methods should not be called.");
		}

		public override Node VisitCompilationUnit(AdamantParser.CompilationUnitContext context)
		{
			// TODO global attributes
			var newContext = new UsingContext(usingContext, GetNamespaces(context.usingStatement()));
			var visitor = new BuildAstVisitor(newContext, currentNamespace);
			var declarations = context.declaration().Select(d => (IDeclarationContainer)d.Accept(visitor));
			return new Assemblage(declarations);
		}

		#region Declarations
		public override Node VisitNamespaceDeclaration(AdamantParser.NamespaceDeclarationContext context)
		{
			var namespaceName = context.namespaceName().GetText();
			var newContext = new UsingContext(usingContext, GetNamespaces(context.usingStatement()));
			var visitor = new BuildAstVisitor(newContext, currentNamespace.Append(namespaceName));
			var declarations = context.declaration().Select(d => (IDeclarationContainer)d.Accept(visitor));
			return new Assemblage(declarations);
		}

		public override Node VisitClassDeclaration(AdamantParser.ClassDeclarationContext context)
		{
			// TODO Attributes
			// TODO what about immutable for classes?
			var accessModifier = GetAccessModifier(context.modifier());
			var isPartial = Has(context.modifier(), AdamantLexer.Partial);
			var safety = GetSafety(context.modifier());
			var isAbstract = Has(context.modifier(), AdamantLexer.Abstract);
			var isSealed = Has(context.modifier(), AdamantLexer.Sealed);
			var name = context.name.GetText();
			var fullName = currentNamespace.Append(name);
			// TODO base types
			// TODO type parameter constraints
			var members = context.member().Select(m => (Member)m.Accept(this));
			return new ClassDeclaration(accessModifier, isPartial, safety, isSealed, isAbstract, fullName, members);
		}

		public override Node VisitGlobalDeclaration(AdamantParser.GlobalDeclarationContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var isMutableReference = context.kind.Type == AdamantLexer.Var;
			var name = context.name.GetText();
			var fullName = currentNamespace.Append(name);
			var type = (OwnershipType)context.ownershipType()?.Accept(this) ?? OwnershipType.NewInferred();
			var initExpression = (Expression)context.expression()?.Accept(this);
			return new GlobalDeclaration(accessModifier, isMutableReference, fullName, type, initExpression);
		}

		public override Node VisitFunctionDeclaration(AdamantParser.FunctionDeclarationContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var parameters = context.parameterList()._parameters.Select(p => (Parameter)p.Accept(this));
			var name = context.name.GetText();
			var fullName = currentNamespace.Append(name);
			var returnType = (Type)context.returnType.Accept(this);
			var body = context.methodBody().statement().Select(s => (Statement)s.Accept(this));
			return new FunctionDeclaration(accessModifier, fullName, parameters, returnType, body);
		}

		public override Node VisitParameter(AdamantParser.ParameterContext context)
		{
			// TODO modifiers
			// TODO this parameter
			var name = context.name.GetText();
			var type = (Type)context.type.Accept(this);
			return new Parameter(name, type);
		}
		#endregion

		#region Types
		public override Node VisitMutableType(AdamantParser.MutableTypeContext context)
		{
			var isReference = context.@ref != null;
			var type = (PlainType)context.plainType().Accept(this);
			return new OwnershipType(isReference, Ownership.MutableBorrow, type);
		}

		public override Node VisitOwnedType(AdamantParser.OwnedTypeContext context)
		{
			var isReference = context.@ref != null;
			var type = (PlainType)context.plainType().Accept(this);
			return new OwnershipType(isReference, Ownership.Owned, type);
		}

		public override Node VisitImmutableType(AdamantParser.ImmutableTypeContext context)
		{
			var isReference = context.@ref != null;
			var type = (PlainType)context.plainType().Accept(this);
			return new OwnershipType(isReference, Ownership.ImmutableBorrow, type);
		}

		public override Node VisitImplicitType(AdamantParser.ImplicitTypeContext context)
		{
			var isReference = context.@ref != null;
			var type = (PlainType)context.plainType().Accept(this);
			return new OwnershipType(isReference, Ownership.Inferred, type);
		}

		public override Node VisitNamedType(AdamantParser.NamedTypeContext context)
		{
			return context.typeName().Accept(this);
		}

		public override Node VisitTypeName(AdamantParser.TypeNameContext context)
		{
			var outerType = (TypeName)context.outerType?.Accept(this);
			var name = new Name(context.identifier().GetText());
			return new TypeName(outerType, name);
		}

		public override Node VisitArraySliceType(AdamantParser.ArraySliceTypeContext context)
		{
			var elementType = (Type)context.elementType.Accept(this);
			var dimensions = context._dimensions.Count + 1;
			return new ArraySliceType(elementType, dimensions);
		}

		#endregion

		#region Members
		public override Node VisitConstructor(AdamantParser.ConstructorContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var name = new Name(context.identifier()?.GetText());
			var parameters = context.parameterList()._parameters.Select(p => (Parameter)p.Accept(this));
			var body = context.methodBody().statement().Select(s => (Statement)s.Accept(this));
			return new Constructor(accessModifier, name, parameters, body);
		}

		public override Node VisitField(AdamantParser.FieldContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var isMutableReference = context.kind.Type == AdamantLexer.Var;
			var name = new Name(context.identifier().GetText());
			var type = (OwnershipType)context.ownershipType()?.Accept(this) ?? OwnershipType.NewInferred();
			var initExpression = (Expression)context.expression()?.Accept(this);
			return new Field(accessModifier, isMutableReference, name, type, initExpression);
		}

		public override Node VisitProperty(AdamantParser.PropertyContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var parameters = context.parameterList()._parameters.Select(p => (Parameter)p.Accept(this));
			var body = context.methodBody().statement().Select(s => (Statement)s.Accept(this));
			return new Property(accessModifier, parameters, body);
		}

		public override Node VisitMethod(AdamantParser.MethodContext context)
		{
			var accessModifier = GetAccessModifier(context.modifier());
			var parameters = context.parameterList()._parameters.Select(p => (Parameter)p.Accept(this));
			var body = context.methodBody().statement().Select(s => (Statement)s.Accept(this));
			return new Method(accessModifier, parameters, body);
		}
		#endregion

		#region Statements
		public override Node VisitExpressionStatement(AdamantParser.ExpressionStatementContext context)
		{
			//TODO implement
			return new ExpressionStatement();
		}

		public override Node VisitReturnStatement(AdamantParser.ReturnStatementContext context)
		{
			// TODO implement
			return new ReturnStatement();
		}

		public override Node VisitIfStatement(AdamantParser.IfStatementContext context)
		{
			// TODO implement
			return new IfStatement();
		}

		public override Node VisitForeachStatement(AdamantParser.ForeachStatementContext context)
		{
			// TODO implement
			return new ForeachStatement();
		}
		#endregion

		#region Expressions
		public override Node VisitNewObjectExpression(AdamantParser.NewObjectExpressionContext context)
		{
			var baseTypes = context.baseTypes();
			var baseClass = (Type)baseTypes?.baseType?.Accept(this);
			var interfaces = baseTypes?._interfaces.Select(i => (Type)i.Accept(this)).ToList() ?? new List<Type>();
			var members = context.member().Select(m => (Member)m.Accept(this));
			return new NewObjectExpression(baseClass, interfaces, members);
		}

		public override Node VisitIntLiteralExpression(AdamantParser.IntLiteralExpressionContext context)
		{
			return new LiteralExpression();
		}
		#endregion

		private static IEnumerable<QualifiedName> GetNamespaces(AdamantParser.UsingStatementContext[] contexts)
		{
			return contexts.Select(s => new QualifiedName(s.namespaceName().GetText()));
		}

		private static bool Has(AdamantParser.ModifierContext[] modifiers, int desiredModifier)
		{
			return modifiers.Any(modifier => modifier.Symbol.Type == desiredModifier);
		}

		private static AccessModifier GetAccessModifier(AdamantParser.ModifierContext[] modifiers)
		{
			// Return the first access modifier
			foreach(var modifier in modifiers)
				switch(modifier.Symbol.Type)
				{
					case AdamantLexer.Public:
						return AccessModifier.Public;
					case AdamantLexer.Protected:
						return AccessModifier.Protected;
					case AdamantLexer.Package:
						return AccessModifier.Package;
					case AdamantLexer.Private:
						return AccessModifier.Private;
				}
			// If we don't find an acces modifier
			return AccessModifier.Private;
		}

		private static Safety GetSafety(AdamantParser.ModifierContext[] modifiers)
		{
			foreach(var modifier in modifiers)
				switch(modifier.Symbol.Type)
				{
					case AdamantLexer.Safe:
						return Safety.ExplicitSafe;
					case AdamantLexer.Unsafe:
						return Safety.Unsafe;
				}

			return Safety.ImplicitSafe;
		}
	}
}
