namespace AnimalKingdom
{
    public class Locust : Animal, ICanFly
    {
        public int NumberOfWings {get; } = 4;
        public override string Sound()
        {
            return base.Sound() + "Trtrtrtrtrtrtrtrtrtrtrtrt...";
        }
    }
}
