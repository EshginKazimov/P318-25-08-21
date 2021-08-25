using System;
using System.Reflection;
using System.Threading;

namespace ThreadTaskReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread

            //Loop1();
            //Loop2();

            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);

            //thread1.Start();
            ////thread1.Join();
            //thread2.Start();
            //Console.WriteLine("Salam");
            //Console.WriteLine("Bye");

            #endregion

            #region Reflection

            //Person p1 = new Person();

            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine($"{item.Namespace}/{item.Name}");
                foreach (var prop in item.GetProperties())
                {
                    Console.WriteLine($"{prop.PropertyType} {prop.Name}");
                }
            }

            #endregion
        }

        #region Thread

        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Loop1: " + i);
            }
        }

        static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Loop2: " + i);
            }
        }

        #endregion
    }

    //Game class olsun, evdeki tapshirigdaki formada (methodsuz, eventsiz)
    //Program.cs-de bir List<Game> duzeldin
    //Ve bu List-de Football type-inda olan game-leri gosterin
    //List-de olan football type-da olan melumatin sonuna "Bu oyun PC-de oynanila bilmez"
    //List-de olan action type-da olan melumatin sonuna "Bu oyun PC-de oynanila biler"

    class Person
    {
        public string FullName { get; set; }
    }

    class Student
    {
        public int Score { get; set; }
    }
}
