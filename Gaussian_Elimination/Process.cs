namespace Gaussian_Elimination;

public class Process
{

    private static List<string[][]> dataListPrivate_StringList2D = [];

    private static void FreshData_Function()
    {

        dataListPrivate_StringList2D = IData.GetAllDataSets_Function();

    }


    private static void GaussianElimination_Function(int problemDataIndex_Int, int problemDestinationIndex_Int, bool jordanElimination_Bool)
    {

        FreshData_Function();

        int[][] baseMatrixProblem_StringArray2D = [];//needs initialization

        int[][] baseMatrixDestination_StringArray2D = [];//needs initialization
        
        int totalRow_Int = baseMatrixProblem_StringArray2D.Length;                

        int totalColumn_Int = baseMatrixProblem_StringArray2D[0].Length;

        if(totalColumn_Int!=totalRow_Int)return; // check first if length of arrays are ok then proceed

        int jordanRule_Int = 1;

        if(jordanElimination_Bool)jordanRule_Int = totalColumn_Int*2;

        string[] baseMatrixVariable_StringArray2D = new string[totalRow_Int];

        int[][] augmentedMatrix_StringArray2D = Merger_Function(jordanRule_Int,baseMatrixProblem_StringArray2D,baseMatrixDestination_StringArray2D);        

        for (int variableNumber_Int = 0; variableNumber_Int < totalRow_Int; variableNumber_Int++)
        {

            baseMatrixVariable_StringArray2D[variableNumber_Int] = string.Format($"x{variableNumber_Int}");
            
        }

        augmentedMatrix_StringArray2D = Sort_Function(augmentedMatrix_StringArray2D);

        for (int currentColumn_Int = 0; currentColumn_Int < totalRow_Int; currentColumn_Int++)
        {

            augmentedMatrix_StringArray2D = Elimination_Function(augmentedMatrix_StringArray2D,currentColumn_Int);

        }

        
    }

    private static int[][] Merger_Function(int jordanRule_Int, int[][] problem_StringArray2D, int[][] destination_StringArray2D)
    {

        int[][] augmented_StringArray2D = [];

        int totalRow_Int = problem_StringArray2D.Length;

        int totalColumn_Int = problem_StringArray2D[0].Length;

        for(int row_Int = 0; row_Int < totalRow_Int; row_Int++)
        {

            augmented_StringArray2D[row_Int] = new int[totalColumn_Int+1];

            for (int column_Int = 0; column_Int < totalColumn_Int; column_Int++)
            {

                augmented_StringArray2D[row_Int][column_Int] = problem_StringArray2D[row_Int][column_Int];
                
            }

            for (int column_Int = 0; column_Int < jordanRule_Int; column_Int++)
            {

                augmented_StringArray2D[row_Int][totalColumn_Int+column_Int] = destination_StringArray2D[row_Int][column_Int];
                
            }               

        }

        return augmented_StringArray2D;

    }

    private static int[][] Elimination_Function(int[][]augmented_StringArray2D,int currentColumn_Int)
    {

        int totalRow_Int = augmented_StringArray2D.Length;


        for(int currentrow_Int = currentColumn_Int+1; currentrow_Int < totalRow_Int; currentrow_Int++)
        {

            if(augmented_StringArray2D[currentrow_Int][currentColumn_Int] != 0)
            {

                int multiplier_Int = augmented_StringArray2D[currentColumn_Int][currentColumn_Int]/augmented_StringArray2D[currentrow_Int][currentColumn_Int];

                Array.ForEach(augmented_StringArray2D[currentrow_Int],delegate(int element_Int)
                {
                    
                    augmented_StringArray2D[currentColumn_Int][currentColumn_Int] = element_Int;
                    
                });
                
            }
            
        }

        return[];

    }

    private static int[]SortColumn_Function(int[][]augmented_StringArray2D, int currentRow_Int)
    {

        int[] availableRows_Int = new int[augmented_StringArray2D.Length];

        int countRows_Int = 0;

        for(int nextRow_Int = 0; nextRow_Int < augmented_StringArray2D.Length; nextRow_Int++)
        {

            if(augmented_StringArray2D[nextRow_Int][currentRow_Int] != 0 &
                (augmented_StringArray2D[currentRow_Int][currentRow_Int] == 0 |
                    (augmented_StringArray2D[currentRow_Int][currentRow_Int] > augmented_StringArray2D[nextRow_Int][currentRow_Int] &
                            -augmented_StringArray2D[nextRow_Int][currentRow_Int]>augmented_StringArray2D[currentRow_Int][currentRow_Int])))
            {

                availableRows_Int[countRows_Int] = nextRow_Int;

                countRows_Int++;
                        
            }

        }       

        return availableRows_Int;

    }

    private static int[][] Sort_Function(int[][]augmented_StringArray2D)
    {   

        for (int row_Int = 0; row_Int < augmented_StringArray2D.Length; row_Int++)
        {

            bool diagonalIsZero_Bool = augmented_StringArray2D[row_Int][row_Int] == 0;

            if(augmented_StringArray2D[row_Int][row_Int] != 1 & augmented_StringArray2D[row_Int][row_Int] != -1)
            {

                int[]availableRows_Int = SortColumn_Function(augmented_StringArray2D,row_Int);

                foreach (int nextRow_Int in availableRows_Int)
                {

                    if(augmented_StringArray2D[row_Int][row_Int] == (1|-1))break;

                    if(augmented_StringArray2D[row_Int][nextRow_Int] != 0 | diagonalIsZero_Bool)
                    {

                        diagonalIsZero_Bool = false;
                        
                        (augmented_StringArray2D[row_Int],
                            augmented_StringArray2D[nextRow_Int])=
                                (augmented_StringArray2D[nextRow_Int],
                                    augmented_StringArray2D[row_Int]);
                                    
                    }

                }

            }

        }

        return augmented_StringArray2D;

    }

}