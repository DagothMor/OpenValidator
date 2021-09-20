using System;
using System.Collections.Generic;
using System.Text;
using Validator;
using Xunit;

namespace ValidatorXUnitTest
{
	public class TestPassport
	{
		[Fact]
		public void IsPassport()
		{
			Assert.True(Passport.IsPassport("3630 432234"));
			Assert.True(Passport.IsPassport("3630432234"));

			Assert.False(Passport.IsPassport("363o 432234"));
			Assert.False(Passport.IsPassport("3630.432234"));
		}
	}
}
