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
        
        for(int currentrow_Int = currentColumn_Int+1; currentrow_Int < augmented_StringArray2D.Length; currentrow_Int++)
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

    static int[][] Sort_Function(int[][]augmented_StringArray2D)
    {
        //length of array

        int arrayLength_Int = augmented_StringArray2D.Length;

        //final sorted augmented array

        int[][] sortedAugmented_IntArray2D = new int[arrayLength_Int][];

        //first index = augmented row, second index = augmented row, value = dependency of [first row] on [second row]

        int[][] availableRows_IntArray2D = new int[arrayLength_Int][];

        //rows

        List<int> rows_IntList =[];

        //index = augmented row, value = number of available options

        List<int> rowsChoices_IntList = [];

        //index = no meaning, value = index of augmented row

        List<int> sortedRows_IntList = []; 

        //index = no meaning, value = index of augmented row

        List<int> usedRows_IntList = []; 

        // Initializing

        for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
        {

            sortedRows_IntList.Add(-1);

            rows_IntList.Add(row_Int);

            rowsChoices_IntList.Add(0);

            sortedAugmented_IntArray2D[row_Int] = new int[arrayLength_Int];

            availableRows_IntArray2D[row_Int] = new int[arrayLength_Int];
            
        }

        //Checking The Options For Each Row

        for(int currentRow_Int = 0; currentRow_Int<arrayLength_Int; currentRow_Int++) 
        {   

            //value of current diagonal (main) element

            int diagonalElement_int = augmented_StringArray2D[currentRow_Int][currentRow_Int];

            //keeping the element value in natural numbers

            if(diagonalElement_int<0)diagonalElement_int =- diagonalElement_int;

            //Checking Possible Chocies After Below The Current Diagonal Element

            for(int nextRow_Int = currentRow_Int+1; nextRow_Int < arrayLength_Int; nextRow_Int++)
            {        

                //keeping the value of the element below

                int option_Int= augmented_StringArray2D[nextRow_Int][currentRow_Int];

                //keeping the element value in natural numbers

                if(option_Int<0)option_Int =- option_Int;

                //Checking Rule Set Of Swaping

                if(option_Int != 0 & (diagonalElement_int == 0 | diagonalElement_int > option_Int))
                {

                    //Calculating Sum Of [Row i] = How Many Other Rows Can [Row i] Swap With

                    rowsChoices_IntList[currentRow_Int]++;

                    //setting eligibility of swapping current row with the row below
                        
                    availableRows_IntArray2D[currentRow_Int][nextRow_Int] = 1;
                                        
                }

            }

            //Also Checking Possible Chocies Before The Current Diagonal Element

            for(int previousRow_Int = currentRow_Int-1; previousRow_Int > -1; previousRow_Int--) 
            {

                //keeping the value of the element below

                int option_Int = augmented_StringArray2D[previousRow_Int][currentRow_Int];

                //keeping the element value in natural numbers

                if(option_Int < 0)option_Int =- option_Int;

                //Checking Rule Set Of Swaping
                
                if(option_Int != 0 &(diagonalElement_int == 0 | diagonalElement_int > option_Int))
                {

                    //Calculating Sum Of [Row i] = How Many Other Rows Can [Row i] Swap With

                    rowsChoices_IntList[currentRow_Int]++;

                    //eligibility of swapping current row with the row below
                    
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
                    augmented_StringArray2D[row_Int][unsortedRow_Int] != 0).DefaultIfEmpty(-1).First());

                if(unusedRow_Int==-1)
                {

                    System.Console.WriteLine("something went wrong while sorting!");
                    
                    return[];
                    
                }
                
                sortedRows_IntList[unsortedRow_Int] = unusedRow_Int;

                sortedAugmented_IntArray2D[unsortedRow_Int] = augmented_StringArray2D[unusedRow_Int];

                System.Console.WriteLine($"Uncodnitioned, Sorted Row {unsortedRow_Int+1} = Input Row {unusedRow_Int+1}");
                
                for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
                {

                    availableRows_IntArray2D[unsortedRow_Int][column_Int] = 0;

                    availableRows_IntArray2D[column_Int][unusedRow_Int] = 0;

                }

            }else
            {            

                int leastDependencies_Int = availableRows_IntArray2D[lowestChoiceIndex_Int].Max();

                int leastDependentRow_Int = availableRows_IntArray2D[lowestChoiceIndex_Int].ToList().IndexOf(leastDependencies_Int);

                for(int column_Int = 0; column_Int == arrayLength_Int; column_Int++)
                {

                    if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] != 0 & augmented_StringArray2D[column_Int][lowestChoiceIndex_Int]!=0)
                    {

                        if(availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int]<=leastDependentRow_Int)
                        {

                            leastDependencies_Int = availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int];
                            
                            leastDependentRow_Int = column_Int;
                            
                        }

                    }

                }

                System.Console.WriteLine($"Sorted Row {lowestChoiceIndex_Int+1} = Input Row {leastDependentRow_Int+1}");

                sortedAugmented_IntArray2D[lowestChoiceIndex_Int] = augmented_StringArray2D[leastDependentRow_Int];

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

        Show_Function(augmented_StringArray2D,rowsChoices_IntList,false);

        System.Console.WriteLine("Output:");

        Show_Function(sortedAugmented_IntArray2D,rowsChoices_IntList,false);

        return sortedAugmented_IntArray2D;

    }

    static void Show_Function(int[][]availableRows_IntArray2D,List<int>rowsChoices_IntList,bool showChoicesSum_Bool)
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

    static int[][] AssessMatrix_Function(int[][] matrix_IntArray2D, out List<int>rowsChoices_IntList)
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