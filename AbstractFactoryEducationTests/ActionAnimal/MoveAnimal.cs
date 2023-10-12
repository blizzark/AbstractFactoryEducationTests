using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEducationTests.ActionAnimal
{
    internal abstract class MoveAnimal
    {
        public abstract void Move();
    }

    internal class Run : MoveAnimal
    {
        public override void Move()
        {
            Console.WriteLine("Бежит");
        }
    }
    internal class Fly : MoveAnimal
    {
        public override void Move()
        {
            Console.WriteLine("Летит");
        }
    }

}
