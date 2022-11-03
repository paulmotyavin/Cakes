using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    internal class Podpunkt
    {
        public string Name1;
        public string Name2;
        public string Name3;
        public string Name4;
        public int price1;
        public int price2;
        public int price3;
        public int price4;
        public Podpunkt(string Name1, int price1, string Name2, int price2, string Name3, int price3, string Name4, int price4)
        {
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Name3 = Name3;
            this.Name4 = Name4;
            this.price1 = price1;
            this.price2 = price2;
            this.price3 = price3;
            this.price4 = price4;
        }
    }
}
