using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9
{
    public class Terning
    {
        public int sider;
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            this.sider = 6;
            this.værdi = 1;
            this.snyd= false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }   

        public void Skriv()
        {
            Console.WriteLine($"[{this.værdi}]");
        }

        public void Kast()
        {
            if (this.snyd)
            {
                værdi = 6;
            }
            else
            {
                værdi = rnd.Next(1, sider);
            }
        }

        

    }

}
