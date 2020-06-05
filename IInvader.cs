namespace TreehouseDefense
{
    interface IInvader
    {
        MapLocation Location {get;}
        int Health {get;}
        bool HasScored {get;}
        bool IsNeutralized {get;}
        bool isActive {get;}
        void Move();
        void DecreaseHealth(int factor);
    }
}