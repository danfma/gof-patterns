using System;

namespace GoF.CreationalPatterns.AbstractFactory
{
    public class HeroAndEnemyConversation
    {
        public HeroAndEnemyConversation(HeroesFactory heroesFactory)
        {
            Hero = heroesFactory.PickHero();
            Enemy = heroesFactory.PickEnemy();
        }

        private Hero Hero { get; }
        private Enemy Enemy { get; }

        public void Start()
        {
            Console.WriteLine("Iniciando a conversa entre: {0} e {1}.", Hero.Name, Enemy.Name);
            Console.WriteLine("{0}: {1}", Hero.Name, Hero.Greet());
            Console.WriteLine("{0}: {1}", Enemy.Name, Enemy.Greet());
            Console.WriteLine("{0}: {1}", Hero.Name, Hero.Defeat(Enemy));
        }
    }
}