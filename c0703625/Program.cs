using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0703625
{
    class Program
    
        class Village
    {
        public static int numberofVillages =0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;
        private Village() {
            Village.numberofVillages++;
        }
        class Countryside
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;
            public void MapInitializer()
               
            {
                Maple = new Village();
        
        Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;
                Toronto = new Village();
                Toronto.VillageName = "Toronto";
                Toronto.previousVillage = Maple;
                Toronto.nextVillage = Ajax;
                Ajax = new Village();
                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.previousVillage = Toronto;
                Ajax.isAstrildeHere = true;


            }
            public void LookForAtrildeHere
        }
    }

}
