using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validator
{
	public static class Passport
	{
		/// <summary>
		/// Проверка паспорта.
		/// </summary>
		/// <param name="passportNumber">Номер паспорта</param>
		/// <returns></returns>
		public static bool IsPassport(string passportNumber)
		{
			// Проверка есть ли пробел между серией и номером.
			passportNumber = passportNumber.Replace(" ", "");

			if (passportNumber.All(char.IsDigit) && passportNumber.Length.Equals(10))
				return true;
			return false;
		}
	}
}
