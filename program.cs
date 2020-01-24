using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class Program
    {
		
		public List<int> ocena = new List<int>();
		public List<int> cas = new List<int>();
		public List<int> procenti = new List<int>();

         static void Main(string[] args)
         {
			
			

			List<int> ocena = new List<int>();
			List<int> cas = new List<int>();
			List<int> procenti = new List<int>();
/*
			System.Console.WriteLine("Contents of WriteLines2.txt = ");
			foreach (string line in ocene)
			{
				Console.WriteLine("\t" + line);
			}
			*/

	
			string[] w_ocene = { "1", "3", "5", "2", "2", "4", "3" };
			System.IO.File.WriteAllLines(@"C:\Users\Vidjan\Desktop\test\test\ocene_database.txt", w_ocene);

			string[] w_cas = { "8", "9", "11", "4", "5", "9", "3", "5" };
			System.IO.File.WriteAllLines(@"C:\Users\Vidjan\Desktop\test\test\cas_database.txt", w_cas);


			string[] ocene_s = System.IO.File.ReadAllLines(@"C:\Users\Vidjan\Desktop\test\test\ocene_database.txt");

			int linesint = 0;
			int m = ocene_s.Count();
			for (int k = 0; k < m; k++)
			{
				Int32.TryParse(ocene_s[k], out linesint);
				ocena.Add(linesint);
				Console.WriteLine(ocena[k]);
			}


			string[] cas_s = System.IO.File.ReadAllLines(@"C:\Users\Vidjan\Desktop\test\test\cas_database.txt");

			int casint = 0;
			int n = cas_s.Count();
			for (int g = 0; g < n; g++)
			{
				Int32.TryParse(cas_s[g], out casint);
				cas.Add(casint);
				Console.WriteLine(cas[g]);
			}

			// od tu gor je za branje iz txt file

		label:
			Console.Write("Kakšno oceno si dobil na testu? (1-5)");
			string ocena1 = Console.ReadLine();
			int x = 0;
			Int32.TryParse(ocena1, out x);
			

			if (x > 5 || x < 1)
			{
				Console.Write("Invalid value");
				goto label;
			}
			else
			{
				Console.Write("Hvala!");
				ocena.Add(x);
			}
			/*
		label2:
			Console.Write("Koliko procentov?(0-100)");
			string procent = Console.ReadLine();
			int y = 0;
			Int32.TryParse(procent, out y);

			if (y > 100 || y < 1)
			{
				Console.Write("Invalid value");
				goto label2;
			}
			else
			{
				Console.Write("Hvala!");
				procenti.Add(y);

			}
			*/

			Console.WriteLine("Koliko ur si se učil za test?");
			string cas1 = Console.ReadLine();
			int z = 0;
			Int32.TryParse(cas1, out z);
			cas.Add(z);


			float avg_ocene;
			int vsota_ocen;
			vsota_ocen = ocena.Sum();
			m = ocena.Count();
			avg_ocene = vsota_ocen / m;

			Console.WriteLine("avg ocene: " + avg_ocene);
			Console.WriteLine("m: " + m);
			Console.WriteLine("vsota ocen: " + vsota_ocen);


			float sestevek_casa = 0f;
			float priporoceno = 1f;
			for(int j = 0; j < m; j++)
			{
					if (avg_ocene < ocena[j])
					sestevek_casa = ocena[j] + sestevek_casa;
			}

			priporoceno = sestevek_casa / m;
			Console.WriteLine("sestevek casa: " + sestevek_casa);
			Console.WriteLine("priporoceno" + priporoceno);
			goto label;
        }

		

			
			

		
		

	}
}
