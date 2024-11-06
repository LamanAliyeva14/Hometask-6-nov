using System;
namespace Enum_Struct_Nullable_Indexer_Exception.Exceptions
{
	public class NotFoundException : Exception
	{
		public NotFoundException()
		{
			Console.WriteLine("Object not found");
		}

        public NotFoundException(string message):base(message)
        {
            
        }

        public NotFoundException(string message, Exception ex):base(message, ex)
        {

        }

    }
}

