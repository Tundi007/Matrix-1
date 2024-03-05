using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Gaussian_Elimination;
public partial interface IFile
{

    private static int localFiles_Int = 1;

    public static void File_Function()
    {        //"How Do You Want To Proceed? (use arrow keys or select on numpad)" , [["1. Enter Code Manually","1. Enter Address","Return"]]

        while(true){

            switch(Console.ReadKey().Key) //could ask twice for column (first enter row, then column; to select sth in a matrix idk)
            {

                case ConsoleKey.D1:
                {
                
                    if(WriteToFile_Function())
                    {
                        
                        GetDataCSV_Function(CurrentLocalFile_Function());

                    }
                
                }return;
                
                case ConsoleKey.D2:
                {

                    UserFileAddress_Function();

                }return;

                case ConsoleKey.D3:
                {

                    GetDataCSV_Function(CurrentLocalFile_Function());

                }return;

                case ConsoleKey.Escape | ConsoleKey.End: return;

                default:
                {
                    
                    System.Console.WriteLine("undefined action or key / something went wrong");

                }break;

            }

        }
        
    }

    private static string CurrentLocalFile_Function()
    {

        return "local"+localFiles_Int+".txt";

    }

    private static void NextLocalFile_Function()
    {

        localFiles_Int++;

    }

    private static string GiveLocalFile_Function(int fileNumber_Int)
    {

        if(File.Exists("local"+fileNumber_Int+".txt")) return "local"+fileNumber_Int+".txt";

        return "-1";

    }
    
    public static string [][] GetDataCSV_Function(string inputAddress_String)
    {

        return ReadCSV_Function(inputAddress_String);

    }

    private static void UserFileAddress_Function()
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

            if(userAddress_String == exitCode_String) return;

        }
        
        while(File.Exists("local"+localFiles_Int+".txt"))localFiles_Int++;

        ReadCSV_Function(userAddress_String);

        try
        {

            File.Copy(userAddress_String, "local.txt");
            
        }
        catch (Exception copyToLocal_Exception)
        {

            System.Console.WriteLine(copyToLocal_Exception);
            
        }

        System.Console.WriteLine("Success");

    }

    private static bool WriteToFile_Function()
    {

        string localFiles_String = "local.txt" + localFiles_Int;

        FileInfo[] appData_FileInfo = [];

        try
        {

            appData_FileInfo[localFiles_Int] = new(localFiles_String);

        }
        catch (System.Exception fileInfo_Exception)
        {
            
            System.Console.WriteLine(fileInfo_Exception);

        }

        localFiles_Int++;

        if(!TxtRegex_Class().IsMatch(appData_FileInfo[localFiles_Int].FullName))return false;

        StreamWriter storeData_StreamWriter = new("");

        if(appData_FileInfo[localFiles_Int].Exists)
        {

            try
            {

                appData_FileInfo[localFiles_Int].Delete();

            }
            catch (System.Exception deleteLocal_Exception)
            {
                
                System.Console.WriteLine(deleteLocal_Exception);
            }
            
        }

        try
        {

            appData_FileInfo[localFiles_Int].Create();

            storeData_StreamWriter = appData_FileInfo[localFiles_Int].AppendText();
            
        }
        catch (System.Exception createText_Exception)
        {

            System.Console.WriteLine(createText_Exception);
        
        }

        while(true)
        {

            string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

            string inputLine_String = IRead.KeyToLine_Function(exitCode_String);

            if(inputLine_String == exitCode_String)
            {

                try
                {

                    storeData_StreamWriter.Dispose();

                }
                catch (System.Exception disposeWriter_Exception)
                {
                    
                    System.Console.WriteLine(disposeWriter_Exception);
                    
                }
                
                if(appData_FileInfo[localFiles_Int].Exists)
                {

                    try
                    {

                        appData_FileInfo[localFiles_Int].Delete();

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

            try
            {

                storeData_StreamWriter.WriteLine(inputLine_String);

            }
            catch (System.Exception writeFile_Exception)
            {
                
                System.Console.WriteLine(writeFile_Exception);

            }

        }

    }    

    private static string[][] ReadCSV_Function(string inputAddress_String)
    {

        string[][] data_StringJArray = [];

        string[][] tempData_StringJArray;

        int rowNumber_Int = 1;

        string? line_String = "";

        StreamReader readLocalText_StreamReader = new("");

        try
        {

            File.Copy(inputAddress_String, "local"+localFiles_Int+".txt");

            readLocalText_StreamReader = new(inputAddress_String);        

            line_String = readLocalText_StreamReader.ReadLine();

        
        }catch (System.Exception readLine_Exception)
        {
            
            System.Console.WriteLine(readLine_Exception);

        }

        while(line_String !=null)
        {

            List<string> matchedNames_List = [];

            int countName_Int = 0;

            tempData_StringJArray = new string[rowNumber_Int][];

            MatchCollection lineElemets_MatchCollection = ReadCSVRegex_Class().Matches(line_String);

            foreach(Match matched_Match in lineElemets_MatchCollection)
            {

                if(matched_Match.Name=="Element")
                {

                    matchedNames_List.Add(matched_Match.Value);

                    countName_Int++;

                }

            }            

            tempData_StringJArray[rowNumber_Int-1] = new string[countName_Int];

            countName_Int = 0;

            foreach (string element_String in matchedNames_List)
            {

                tempData_StringJArray[rowNumber_Int-1][countName_Int] = element_String;

                countName_Int++;
            
            }

            for(int count_int = 0 ; count_int < rowNumber_Int - 2 ; count_int++)
            {

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