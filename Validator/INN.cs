using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
	public static class INN
	{
		/// <summary>
		/// Проверка ИНН.
		/// </summary>
		/// <param name="innNumber">Номер ИНН</param>
		/// <returns></returns>
		public static bool IsPersonalINN(string innNumber)
		{ 
			return !innNumber.Contains("1234567890")
				&& innNumber.Length == 11
				|| innNumber.Length == 12;
		}

		/// <summary>
		/// Проверка юридического ИНН.
		/// </summary>
		/// <param name="innNumber">Номер ИНН</param>
		/// <returns></returns>
		public static bool IsJuristicalINN(string innNumber)
		{
			return !innNumber.Contains("1234567890")
				&& innNumber.Length == 10;
		}
		/// <summary>
		/// Проверка ИНН иностранного юридического лица.
		/// </summary>
		/// <param name="innNumber">Номер ИНН</param>
		/// <returns></returns>
		public static bool IsForeignLegalPerson(string innNumber)
		{
			try
			{
				return innNumber.Substring(0,4).Equals("9909") && IsJuristicalINN(innNumber);
			}
			catch
			{
				return false;
			}
		}
	}
}
