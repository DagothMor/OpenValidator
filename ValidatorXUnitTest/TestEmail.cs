using System;
using System.Collections.Generic;
using Validator;
using Xunit;

namespace ValidatorXUnitTest
{
	public class TestEmail
	{
		[Fact]
		public void EmailTest()
		{
			var host = "akelon.com";

			List<string> validEmails = new List<string>()
			{
				"valid@akelon.com",
				"valiiid@akelon.com",
				"1@akelon.com"
			};
			List<string> unvalidEmails = new List<string>()
			{
				"valid@akelon.com",
				"valiiid@akelon.com",
				"1@akelon.com"
			};
			foreach (var email in validEmails)
			{
				Assert.True(Email.IsEmail(email));
			}
			foreach (var email in validEmails)
			{
				Assert.True(Email.HasAHost(email, host));
			}
		}
	}
}
