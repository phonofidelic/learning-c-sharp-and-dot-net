using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("/foo/bar/Examplez.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                DisplayErrorMessage("Make sure file is named correctly.");
            }
            catch (DirectoryNotFoundException ex)
            {
                DisplayErrorMessage("Make sure the directory exists.");
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);

                /*
                    Possibly send debug information to a logging system
                */
            }
            finally
            {
                /*
                    Do any necessary cleanup
                    (setting objects to null, closing database connections)
                */
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();

        }
        
        static void DisplayErrorMessage(string message)
        {
            Console.WriteLine("There was a problem:");
            Console.WriteLine(message);
        }
    }
}