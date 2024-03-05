using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Gaussian_Elimination;

namespace Gaussian_Elimination;
public partial interface IFile
{

    public static void File_Function(string menu_String, string[][]menuItems_ArrayString)
    {        //"How Do You Want To Proceed? (use arrow keys or select on numpad)" , [["1. Enter Code Manually","1. Enter Address","Return"]]

        while(true){

            switch(Console.ReadKey().Key) //could ask twice for column (first enter row, then column; to select sth in a matrix idk)
            {

                case ConsoleKey.D1:
                {
                
                    WriteToFile_Function(new("local.txt"));
                
                }return;
                
                case ConsoleKey.D2:
                {

                    UserFileAddress_Function();

                }return;

                default:
                {
                    
                    System.Console.WriteLine("undefined action or key / something went wrong");

                }break;

            }

        }
        
    }

    private static void UserFileAddress_Function()
    {

        FileInfo userFile_FileInfo = new("");

        string hint_String = "Enter Your Address:";

        while(!userFile_FileInfo.Exists)
        {

            string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

            Console.Clear();
            
            System.Console.WriteLine(hint_String);

            hint_String = "Please Enter A Valid Address:";

            string userAddress_String = IRead.KeyToLine_Function(exitCode_String);

            if(userAddress_String.Trim() == exitCode_String)return;

            if(TxtRegex_Class().IsMatch(userAddress_String)) userFile_FileInfo = new (userAddress_String);

        }
        
        if(File.Exists("local.txt"))File.Delete("local.txt");

        userFile_FileInfo.CopyTo("local.txt");

        System.Console.WriteLine("Success");

    }

    private static void WriteToFile_Function(FileInfo appData_FileInfo)
    {

        StreamWriter storeData_StreamWriter;

        if(appData_FileInfo.Exists)
        {

            appData_FileInfo.Delete();
            
        }

        appData_FileInfo.Create();

        storeData_StreamWriter = appData_FileInfo.AppendText();

        while(true)
        {

            string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

            string inputLine_String = IRead.KeyToLine_Function(exitCode_String);

            switch (inputLine_String)
            {

                default:
                {

                    if(!Regex.IsMatch(inputLine_String,@".*" + exitCode_String + @"$"))
                    {

                        storeData_StreamWriter.WriteLine(inputLine_String);

                        break;                        

                    }

                    inputLine_String = inputLine_String.Replace("\u2386",null);

                    storeData_StreamWriter.WriteLine(inputLine_String);

                    storeData_StreamWriter.Dispose();

                    return;

                }

            }

            storeData_StreamWriter.Dispose();     

        }

    }

    private static string[][] ReadLocalFile_Function()
    {

        string[][] data_StringJArray = [];

        string[][] tempData_StringJArray = [];

        int rowNumber_Int = 1;

        if(!File.Exists("local.txt")) return [];

        StreamReader readLocalText_StreamReader = new("local.txt");

        string? line_String;

        while((line_String = readLocalText_StreamReader.ReadLine())!=null)
        {

            MatchCollection lineElemets_MatchCollection = ReadCSVRegex_Class().Matches(line_String);

            tempData_StringJArray = new string[rowNumber_Int][];

            tempData_StringJArray[rowNumber_Int-1] = new string[lineElemets_MatchCollection.Count];

            for(int count_int = 0 ; count_int < lineElemets_MatchCollection.Count ; count_int++)
            {

                tempData_StringJArray[rowNumber_Int][count_int] = lineElemets_MatchCollection[count_int].ToString();
                
            }

            for(int count_int = 0 ; count_int < lineElemets_MatchCollection.Count - 1 ; count_int++)
            {

                tempData_StringJArray[count_int] = new string[data_StringJArray[count_int].Length];

                tempData_StringJArray[count_int] = data_StringJArray[count_int];

            }

            rowNumber_Int++;

            data_StringJArray = tempData_StringJArray;

        }

        readLocalText_StreamReader.Dispose();

        return data_StringJArray;

    }

    [GeneratedRegex(@".*\.txt$")]
    private static partial Regex TxtRegex_Class();

    [GeneratedRegex(@",(?<Element>.*?),")]
    private static partial Regex ReadCSVRegex_Class();

}