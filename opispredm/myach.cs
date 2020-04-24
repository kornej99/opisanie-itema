using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace description_of_item
{
    class myach
    {
        public int weight { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public double speed { get; set; }
        public string material { get; set; }

        string mat1 = "Камень";
        int HP = 50;
        public void Uron()
        {
            if (speed > 10)
            {
                HP -= 5;
            }
            else
            {
                smert();
            }
        }
        public string smert()
        {
            if (material == mat1)
            {
                return "wasted";
            }
            return "";
        }
    }
}
