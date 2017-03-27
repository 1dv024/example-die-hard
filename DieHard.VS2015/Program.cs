using System;

namespace DieHard
{
    class Program
    {
        static void Main(string[] args)
        {
            Die myDie = new Die();
            Die myOtherDie = new Die();

            for (int i = 0; i < 1000; i++)
            {
                myDie.Throw();
                myOtherDie.Throw();
                Console.WriteLine("{0}\t{1}", myDie.FaceValue, myOtherDie.FaceValue);
            }
        }
    }
}
