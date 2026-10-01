namespace Week6ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            int[,] testArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] rotatedArray = RotatedArray(testArray);
            for (int i = 0; i < rotatedArray.GetLength(0); i++)
            {
                for (int j = 0; j < rotatedArray.GetLength(1); j++)
                {
                    Console.Write(rotatedArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
            //1 2 3     7 4 1
            //4 5 6  >  8 5 2
            //7 8 9	    9 6 3

            //[0, 0][0, 1][0, 2]   [2, 0][1, 0][0, 0]
            //[1, 0][1, 1][1, 2] > [2, 1][1, 1][0, 1]
            //[2, 0][2, 1][2, 2]   [2, 2][1, 2][0, 2]

            //old[0, 0] = new[0,2]
            //old [0,1] = new [1,2]
            //old [0,2] = new [2,2]
            //old [1,0] = new [0,1]
            //old [1,1] = new [1,1]
            //old [1,2] = new [2,1]

            //old [row, col] = new [col,(n-1) - row]

        static int[,] RotatedArray(int[,] array)
        {
            int n = array.GetLength(0);
            int[,] rotatedArray = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedArray[i, j] = array[n - 1 - j, i];
                }
            }
            return rotatedArray;
        }
    }
}
