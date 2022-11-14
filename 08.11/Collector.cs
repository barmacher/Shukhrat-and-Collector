namespace _08._11
{
    public class Collector
    {
        public double Rage { get; set; }
        const int cap = 5000;

        public void BreakKness(Shukhrat shukhrat1)
        {
            if(shukhrat1.Debt> cap)
            {
                Console.WriteLine($"Так как долг Шухрата больше 5000, я сломал ему колени");
            }
        }

    }
}
