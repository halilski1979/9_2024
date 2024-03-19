namespace Lotaria_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var danni=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rows = danni[0];
            int cols = danni[1];
            int sumGlaven = 0;
            int sumAbout = 0;
            int sumSecond = 0;
            int sumBelow = 0;
            int sumGlvEvent = 0;
            int sumFirstAndLatRow = 0;
            int sumFirstAndLastCol = 0;
            int[,]matrix=new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                int[]newArray=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = newArray[col];
                    if (row==col)
                    {
                        sumGlaven += matrix[row, col];
                        if (matrix[row,col]%2==0)
                        {
                            sumGlvEvent += matrix[row, col];
                        }
                    }
                    if (row<col)
                    {
                        sumAbout += matrix[row, col];
                    }
                    if (col==cols-1-row)
                    {
                        sumSecond += matrix[row, col];
                    }
                    if (row>col)
                    {
                        sumBelow += matrix[row, col];
                    }
                    if (row==0||row==rows-1)
                    {
                        if (matrix[row,col]%2==0)
                        {
                            sumFirstAndLatRow += matrix[row, col];
                        }
                    }
                    if (col==0||col==cols-1)
                    {
                        if (matrix[row,col]%2!=0)
                        {
                            sumFirstAndLastCol += matrix[row, col];
                        }
                    }
                }
            }//end Matrix
            if (sumGlaven==sumSecond&&sumAbout%2==0&&sumBelow%2!=0)
            {
                Console.WriteLine("YES");
                double total = (sumBelow + sumGlvEvent + sumFirstAndLatRow + sumFirstAndLastCol) / 4;
                Console.WriteLine($"The amount of money won is: {total:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}