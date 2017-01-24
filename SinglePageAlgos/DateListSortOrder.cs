using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageAlgos
{    
    //This class checks the sorted order of a list<DateTime> whether 
    public class DateListSortOrder
    {  
        public static string CheckDateOrder(List<DateTime> test)
        {
            IEnumerable<DateTime> temp;

            temp=from item in test orderby item.Year select item;

            if (test.SequenceEqual(temp))
                return "Sorted by year";
            else
            {
                temp = from item in test orderby item.Month select item;
                if (test.SequenceEqual(temp))
                    return "Sorted by month";
            }
            return "Not sorted";
        }
    }
}
