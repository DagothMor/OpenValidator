using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validator
{
	public static class Phone
	{
		/// <summary>
		/// Является ли строка по ссылке номером телефона.
		/// </summary>
		/// <param name="phonenumber">Номер телефона.</param>
		/// <returns></returns>
		public static bool IsPhone(ref string phonenumber)
		{
			
			// чистка от второстепенных символов.
			phonenumber = phonenumber.Replace("-", "");
			phonenumber = phonenumber.Replace("(", "");
			phonenumber = phonenumber.Replace(")", "");
			phonenumber = phonenumber.Replace("_", "");

			if (phonenumber.Contains("+"))
			{
				// Есть ли плюс после первого символа.
				if (phonenumber.Skip(1).Contains('+'))
					return false;
			}
			phonenumber = phonenumber.Replace("+", "");
			if (phonenumber.All(char.IsDigit))
				return true;
			return false;
		}

		/// <summary>
		/// Является ли строка номером телефона.
		/// </summary>
		/// <param name="phonenNumber">Номер телефона.</param>
		/// <returns></returns>
		public static bool IsPhone(string phonenNumber)
		{
			// чистка от второстепенных символов.
			phonenNumber = phonenNumber.Replace("-", "");
			phonenNumber = phonenNumber.Replace("(", "");
			phonenNumber = phonenNumber.Replace(")", "");
			phonenNumber = phonenNumber.Replace("_", "");

			if (phonenNumber.Contains("+"))
			{
				// Есть ли плюс после первого символа.
				if (phonenNumber.Skip(1).Contains('+'))
					return false;
			}
			phonenNumber = phonenNumber.Replace("+", "");
			if (phonenNumber.All(char.IsDigit))
				return true;
			return false;
		}

		/// <summary>
		/// Проверка телефона с определенной длиной номера.
		/// </summary>
		/// <param name="phonenumber">Номер телефона.</param>
		/// <param name="length">Длина телефона.</param>
		/// <returns></returns>
		public static bool IsPhone(string phoneNumber, int length)
		{
			if (!IsPhone(ref phoneNumber))
				return false;

			// Является ли очищенное от + - () число определенной длины.
			if (phoneNumber.Length != length)
				return false;

			return true;
		}

		/// <summary>
		/// Проверка телефона в выбранном диапазоне.
		/// </summary>
		/// <param name="phoneNumber">Номер телефона</param>
		/// <param name="maxLength"> Максимальная длина числа телефона, например сотового.</param>
		/// <param name="minLength"> Минимальная длина числа телефона, например домашнего.</param>
		/// <returns></returns>
		public static bool IsPhone(string phoneNumber, int minLength, int maxLength)
		{
			if (!IsPhone(ref phoneNumber))
				return false;
			bool kek = phoneNumber.Length <= maxLength;
			bool lol = phoneNumber.Length >= minLength;
			// Находится ли очищенное от + - () число в указанном диапазоне.
			if (kek
				&& lol)
				return true;

			return false;
		}
	}
}
