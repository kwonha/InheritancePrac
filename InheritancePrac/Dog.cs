using System;

namespace InheritancePrac
{
    public class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog() { this.Age = 0; }

        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}