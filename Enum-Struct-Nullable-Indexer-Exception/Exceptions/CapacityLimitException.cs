using System;
namespace Enum_Struct_Nullable_Indexer_Exception.Exceptions
{
	public class CapacityLimitException:Exception
    { 
        public CapacityLimitException()
		{
            Console.WriteLine("Capacity is full");
		}

        public CapacityLimitException(string message):base(message)
        {
        }

        public CapacityLimitException(string message,Exception ex):base(message,ex)
        {

        }

    }
}

