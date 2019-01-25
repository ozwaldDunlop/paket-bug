using System;
using System.IO;
using Ionic;
using Ionic.Zlib;

namespace ClassLibrary1
{
	public class Class1
	{
		public GZipStream Stream;

		public Class1()
		{
			this.Stream = new GZipStream(new MemoryStream(), CompressionMode.Compress);
		}
	}
}
