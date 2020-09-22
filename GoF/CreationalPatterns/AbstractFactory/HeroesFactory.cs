namespace GoF.CreationalPatterns.AbstractFactory
{
    public abstract class HeroesFactory
    {
        public abstract Hero PickHero();
        public abstract Enemy PickEnemy();
    }
}