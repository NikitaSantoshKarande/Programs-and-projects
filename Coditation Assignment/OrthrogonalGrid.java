//Coditation Assignment
/*Imagine an infinite two-dimensional orthogonal grid of square cells, each of which is in one of two
 possible states, live or dead. Every cell interacts with its eight neighbors, which are the cells that are directly horizontally, vertically, or diagonally adjacent.*/

/*1. Any live cell with fewer than two live neighbors dies, as if by loneliness.
2. Any live cell with more than three live neighbors dies, as if by overcrowding.
3. Any live cell with two or three live neighbors lives, unchanged, to the next generation.
4. Any dead cell with exactly three live neighbors comes to life.*/

//ANSWER:

//The @ represent an live cell
//The * represent a dead cell

import java.lang.*;
import java.util.*;

class OrthrogonalGrid{
	
  public static void main(String args[])
  {
    Scanner sobj = new Scanner(System.in);

    System.out.println("Enter the size 1:");
    int M = sobj.nextInt();

    System.out.println("Enter the size 2:");
    int N = sobj.nextInt();

  
    int k = 0;
  	int[][] obj = new int[M][N];
	for(int i = 0;i < obj.length;i++)
	{
	   for(int j = 0; j < obj[i].length;j++)
	   {
	   	    obj[i][j] = (int)Math.round(Math.random());    
	   }
	}
	// Displaying the grid
        System.out.println("Original Generation");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (obj[i][j] == 0)
                    System.out.print("*");
                else
                    System.out.print("@");
            }
            System.out.println();
        }
        System.out.println();
        nextGeneration(obj, M, N);
        
    }
  
    // Function to print next generation
    static void nextGeneration(int grid[][], int M, int N)
    {
        int[][] future = new int[M][N];
  
        // Loop through every cell
        for (int l = 1; l < M - 1; l++)
        {
            for (int m = 1; m < N - 1; m++)
            {
                // finding no Of Neighbours that are alive
                int aliveNeighbours = 0;
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                        aliveNeighbours += grid[l + i][m + j];
  
                // The cell needs to be subtracted from
                // its neighbours as it was counted before
                aliveNeighbours -= grid[l][m];
  
                // Implementing the Rules of Life
  
                // Cell is lonely and dies
                if ((grid[l][m] == 1) && (aliveNeighbours < 2))
                    future[l][m] = 0;
  
                // Cell dies due to over overcrowding .
                else if ((grid[l][m] == 1) && (aliveNeighbours > 3))
                    future[l][m] = 0;
  
                // A new cell is born
                else if ((grid[l][m] == 0) && (aliveNeighbours == 3))
                    future[l][m] = 1;
  
                // Remains the same
                else
                    future[l][m] = grid[l][m];
            }
        }
  
        System.out.println("Next Generation");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (future[i][j] == 0)
                    System.out.print("*");
                else
                    System.out.print("@");
            }
            System.out.println();
        }

   }
  }