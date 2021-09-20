using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Validator
{
	public static class Email
	{
		/// <summary>
		/// Проверка почты.
		/// </summary>
		/// <param name="email">Почта</param>
		/// <returns></returns>
		public static bool IsEmail(string email)
		{
			try
			{
				var addr = new MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Проверка того, что почта относится к указанному хосту.
		/// </summary>
		/// <param name="email">Почта.</param>
		/// <param name="host">Указанный хост.</param>
		/// <returns></returns>
		public static bool HasAHost(string email, string host)
		{
			try
			{
				var addr = new MailAddress(email);
				return addr.Host == host;
			}
			catch
			{
				return false;
			}
		}
	}
}
