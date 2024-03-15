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

int [][] augmented_StringArray2D = [[3,2,1,0,5,2,1],[-2,0,1,0,3,32,11],[1,32,51,67,31,6,1],[10,12,11,0,5,22,5],[1,0,1,-1,1,1,1],[8,3,1,2,2,3,5],[3,0,0,1,5,2,1]];

//length of array

int arrayLength_Int = augmented_StringArray2D.Length;

//first index = augmented row, second index = augmented row, value = dependency of [first row] on [second row]

int[][] availableRows_IntArray2D = new int[arrayLength_Int][];

//array of processed rows

int[] processedRows_IntArray = new int[arrayLength_Int];

//final sorted augmented array

int[][] sortedAugmented_IntArray2D = new int[arrayLength_Int][];

//index = augmented row, value = number of available options

List<int> rowsChoices_IntList = [];

//index = augmented row, value = number of dependent rows

List<int> rowsDependencies_IntList = []; 

// Initializing

for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
{

    rowsDependencies_IntList.Add(0);

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

//Sum Of [Column i] = How Many Rows Are Dependent On [Row i]

for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
{

    for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
    {

        if(availableRows_IntArray2D[column_Int][row_Int] == 1)rowsDependencies_IntList[row_Int]++;
    
    }

}

Console.Clear();

//showing the results
for (int row_Int = 0; row_Int < arrayLength_Int; row_Int++)
{

    System.Console.Write($"Row {row_Int+1}: ");

    for(int column_Int = 0; column_Int<arrayLength_Int; column_Int++)
    {

        int chosenNumbers_Int = 0;

        if(availableRows_IntArray2D[row_Int][column_Int] == 1)
        {

            chosenNumbers_Int = rowsDependencies_IntList[column_Int];

            if(availableRows_IntArray2D[row_Int][column_Int]==1)chosenNumbers_Int--;

        }

        if(augmented_StringArray2D[row_Int][row_Int] == 0 & chosenNumbers_Int!=0)
        {
            
            chosenNumbers_Int = -chosenNumbers_Int;

            availableRows_IntArray2D[row_Int][column_Int] = chosenNumbers_Int;

            System.Console.Write($"{availableRows_IntArray2D[row_Int][column_Int]} ");

        }else
        {

            availableRows_IntArray2D[row_Int][column_Int] = chosenNumbers_Int;

            System.Console.Write($" {availableRows_IntArray2D[row_Int][column_Int]} ");

        }

    }

    System.Console.WriteLine($": {rowsChoices_IntList[row_Int]}"); // when soorting, first choose the row that has the most choices,
    // in those choices, try to select the most independent option so we dont affect other rows (and their choices) if there were
    //multiple options, select the one with the lesser value

}

System.Console.WriteLine();

System.Console.WriteLine();

System.Console.WriteLine();

for(int process_Int = 0; process_Int<arrayLength_Int; process_Int++)
{    

    int mostIndependentRow_Int;

    int highestChoiceIndex_Int = rowsChoices_IntList.IndexOf(rowsChoices_IntList.Max());

    rowsChoices_IntList[highestChoiceIndex_Int] = 0;

    List<int> temp_IntList = [];

    Predicate<int> negativeCondition_Perdicate = Negative_SubFunction;

    // Predicate<int , bool> negativeCondition_Perdicate2 = Negative_SubFunction2;

    Predicate<int> independentCondition_Perdicate = Independent_SubFunction;    
    
    static bool Negative_SubFunction(int element_Int)
    {

        return element_Int<1;

    }

    static bool Independent_SubFunction(int element_Int)
    {

        return element_Int==0;

    }

    static (int ,bool) Negative_SubFunction2(int element_Int)
    {

        return (element_Int,element_Int == 0);

    }

    for(int column_Int = 0; column_Int<arrayLength_Int;column_Int++)
    {

        temp_IntList.Add(availableRows_IntArray2D[highestChoiceIndex_Int][column_Int]);

        int element=0;

        bool bool_Bool = false;

        if(temp_IntList[column_Int]==0)
        {

            temp_IntList[column_Int] = availableRows_IntArray2D[highestChoiceIndex_Int].Max()+1;

        }
        
    }

    if(!temp_IntList.TrueForAll(independentCondition_Perdicate))
    {

        if(temp_IntList.TrueForAll(negativeCondition_Perdicate))
        {
            
            mostIndependentRow_Int = temp_IntList.IndexOf(temp_IntList.Max());

        }else
        {

            mostIndependentRow_Int = temp_IntList.IndexOf(temp_IntList.Min());

        }

        sortedAugmented_IntArray2D[process_Int] = augmented_StringArray2D[mostIndependentRow_Int];

        for(int row_Int=0 ; row_Int<arrayLength_Int;row_Int++)
        {

            availableRows_IntArray2D[row_Int][mostIndependentRow_Int] = 0;

        }

    }

    Show_SubFunction(availableRows_IntArray2D,rowsChoices_IntList,arrayLength_Int);

}
static void Show_SubFunction(int[][]availableRows_IntArray2D,List<int>rowsChoices_IntList,int arrayLength_Int)
{

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

        System.Console.WriteLine($": {rowsChoices_IntList[row_Int]}");

    }

    System.Console.WriteLine();

    System.Console.WriteLine("------------------------------------------------");

    System.Console.WriteLine();

}