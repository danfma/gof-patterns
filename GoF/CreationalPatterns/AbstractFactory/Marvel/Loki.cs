using System;

namespace GoF.CreationalPatterns.AbstractFactory.Marvel
{
    public class Loki : Enemy
    {
        public Loki()
            : base("Loki")
        {
        }

        public override string Greet()
        {
            return "Chega! Todos vocês estão abaixo de mim! " +
                   "Eu sou um Deus, criatura ridícula, e eu não vou ser intimidado por um...";
        }
    }
}