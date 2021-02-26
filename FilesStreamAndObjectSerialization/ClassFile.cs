using System;
using System.IO;

namespace FilesStreamAndObjectSerialization
{
    class ClassFile
    {
        static void Main(string[] args)
        {

            //Change the path to the file before running the code

            //To check if a file exist
            if (File.Exists(@"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - INHERITANCE.pptx"))
            {
                Console.WriteLine("File exist");
            }
            else
                Console.WriteLine("File do not exist");

            
            //To copy a file from one location to another
            File.Copy(@"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - INHERITANCE.pptx", @"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - AJAYI.pptx");
            //After copying the file, check if the file truly exist
            if (File.Exists(@"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - AJAYI.pptx"))
            {
                Console.WriteLine("Ajayi File exist");
            }
            else
                Console.WriteLine(" Ajayi File do not exist");

            Console.WriteLine();

            //To delete a file
            File.Delete(@"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - AJAYI.pptx");
            //After deeting, check if it has truly been deleted
            if (File.Exists(@"C:\Users\JESULAYO\Documents\OOU\EEG 324 - PROGRAMMING LANGUAGE II\EEG 324 - AJAYI.pptx"))
            {
                Console.WriteLine("Ajayi File exist");
            }
            else
                Console.WriteLine(" Ajayi File do not exist");


            string path = @"C:\Users\JESULAYO\Downloads\debug.log";

            //Read the text in a file
            var content = File.ReadAllText(path);
            Console.WriteLine(content);
            
            //Get the creation time of the file
            Console.WriteLine("Creation time is: " + File.GetCreationTime(path));
            
            //Get the last time the file was edited
            Console.WriteLine("Last write time is: " + File.GetLastWriteTime(path));
            
            //Get the last time you access the file
            Console.WriteLine("Last access time is: " + File.GetLastAccessTime(path));
            

        }
    }
}
