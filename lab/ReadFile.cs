using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace lab
{
	internal class ReadFile
	{
		private static ReadFile ins = null;

		private ReadFile()
		{
			ReadFromFile();
		}

		private List<string> con;

		private void ReadFromFile()
		{
			con = new List<string>();
			con = File.ReadAllLines("file.txt").ToList();

			//Data Source=ASMAALAP;Initial Catalog=Hotel;Integrated Security=True
			string cons =
				$@"Data Source={con[0]};Initial Catalog={con[1]};Integrated Security=True;UserID={con[2]};Password={con[4]};";
			Properties.Settings.Default.con = cons;

		}

		public static ReadFile InsFile()
		{
			return ins ?? (ins = new ReadFile());
		}
	}
}
