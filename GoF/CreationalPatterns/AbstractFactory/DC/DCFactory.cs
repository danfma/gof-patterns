namespace GoF.CreationalPatterns.AbstractFactory.DC
{
    public class DCFactory : HeroesFactory
    {
        public override Hero PickHero()
        {
            return new Batman();
        }

        public override Enemy PickEnemy()
        {
            return new Joker();
        }
    }
}