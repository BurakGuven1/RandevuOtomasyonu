using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuOtomasyonu
{
    public class slot
    {
        public static Dictionary<int, string> getSlots()
        {
            Dictionary<int, string> slots = new Dictionary<int, string>();
            slots.Add(1, "Slot 1: From 08.00  to 09.00");
            slots.Add(2, "Slot 2: From 09.00  to 10.00 ");
            slots.Add(3, "Slot 3: From 10.00  to 11.00 ");
            slots.Add(4, "Slot 4: From 11.00 to 12.00 ");
            slots.Add(5, "Slot 5: From 13.00  to 14.00 ");
            slots.Add(6, "Slot 6: From 14.00  to 15.00");
            slots.Add(7, "Slot 7: From 15.00  to 16.00 ");
            slots.Add(8, "Slot 8: From 16.00 to 17.00 ");
            
            return slots;
        }

        //   08.00-09.00
        //  09.00-10.00
        //  10.00-11.00
        // 11.00-12.00
        //13.00-14.00
        //14.00-15.00
        //15.00-16.00
        //16.00-17.00
 


    }
}
