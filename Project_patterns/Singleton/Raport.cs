using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_patterns.Singleton
{
    public class Raport
    {
		private StreamWriter _writer;
		private static Raport _raport;
		private Raport()
		{
			_writer = new StreamWriter(@"C:\log.txt", true);
		}

		public static Raport GetInstance()
		{
			if (_raport == null)
				_raport = new Raport();

			return _raport;
		}

		public void DodajDoRaportu(string informacje)
		{
			_writer.WriteLine(informacje);
		}

		public void ZamknijRaport()
		{
			_writer.Close();
		}
	}
}
