using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShort
{
    class program
    {
        //arraay of integers to hold value
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

       //number of element in array
        private int n;


        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements\n");
            }
        
        Console.WriteLine("\n===============");
        Console.WriteLine("Enter Array Elements");
        Console.WriteLine("\n===============");
            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;

            i = low + 1;
            j = high;

            pivot = arr[low];
            while (i <= j) 
            {
                while ((arr[i] <= pivot) && ( i <= high))
                {
                    j++;
                    cmp_count++;
                }
                cmp_count++;
                
                while ((arr[j] <= pivot) && ( j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;
                if (i < j)

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
