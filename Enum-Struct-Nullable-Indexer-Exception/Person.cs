using System;
namespace Enum_Struct_Nullable_Indexer_Exception
{
	public class Person
	{
		private string _name;
		private string _surname;
		private byte age;
		public string Name { get; set; }
		public string Surname { get; set; }
		public byte Age { get; set; }

		public Person(string name, string surname, byte age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}

		public static bool operator <=(Person a, Person b)
		{
			return a.Age <= b.Age;
		}
	    public static bool operator >=(Person a, Person b)
		{
			return a.Age >= b.Age;
		}


	}
}

