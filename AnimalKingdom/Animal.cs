namespace AnimalKingdom
{
    public abstract class Animal
    {
        public virtual string Sound()
        {
            return "Sound = ";
        }
    }

    public interface IMammal
    {
        readonly int NumberOfNipples;
    }

    public interface ICanFly
    {
        readonly int NumberOfWings;
    }
}
