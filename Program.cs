using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        interface Drawable
        {
            void draw();
        }
        class Rectangle : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        class Circle : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
        class TestInterface
        {
            public static void Main()
            {
                Drawable d;
                d = new Rectangle();
                d.draw();
                d = new Circle();
                d.draw();
                Console.ReadLine();
            }
        }
    }
}
