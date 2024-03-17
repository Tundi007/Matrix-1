using System.Numerics;
using Fractions;
namespace Gaussian_Elimination;

public class Process
{
    

    public static void Start_Function(Fraction[][] baseMatrixProblem_FractionArray2D,Fraction[][] baseMatrixDestination_FractionArray2D,int variableNumber_Int,bool jordanElimination_Bool)
    {

        GaussianElimination_Function(baseMatrixProblem_FractionArray2D, baseMatrixDestination_FractionArray2D, variableNumber_Int,jordanElimination_Bool);

    }

    private static void GaussianElimination_Function(Fraction[][] baseMatrixProblem_FractionArray2D, Fraction[][] baseMatrixDestination_FractionArray2D, int variableNumber_Int,bool jordanElimination_Bool)
    {

        if(variableNumber_Int>baseMatrixProblem_FractionArray2D.Length)return; //number of variables shouldnt be more than problem's

        if(baseMatrixProblem_FractionArray2D.Length!=baseMatrixProblem_FractionArray2D[0].Length)return; // check first if length of arrays are ok then proceed

        string[][] baseVectorVariable_StringArray2D = new string[baseMatrixProblem_FractionArray2D.Length][]; // variable vector

        Fraction[][] augmentedMatrix_FractionArray2D = [];

        for (int variable_Int = 0; variable_Int < variableNumber_Int; variable_Int++)
        {

            baseVectorVariable_StringArray2D[variable_Int] = new string[1];

            baseVectorVariable_StringArray2D[variable_Int][0] = string.Format($"x{variable_Int}");
            
        }

        augmentedMatrix_FractionArray2D = Sort_Function(augmentedMatrix_FractionArray2D);

        augmentedMatrix_FractionArray2D = Elimination_Function(augmentedMatrix_FractionArray2D);

        Show_Function(augmentedMatrix_FractionArray2D,[],false);

        
    }

    private static int[][] Merger_Function(int jordanRule_Int, int[][] problem_StringArray2D, int[][] destination_StringArray2D)
    {

        int[][] augmented_FractionArray2D = [];

        int totalRow_Int = problem_StringArray2D.Length;

        int totalColumn_Int = problem_StringArray2D[0].Length;

        for(int row_Int = 0; row_Int < totalRow_Int; row_Int++)
        {

            augmented_FractionArray2D[row_Int] = new int[totalColumn_Int+1];

            for (int column_Int = 0; column_Int < totalColumn_Int; column_Int++)
            {

                augmented_FractionArray2D[row_Int][column_Int] = problem_StringArray2D[row_Int][column_Int];
                
            }

            for (int column_Int = 0; column_Int < jordanRule_Int; column_Int++)
            {

                augmented_FractionArray2D[row_Int][totalColumn_Int+column_Int] = destination_StringArray2D[row_Int][column_Int];
                
            }

        }

        return augmented_FractionArray2D;

    }

    private static Fraction[][] Elimination_Function(Fraction[][]augmented_FractionArray2D)
    {
        
        for(int row_Int = 0; row_Int<augmented_FractionArray2D.Length-1;row_Int++)
        {   

            for(int eliminationRow_Int = row_Int+1;eliminationRow_Int<augmented_FractionArray2D.Length;eliminationRow_Int++)
            {

                Fraction diagonalRow_FractionArray = augmented_FractionArray2D[eliminationRow_Int][row_Int]/augmented_FractionArray2D[row_Int][row_Int];

                for (int column_Int=0; column_Int < augmented_FractionArray2D[eliminationRow_Int].Length;column_Int++)
                {

                    augmented_FractionArray2D[eliminationRow_Int][column_Int]-=diagonalRow_FractionArray*augmented_FractionArray2D[row_Int][column_Int];
                    
                }

            }

        }

        return augmented_FractionArray2D;

    }

    static Fraction[][] Sort_Function(Fraction[][]augmented_FractionArray2D)
    {

        int arrayLength_Int = augmented_FractionArray2D.Length;

        Fraction[][] sortedAugmented_IntArray2D = new Fraction[arrayLength_Int][];

        Fraction[][] availableRows_IntArray2D = new Fraction[arrayLength_Int][];

        List<int> rows_IntList =[];

        List<int> rowsChoices_IntList = [];

        List<int> sortedRows_IntList = []; 

        List<int> usedRows_IntList = []; 

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            sortedRows_IntList.Add(-1);

            rows_IntList.Add(row_Int);

            rowsChoices_IntList.Add(0);

            sortedAugmented_IntArray2D[row_Int] = new Fraction[arrayLength_Int];

            availableRows_IntArray2D[row_Int] = new Fraction[arrayLength_Int];
            
        }

        for(int currentRow_Int = 0; currentRow_Int<arrayLength_Int; currentRow_Int++) 
        {   

            int diagonalElement_int = (int)augmented_FractionArray2D[currentRow_Int][currentRow_Int];

            if(diagonalElement_int<0)diagonalElement_int =- diagonalElement_int;

            for(int nextRow_Int = currentRow_Int+1; nextRow_Int < arrayLength_Int; nextRow_Int++)
            {        

                int option_Int= (int)augmented_FractionArray2D[nextRow_Int][currentRow_Int];

                if(option_Int<0)option_Int =- option_Int;

                if(option_Int != 0 & (diagonalElement_int == 0 | diagonalElement_int > option_Int))
                {

                    rowsChoices_IntList[currentRow_Int]++;
                        
                    availableRows_IntArray2D[currentRow_Int][nextRow_Int] = 1;
                                        
                }

            }

            for(int previousRow_Int = currentRow_Int-1; previousRow_Int > -1; previousRow_Int--) 
            {

                int option_Int = (int)augmented_FractionArray2D[previousRow_Int][currentRow_Int];

                if(option_Int < 0)option_Int =- option_Int;

                if(option_Int != 0 &(diagonalElement_int == 0 | diagonalElement_int > option_Int))
                {

                    rowsChoices_IntList[currentRow_Int]++;

                    availableRows_IntArray2D[currentRow_Int][previousRow_Int] = 1;
                    
                }

            }

        }

        AssessMatrix_Function(availableRows_IntArray2D,out rowsChoices_IntList);

        Console.Clear();

        Show_Function(availableRows_IntArray2D,rowsChoices_IntList,true);

        for(int process_Int = 0; process_Int<arrayLength_Int; process_Int++)
        {

            int lowestChoiceIndex_Int = rowsChoices_IntList.IndexOf(rowsChoices_IntList.Where(x => x != 0).DefaultIfEmpty(-1).Min());
            
            if(lowestChoiceIndex_Int == -1)
            {            

                int unsortedRow_Int = sortedRows_IntList.IndexOf(-1);
                
                int unusedRow_Int = rows_IntList.IndexOf(rows_IntList.Where(row_Int => !sortedRows_IntList.Contains(row_Int) &
                    augmented_FractionArray2D[row_Int][unsortedRow_Int] != 0).DefaultIfEmpty(-1).First());

                if(unusedRow_Int==-1)
                {

                    System.Console.WriteLine("something went wrong while sorting!");
                    
                    return[];
                    
                }
                
                sortedRows_IntList[unsortedRow_Int] = unusedRow_Int;

                sortedAugmented_IntArray2D[unsortedRow_Int] = augmented_FractionArray2D[unusedRow_Int];

                System.Console.WriteLine($"Uncodnitioned, Sorted Row {unsortedRow_Int+1} = Input Row {unusedRow_Int+1}");
                
                for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
                {

                    availableRows_IntArray2D[unsortedRow_Int][column_Int] = 0;

                    availableRows_IntArray2D[column_Int][unusedRow_Int] = 0;

                }

            }else
            {            

                int leastDependencies_Int = (int)availableRows_IntArray2D[lowestChoiceIndex_Int].Max();

                int leastDependentRow_Int = availableRows_IntArray2D[lowestChoiceIndex_Int].ToList().IndexOf(leastDependencies_Int);

                for(int column_Int = 0; column_Int == arrayLength_Int; column_Int++)
                {

                    if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] != 0 & augmented_FractionArray2D[column_Int][lowestChoiceIndex_Int]!=0)
                    {

                        if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int]<=leastDependentRow_Int)
                        {

                            leastDependencies_Int = (int)availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int];
                            
                            leastDependentRow_Int = column_Int;
                            
                        }

                    }

                }

                System.Console.WriteLine($"Sorted Row {lowestChoiceIndex_Int+1} = Input Row {leastDependentRow_Int+1}");

                sortedAugmented_IntArray2D[lowestChoiceIndex_Int] = augmented_FractionArray2D[leastDependentRow_Int];

                sortedRows_IntList[lowestChoiceIndex_Int] = leastDependentRow_Int;

                for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
                {

                    rowsChoices_IntList[lowestChoiceIndex_Int] = 0;

                    availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] = 0;

                    availableRows_IntArray2D[column_Int][leastDependentRow_Int] = 0;

                }

            }

            availableRows_IntArray2D = AssessMatrix_Function(availableRows_IntArray2D,out rowsChoices_IntList);

            for(int index_Int=0;index_Int<arrayLength_Int;index_Int++)System.Console.Write($"S{index_Int+1}=A{sortedRows_IntList[index_Int]+1} ");

            System.Console.WriteLine();

            System.Console.WriteLine("New Table:");

            Show_Function(availableRows_IntArray2D,rowsChoices_IntList,true);
        
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Input:");

        Show_Function(augmented_FractionArray2D,rowsChoices_IntList,false);

        System.Console.WriteLine("Output:");

        Show_Function(sortedAugmented_IntArray2D,rowsChoices_IntList,false);

        return sortedAugmented_IntArray2D;

    }

    static void Show_Function(Fraction[][]availableRows_IntArray2D,List<int>rowsChoices_IntList,bool showChoicesSum_Bool)
    {

        int arrayLength_Int = availableRows_IntArray2D.Length;

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            System.Console.Write($"Row {row_Int+1}: ");

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                if(availableRows_IntArray2D[row_Int][column_Int] >= 0)
                {

                    System.Console.Write($" {availableRows_IntArray2D[row_Int][column_Int]} ");

                }else
                {

                    System.Console.Write($"{availableRows_IntArray2D[row_Int][column_Int]} ");

                }

            }

            if(showChoicesSum_Bool)System.Console.Write($": {rowsChoices_IntList[row_Int]}");

            System.Console.WriteLine();

        }

        System.Console.WriteLine();

        System.Console.WriteLine("------------------------------------------------");

        System.Console.WriteLine();

    }

    static Fraction[][] AssessMatrix_Function(Fraction[][] matrix_IntArray2D, out List<int>rowsChoices_IntList)
    {

        int arrayLength_Int = matrix_IntArray2D.Length;

        List<int> independencyRank_IntList = [];

        rowsChoices_IntList = [];

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            rowsChoices_IntList.Add(0);

            independencyRank_IntList.Add(0);

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                if(matrix_IntArray2D[column_Int][row_Int] != 0)independencyRank_IntList[row_Int]++;
            
            }

        }

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
            {

                int chosenNumbers_Int = 0;

                if(matrix_IntArray2D[row_Int][column_Int] != 0)
                {

                    rowsChoices_IntList[row_Int]++;

                    chosenNumbers_Int = independencyRank_IntList[column_Int];

                    if(matrix_IntArray2D[column_Int][row_Int]!=0)chosenNumbers_Int--;

                    if(chosenNumbers_Int == 0)chosenNumbers_Int++;

                }

                matrix_IntArray2D[row_Int][column_Int] = chosenNumbers_Int;

            }

        }

        return matrix_IntArray2D;

    }

}