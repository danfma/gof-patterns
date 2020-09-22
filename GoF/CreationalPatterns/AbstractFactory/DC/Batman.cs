using System;

namespace GoF.CreationalPatterns.AbstractFactory.DC
{
    public class Batman : Hero
    {
        public Batman()
            : base("Batman")
        {
        }

        public override string Greet()
        {
            return "Me diz, você sangra? Vai sangrar!";
        }

        public override string Defeat(Enemy enemy)
        {
            return $"Irei te visitar no Asilo de Arkham, {enemy.Name}!";
        }
    }
}