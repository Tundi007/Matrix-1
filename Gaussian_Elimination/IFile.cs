public interface IFile
{

    public static void FileInput_Function(string menuItems_String, string[][]menuItems_ArrayString)
    {

        (int menuOptions_Int, _, _, FileInfo userFile_FileInfo) = IRead.ReadKeyMenu_Function("How Do You Want To Proceed? (use arrow keys or select on numpad)", [["Enter Code Manually","Enter Address","Return"]]);

        switch (menuOptions_Int)
        {
            case 0:
            {
            
                WriteToFile_Function(new("local.txt"));
            
            }break;
            
            case 1:
            {

                System.Console.WriteLine("Please Enter The Full Address To Your Text File:"); // could get directory and show all files!

                (_,string userAddress_String)=IRead.ReadKeyToReadLine_Function();

                userFile_FileInfo = new(userAddress_String??= "");

                if(File.Exists("local.txt"))File.Delete("local.txt");

                userFile_FileInfo.CopyTo("local.txt");

            }break;

            default:
            {

                System.Console.WriteLine("something went wrong");

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

            (int option_Int , string line_String) = IRead.ReadKeyToReadLine_Function();

            switch (option_Int)
            {

                case 1:
                {
                
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

    public static void LineInput_Function()
    {

        System.Console.WriteLine("Enter Desired Line:");

        Console.ReadLine();

    }
    
}