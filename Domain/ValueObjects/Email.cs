using DotNetCore.Objects;
using System.Collections.Generic;

namespace DotNetCoreArchitecture.Domain
{
    public sealed class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; }


    }
}
