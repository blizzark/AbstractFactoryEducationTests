using AbstractFactoryEducationTests.ActionAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEducationTests.AnimalsFactory
{
    internal abstract class AnimalFactory
    {
        public abstract MoveAnimal Moving();
        public abstract SoundSignalAnimal Signal();
    }

    internal class Lion : AnimalFactory
    {
        public override MoveAnimal Moving() { return new Run(); }
        public override SoundSignalAnimal Signal() { return new Roar(); }
    }

    internal class Bird : AnimalFactory
    {
        public override MoveAnimal Moving() { return new Fly(); }
        public override SoundSignalAnimal Signal() { return new Song(); }
    }
}
