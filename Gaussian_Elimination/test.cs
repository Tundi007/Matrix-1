using System.Security.Cryptography;
using System.Text.RegularExpressions;
// string userAddress_Strin2g = null;
// if((userAddress_Strin2g??="a")==null){System.Console.WriteLine("null");}else{System.Console.WriteLine(userAddress_Strin2g);}
// // ConsoleKeyInfo a = Console.ReadKey(true);
// string userAddress_String = Console.ReadLine();
// Console.WriteLine(a.KeyChar.ToString());
// System.Console.WriteLine(IRead.KeyToLine_Function());

string exitCode_String = RandomNumberGenerator.GetInt32(65535).ToString();

System.Console.WriteLine(exitCode_String);

Thread.Sleep(1500);

string a = IRead.KeyToLine_Function(exitCode_String);

System.Console.WriteLine(a);

if(exitCode_String == a)return;

System.Console.WriteLine(Regex.IsMatch(a, @".*" + exitCode_String + @"$"));