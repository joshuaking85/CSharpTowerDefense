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
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                // Do stuff
                if(invader.isActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(isSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        if(invader.IsNeutralized){
                            Console.WriteLine("Invader is Neutralized!");
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