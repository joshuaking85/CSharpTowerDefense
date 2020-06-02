namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        protected override double Accuracy { get; } = .99;
        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}