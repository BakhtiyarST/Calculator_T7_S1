using System.Numerics;
using System.Text;

namespace Seminar1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double val1, val2, result=0;
			string operand;

			if (args.Length == 3)
			{
				val1 = Double.Parse(args[0]);
				val2 = Double.Parse(args[2]);
				operand = args[1];
				if (operand=="+")
				{
					result = val1 + val2;
				}
				else if (operand=="-")
				{
					result = val1 - val2;
				}
				else if ( operand=="*")
				{
					result = val1 * val2;
				}
				else if (operand == "/")
				{
					result = val1 / val2;
				}
				Console.WriteLine($"The result is: {result}");
			}
			else
			{
				Console.WriteLine("The wrong number of arguments");
			}

			/*
			int val1, val2, ind1, ind2, count;
			double res;
			string resStr, oper, valStr1, valStr2, tmpStr;
			List<string> operStr = new List<string>();
			List<string> valStr = new List<string>();

			string operands = "+-*%^/";
			count = -1;
			if (args.Length == 0)
			{
				Console.WriteLine("Please enter the expression. Try again.");
			}
			else
			{
				StringBuilder sb = new StringBuilder();
				Console.WriteLine($"args size: {args.Length}");
				foreach (string arg in args)
				{
					Console.WriteLine($"current arg = {arg}");
					if (arg.Equals(' '))
					{
						Console.WriteLine($"arg is space");
					}
					else if (arg.Equals("+"))
					{
						Console.WriteLine($"arg is +");
					}
					else
					{
						Console.WriteLine($"arg is another one");
					}
					if (arg.Equals(' '))
					{
						continue;
					}
					else if (arg.Equals('+') || arg.Equals('-') || arg.Equals('*') || arg.Equals('/'))
					{
						count++;
						operStr.Add(arg);
						valStr.Add(sb.ToString());
						sb.Clear();
					}
					else
					{
						sb.Append(arg);
					}
				}
				
				if (sb.ToString().Length > 0)
				{
					valStr.Add(sb.ToString());
					Console.WriteLine($"valStr: {sb.ToString()}");
					sb.Clear();
					val1 = Convert.ToInt32(valStr[0]);
					val2 = Convert.ToInt32(valStr[1]);
					Console.WriteLine($"Val1 = {val1}");
					Console.WriteLine($"Val2 = {val2}");
					Console.WriteLine($"Operand = {operStr[0]}");
					if (operStr[0].Equals("+"))
					{
						res = val1 + val2;
					}
					else if (operStr[0].Equals("-"))
					{
						res = val1 - val2;
					}
					else if (operStr[0].Equals("*"))
					{
						res = val1 * val2;
					}
					else if (operStr[0].Equals("/"))
					{
						res = (double)val1 / val2;
					}
					else
					{
						Console.WriteLine("Operand is not recongnised. Try again.");
						return;
					}
					Console.WriteLine($"The result is: {res}");
				}
				else
				{
					Console.WriteLine("The entered expression is incorrect. Try again.");
				}
				
			}
			*/
    }
	}
}

/*
else if (operStr[0].Equals("%"))
{
	res = val1 % val2;
}
else if (operStr[0].Equals("^"))
{
	res = Math.Pow((double)val1, (double)val2);
}
*/