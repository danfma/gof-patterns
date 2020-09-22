namespace GoF.CreationalPatterns.AbstractFactory
{
    public abstract class Enemy : Challenger
    {
        protected Enemy(string name)
            : base(name)
        {
        }
    }
}