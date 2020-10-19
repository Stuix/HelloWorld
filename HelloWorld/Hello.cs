using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
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
