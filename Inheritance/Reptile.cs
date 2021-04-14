using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanSwim { get; set; }
    }
}
