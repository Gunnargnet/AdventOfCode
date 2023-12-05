using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AocUtils;

public static class Utils
{

	public static string[] GetImportedData(string filename = "TextFile1.txt")
	{
		var allLines = File.ReadAllLines(filename);


		//StreamReader sr = new StreamReader(filename);

		//var line = sr.ReadLine();

		////Continue to read until you reach end of file
		//while (line != null)
		//{
		//	//write the line to console window
		//	Console.WriteLine(line);
		//	//Read the next line
		//	line = sr.ReadLine();
		//}
		////close the file
		//sr.Close();

		return allLines;

	}

}



