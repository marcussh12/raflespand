using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9
{
    internal class Raflebæger
    {
        private List<Terning> terninger = new List<Terning>();
        public Raflebæger(int antal)
        {
            for (int i = 0; i < antal; i++)
            {
                this.terninger.Add(new Terning());
            }
        }

        public void Ryst()
        {
            foreach (Terning terning in this.terninger)
            {
                terning.Kast();
            }
        }

        public void Løft()
        {
            foreach (Terning terning in terninger)
            {
                Console.Write($"[{terning.værdi}]");
            }
            Console.Write("\n");
        }

        public int antalTerninger
        {
            get
            {
                return terninger.Count;
            }
            set
            {
                if (value > terninger.Count)
                {
                    for (int i = terninger.Count; i < value; i++)
                    {
                        terninger.Add(new Terning());
                    }
                }
            }
        }

    }
}
