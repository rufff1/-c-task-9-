using System;

namespace task4
{

    public class task4
    {
        static void Main()
        {
            User user = new User("Rufat", "Guluzade" , "1410", Month.January);
            Console.WriteLine( user.GetDetails());
            User user1 = new User("Samir", "Namazov", "12ss32", Month.February);
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("Ilaha", "Cafarli", "1410", Month.November);
            Console.WriteLine(user2.GetDetails());
            User user3 = new User("Maryam", "Cafarli", "1526", Month.April);
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("Isi", "Guluzada", "2828", Month.March);
            Console.WriteLine(user4.GetDetails());


        }
    }
}