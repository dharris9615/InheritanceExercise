using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public bool CanFly { get; set; }
        public string ClimateOrigin { get; set; }
        public bool Carnivore { get; set; }
        public string Color { get; set; }

    }
}
