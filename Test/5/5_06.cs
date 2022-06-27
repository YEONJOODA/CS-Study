using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
	[Serializable]
	class Orange
	{
		private string country;
		private int price;

		public Orange(string country, int price)
		{
			this.country = country;
			this.price = price;
		}

		public void Show()
		{
			Console.WriteLine("원산지 : " + country);
			Console.WriteLine("가격 : " + price);
		}
	}

	internal class _5_06
	{
		static void Main1(string[] args)
		{
			string path = "C:\\Users\\1302\\Desktop\\Orange.dat";

			// 직렬화
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				BinaryFormatter serializer = new BinaryFormatter();

				Orange orange = new Orange("캘리포니아", 5000);
				serializer.Serialize(fs, orange);
			}

			// 역직렬화
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				BinaryFormatter deserializer = new BinaryFormatter();

				Orange orange = (Orange)deserializer.Deserialize(fs);
				orange.Show();
			}
		}
	}
}
