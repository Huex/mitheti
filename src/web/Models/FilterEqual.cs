using System;

namespace Mitheti.Web.Models
{
    public class FilterEqual<T> where T : IEquatable<T>
    {
        public bool IsSet { get; set; }
        public T Value { get; set; }

        public bool Apply(T filter) => IsSet ? Value.Equals(filter) : true;
    }
}