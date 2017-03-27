using System;

namespace DieHard
{
    public class Die
    {
        const int MinFaceValue = 1;
        const int MaxFaceValue = 6;

        private static readonly Random RandomSeed;

        private readonly Random _random;
        private int _faceValue;

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

        static Die()
        {
            RandomSeed = new Random();
        }

        public Die()
        {
            _random = new Random(RandomSeed.Next());
            Throw();
        }

        public int Throw()
        {
            FaceValue = _random.Next(MinFaceValue, MaxFaceValue + 1);

            return FaceValue;
        }
    }
}
