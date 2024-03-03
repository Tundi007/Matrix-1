using System.Text.RegularExpressions;

public partial interface IFile
{

    public static void File_Function(string menuItems_String, string[][]menuItems_ArrayString)
    {

        FileInfo userFile_FileInfo = new("");

        (int row_Int, int column_Int, ConsoleKey userKey_ConsoleKey) = IRead.KeyMenu_Function("How Do You Want To Proceed? (use arrow keys or select on numpad)", [["Enter Code Manually","Enter Address","Return"]]);

        switch (row_Int)//could ask twice for column (first enter row, then column; to select sth in a matrix idk)
        {

            case 0:
            {
            
                WriteToFile_Function(new("local.txt"));
            
            }break;
            
            case 1:
            {

                string wrong_String = "Please Enter The Full Address To Your Text File (Enter \"exit\" To Abort):";

                while(!userFile_FileInfo.Exists)
                {

                    System.Console.WriteLine(wrong_String);

                    wrong_String = "Address Not Found, Please Try Again:";

                    (_,string userAddress_String)=IRead.KeyToLine_Function();

                    if(userAddress_String == "exit")return;

                    if(TxtRegex_Class().IsMatch(userAddress_String)) userFile_FileInfo = new (userAddress_String??= "");

                }

                if(File.Exists("local.txt"))File.Delete("local.txt");

                userFile_FileInfo.CopyTo("local.txt");

            }break;

            default:
            {

                    Console.Clear();

                    System.Console.WriteLine("something went wrong");

                    Thread.Sleep(500);

                    Console.Clear();

            }break;
        }        
        
    }

    public static void WriteToFile_Function(FileInfo appData_FileInfo)
    {

        if(appData_FileInfo.Exists)appData_FileInfo.Delete();
        
        StreamWriter writeToLocalText_StreamWriter = appData_FileInfo.AppendText();

        int hint_Int = 3;

        int hintReset_Int = hint_Int;

        while(true)
        {

            (int option_Int , string line_String) = IRead.KeyToLine_Function();

            switch (option_Int)
            {

                case 1:
                {

                    hint_Int=hintReset_Int;
                
                    writeToLocalText_StreamWriter.WriteLine(line_String);
                
                }break;

                case 2:
                {

                    if(line_String!="")
                    {

                        writeToLocalText_StreamWriter.WriteLine(line_String);

                    }
                
                    writeToLocalText_StreamWriter.Dispose();
                
                }return;

                case 3:
                {

                    writeToLocalText_StreamWriter.WriteLine(line_String);

                    hint_Int--;

                    if(hint_Int<1)
                    {

                        hintReset_Int += 3;

                        hint_Int=hintReset_Int;

                        System.Console.WriteLine("(hint: hold \"ctrl\" and press \"Enter\" to finish; press \"escape\" to abort and reverse changes)");

                    }                    

                }break;

                case 4:
                {
                
                    writeToLocalText_StreamWriter.Dispose();  
                
                    appData_FileInfo.Delete();
                
                }return;

                default:
                {
                    Console.Clear();

                    System.Console.WriteLine("something went wrong");

                    Thread.Sleep(500);

                    Console.Clear();

                }break;

            }            

        }

    }

    [GeneratedRegex(@".*\.txt$")]
    private static partial Regex TxtRegex_Class();
}