using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreArchitecture.Domain
{
    public class BookCatogryEntityFactory
    {
        public static BookCatogryEntity Create(string Description)
        {
            return new BookCatogryEntity(Description); ;
        }
    }
}
