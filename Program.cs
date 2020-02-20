using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            multiton obj = multiton.checkobj("1");
            obj.printDetails();


            multiton obj1 =multiton.checkobj("1");
            obj1.printDetails();


            multiton obj2 =multiton.checkobj("1");
            obj2.printDetails();
            Console.ReadKey();
            
        }
    }


    class multiton
    {
        public static int count = 0;
        public static readonly Dictionary<string, multiton> instances = new Dictionary<string, multiton>();
        static object checklock = new object();

        private multiton()
        {
            count++;
            Console.WriteLine("create {0} object",count);

        }

        public static multiton checkobj(string key)
        {
            lock (checklock)
            {
                if(!instances.ContainsKey(key))
                {
                    instances.Add(key, new multiton());
                }
            }
            return instances[key];

        }

        public void printDetails()
        {
            Console.WriteLine("implemented multiton pattern");
        }



    }
}
