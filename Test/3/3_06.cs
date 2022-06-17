using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
	class Rent
	{
		public void Payment()
		{
			Console.WriteLine("임대료를 받습니다.");
		}
	}

	class Landload : Rent
	{
		public void GetMoney()
		{
			Console.WriteLine("건물주 입니다.");
			Payment();
		}
	}

	internal class _3_06
	{
		static void Main1(string[] args)
		{
			Landload master = new Landload();
			master.GetMoney();
		}
	}
}
