using System;
using System.Collections.Generic;
using System.Text;
using Validator;
using Xunit;

namespace ValidatorXUnitTest
{
	public class OKVEDTEST
	{
		[Fact]
		public void IsOKVED()
		{
			Assert.True(OKVED.IsOKVED("1.1.1"));
			Assert.True(OKVED.IsOKVED("11.11.11"));

			Assert.False(OKVED.IsOKVED("11..11.11"));
			Assert.False(OKVED.IsOKVED("11.111.11"));
			Assert.False(OKVED.IsOKVED("11.11.1.1"));
		}
	}
}
