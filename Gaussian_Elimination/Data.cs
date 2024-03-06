using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.FileIO;

namespace Gaussian_Elimination;

public class Data
{

    static string[][] data_StringJArray = [];

    public static string[][] GetData_Function()
    {

        return data_StringJArray;

    }

    public static void SetData_Function()
    {

        data_StringJArray = IFile.GetDataCSV_Function(IFile.CurrentLocalFile_Function());

    }
    
}