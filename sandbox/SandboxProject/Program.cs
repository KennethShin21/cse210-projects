using System;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.SetFirstName("Kenneth");
            person1.SetLastName("Benting");

            Console.WriteLine(person1.GetFullName());

            ChurchMember person2 = new ChurchMember();
            person2.SetFirstName("John");
            person2.SetLastName("Andrews");
            person2.SetCalling("Clerk");

            Console.WriteLine(person2.GetFullNameAndCalling());


        }
    }
}
