using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consumer.AndyLemonway;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient AndyLemonwayWS = new WebService1SoapClient();

            //Create a New console application which will call the WebService
            //(on your localhost) to compute the Fibonacci(10) and print the result
            //to Fibonacci(10) the console 
            Console.WriteLine(AndyLemonwayWS.FibonacciService(10));
            Console.ReadLine();
        }
    }
}
