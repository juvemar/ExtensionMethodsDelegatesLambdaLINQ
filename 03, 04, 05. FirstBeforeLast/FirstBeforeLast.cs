using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstBeforeLast
{
    public class FirstBeforeLast
    {
        static void Main()
        {
            var initialStudents = new List<Student> { new Student("Georgi","Minchev", 25), 
                                                      new Student("Simeon", "Georgiev", 14),
                                                      new Student("Andrey", "Milanov", 20),
                                                      new Student("Kamen", "Kamenov", 17),
                                                      new Student("Kamen", "Stankov", 27),
                                                      new Student("Stamen", "Anastasov", 29),
                                                      new Student("Diana", "Paskaleva", 22),
                                                      new Student("Diana", "Lukova", 19),
                                                      new Student("Petio", "Mishev", 22),
                                                      new Student("Petya","Daskalova", 18),
                                                      };
            
            var lastAfterFirstName = initialStudents.Where(p => p.FirstName.CompareTo(p.LastName) < 0);//Problem 3
            //var lastAfterFirstName =
            //    from p in initialStudents
            //    where p.FirstName.CompareTo(p.LastName) < 0
            //    select p;
            Console.WriteLine("Students with first name before last name alphabetically:");
            Print(lastAfterFirstName);
            Console.WriteLine(new string('-', 60));
            
            var ageInInterval = initialStudents.Where(a => a.Age > 18 && a.Age < 24);//Problem 4
            //var ageInInterval =
            //    from a in initialStudents
            //    where a.Age < 24 && a.Age > 18
            //    select a;
            Console.WriteLine("Students with age between 18 ang 24:");
            Print(ageInInterval);
            Console.WriteLine(new string('-', 60));
            
            var orderByFirstLast = initialStudents.OrderByDescending(n => n.FirstName)//Problem 5
                                                .ThenByDescending(n => n.LastName);
            //var orderByFirstLast =
            //    from n in initialStudents
            //    orderby n.FirstName descending,
            //    n.LastName descending
            //    select n;
            Console.WriteLine("Students ordered by first and last name in descending order:");
            Print(orderByFirstLast);
            Console.WriteLine();
        }

        private static void Print(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
