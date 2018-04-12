using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDEV117Assignment7
{
    class MagazineSubscription
    {
        // Declarations
        private string subscriberName;
        private string magazineName;
        private int monthsRemaining;

        public void setSubscriberName(string name)
        {
            subscriberName = name;
        }

        public void setMagazineName(string name)
        {
            magazineName = name;
        }

        public void setMonthsRemaining(int num)
        {
            monthsRemaining = num;
        }

        public string getSubscriberName()
        { 
            return subscriberName;
        }

        public string getMagazineName()
        { 
            return magazineName;
        }

        public int getMonthsRemaining()
        {
            return monthsRemaining;
        }
    }
}
