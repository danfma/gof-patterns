namespace GoF.CreationalPatterns.AbstractFactory.Marvel
{
    public class MarvelFactory : HeroesFactory
    {
        public override Hero PickHero()
        {
            return new Hulk();
        }

        public override Enemy PickEnemy()
        {
            return new Loki();
        }
    }
}