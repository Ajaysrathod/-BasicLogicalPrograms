namespace BasicLogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Logical Program");
            Console.WriteLine("1:Flip coin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoinUC1 flipCoin = new FlipCoinUC1();
                    flipCoin.FlipCoins();
                    break;
                case 2:
                    LeapYearUC2 leapYear = new LeapYearUC2();
                    leapYear.LeapYears();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}