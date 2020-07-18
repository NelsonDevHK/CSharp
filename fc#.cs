using System;

namespace Project_1 
{
    class MainClass
     {
        public static void Main (string[] args) 
        {
            int[] arr = { 3, 3, 2, 1, 3, 2, 1};
         int temp;
         for( int i =0 ; i <= arr.Length -2; i++)
         {
             for (int j = 0; j <= arr.Length -2 ; j++)
             {
                 if(arr[j] > arr [j+1])
                 {
                     temp = arr[j];
                     arr[j] = arr[j+1];
                     arr[j+1] = temp;
                 }
             }
         }
         Console.WriteLine("Sorted:");
         foreach (int p in arr)
            Console.Write(p + " ");
         Console.Read();
 
        }
    }
}
