// using System.Text.RegularExpressions;
// using System.Security.Cryptography; 
// using System.Text.RegularExpressions;
// string userAddress_Strin2g = null;
// if((userAddress_Strin2g??="a")==null){System.Console.WriteLine("null");}else{System.Console.WriteLine(userAddress_Strin2g);}
// // ConsoleKeyInfo a = Console.ReadKey(true);
// string userAddress_String = Console.ReadLine();
// Console.WriteLine(a.KeyChar.ToString());
// System.Console.WriteLine(IRead.KeyToLine_Function());

// string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

// System.Console.WriteLine(exitCode_String);

// Thread.Sleep(1500);

// string a = IRead.KeyToLine_Function(exitCode_String);

// System.Console.WriteLine(a);

// if(exitCode_String == a)return;

// System.Console.WriteLine(Regex.IsMatch(a, @".*" + exitCode_String + @"$"));
// string[][] a = new string[10][];
// a[0] = new string[10];
// a[0][4]="A";
// foreach (var item in a[0])
// {

//     System.Console.WriteLine(item);

// }

// int defaultValue = 42; // Set your desired default value
// int[][] customDefaultArray = new int[2][];
// for (int i = 0; i < customDefaultArray.Length; i++)customDefaultArray[i] = Enumerable.Repeat(defaultValue, 5).ToArray();
// foreach (var item in customDefaultArray[0])System.Console.WriteLine(item);    
// int a = 1;
// try
// {

//     a= 5;

//     System.Console.WriteLine(a);

// }
// catch (System.Exception)
// {

//     a=2;

//     throw;
// }

// System.Console.WriteLine(a);

// using System.Globalization;
// using System.Text.RegularExpressions;

// string? a = "ad , , 012 , ,m@nv-,zlm ,asd!a*&(@A> , , , ,,";

// while(!string.IsNullOrEmpty(a))
// {

//     Match c = MyRegex().Match(a);

//     a = a.Remove(0,c.ToString().Length);

//     string b = c.ToString().Replace(",",null).Trim();

//     if(string.IsNullOrWhiteSpace(b)) b = "_";

//     System.Console.WriteLine(b);

// }

// partial class Program
// {
//     [GeneratedRegex(@"(?<Element>,?[^,]+|,?\s*)|(?<NA>.*)?")]
//     private static partial Regex MyRegex();
// }

// string[][] a=[];

// a = [["2"],[],[]];

// a[1] = ["2","a"];

// a[2] = ["2","wow","z","x","2"];

// a[2][3] = "hi";

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// string[] d = ["changed","woah"];

// a[2] = d;

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// string[][] a =[["3"],["1","2"]];

// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// System.Console.WriteLine("-----------");

// (a[0],a[1])=(a[1],a[0]);


// foreach (string[] b in a)
// {

//     foreach (string c in b)
//     {

//         System.Console.WriteLine(c);

//     }

// }

// Action<string> messageTarget;

// string? input = Console.ReadLine();

// input??="";

// if (input.Length > 5) messageTarget = ShowWindowsMessage;
// else messageTarget = Console.WriteLine;

// messageTarget(input);

// static void ShowWindowsMessage(string message)
// {

// System.Console.WriteLine(message + " is longer than 5 characters!");

// using System.Security.Cryptography;

// string a = RandomNumberGenerator.GetInt32(65355).ToString();

// string b="";

// if((b=IRead.KeyToLine_Function(a)).Contains(a))
// {
//     return;

// }
{
    int [][] augmented_StringArray2D = [[-2,2,2,0,1,2,2],[2,2,2,0,2,2,2],[2,2,1,-2,2,2,2],[1,2,2,2,2,2,2],[-2,2,2,2,2,2,1],[2,0,2,2,2,2,2],[2,2,2,2,2,-1,2]];

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
            
            if(diagonalElement_int == 0 | diagonalElement_int > option_Int)
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

                Console.Clear();

                System.Console.WriteLine("something went wrong while sorting!");
                
                return;
                
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

            int mostIndependentRow_Int = availableRows_IntArray2D[lowestChoiceIndex_Int].ToList().IndexOf(
                availableRows_IntArray2D[lowestChoiceIndex_Int].ToList().Where(x => x != 0).DefaultIfEmpty().Min());

            System.Console.WriteLine($"Sorted Row {lowestChoiceIndex_Int+1} = Input Row {mostIndependentRow_Int+1}");

            sortedAugmented_IntArray2D[lowestChoiceIndex_Int] = augmented_StringArray2D[mostIndependentRow_Int];

            sortedRows_IntList[lowestChoiceIndex_Int] = mostIndependentRow_Int;

            for(int column_Int=0 ; column_Int<arrayLength_Int;column_Int++)
            {

                rowsChoices_IntList[lowestChoiceIndex_Int] = 0;

                availableRows_IntArray2D[lowestChoiceIndex_Int][column_Int] = 0;

                availableRows_IntArray2D[column_Int][mostIndependentRow_Int] = 0;

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