using System;
using GoF.CreationalPatterns.AbstractFactory.DC;
using GoF.CreationalPatterns.AbstractFactory.Marvel;

namespace GoF.CreationalPatterns.AbstractFactory
{
    public static class AbstractFactorySample
    {
        public static void Run()
        {
            var factories = new HeroesFactory[]
            {
                new MarvelFactory(),
                new DCFactory()
            };

            for (int i = 0; i < factories.Length; i++)
            {
                var factory = factories[i];
                var conversation = new HeroAndEnemyConversation(factory);

                conversation.Start();

                Console.WriteLine();
            }
        }
    }
}