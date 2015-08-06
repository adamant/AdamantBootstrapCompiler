﻿using System;
using Adamant.Compiler.Antlr;
using Adamant.Compiler.Cmd.Options;
using Antlr4.Runtime;
using NDesk.Options;
using NDesk.Options.Extensions;

namespace Adamant.Compiler.Cmd
{
	public class Program
	{
		static void Main(string[] args)
		{
			var options = ParseOptions(args);

			var filename = args[0];
			var stream = new AntlrFileStream(filename);
			var lexer = new AdamantLexer(stream);
			var tokens = new CommonTokenStream(lexer);
			if(options.Action == CmdAction.Tokenize)
			{
				tokens.Fill();
				foreach(var token in tokens.GetTokens())
					Console.WriteLine(token);
				return;
			}
			var parser = new AdamantParser(tokens);
			parser.BuildParseTree = true;
			var tree = parser.compilationUnit();
		}

		private static CmdOptions ParseOptions(string[] args)
		{
			var options = new OptionSet();
			var tokenize = options.AddSwitch("tokenize", "Rather than compiling, run the lexer and output the tokens");

			var files = options.Parse(args);

			return new CmdOptions()
			{
				File = files[0],
				Action = tokenize ? CmdAction.Tokenize : CmdAction.Compile,
			};
		}
	}
}
