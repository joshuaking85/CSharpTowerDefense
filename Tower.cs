using System;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();
        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool isSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach(IInvader invader in invaders)
            {
                // Do stuff
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(isSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if(invader.IsNeutralized){
                            Console.WriteLine("Neutralized and invader at " + invader.Location + "!");
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Shot at and Missed an Invader!");
                    }
                    break;
                }
            }
        }
    }
}