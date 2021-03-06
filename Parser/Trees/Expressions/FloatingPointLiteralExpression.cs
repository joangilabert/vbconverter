using System;
using System.Collections.Generic;
using System.Text;
//
// Visual Basic .NET Parser
//
// Copyright (C) 2005, Microsoft Corporation. All rights reserved.
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
// EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
// MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//

using VBConverter.CodeParser.Base;

namespace VBConverter.CodeParser.Trees.Expressions
{
	/// <summary>
	/// A parse tree for a floating point literal.
	/// </summary>
	public sealed class FloatingPointLiteralExpression : NumericLiteralExpression<double>
	{
		/// <summary>
		/// Constructs a new parse tree for a floating point literal.
		/// </summary>
		/// <param name="literal">The literal value.</param>
		/// <param name="typeCharacter">The type character on the literal.</param>
		/// <param name="span">The location of the parse tree.</param>
		public FloatingPointLiteralExpression(double literal, TypeCharacter typeCharacter, Span span) : base(literal, typeCharacter, TreeType.FloatingPointLiteralExpression, span)
		{
		}
	}
}
