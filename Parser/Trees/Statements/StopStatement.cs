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
using VBConverter.CodeParser.Trees.Comments;

namespace VBConverter.CodeParser.Trees.Statements
{
	/// <summary>
	/// A parse tree for a Stop statement.
	/// </summary>
	public sealed class StopStatement : Statement
	{

		/// <summary>
		/// Constructs a new parse tree for a Stop statement.
		/// </summary>
		/// <param name="span">The location of the parse tree.</param>
		/// <param name="comments">The comments for the parse tree.</param>
		public StopStatement(Span span, IList<Comment> comments) : base(TreeType.StopStatement, span, comments)
		{
		}
	}
}
