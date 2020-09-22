namespace GoF.CreationalPatterns.AbstractFactory
{
    public abstract class Challenger
    {
        protected Challenger(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Greet();
    }
}