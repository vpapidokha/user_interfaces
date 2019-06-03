using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	class Tetris
	{

		public Tetris() { }

		public virtual void Run()
		{
			ShowStartPage();
		}


		protected virtual void ShowStartPage()
		{
			Console.Clear();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("        ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■");
			Console.WriteLine("        ■                                                                 ■");
			Console.WriteLine("        ■     ■ ■ ■ ■ ■   ■ ■ ■ ■   ■ ■ ■ ■ ■   ■ ■ ■     ■   ■ ■ ■       ■");
			Console.WriteLine("        ■         ■       ■             ■       ■   ■     ■   ■           ■");
			Console.WriteLine("        ■         ■       ■ ■ ■         ■       ■ ■ ■     ■   ■ ■ ■       ■");
			Console.WriteLine("        ■         ■       ■             ■       ■ ■       ■       ■       ■");
			Console.WriteLine("        ■         ■       ■ ■ ■ ■       ■       ■   ■     ■   ■ ■ ■       ■");
			Console.WriteLine("        ■                                                                 ■");
			Console.WriteLine("        ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("        ■               ■ Created by Vlavyslav Papidokha ■                ■");
		}
	}
}
