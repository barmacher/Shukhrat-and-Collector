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
            Money = new Random().Next(0, Debt);
            GetMoney();

        }

        private void GetMoney()
        {
            Theft();
            CarBurglary();
            Console.WriteLine("Метод сработал");
        }

        private void Theft()
        {
            int rand = new Random().Next(0,100);
            Money += rand;
        }

        private void CarBurglary()
        {
            int rand = new Random().Next(10, 100000);
            Money += rand;
        }


    }
}
