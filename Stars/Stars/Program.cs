using System;

namespace Stars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Triangle Town");
			DrawFirstTriangle (10);
			DrawSecondTriangle (10);
			DrawThirdTriangle (10);
			DrawFourthTriangle (10);
		}

		static void DrawFirstTriangle(int size) { 
			for (int i = 0; i <= 5; i++) {
				for (int j = 0; j <= i; j++) {
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
		
		}

		static void DrawSecondTriangle(int size) { 
			for (int i = 5; i >= 0; i--) {
				for (int j = 0; j <= i; j++) {
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
		}

		static void DrawThirdTriangle(int size) { 
			for (int i = 5; i >= 0; i--) {
				for (int j = 0; j <= 5; j++) {
					if (i > j) {
						Console.Write (" ");
					} else {
						Console.Write ("*");
					}
				}
				Console.WriteLine ();	
			}
		}

		static void DrawFourthTriangle(int size) { 
			for (int i = 0; i <= 5; i++) {
				for (int j = 0; j <= 5; j++) {
					if (i > j) {
						Console.Write (" ");
					} else {
						Console.Write ("*");
					}
				}
				Console.WriteLine ();	
			}
		}		
	}
}
