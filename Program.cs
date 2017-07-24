using System;

namespace var_dynamic
{
    class Program
    {
        class MyClass
        {
            dynamic field;

            public MyClass(dynamic arg)
            {
                field = arg;
            }

            public dynamic Field
            {
                get { return field; }
                set { field = value; }
            }

            public dynamic Method(dynamic arg)
            {
                return arg;
            }
            dynamic[] array = new dynamic[3];

            //индексатор

            public dynamic this[dynamic index]
            {
                get { return array[index]; }
                set { array[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            MyClass my = new MyClass("First");
            Console.WriteLine(my.Field);
            my = new MyClass(new object().GetType());
            Console.WriteLine(my.Field);

            Console.WriteLine("char: {0}", my.Method('f'));
            Console.WriteLine("string: {0}", my.Method("Second"));

            my[0] = "one";
            my[1] = 1;
            my[2] = new object();

            Console.WriteLine("\n");

            for(int i=0;i<3;i++)
            {
                Console.Write(my[i]+"  ");
                    
            }

            Console.ReadKey();
        }
    }
}
