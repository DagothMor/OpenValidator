using System;
using System.Collections.Generic;
using Validator;
using Xunit;

namespace ValidatorXUnitTest
{
	public class TestINN
	{
		[Fact]
		public void PersonalINNTest()
		{
			Assert.True(INN.IsPersonalINN("99091234567"));
			Assert.True(INN.IsPersonalINN("990912345678"));

			Assert.False(INN.IsPersonalINN("9909123456"));
			Assert.False(INN.IsPersonalINN("9909123456789"));
		}
		[Fact]
		public void JuristicalINNTest()
		{
			Assert.True(INN.IsJuristicalINN("9909123456"));

			Assert.False(INN.IsJuristicalINN("99091234567"));
		}
		[Fact]
		public void IsForeignLegalPersonINNTest()
		{
			Assert.True(INN.IsForeignLegalPerson("9909123456"));

			Assert.False(INN.IsForeignLegalPerson("9908123456"));
		}
	}
}
