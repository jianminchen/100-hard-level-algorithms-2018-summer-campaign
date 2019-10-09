using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_Knapsack_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var values  = new int[] { 60, 100, 120 };
            var weights = new int[] { 10, 20, 30 };

            var capacity = 50;
            var n = values.Length;

            Console.WriteLine(knapSack(capacity, weights, values, n)); 
        }
        
        /// <summary>
        /// study code
        /// https://www.geeksforgeeks.org/0-1-knapsack-problem-dp-10/
        /// Returns the maximum value that can be put in a knapsack of capacity W
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int knapSack(int capacity, int[] weight,
                            int[] value, int n)
        {
            // Base Case 
            if (n == 0 || capacity == 0)
            {
                return 0;
            }

            // If weight of the nth item is more than Knapsack capacity W,  
            // then this item cannot be included in the optimal solution          
            if (weight[n - 1] > capacity)
            {
                return knapSack(capacity, weight, value, n - 1);
            }

            // Return the maximum of two cases:  
            // (1) nth item included  
            // (2) not included 
            else return max(value[n - 1] +
                knapSack(capacity - weight[n - 1], weight, value, n - 1),
                         knapSack(capacity, weight, value, n - 1));
        } 

        static int max(int a, int b)  
        { 
            return (a > b)? a : b;  
        } 
    }
}
