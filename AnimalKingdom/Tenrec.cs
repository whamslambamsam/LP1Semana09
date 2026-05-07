namespace AnimalKingdom
{
    public class Tenrec : Animal, IMammal
    {
        public int NumberOfNipples {get; } = 29;
        public override string Sound()
        {
            return base.Sound() + "Tsh-tsh... Tsh-tsh...";
        }
    }
}
