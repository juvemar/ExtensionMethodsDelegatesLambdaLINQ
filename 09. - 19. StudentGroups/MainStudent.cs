namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainStudent
    {
        public static readonly List<Student> list = new List<Student>{ 
                new Student( "Martin", "Petrov", "222406149", "028342423423", "mar70p@abv.bg", 1, 3, 2, 4, 5),
                new Student("Galin", "Ivanov", "222406242", "0428834423423", "gal83@gmail.com", 2, 4, 5, 6, 2),
                new Student("Delyan", "Stankov", "222807403", "028983556776", "crazyModaFoka@gmail.com", 1, 2, 2, 4, 6),
                new Student("Petio", "Georgiev", "223404356", "028834968495", "playera@abv.bg", 2, 4, 3, 2, 6),
                new Student("Stilyan", "Tsonev", "234905654", "028495028431", "stilio69@yahoo.com", 3, 2, 2, 5, 5),
                new Student("Plamev", "Panev", "2229062012", "0348123453054", "gam3r90@abv.bg", 2, 6, 6, 3, 5),};
        static void Main()
        {
            Console.WriteLine("Students from group 2(LINQ):");
            Print(Extensions.GroupTwoLINQ(list));//Problem 9.
            Console.WriteLine();
            Console.WriteLine("Students from group 2(extension method):");
            Print(Extensions.GroupTwoExtensions(list));//Problem 10.
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Students with abv.bg emails:");
            Print(Extensions.EmailAbvBg(list));//Problem 11.
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Students with Sofia phones:");
            Print(Extensions.SofiaTel(list));//Problem 12.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress a key to clear the console and to continue with the next task.");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Students with at least one excellent mark:");
            Print(Extensions.ExcellentMark(list));//Problem 13.
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(@"Students with two bad marks(""2""):");
            Print(Extensions.TwoMarksTwo(list));//Problem 14.
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Students enrolled in 2006:");
            Print(Extensions.FacultyNumber(list));//Problem 15.
            Console.WriteLine(new string('-', 40));

            List<string> longestString = new List<string>
            {
                    "Short student", "Shorter",
                    "Such a long student", "Longest student in the world", "Not so long"
            };
            Console.WriteLine("The longest string is:");
            Console.WriteLine(Extensions.Longest(longestString));
            Console.WriteLine(new string('-', 40));

            Extensions.ExtractByGroupNumber();//Problem 18.
            Extensions.GroupName();//Problem 19.
        }

        private static void Print(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
