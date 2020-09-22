namespace GoF.CreationalPatterns.AbstractFactory
{
    public abstract class Hero : Challenger
    {
        protected Hero(string name)
            : base(name)
        {
        }

        public abstract string Defeat(Enemy enemy);
    }
}