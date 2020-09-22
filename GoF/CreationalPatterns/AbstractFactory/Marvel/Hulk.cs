namespace GoF.CreationalPatterns.AbstractFactory.Marvel
{
    public class Hulk : Hero
    {
        public Hulk()
            : base("Hulk")
        {
        }

        public override string Greet()
        {
            return "...";
        }

        public override string Defeat(Enemy enemy)
        {
            return $"Hulk esgama!! {enemy.Name} é fraquinho!";
        }
    }
}