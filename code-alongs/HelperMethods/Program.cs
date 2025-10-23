using System.Data.Common;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message: ");
            string userMessage = Console.ReadLine() ?? "";

            // if (userMessage == null)
            // {
            //     Console.WriteLine("Sorry, that was not a valid message");
            //     return;
            // }
            // if (!ValidateUserMessage(userMessage))
            // {
            //     return;
            // }

            // Console.WriteLine("Your message in ReverseString is: {0}", ReverseString(userMessage));

            // PrintReverseMessage(ReverseString(userMessage));

            Console.Write("Enter annother message: ");
            string nextMessage = Console.ReadLine() ?? "";

            // if (nextMessage == null)
            // {
            //     Console.WriteLine("Sorry, that was not a valid message");
            //     return;
            // }

            PrintReversedMessage(ReverseString(userMessage), ReverseString(nextMessage));
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            string reverseMessage = "";
            foreach (char item in messageArray)
            {
                reverseMessage += item;
            }

            return reverseMessage;
        }

        private static void PrintReversedMessage(string message)
        {
            Console.WriteLine("Your message in reverse is: {0}", message);
        }

        private static void PrintReversedMessage(string message, string nextMessage)
        {
            Console.WriteLine(String.Format("Your messages in reverse are: \"{0}\" and \"{1}\"", message, nextMessage));
        }
        
        // private static bool ValidateUserMessage(Nullable<> userMessage)
        // {
        //     if (userMessage == null)
        //     {
        //         Console.WriteLine("Sorry, that was not a valid message");
        //         return false;
        //     }

        //     return true;
        // }
    }
}