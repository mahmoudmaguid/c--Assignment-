using System;
using System.IO;


namespace c___1_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
// this app will allow user to enter a file name .
// if the file name is exist the app will allow to the user to enter a string data , and replace the data enterd by blank space.
// if the user enterd a file name not exsit the app will give an error message and ask the user to try again .
// the app will keep running till the user type stop .
// this app been made completely by Mahmoud Abdel Maguid , and copyright to Mahmoud Abdel Maguid.

            string DynamicTextFile = Console.ReadLine();
            if (File.Exists(DynamicTextFile))
            {


                while (DynamicTextFile == "DynamicTextFile")
                {
                    string DynamicTextFileContent = Console.ReadLine();
                    File.WriteAllText(DynamicTextFile, DynamicTextFileContent);
                    File.WriteAllText(DynamicTextFile, " ");
                    if (DynamicTextFileContent == "stop")
                    {
                        Console.WriteLine("APP HAS BEEN TERMINATED");
                        break;

                    }

                }

            }
            else
            {
                while (DynamicTextFile != "DyanamicTextFile")
                {
                    Console.WriteLine("WRONG FILE PLEASE TRY AGAIN");
                    DynamicTextFile = Console.ReadLine();
                    while (DynamicTextFile == "DynamicTextFile")
                    {
                        string DynamicTextFileContent = Console.ReadLine();
                        File.WriteAllText(DynamicTextFile, DynamicTextFileContent);
                        File.WriteAllText(DynamicTextFile, " ");
                        if (DynamicTextFileContent == "stop")
                        {
                            Console.WriteLine("APP HAS BEEN TERMINATED");
                            break;

                        }
                    }
                }

            }

        }
    }
}
