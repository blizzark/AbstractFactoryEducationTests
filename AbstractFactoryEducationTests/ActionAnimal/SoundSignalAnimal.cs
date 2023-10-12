using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEducationTests.ActionAnimal
{
    internal abstract class SoundSignalAnimal
    {
        public abstract void Signal();
    }

    internal class Roar: SoundSignalAnimal
    {
        public override void Signal()
        {
            Console.WriteLine("Рык");
        }
    }

    internal class Song : SoundSignalAnimal
    {
        public override void Signal()
        {
            Console.WriteLine("Поёт");
        }
    }
}
