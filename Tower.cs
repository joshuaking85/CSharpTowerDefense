using System;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();
        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool isSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                // Do stuff
                if(invader.isActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(isSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and Hit Invader!");
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