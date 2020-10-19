using System;

namespace ClassLibrary
{
    public class Hello
    {
        private string Greeting;

        public Hello(string greeting)
        {
            this.Greeting = greeting;

        }

        public void sayHello()
        {
            Console.WriteLine(Greeting);
        }
    }
}
