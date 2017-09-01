using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assesment.LinkedList;

namespace Tests
{
    [TestClass]
    public class AnimalShelterTest
    {
        [TestMethod]
        public void TestDequeue()
        {
            var animals = GetTestCase1();
            var oldest = animals.Dequeue();

            Assert.IsInstanceOfType(oldest, typeof(Cat));
            Assert.AreEqual(3, animals.Count);
            Assert.AreEqual("Sam", oldest.Name);

            oldest = animals.Dequeue();
            Assert.IsInstanceOfType(oldest, typeof(Cat));
            Assert.AreEqual(2, animals.Count);
            Assert.AreEqual("Tom", oldest.Name);
        }

        [TestMethod]
        public void TestDequeueCat()
        {
            var animals = GetTestCase1();
            var oldest = animals.DequeueCat();

            Assert.IsInstanceOfType(oldest, typeof(Cat));
            Assert.AreEqual(3, animals.Count);
        }

        [TestMethod]
        public void TestDequeueDog()
        {
            var animals = GetTestCase1();
            var oldest = animals.DequeueDog();

            Assert.IsInstanceOfType(oldest, typeof(Dog));
            Assert.AreEqual(3, animals.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(QueueEmptyException))]
        public void TestDequeueEmpty()
        {
            var animals = new AnimalQueue();

            Assert.AreEqual(0, animals.Count);

            var oldest = animals.Dequeue();
        }

        [TestMethod]
        [ExpectedException(typeof(QueueEmptyException))]
        public void TestDequeueCatEmpty()
        {
            var animals = new AnimalQueue();

            Assert.AreEqual(0, animals.Count);

            var oldest = animals.DequeueCat();
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundException))]
        public void TestDequeueCatNotFound()
        {
            var animals = new AnimalQueue();
            animals.Enqueue(new Dog() { Name = "Body" });

            var oldest = animals.DequeueCat();
        }

        private AnimalQueue GetTestCase1()
        {
            AnimalQueue queue = new AnimalQueue();
            queue.Enqueue(new Cat() { Name = "Sam" });
            queue.Enqueue(new Cat() { Name = "Tom" });
            queue.Enqueue(new Dog() { Name = "Tarly" });
            queue.Enqueue(new Cat() { Name = "Messy" });
            return queue;
        }
    }
}
