using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Method_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hellouniverse();
            hellouniverse();
            hellouniverse();


        } // Closing Main
        
         
        //------------------------------------------

        // Create a method, that when called, prints
        // 1
        // 2
        // 3

        
       public static void hellouniverse()
        {
            One();
            Console.WriteLine("2");
            Three();

        } // hellouniverse()

        public static void One()
        {
            Console.WriteLine("1");
        } // One()

        public static void Three()
        {
            Console.WriteLine("3");
        } // Three()


    } // class
     
} // namespace
