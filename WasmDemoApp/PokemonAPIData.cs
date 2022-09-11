using System;
using System.Collections.Generic;

namespace WasmDemoApp
{
    public class PokemonAPIData
    {
        public List<ListPokemon> results { get; set; }
    }

    public class ListPokemon
    {
        public string name { get; set; }

        public string url { get; set; }
    }

    /*public class MatrixMultiplicationExample
    {
        public void sasdgasgd(String args[])
        {
            //creating two matrices    
            int[][] a = new int[][]
            int b[][]={ { 1,1,1},{ 2,2,2},{ 3,3,3} };

            //creating another matrix to store the multiplication of two matrices    
            int c[][]= new int[3][3];  //3 rows and 3 columns  

            //multiplying and printing multiplication of 2 matrices    
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i][j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        c[i][j] += a[i][k] * b[k][j];
                    }//end of k loop  
                    System.out.print(c[i][j] + " ");  //printing matrix element  
                }//end of j loop  
                System.out.println();//new line    
            }
        }
    } */
}
