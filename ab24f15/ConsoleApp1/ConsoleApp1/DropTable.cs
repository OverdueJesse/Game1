using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class DropTable
    {
        static Random rng = new Random();

        static Items[] commonDrops = new Items[12];
        static Items[] uncommonDrops = new Items[8];
        static Items[] rareDrops = new Items[4];
        

        public static Items RandWeapon()
        {

            int tableDeterminant = rng.Next(0, 100);
            Items tableElement;

            if (tableDeterminant <= 5)
            {
                tableElement = rareDrops[rng.Next(0, 12)];
            }
            else if (tableDeterminant <= 15)
            {
                tableElement = uncommonDrops[rng.Next(0, 7)];
            }
            else
            {
                tableElement = commonDrops[rng.Next(0, 4)];
            }

            return tableElement;
        }

        public static void fillTables()
        {
            Items sword0 = new Items(1, 1, 1);
            Items sword1 = new Items(1, 1, 1);
            Items sword2 = new Items(1, 1, 1);
            Items sword3 = new Items(1, 1, 1);
            Items sword4 = new Items(1, 1, 1);
            Items sword5 = new Items(1, 1, 1);

            Items dagger0 = new Items(1, 1, 1);
            Items dagger1 = new Items(1, 1, 1);
            Items dagger2 = new Items(1, 1, 1);
            Items dagger3 = new Items(1, 1, 1);
            Items dagger4 = new Items(1, 1, 1);
            Items dagger5 = new Items(1, 1, 1);

            Items bow0 = new Items(1, 1, 1);
            Items bow1 = new Items(1, 1, 1);
            Items bow2 = new Items(1, 1, 1);
            Items bow3 = new Items(1, 1, 1);
            Items bow5 = new Items(1, 1, 1);

            Items staff0 = new Items(1, 1, 1);
            Items staff1 = new Items(1, 1, 1);
            Items staff2 = new Items(1, 1, 1);
            Items staff3 = new Items(1, 1, 1);
            Items staff4 = new Items(1, 1, 1);
            Items staff5 = new Items(1, 1, 1);

            commonDrops[0] = sword0;
        }
    }
}
