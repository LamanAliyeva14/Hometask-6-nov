using System;
namespace Enum_Struct_Nullable_Indexer_Exception
{
	abstract class Product
	{
		public string Name;
		private int _id;
		public double Price;
		public int Count;
		protected double TotalIncome;
		public int Id
		{
			get => _id;
			set
			{

			}
		}


		public Product(int id, string name, double price, int count)
		{
			_id = id;
			Name = name;
			Price = price;
			Count = count;
		}

		public static void AddBooks(string word)
		{
			int[] ints = new int[0];
			for (int i = 0; i < word.Length; i++)
			{
				Array.Resize(ref ints, ints.Length + 1);
				ints[ints.Length - 1] = i;
			}
		}



		public abstract void Sell();

		public abstract void ShowInfo();


	}
}

