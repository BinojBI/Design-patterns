using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
   public class Singleton
    {
        private static Singleton uniquesingleton;

        private Singleton() { }

            public static Singleton getSingleton()
        {
            if (uniquesingleton == null) {
                uniquesingleton = new Singleton();
            }

            return uniquesingleton;
        }
    
    }
}
