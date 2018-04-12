using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDEV117Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            MagazineSubscription subscriberOne = new MagazineSubscription();
            MagazineSubscription subscriberTwo = new MagazineSubscription();

            subscriberOne.setSubscriberName("Matthew Dal Santo");
            subscriberOne.setMagazineName("National Geographic");
            subscriberOne.setMonthsRemaining(11);

            subscriberTwo.setSubscriberName("George W. Bush");
            subscriberTwo.setMagazineName("The Hill");
            subscriberTwo.setMonthsRemaining(10);

            Console.WriteLine("Subscriber Name: " + subscriberOne.getSubscriberName());
            Console.WriteLine("Magazine Name: " + subscriberOne.getMagazineName());
            Console.WriteLine("Number of months remaining for subscription: " + subscriberOne.getMonthsRemaining());
            Console.WriteLine("");
            Console.WriteLine("Subscriber Name: " + subscriberTwo.getSubscriberName());
            Console.WriteLine("Magazine Name: " + subscriberTwo.getMagazineName());
            Console.WriteLine("Number of months remaining for subscription: " + subscriberTwo.getMonthsRemaining());
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit...");
            Console.ReadKey();
        }
    }
}
