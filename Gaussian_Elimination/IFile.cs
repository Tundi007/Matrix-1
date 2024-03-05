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

    [GeneratedRegex(@".*\.txt$")]
    private static partial Regex TxtRegex_Class();

}