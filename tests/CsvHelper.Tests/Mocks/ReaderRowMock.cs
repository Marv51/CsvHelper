﻿using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.Tests.Mocks
{
	public class ReaderRowMock : IReaderRow
	{
		public string this[int index] => throw new NotImplementedException();

		public string this[string name] => throw new NotImplementedException();

		public string this[string name, int index] => throw new NotImplementedException();

		public int ColumnCount => throw new NotImplementedException();

		public int CurrentIndex => throw new NotImplementedException();

		public string[] HeaderRecord => throw new NotImplementedException();

		public IParser Parser => throw new NotImplementedException();

		public CsvContext Context => throw new NotImplementedException();

		public IReaderConfiguration Configuration { get; private set; }

		public ReaderRowMock()
		{
			Configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
		}

		public ReaderRowMock(CsvConfiguration configuration)
		{
			Configuration = configuration;
		}

		public string GetField(int index)
		{
			throw new NotImplementedException();
		}

		public string GetField(string name)
		{
			throw new NotImplementedException();
		}

		public string GetField(string name, int index)
		{
			throw new NotImplementedException();
		}

		public object GetField(Type type, int index)
		{
			throw new NotImplementedException();
		}

		public object GetField(Type type, string name)
		{
			throw new NotImplementedException();
		}

		public object GetField(Type type, string name, int index)
		{
			throw new NotImplementedException();
		}

		public T GetField<T>(int index)
		{
			throw new NotImplementedException();
		}

		public T GetField<T>(string name)
		{
			throw new NotImplementedException();
		}

		public T GetField<T>(string name, int index)
		{
			throw new NotImplementedException();
		}

		public T GetRecord<T>()
		{
			throw new NotImplementedException();
		}

		public T GetRecord<T>(T anonymousTypeDefinition)
		{
			throw new NotImplementedException();
		}

		public object GetRecord(Type type)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField(Type type, int index, out object field)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField(Type type, string name, out object field)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField(Type type, string name, int index, out object field)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField<T>(int index, out T field)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField<T>(string name, out T field)
		{
			throw new NotImplementedException();
		}

		public bool TryGetField<T>(string name, int index, out T field)
		{
			throw new NotImplementedException();
		}
	}
}
