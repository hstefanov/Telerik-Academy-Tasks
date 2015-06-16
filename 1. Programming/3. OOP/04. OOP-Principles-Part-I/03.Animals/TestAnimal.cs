/*
03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
Dogs, frogs and cats are Animals. 
All animals can produce sound (specified by the ISound interface).
Kittens and tomcats are cats. All animals are described by age, name and sex. 
Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal 
using a static method (you may use LINQ).
*/

namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestAnimal
    {
        static void Main()
        {
            Dog dog = new Dog(10, "Sharo", AnimalSex.male);
            Console.WriteLine(dog + " " + dog.ProduceSound());

            Frog frog = new Frog(2, "Kermit", AnimalSex.female);
            Console.WriteLine(frog + " " + frog.ProduceSound());

            Cat cat = new Cat(4, "cat", AnimalSex.female);
            Console.WriteLine(cat + " " + cat.ProduceSound());

            Kitten kitten = new Kitten(1, "kitten", AnimalSex.female);
            Console.WriteLine(kitten + " " + kitten.ProduceSound());

            TomCat tomcat = new TomCat(2, "tomcat", AnimalSex.male);
            Console.WriteLine(tomcat + " " + tomcat.ProduceSound());

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(3,"doggy",AnimalSex.male),
                new Dog(5,"snoopy",AnimalSex.male),
                new Dog(10,"puppy",AnimalSex.female)
            };
            double avarageAgeDogs = dogs.Average(x => x.Age);
            Console.WriteLine("Dogs average age: {0}", avarageAgeDogs);

            List<Cat> cats = new List<Cat>()
            {
                new Cat(10,"kitty",AnimalSex.female),
                new Cat(3,"pritty",AnimalSex.female),
                new Cat(2,"cat",AnimalSex.male)
            };
            double avarageAgeCats = cats.Average(x => x.Age);
            Console.WriteLine("Cats average age: {0}", avarageAgeCats);

        }
    }
}
