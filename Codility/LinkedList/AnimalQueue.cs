using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assesment.LinkedList
{
    /*An animal shelter, which holds only dogs and cats, operates on a strictly"first in, 
    first out" basis. People must adopt either the "oldest" (based on arrival time) of 
    all animals at the shelter, or they can select whether they would prefer a dog or a 
    cat(and will receive the oldest animal of that type). They cannot select which 
    specific animal they would like. Create the data structures to maintain this system 
    and implement operations such as enqueue, dequeueAny, dequeueDog, and dequeueCat. */

    [DebuggerDisplay("Count = {Count}")]
    public class AnimalQueue
    {
        public void Enqueue(Animal animal)
        {
            _animals.AddLast(animal);
        }

        public Animal Dequeue()
        {
            if (_animals.First == null)
                throw new QueueEmptyException();
            var first = _animals.First.Value;
            _animals.RemoveFirst();
            return first;
        }

        public Dog DequeueDog()
        {
            return Dequeue<Dog>();
        }

        public Cat DequeueCat()
        {
            return Dequeue<Cat>();
        }

        public int Count => _animals.Count;

        private T Dequeue<T>() where T : Animal
        {
            if (_animals.First == null)
                throw new QueueEmptyException();
            var animal = _animals.First;
            while (animal != null)
            {
                if (animal.Value is T)
                    break;
                else
                    animal = animal.Next;
            }
            if (animal == null)
                throw new NotFoundException();
            _animals.Remove(animal);
            return animal.Value as T;
        }

        private LinkedList<Animal> _animals = new LinkedList<Animal>();
    }

    public abstract class Animal
    {
        public string Name { get; set; }
    }
    public class Dog : Animal { }
    public class Cat : Animal { }
    public class QueueEmptyException : Exception { }
    public class NotFoundException : Exception { }
}
