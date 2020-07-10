using System;

namespace Problem_Solution_Essay
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1 - Array 
            /* Ön tanımlı bir array içinde birbirine komşu olmayan elemanlardan oluşturulan alt kümeler arasında, toplamı en büyük olanı bulma */

            int[] array = new int[] { -4, 3, 5, 1, -8, 1, -2, 7 };

            static int FindMaxSum(int[] array, int arrayCount)
            {
                int include = array[0];
                int exclude = 0;
                int excludeNew;
                int i;

                for (i = 1; i < arrayCount; i++)
                {
                    excludeNew = (include > exclude) ? include : exclude;
                    /* Yukarıdaki ternary operator'ün açılımı */
                    //if (include > exclude)
                    //{
                    //    excludeNew = include;
                    //}
                    //else
                    //{
                    //    excludeNew = exclude;
                    //}
                    include = exclude + array[i];
                    exclude = excludeNew;
                }
                return ((include > exclude) ? include : exclude);
            }

            Console.Write("Array max sum is: " + FindMaxSum(array, array.Length));

            Console.ReadKey();

            #endregion

            #region Question2 - Belirlenen sayının bütün bölenlerini bulup toplama

            //static int DivideSum(int number)
            //{
            //    int result = 0;
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            if (i == (number / i))
            //                result += i;
            //            else
            //                result += (i + number / i);
            //        }
            //    }
            //    return (result + 1);
            //}

            //int number = 10;

            //Console.Write(number + " sayısının tam bölenlerinin toplamı: " + DivideSum(number));

            //Console.ReadKey();
        }
        #endregion
    }
}

