 using System;
using System.Collections.Generic;

namespace BilBulat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] num = { 2, 7, 11, 15 };
			int target = 9;

			int[] hasil = Bil(num,target);

			if(hasil != null)
			{
				Console.WriteLine($"Map : {hasil[0]},{hasil[1]}");
				Console.WriteLine($"Bilangan : {num[hasil[0]]},{num[hasil[1]]}");
			}
			else
			{
				Console.WriteLine("Tidak ada yang diketahui");
			}
		}

		static int[] Bil(int[] num,int target)
		{
			Dictionary<int,int> map = new Dictionary<int,int>();

			for(int a=0;a< num.Length; a++)
			{
				int Kom = target - num[a];
				if(map.ContainsKey(Kom))
				{
					return new int[] { map[Kom], a };
				}
				map[num[a]] = a;
			}

			return null;
		}
	}
}
