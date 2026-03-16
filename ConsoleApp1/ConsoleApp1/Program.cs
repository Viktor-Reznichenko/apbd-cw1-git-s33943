// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

 static int CalculateAverage(int[] values)
 {
     //modified
     return 1;
 };
 static int CalculateMax(int[] values)
 {
     return 0;
 };

 static int CalculateMin(int[] values)
 {
     int min = values[0];

     for (int i = 1; i < values.Length; i++)
     {
         if (values[i] < min)
         {
             min = values[i];
         }
     }

     return min;
     //modified
 };