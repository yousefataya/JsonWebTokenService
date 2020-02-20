using DotNetCore.Objects;
using System.Collections.Generic;

namespace DotNetCoreArchitecture.Domain
{
    public sealed class FullName
    {
        public FullName(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }

        public string Surname { get; }

        public IEnumerable<object> GetEquals()
        {
            yield return Name;
            yield return Surname;
        }
    }
}
