using System;

namespace DieHard
{
    /// <summary>
    /// Represents a console application.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Runs an application.
        /// </summary>
        public void Run()
        {
            Die myDie = new Die();
            Die myOtherDie = new Die();

            for (int i = 0; i < 1000; i++)
            {
                myDie.Throw();
                myOtherDie.Throw();

                Console.WriteLine($"{myDie.FaceValue}\t{myOtherDie.FaceValue}");
            }
        }
    }
}
