using System;

namespace GoF.CreationalPatterns.AbstractFactory.DC
{
    public class Joker : Enemy
    {
        public Joker()
            : base("Coringa")
        {
        }

        public override string Greet()
        {
            return "Tá me achando com cara de quê? Palhaço? Olha só pra você, todo vestido de preto!";
        }
    }
}