namespace BasicCorePrograming
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Welcome to Basic Core Programs");
                Console.WriteLine("1: Flip Coin" + "\n" + "2: Leap Year" + "\n" + "3: Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch(check)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.CheckHailTail();
                        break;
                        case 2:
                            LeapYear year = new LeapYear(); 
                        year.CheckLeapYear();
                        break; 
                        default: break;
                        flag= false;
                        break;
                }
            }
        }
    }
}