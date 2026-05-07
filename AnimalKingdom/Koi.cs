namespace AnimalKingdom
{
    public class Koi : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Glub-glub!";
        }
    }
}