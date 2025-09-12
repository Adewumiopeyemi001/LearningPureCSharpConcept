using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Array
    {
        /*
        Array is refrence type
        Is used to store a collection of data
        Stores a fixed-Size sequential collection
        int[] arr1 = new int[5];
        arr1[0] = 10;

        Multi Dimension Array
        int[,] arr1 = new int[2, 3] {{1,2,3}, {11,22,33}};
        int[,] arr2 = new int[,] {{1,2,34,4}, {3,5,33,2}};

        int[,] arr3 = new int[2, 3];
        arr3[0, 0] = 1;
        arr3[0, 1] = 2;

        Jagged Array also called Array of array


        */
        public static void Array1()
        {
            int[] arr = { 7, 3, 5, 1, 9, 2 };
            Console.WriteLine(arr[0]);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Array2() 
        {
            int[] arr = [7, 3, 5, 1, 9, 2];
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr [j + 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Array3()
        {
            int[] arr = { 7, 3, 5, 1, 9, 2 };
            Console.Write("Enter the number to search: ");
            int num = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    found = true;
                    break;
                }
            }
            if(found)
                Console.WriteLine("Element found");
            else
                Console.WriteLine("Element not found");
        }

        public static void Array4()
        {
            int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 }, { 11, 22, 33, 44 } };
            for (int i = 0; i < 3; i++)
            {
                for (global::System.Int32 j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
        public static void Array5() 
        {
            int[][] arr = [[1, 2, 3], [20, 30], [11, 22, 33, 44]]; //Array of array
            foreach (int[] ar in arr)
            {
                foreach (int item in ar)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
