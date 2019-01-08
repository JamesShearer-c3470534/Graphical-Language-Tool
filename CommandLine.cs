
<<<<<<< HEAD
=======

>>>>>>> bfa5cdce0a097982385df5656acf262ba42916a7
using System;
using System.Collections.Generic;

namespace BlackBeltCoder
{
	/// <summary>
	/// Represents a command-line flag argument
	/// </summary>
	public class CommandLineFlag
	{
		public string Flag { get; set; }
		public string Argument { get; set; }
	}

	/// <summary>
	/// Command line parser class
	/// </summary>
	class CommandLine
	{
		// List of command-line arguments
		public List<string> Arguments { get; set; }

		// List of command-line flags
		public List<CommandLineFlag> Flags { get; set; }

		// Parsing state variables
		string _cmd;
		int _pos;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="commandLine">Command line to parse</param>
		public CommandLine(string commandLine)
		{
			// Initialize parser for given command line
			BeginParsing(commandLine);

			// Loop until all characters processed
			while (!EndOfText)
			{
				// Skip whitespace
				while (Char.IsWhiteSpace(Peek()))
					MoveAhead();

				// Determine if this is a flag
				if (Peek() == '/' || Peek() == '-')
				{
					// Parse flag
					MoveAhead();
					int start = _pos;
					while (Char.IsLetterOrDigit(Peek()))
						MoveAhead();
					if (_pos > start)
					{
						CommandLineFlag flag = new CommandLineFlag();
						flag.Flag = _cmd.Substring(start, _pos - start);
						if (Peek() == ':')
						{
							// Parse flag argument
							MoveAhead();
							flag.Argument = ParseArgument();
						}
						Flags.Add(flag);
					}
				}
				else
				{
					// Parse command-line argument
					string arg = ParseArgument();
					if (arg.Length > 0)
						Arguments.Add(arg);
				}
			}
		}

		/// <summary>
		/// Initializes parser state variables to parse specified
		/// command line.
		/// </summary>
		/// <param name="commandLine">Command line to parse</param>
		protected void BeginParsing(string commandLine)
		{
			Arguments = new List<string>();
			Flags = new List<CommandLineFlag>();
			_cmd = commandLine;
			_pos = 0;
		}

		/// <summary>
		/// Returns true if the current position is at the end of
		/// the string.
		/// </summary>
		protected bool EndOfText
		{
			get { return (_pos >= _cmd.Length); }
		}

		/// <summary>
		/// Safely returns the character at the current position.
		/// </summary>
		protected char Peek()
		{
			return (_pos < _cmd.Length) ? _cmd[_pos] : (char)0;
		}

		/// <summary>
		/// Safely advances to current position to the next
		/// character.
		/// </summary>
		protected char MoveAhead()
		{
			char c = Peek();
			_pos = Math.Min(_pos + 1, _cmd.Length);
			return c;
		}

		/// <summary>
		/// Parses a command-line argument. Supports arguments enclosed
		/// in double or single quotation marks. If no argument could
		/// be parsed, an empty string is returned.
		/// </summary>
		protected string ParseArgument()
		{
			string result;

			if (Peek() == '"' || Peek() == '\'')
			{
				// Parse quoted argument
				char quote = MoveAhead();
				int start = _pos;
				while (!EndOfText && Peek() != quote)
					MoveAhead();
				result = _cmd.Substring(start, _pos - start);
				MoveAhead();	// Eat closing quote
			}
			else
			{
				// Parse argument
				int start = _pos;
				while (!EndOfText && !Char.IsWhiteSpace(Peek()) &&
					Peek() != '/' && Peek() != '-')
					MoveAhead();
				result = _cmd.Substring(start, _pos - start);
			}
			// Return the parsed argument
			return result;
		}
	}
}
