using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            singleton ca = singleton.getInstance;
            ca.printMessage();


            singleton ca1 = singleton.getInstance;
            ca.printMessage();
            Console.ReadKey();
                

        }
    }


    public class singleton
    {
        public static singleton instance = null;
        public static int counter = 0;
        private singleton()
        {
            counter++;


        }

        public static singleton getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new singleton();
                    
                }
                return instance;
            }
            
        }

        public void printMessage()
        {
            Console.WriteLine("CAlling singleton method {0} times", +counter);

        }


    }
    
}
