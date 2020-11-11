using ClassLibrary1;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
		static void Main(string[] args)
		{
			Class1 cl = new Class1();

			cl.SurpressJit(); //set bp here
			Console.WriteLine("Hello World!");
		}
	}
}
