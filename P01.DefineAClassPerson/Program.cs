using System;
using System.Linq;

namespace P01.DefineAClassPerson
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string[] members;
            Family myFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                members = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person currPerson = new Person(members[0], int.Parse(members[1]));
                myFamily.AddMember(currPerson);
            }

            foreach (var member in myFamily.People().Where(p => p.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
