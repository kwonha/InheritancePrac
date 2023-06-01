using System;

namespace InheritancePrac
{
    public class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(int age) : base(age)
        {
        }

        public sealed override void Eat()
        {
            Console.WriteLine("자박자박 먹습니다.");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}