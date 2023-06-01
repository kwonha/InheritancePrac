using System;
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

                var _dog = item as Dog;
                if (_dog != null) { _dog.Bark(); }

                var _cat = item as Cat;
                if (_cat != null) { _cat.Meow(); }

                if (item is Dog)
                {
                    /* var _dog = (Dog)item;
                     _dog.Bark(); // 이 방법이나*/
                    ((Dog)item).Bark();
                }
                else if(item is Cat) 
                {
                    ((Cat)item).Meow(); // 이 방법이나 취향껏, 상황껏
                }
               
            }

        }
    }
}
