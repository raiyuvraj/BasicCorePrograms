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
                Console.WriteLine("1: Flip Coin" + "\n" + "2: Leap Year" + "\n" + 
                    "3: Power of 2" + "\n"+ "4: Harmonic Number" +"\n"+"5: Factors" +"\n"+ 
                    "6: Check Even/Odd" +"\n"+ "7: Vowel/Consonant" +"\n"+ "8: Quotient and Remainder" +"\n"+ "9: Exit");
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
                        case 3:
                            PowerOf2 power = new PowerOf2();
                        power.Power();
                        break;
                        case 4:
                            HarmonicNmber harmonic = new HarmonicNmber();
                            harmonic.Harmonic();
                        break;
                        case 5:
                            Factors factors= new Factors();
                        factors.PrimeFactor();
                        break;
                        case 6:
                            EvenOdd eo = new EvenOdd(); 
                        eo.CheckEvenOdd();
                        break;
                        case 7:
                            VowelConsonanat ab = new VowelConsonanat();
                        ab.Alphabet();
                        break;
                        case 8:
                            QuoandRem qr = new QuoandRem();
                        qr.QuoRem();
                        break;
                        default: break;
                        flag= false;
                        break;
                }
            }
        }
    }
}