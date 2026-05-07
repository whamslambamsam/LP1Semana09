namespace AnimalKingdom
{
    public class Snake : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Sssssssssss.";
        }
    }
}
