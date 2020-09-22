using System.Collections.Generic;
using System.Linq;

namespace GoF.CreationalPatterns.Builder
{
    public class Vehicle
    {
        private readonly Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string name) =>
            Name = name;

        public string Name { get; }

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public IEnumerable<(string Part, string Description)> GetParts()
        {
            foreach (var (key, value) in _parts)
            {
                yield return (key, value);
            }
        }
    }
}