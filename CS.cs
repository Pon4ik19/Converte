using System;

namespace Converter
{
	public class CS
	{
		public CS ()
		{
		}
		static public string F(string str)
		{
			if (str.IndexOf (".") == -1)
				return str;
			else if (str.Length >= str.IndexOf (".") + 6)
				return str.Substring (0, str.IndexOf (".") + 5);
			else
				return str;
		}

	}
}

