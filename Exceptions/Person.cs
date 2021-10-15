namespace Exceptions
{
    internal class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Lastname} {Age}";
        }
    }
}