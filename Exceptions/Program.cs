using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {





            var be = new BadExamples();
            int k = 0;
            while (true)
            {
                try
                {
                    k=be.ParseTal(Console.ReadLine());
                    break;
                }
                catch (NumberFormatException e) {
                    Console.WriteLine("Prøv igen");
                }
            }
            Console.WriteLine(k);
            return;


            try
            {
                Example e = new Example();

                Person p = e.IndirectParsePerson("Henrik Hansen, 1t0");
                Console.WriteLine(p);




            } 
            //catch(PersonAgeException ex)
            //{
            //    Console.WriteLine("Alder er fejlformateret");
            //    //Console.WriteLine(ex.Message);
            //}
            catch(NameformatException ex)
            {
                Console.WriteLine("Navn er fejlformateret");
            }
            catch (AppException ex)
            {
                Console.WriteLine("Ukendt app fejl");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ukendt fejl");
            }
            //new Example().Run();
        }
    }
}
