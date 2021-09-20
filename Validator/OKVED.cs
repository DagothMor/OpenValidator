using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Validator
{
	public static class OKVED
	{
		/// <summary>
		/// Проверка ОКВЭД.
		/// </summary>
		/// <param name="OKVED">Номер ОКВЭД</param>
		/// <returns></returns>
		public static bool IsOKVED(string OKVED)
		{
			bool previousCharIsDot = true;
			sbyte countOfDigits = 0;
			sbyte countOfDots = 0;
			foreach (var c in OKVED)
			{
				if (!char.IsDigit(c) && c != '.')
					return false;
			}
			// Есть ли лишние символы.
			if (OKVED.Length > 9)
				return false;
			foreach (char c in OKVED)
			{
				if (c == '.')
				{
					countOfDots++;
					if (countOfDots > 2)
						return false;
					if (previousCharIsDot == true)
						return false;
					else
					{
						countOfDigits = 0;
						previousCharIsDot = true;
					}
				}
				else
				{
					if (countOfDigits < 2)
					{
						countOfDigits++;
						previousCharIsDot = false;
					}
					else
						return false;
				}
			}
			return true;
		}
	}
}
