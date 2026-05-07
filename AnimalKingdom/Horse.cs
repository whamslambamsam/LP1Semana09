namespace AnimalKingdom
{
    public class Horse : Animal, IMammal
    {
        public int NumberOfNipples {get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Neigh!";
        }
    }
}
