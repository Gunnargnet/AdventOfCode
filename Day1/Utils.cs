using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{

	public class Utils
	{
		public Utils()
		{
		}

		public string GetImportedData(string filename)
		{
			var fileroot = "C:\\Utveckling\\AdventOfCode2023\\AdventOfCode\\AdventOfCode2023\\ImportData\\";

			StreamReader sr = new StreamReader(fileroot + filename + ".txt");

			var line = sr.ReadLine();

			//Continue to read until you reach end of file
			while (line != null)
			{
				//write the line to console window
				Console.WriteLine(line);
				//Read the next line
				line = sr.ReadLine();
			}
			//close the file
			sr.Close();
			return line;

		}

	}

	

}
