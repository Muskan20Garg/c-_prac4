using System;  
namespace abc
{
  public class array
   {  
     public static void Main(string[] args)  
      {  
          	var numbers = new[] {3,7,9,2,14,6};
	//length
	Console.WriteLine("length: " + numbers.length);
	//IndexOF()
	var index = Array.IndexOf(numbers,9);
	Console.WriteLine(index);
	//Clear()
	Array.Clear(numbers,0,2);
	foreach(var n in numbers)
		Console.WriteLine(n);
    }  
  }
}  