using System;
class Arrays{
	static void Main(string[] args){
        //taking number of rows and columns as input from user
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        //creating 2D array
        int[,] matrix = new int[rows, columns];

        // Take input to fill the 2D array
        Console.WriteLine("Enter elements of the matrix:");
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                Console.WriteLine("Enter the element of matrix at index ({0},{1}): ",i,j);
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //creating 1D array of size rows*columns to store the matrix elements
        int[] array = new int[rows * columns];
        int index = 0;
        //copying elements from 2D array to 1D array
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                array[index] = matrix[i, j];
                index++; //incrementing the index 
            }
        }
        //printing the array elements
        Console.WriteLine("The elements of the 1D array are: ");
        foreach(int element in array){
            Console.Write(element + " ");
        }
    }
}
