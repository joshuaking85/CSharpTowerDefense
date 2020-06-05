namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();
        public override int Health { get; protected set; }
        public ShieldedInvader(Path path) : base(path)
        {
        }
        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() > .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a Shielded Invader but it sustained no damage!");
            }
        }
    }
}