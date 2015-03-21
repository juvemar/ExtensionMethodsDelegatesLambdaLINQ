using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class MainStudent
    {
        public static readonly List<Student> list = new List<Student>{ 
                new Student( "Martin", "Petrov", "222423149", "028342423423", "mar70p@abv.bg", new List<int>{ 3, 2, 4, 5 }, 1),
                new Student("Galin", "Ivanov", "222423242", "0428834423423", "gal83@gmail.com", new List<int>{ 4, 5, 6, 2 }, 2),
                new Student("Delyan", "Stankov", "222859403", "028983556776", "crazyModaFoka@gmail.com", new List<int>{ 2, 3, 4, 6 }, 1),
                new Student("Petio", "Georgiev", "223425356", "028834968495", "playera@abv.bg", new List<int> {4, 3, 2, 6 }, 2),
                new Student("Stilyan", "Tsonev", "234935654", "028495028431", "stilio69@yahoo.com", new List<int>{ 3, 2, 5, 5 }, 3),
                new Student("Plamev", "Panev", "2229432012", "0348123453054", "gam3r90@abv.bg", new List<int>{ 6, 6, 3, 5 }, 2),};
        static void Main()
        {
            StudentsFromGroupTwo();//Problem 9. && Problem 10.
            EmailAbvBg();//Problem 11.
            SofiaTel();//Problem 12.
            ExcellentMark();//Problem 13.
        }

        private static void StudentsFromGroupTwo()//Problem 9. && Problem 10.
        {
            Console.WriteLine("Students from group 2(LINQ):");
            var groupTwo =
                from st in list
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            Print(groupTwo);
            Console.WriteLine();

            Console.WriteLine("Students from group 2(extension method):");
            groupTwo = list
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            Print(groupTwo);
            Console.WriteLine(new string('-',40));
        }

        private static void EmailAbvBg()//Problem 11.
        {
            Console.WriteLine("Students with abv.bg emails:");
            var emailAbv =
                from m in list
                where m.Email.Contains("abv.bg")
                select m;
            Print(emailAbv);
            Console.WriteLine(new string('-', 40));
        }

        private static void SofiaTel()//Problem 12.
        {
            Console.WriteLine("Students with Sofia phones:");
            var sofiaPhone =
                from t in list
                where t.Tel.StartsWith("02")
                select t;
            Print(sofiaPhone);
        }

        private static void ExcellentMark()//Problem 13.
        {
            Console.WriteLine("Students with at least one excellent mark:");
            var excellent = list
                .Where(m => m.Marks.Contains(6));
            foreach (var item in excellent)
            {
                Console.WriteLine("{0} {1} - {2}", item.FirstName, item.LastName, item.Marks);
            }
        }

        private static void Print(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
