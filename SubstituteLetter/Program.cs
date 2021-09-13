using System;

namespace SubstituteLetter
{
    class Program
    {
        static void Main(string[] args)
        {
			//ABCDEFGHIJKLMNOPQRSTUVWXYZ
			//pan=CNA
			var req = "pan";
			var res = getLenght(req);
			Console.Write($"request: {req}\nresponse: {res}");
		}

		private static string getLenght(string text)
		{
			string response = "";
			string result = "";
			string str = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ").ToLower();
			int FinalPosition = 0;
			for (var ii = 0; ii < text.Length; ii++)
			{
				char l = text[ii];
				//Console.WriteLine(l);
				for (var i = 0; i < str.Length; i++)
				{
					char letter = str[i];
					if (l == letter)
					{
						//Console.WriteLine(letter + ": " + i);
						FinalPosition = i;
						//Console.WriteLine("position: " + FinalPosition);
					}
				}

				if (FinalPosition >= 13) str = str + str;
				//Console.WriteLine("text: " + str.Substring(FinalPosition + 13, 1));
				result = str.Substring(FinalPosition + 13, 1);
				//Console.WriteLine("result: " + result);
				response = response + result;
			}
			//Console.WriteLine("response: " + response.ToUpper() + "\n");

			return response;
		}
	}
}
