using System;
namespace Enum_Struct_Nullable_Indexer_Exception.Exceptions
{
	public class ProductCountIsZeroException:Exception
	{
		public ProductCountIsZeroException()
		{
            Console.WriteLine("Count of product is 0");
		}

        public ProductCountIsZeroException(string message):base(message)
        {
        }

        public ProductCountIsZeroException(string message, Exception ex):base(message, ex)
        {
        }
    }
}

