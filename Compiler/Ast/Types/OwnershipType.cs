﻿using System;
using Adamant.Compiler.Ast.Visitors;

namespace Adamant.Compiler.Ast.Types
{
	public class OwnershipType : Type
	{
		public OwnershipType(bool isReference, Ownership ownership, PlainType type)
		{
			IsReference = isReference;
			Ownership = ownership;
			OwnershipIsInferred = ownership == Ownership.Inferred;
			Type = type;
		}

		public bool IsReference { get; }
		public bool OwnershipIsInferred { get; }
		public Ownership Ownership { get; private set; }
		public PlainType Type { get; }

		public void DefaultOwnership(Ownership ownership)
		{
			if(Ownership == Ownership.Inferred)
				Ownership = ownership;
		}

		public void AssignValueWithOwnership(Ownership ownership)
		{
			if(Ownership == Ownership.Inferred)
				Ownership = ownership;
			else
			{
				// TODO check that ownership is compatible with the declared one
				throw new NotImplementedException();
			}
		}

		public static OwnershipType NewInferred()
		{
			return new OwnershipType(false, Ownership.Inferred, new InferredType());
		}

		public override TReturn Accept<TParam, TReturn>(ITypeVisitor<TParam, TReturn> visitor, TParam param)
		{
			return visitor.VisitOwnershipType(this, param);
		}
	}
}
