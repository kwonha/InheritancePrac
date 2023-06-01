﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Public();
            //dog.Protected();
            //dog.Private();
            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat() };


            //List<Object> Things = new List<Object>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() };
            // -> 상속 없이 두 클래스를 합쳐 사용할 수 있다.



            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();
                ((Dog)item).Bark();
            }

        }
    }
}
