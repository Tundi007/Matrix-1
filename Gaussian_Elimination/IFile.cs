using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Gaussian_Elimination;
public partial interface IFile
{

    public static void File_Function()
    {        //"How Do You Want To Proceed? (use arrow keys or select on numpad)" , [["1. Enter Code Manually","1. Enter Address","Return"]]

        while(true){

            switch(Console.ReadKey().Key) //could ask twice for column (first enter row, then column; to select sth in a matrix idk)
            {

                case ConsoleKey.D1:
                {
                
                    if(WriteToFile_Function(new("local.txt")))
                    {
                        
                        ReadLocalFile_Function();

                    }
                
                }return;
                
                case ConsoleKey.D2:
                {

                    if(UserFileAddress_Function())
                    {

                        ReadLocalFile_Function();
                    
                    }

                }return;

                case ConsoleKey.D3:
                {

                    ReadLocalFile_Function();

                }return;

                case ConsoleKey.Escape | ConsoleKey.End: return;

                default:
                {
                    
                    System.Console.WriteLine("undefined action or key / something went wrong");

                }break;

            }

        }
        
    }

    private static bool UserFileAddress_Function()
    {

        string userAddress_String = "";

        string hint_String = "Enter Your Address:";

        while(!File.Exists(userAddress_String) && TxtRegex_Class().IsMatch(userAddress_String))
        {

            string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

            Console.Clear();
            
            System.Console.WriteLine(hint_String);

            hint_String = "Please Enter A Valid Address:";

            userAddress_String = IRead.KeyToLine_Function(exitCode_String);

            if(userAddress_String == exitCode_String) return false;

        }
        
        if(File.Exists("local.txt"))File.Delete("local.txt");

        try
        {

            File.Copy(userAddress_String, "local.txt");
            
        }
        catch (Exception copyToLocal_Exception)
        {

            System.Console.WriteLine(copyToLocal_Exception);
            
        }

        System.Console.WriteLine("Success");

        return true;

    }

    private static bool WriteToFile_Function(FileInfo appData_FileInfo)
    {

        if(!TxtRegex_Class().IsMatch(appData_FileInfo.FullName))return false;

        StreamWriter storeData_StreamWriter;

        if(appData_FileInfo.Exists)
        {

            try
            {

                appData_FileInfo.Delete();

            }
            catch (System.Exception deleteLocal_Exception)
            {
                
                System.Console.WriteLine(deleteLocal_Exception);
            }
            
        }

        try
        {

            appData_FileInfo.Create();
            
        }
        catch (System.Exception createText_Exception)
        {

            System.Console.WriteLine(createText_Exception);
        
        }

        storeData_StreamWriter = appData_FileInfo.AppendText();

        while(true)
        {

            string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

            string inputLine_String = IRead.KeyToLine_Function(exitCode_String);

            if(inputLine_String == exitCode_String)
            {

                storeData_StreamWriter.Dispose();
                
                if(appData_FileInfo.Exists)
                {

                    try
                    {

                        appData_FileInfo.Delete();

                    }
                    catch (System.Exception deleteLocal_Exception)
                    {
                        
                        System.Console.WriteLine(deleteLocal_Exception);
                    }
                    
                }
            
                return false;
                
            }

            if(inputLine_String.Contains(exitCode_String))
            {
                
                inputLine_String = inputLine_String.Replace(exitCode_String, null);

                try
                {

                    storeData_StreamWriter.WriteLine(inputLine_String);
    
                    storeData_StreamWriter.Dispose();

                }
                catch (System.Exception writeFile_Exception)
                {
                    
                    System.Console.WriteLine(writeFile_Exception);
                }

                return true;
            
            }

            storeData_StreamWriter.WriteLine(inputLine_String);

        }

    }

    private static string[][] ReadLocalFile_Function()
    {

        string[][] data_StringJArray = [];

        string[][] tempData_StringJArray;

        int rowNumber_Int = 1;

        string? line_String = "";

        StreamReader readLocalText_StreamReader = new("");

        if(!File.Exists("local.txt")) return [];        

        try
        {

            readLocalText_StreamReader = new("local.txt");        

            line_String = readLocalText_StreamReader.ReadLine();

        
        }catch (System.Exception readLine_Exception)
        {
            
            System.Console.WriteLine(readLine_Exception);

        }

        while(line_String !=null)
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

            try
            {

                line_String = readLocalText_StreamReader.ReadLine();

            }
            catch (System.Exception readLine_Exception)
            {
                
                System.Console.WriteLine(readLine_Exception);
                
            }

        }

        try
        {

            readLocalText_StreamReader.Dispose();

        }
        catch (System.Exception disposeWriter_Exception)
        {
            
            System.Console.WriteLine(disposeWriter_Exception);

        }

        return data_StringJArray;

    }

    [GeneratedRegex(@".*\.txt$")]
    private static partial Regex TxtRegex_Class();

    [GeneratedRegex(@",(?<Element>.*?),")]
    private static partial Regex ReadCSVRegex_Class();

}