using System;

namespace sumInATriangle
{
    class maximumPath
    {
        int row, rowIndex, colmnIndex;
        int[,] triangleArray = new int[100, 100];

        //Getting input from the user      
        public void getValue()
        {
            row = -1;
            while (row < 1)
            {
                Console.WriteLine("\nEnter no. of rows");
                row = Convert.ToInt32(Console.ReadLine());
                if(row<1)
                {
                    Console.WriteLine("\nEnter a non-zero or a positive number");
                }
                
            }
                Console.WriteLine("\nEnter The Values");
                for (rowIndex = 0; rowIndex < row; rowIndex++)
                {
                    for (colmnIndex = 0; colmnIndex <= rowIndex; colmnIndex++)
                    {
                        triangleArray[rowIndex, colmnIndex] = Convert.ToInt32(Console.ReadLine());
                    }
                }
         
        }

        //Printing the triangle array
        public void printArray()
        {
            Console.WriteLine("\nThe Input Triangle Is: \n");
            for (rowIndex = 0; rowIndex < row; rowIndex++)
            {
                for (colmnIndex = 0; colmnIndex <= rowIndex; colmnIndex++)
                {
                    Console.Write(triangleArray[rowIndex, colmnIndex] + " ");
                }
                Console.WriteLine("");
            }
        }


        //Calculating the maximum sum in a path
        public void calculateSum()
        {
            for (rowIndex = row - 2; rowIndex >= 0; rowIndex--)
            {
                for (colmnIndex = 0; colmnIndex <= rowIndex; colmnIndex++)
                {

                    if (triangleArray[rowIndex + 1, colmnIndex] > triangleArray[rowIndex + 1, colmnIndex + 1])
                    {
                        triangleArray[rowIndex, colmnIndex] += triangleArray[rowIndex + 1, colmnIndex];
                    }
                    else
                    {
                        triangleArray[rowIndex, colmnIndex] += triangleArray[rowIndex + 1, colmnIndex + 1];
                    }
                }
            }
        }

        //Printing the maximum sum
        public void result()
        {
            Console.WriteLine("\nThe Max Sum in a Path is: \n");
            Console.Write("{0} \n\n", triangleArray[0, 0]);
            Console.WriteLine("--------------------------");
        }

   
        static void Main(string[] args)
        {
            //int row, rowIndex, colmnIndex, iteration,iterationIndex;
            //int[,] triangleArray = new int[100, 100];
            maximumPath max = new maximumPath();
            int iteration,iterationIndex;
            iteration = -1;
            while(iteration<1)
            {
                Console.WriteLine("\nEnter the number of Test Cases : \n");
                iteration = Convert.ToInt32( Console.ReadLine());
                if (iteration < 1)
                {
                    Console.WriteLine("\nEnter a non-zero or a  positive value");
                }
            }
             for (iterationIndex = 1; iterationIndex <= iteration; iterationIndex++)
             {
                    Console.WriteLine("\nIteration {0}", +iterationIndex);
                    max.getValue();
                    max.printArray();
                    max.calculateSum();
                    max.result();
             }
                Console.ReadLine();
           
        }
    }
}
