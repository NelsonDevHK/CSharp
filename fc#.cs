using System;

namespace Project_1 
{
    class MainClass
     {
        public static void Main (string[] args) 
        {
            int[] arr = {4, 7, 1 ,-3, 2};
         bool equal = false;
         int required = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("the number sum" +required);
         Console.WriteLine();
         for( int i =0 ; i <= arr.Length -2; i++)
         {
             for(int j = i ; j <= arr.Length -2 ;j++)
             {
                 if(arr[i] + arr [j+1] == required)
                  {
                      equal = true;
                    }
             }
         }
         Console.WriteLine("Return: ");
            Console.WriteLine(equal + " ");
         Console.Read();
 
        }
    }
}
