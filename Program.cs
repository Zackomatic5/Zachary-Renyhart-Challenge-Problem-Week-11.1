namespace Zachary_Renyhart_Challenge_Problem_Week_11._1
{
    internal class Program
    {
        //Leetcode Problem #75
        static void Main(string[] args)
        {
            //Create an array where
            // O = Red, 1 = Blue, 2 = White
            //Without using the .Sort method order the colors together.
            int[] array = { 0, 2, 1, 2, 2, 0, 1, 0 };

            for (int i = 0; i < array.Length; i++)
            {//Iterate through the array starting at the i'th element.
                for (int j = i + 1; j < array.Length; j++)
                {//Iterate through the array starting at the i + 1 element or the second element.
                 //This is to compare the I and J elements.
                       
                    if (array[j] < array[i])
                    {//If J is less than I, a temp value will hold J. I and J will reverse spots
                        //This will continue iterating throughout the entire array until the array is sorted from least to greatest.
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                    
                }
            }
            PrintArray(array);
        }
        static void PrintArray(int[] array)
        {//This method is to print the array
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }

    }
}
