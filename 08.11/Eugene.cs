using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11
{
    public class Eugene : IPerson
    {
        public int Debt { get; set; }
        private int Money { get; set; }

        public void GetMoney()
        {
            Robbery();
            Work();
        }

        public void Robbery()
        {
            int rand = new Random().Next(100, 1000);
            Money += rand;
            Console.WriteLine("Обокрал");
        }

        public void Work()
        {
            int rand = new Random().Next(10000, 100000);
            Money += rand;
            Console.WriteLine("Заработал");
        }
    }
}
