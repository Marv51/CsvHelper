﻿namespace CsvHelper.Tests;

/// <summary>
/// A <see cref="StreamWriter"/> class with configurable line ending for unit tests.
/// </summary>
public class TestStreamWriter : StreamWriter
{
	private readonly string newLine;

	public TestStreamWriter(Stream stream, string newLine = "\r\n") : base(stream)
	{
		this.newLine = newLine ?? throw new ArgumentNullException(nameof(newLine));
	}

	public override void WriteLine(string value)
	{
		base.Write(value);
		base.Write(newLine);
	}
}
