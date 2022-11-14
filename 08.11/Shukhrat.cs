using System.Xml.Schema;

namespace _08._11
{
    public class Shukhrat
    {

        public int Debt { get; set; }
        private int Money { get; set; }


        public Shukhrat()
        {
            Debt = new Random().Next(10000,50000);
            Console.WriteLine("Долг:" + Debt);
            Money = new Random().Next(0, Debt);
            Console.WriteLine("Деньги Шухрата на данный момент:" + Money);
            GetMoney();
            Console.WriteLine("Деньги Шухрата после добычи денег:" + Money);


        }

        private void GetMoney()
        {
            Theft();
            CarBurglary();
            
        }

        private void Theft()
        {
            int rand = new Random().Next(0,100);
            Money += rand;
        }

        private void CarBurglary()
        {
            int rand = new Random().Next(10, 10000);
            Money += rand;
        }

        
        }

    }

