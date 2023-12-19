﻿// Copyright 2009-2021 Josh Close
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
namespace CsvHelper.Tests.Mocks;


public class ParserMockTests
    {
	[Fact]
        public void Test()
	{
		var parser = new ParserMock
		{
			{ "Id", "Name" },
			{ "1", "one" },
		};
		Assert.True(parser.Read());
		Assert.Equal("Id", parser[0]);
		Assert.Equal("Name", parser[1]);

		Assert.True(parser.Read());
		Assert.Equal("1", parser[0]);
		Assert.Equal("one", parser[1]);

		Assert.False(parser.Read());
		Assert.False(parser.Read());
	}
}
