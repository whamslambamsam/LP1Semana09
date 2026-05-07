namespace AnimalKingdom
{
    public class Blackbird : Animal, ICanFly
    {
        public int NumberOfWings {get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Tweet, tweet, tweet, tweet!";
        }
    }
}
