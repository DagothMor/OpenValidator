using System;
using System.Collections.Generic;
using System.Text;
using Validator;
using Xunit;

namespace ValidatorXUnitTest
{
	public class TestPhone
	{
		[Fact]
		public void IsPhone()
		{
			Assert.True(Phone.IsPhone( "88005553535"));
			Assert.True(Phone.IsPhone( "+78005553535"));
			Assert.True(Phone.IsPhone( "+7(800)-555-35-35"));

			Assert.False(Phone.IsPhone("80o5553535"));
			Assert.False(Phone.IsPhone("+7(800)-55+5-35-35"));
		}
		[Fact]
		public void IsPhoneInRange()
		{
			Assert.True(Phone.IsPhone("123456789",7,11));
			Assert.True(Phone.IsPhone("+7(800)-555-35-35",7,11));

			Assert.False(Phone.IsPhone("9909123456789",7,11));
			Assert.False(Phone.IsPhone("+7(800)-55+5-35-35",7,11));
		}
		[Fact]
		public void IsPhoneInSpecialLength()
		{
			Assert.True(Phone.IsPhone("123456789",9));
			Assert.True(Phone.IsPhone("+1(234)-567-89-01",11));

			Assert.False(Phone.IsPhone("+1(234)-55+5-35-35", 7));
			Assert.False(Phone.IsPhone("1234567890",9));
		}
	}
}
