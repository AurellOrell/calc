using System;

namespace HelloWorld
{
  class index
  {
    static void Main(string[] args)
    {
      int a = 10;
int b = 6;	  
Console.Writeline("{0} + {1} = {2}", a, b, plus(a, b));
Console.Writeline("{0} - {1} = {2}", a, b, minus(a, b));
    }
	static int plus(int a, int b){
	return a + b;
	}
	
	static int plus(int a, int b){
	return a - b;
	}
  }
}