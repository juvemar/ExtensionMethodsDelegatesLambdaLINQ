using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class Extensions
    {
        public static IEnumerable<string> GroupTwoLINQ(IEnumerable<Student> collection)
        {
            var groupTwo =
                from st in collection
                where st.GroupNumber == 2
                orderby st.FirstName
                select st.FirstName + " " + st.LastName;

            return groupTwo;
        }

        public static IEnumerable<string> GroupTwoExtensions(IEnumerable<Student> collection)
        {
            var groupTwo = collection
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName)
                .Select(st => st.FirstName + " " + st.LastName);

            return groupTwo;
        }

        public static IEnumerable<string> EmailAbvBg(IEnumerable<Student> collection)
        {
            var emailAbv =
                from m in collection
                where m.Email.Contains("abv.bg")
                select m.Email;

            return emailAbv;
        }

        public static IEnumerable<string> SofiaTel(IEnumerable<Student> collection)
        {
            var sofiaPhone =
                from t in collection
                where t.Tel.StartsWith("02")
                select t.FirstName + " " + t.LastName;

            return sofiaPhone;
        }

        public static IEnumerable<string> ExcellentMark(IEnumerable<Student> collection)
        {
            var excellent =
                from m in collection
                where m.Marks.Contains(6)
                select m.FirstName + " " + m.LastName + " - " + string.Join(", ", m.Marks);

            return excellent;
        }

        public static IEnumerable<string> TwoMarksTwo(IEnumerable<Student> collection)
        {
            var badMark = collection
                .Where(st => st.Marks.Count(m => m == 2) == 2)
                .Select(st => st.FirstName + " " + st.LastName);

            return badMark;
        }

        public static IEnumerable<string> FacultyNumber(IEnumerable<Student> collection)
        {
            var faculty = collection
                .Where(m => m.FN.Substring(4, 2) == "06")
                .Select(m => string.Join(", ", m.Marks));

            return faculty;
        }

        public static string Longest(List<string> array)//Problem 17.
        {
            var win = array.OrderBy(st => st.Length).Last();
            return win;
        }

        public static void ExtractByGroupNumber()//Problem 18.
        {
            Console.WriteLine("Students grouped by group number:");
            var group =
                from st in MainStudent.list
                group st by st.GroupNumber into grouped
                select new
                {
                    GroupNumber = grouped.Key,
                    list = grouped
                };
            foreach (var st in group)
            {
                Console.WriteLine("\nGroup {0}, students:\n", st.GroupNumber);

                foreach (var item in st.list)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }
        }

        public static void GroupName()//Problem 19.
        {
            Console.WriteLine("Students grouped by group number using extension method:");
            var group = MainStudent.list
                .GroupBy(st => st.GroupNumber);

                foreach (var student in group)
                {
                    Console.WriteLine(student.ToArray());
                }
        }
    }
}
