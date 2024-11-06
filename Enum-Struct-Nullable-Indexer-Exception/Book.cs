using System;
namespace Enum_Struct_Nullable_Indexer_Exception
{
    public class Book : Product
    {
        public Book()
        {
        }

        public override void Sell()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}

