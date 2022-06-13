using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class TV : Internet, IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void booting()
        {
            Console.WriteLine("TV Booting...");
        }

        public void AccessInternet()
        {
            base.Access();
        }
    }
}
