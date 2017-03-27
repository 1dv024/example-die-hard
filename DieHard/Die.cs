using System;

namespace DieHard
{
    /// <summary>
    /// Represents a die.
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The minimum face value.
        /// </summary>
        const int MinFaceValue = 1;

        /// <summary>
        /// The maximum face value.
        /// </summary>
        const int MaxFaceValue = 6;

        /// <summary>
        /// Random seed generator for face value generators.
        /// </summary>
        private static readonly Random RandomSeed;

        /// <summary>
        /// Random face value generator.
        /// </summary>
        private readonly Random _random;

        /// <summary>
        /// The face value of the current instance.
        /// </summary>
        private int _faceValue;

        /// <summary>
        /// Gets or sets the face value of the current instance.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is greater than or equal to MinFaceValue 
        /// and less than or equal to MaxFaceValue.
        /// </returns>
        public int FaceValue
        {
            get { return _faceValue; }

            private set
            {
                if (value < MinFaceValue || value > MaxFaceValue)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _faceValue = value;
            }
        }

        /// <summary>
        /// Initializes static data of the Die class.
        /// </summary>
        static Die()
        {
            RandomSeed = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the Die class.
        /// </summary>
        public Die()
        {
            _random = new Random(RandomSeed.Next());
            Throw();
        }

        /// <summary>
        /// Throws the die and returns the outcome.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is greater than or equal to MinFaceValue 
        /// and less than or equal to MaxFaceValue.
        /// </returns>
        public int Throw() => FaceValue = _random.Next(MinFaceValue, MaxFaceValue + 1);
    }
}
