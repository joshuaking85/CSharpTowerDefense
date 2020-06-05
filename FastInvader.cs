namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        protected override int StepSize { get; } = 2;
        public override int Health { get; protected set; }
        public FastInvader(Path path) : base(path)
        {

        }
    }
}