using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.FileIO;

namespace Gaussian_Elimination;

public class Data
{

    private static int numberOfMatricesPrivate_Int = 0;

    private static readonly List<int> checkedFilesPrivate_ListInt = [];

    private static string[][]?[] dataPrivate_StringArray3D
    {
     
        set
        {

            dataPrivate_StringArray3D = value;

        }
     
        get
        {

            return dataPrivate_StringArray3D;

        }
        
    }

    public static string[][]?[] publicData_StringArray3D
    {
        
        get
        {

            return dataPrivate_StringArray3D;

        }
        
    }

    public static string[][]? GetDataSets_Function(int matrixNumber_Int)
    {

        if(!checkedFilesPrivate_ListInt.Contains(matrixNumber_Int)) return [["-1"]];

        return publicData_StringArray3D[matrixNumber_Int-1];

    }

    public static bool InitializeData_Function(int thisFIle_Int)
    {

        if(checkedFilesPrivate_ListInt.Contains(thisFIle_Int))return false;

        System.Console.WriteLine(SetDataCSVPrivate_Function(thisFIle_Int));

        return true;

    }

    private static string SetDataCSVPrivate_Function(int thisFIle_Int)
    {

        if(IFile.CheckLocalFile_Function(thisFIle_Int,true))return "File Doesn't Exist!";

        checkedFilesPrivate_ListInt.Add(thisFIle_Int);

        dataPrivate_StringArray3D[numberOfMatricesPrivate_Int] = IFile.GetDataCSV_Function(IFile.CurrentLocalFile_Function());

        numberOfMatricesPrivate_Int++;

        return "done";

    }

    public static bool OverWriteData_Function(int thisFIle_Int)
    {

        if(!checkedFilesPrivate_ListInt.Contains(thisFIle_Int))return false;

        return ChangeDataCSVPrivate_Function(thisFIle_Int, checkedFilesPrivate_ListInt.IndexOf(thisFIle_Int));

    }

    private static bool ChangeDataCSVPrivate_Function(int thisFIle_Int,int thisData_int)
    {

        if(!IFile.CheckLocalFile_Function(thisFIle_Int,true))return false;

        dataPrivate_StringArray3D[thisData_int] = IFile.GetDataCSV_Function(IFile.CurrentLocalFile_Function());

        return true;

    }
    
    private static bool DerefrenceDataCSVPrivate_Function(int thisFIle_Int)
    {

        if(!checkedFilesPrivate_ListInt.Contains(thisFIle_Int))return false;

        return true;
        
    }

}