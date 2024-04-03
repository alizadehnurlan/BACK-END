

namespace Lesson8.Bank
{
    internal class BankAccount
    {
        public int card;
        public double Balance;
        public void medaxil(double miqdar)
        {
            if (miqdar < 0)
            {
                Console.WriteLine("miqdar menfi ola bilmez");
                return;
            }

            Balance += miqdar;
        }   
        public void mexaric(double miqdar)
        {

            if (miqdar < 0)
            {
                Console.WriteLine("miqdar menfi ola bilmez");
               return ;
            }

             Balance -= miqdar;
        }
    }
}
