using System;

namespace InheritancePrac
{
    public class Cat
    {
        /// <summary>
        /// 고양이 나이
        /// </summary>
        public int Age { get; set; } 
        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}