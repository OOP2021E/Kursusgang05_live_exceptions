using System;

namespace Exceptions
{
    class Example
    {


        public void Run()
        {
            Person p = ParsePerson("Henrik Hansen, 1t0");
            Console.WriteLine(p);
        }

        public Person IndirectParsePerson(string s) {
            return ParsePerson(s);
        }

        int foo()
        {
            throw new NotImplementedException();
        }

        public  Person ParsePerson(string v)
        {
            Console.WriteLine("PArsing");
            string[] parts = v.Split(',');
            string[] nameparts = parts[0].Split(' ', 2);
            try
            {
                var age = int.Parse(parts[1]);
                var name = nameparts[0];
                var lastname = nameparts[1];
                return new Person
                {
                    Age = age,
                    Name = name,
                    Lastname = lastname,
                };
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new NameformatException(parts[0]);
            }
            catch(FormatException ex)
            {
                throw new PersonAgeException();
            }
            finally
            {
                Console.WriteLine("done");
            }
        }
    }
}
