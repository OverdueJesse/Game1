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
            Items sword1 = new Items(2, 2, 2);
            Items sword2 = new Items(3, 3, 3);
            Items sword3 = new Items(4, 4, 4);
            Items sword4 = new Items(5, 5, 5);
            Items sword5 = new Items(6, 6, 6);

            Items dagger0 = new Items(1, 1, 1);
            Items dagger1 = new Items(2, 2, 2);
            Items dagger2 = new Items(3, 3, 3);
            Items dagger3 = new Items(4, 4, 4);
            Items dagger4 = new Items(5, 5, 5);
            Items dagger5 = new Items(6, 6, 6);

            Items bow0 = new Items(1, 1, 1);
            Items bow1 = new Items(2, 2, 2);
            Items bow2 = new Items(3, 3, 3);
            Items bow3 = new Items(4, 4, 4);
            Items bow4 = new Items(5, 5, 5);
            Items bow5 = new Items(6, 6, 6);

            Items staff0 = new Items(1, 1, 1);
            Items staff1 = new Items(2, 2, 2);
            Items staff2 = new Items(3, 3, 3);
            Items staff3 = new Items(4, 4, 4);
            Items staff4 = new Items(5, 5, 5);
            Items staff5 = new Items(6, 6, 6);

            //Common Drops
            commonDrops[0] = sword0;
            commonDrops[1] = sword1;
            commonDrops[2] = sword2;
            commonDrops[3] = dagger0;
            commonDrops[4] = dagger1;
            commonDrops[5] = dagger2;
            commonDrops[6] = bow0;
            commonDrops[7] = bow1;
            commonDrops[8] = bow1;
            commonDrops[9] = staff0;
            commonDrops[10] = staff1;
            commonDrops[11] = staff2;

            //Uncommon Drops
            uncommonDrops[0] = sword3;
            uncommonDrops[1] = sword4;
            uncommonDrops[2] = dagger3;
            uncommonDrops[3] = dagger4;
            uncommonDrops[4] = bow3;
            uncommonDrops[5] = bow4;
            uncommonDrops[6] = staff3;
            uncommonDrops[7] = staff4;

            //Rare Drops
            rareDrops[0] = sword5;
            rareDrops[1] = dagger5;
            rareDrops[2] = bow5;
            rareDrops[3] = staff5;
        }
    }
}
