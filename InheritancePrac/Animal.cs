using System;
namespace InheritancePrac
{
    public class Animal
    {
        /// <summary>
        ///나이
        /// </summary>
        public int Age { get; set; }

        Animal() { this.Age = 0; }

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