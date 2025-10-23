﻿using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myString = "My \"so-called\" life";
            // string myString = "What if I need a\nnew line?";
            // string myString = "Go to your c:\\ drive";
            // string myString = @"Go to your c:\ drive";

            // string myString = String.Format("{0} = {1}", "First", "Second");
            // string myString = String.Format("{0} = {0}", "First", "Second");
            // string myString = String.Format("{1} = {0}", "First", "Second");

            /** 
                Currency formatting: 
            */
            // string myString = string.Format("{0:C}", 123.45);

            /** 
                Large number formatting: 
            */
            // string myString = string.Format("{0:N}", 1234567890);

            /**
                Percentage formatting
            */
            // string myString = string.Format("Percentage: {0:P}", .123);

            /**
                Custom formatting: 
            */
            // string myString = string.Format("Phone Number: {0:(###) ###-####}", 9547740076);

            // string myString = " That summer we took threes across the board  ";
            // myString = myString.Substring(6, 14);
            // myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove(6, 14);

            // myString = String.Format("Length before: {0} -- Length after: {1}",
            //     myString.Length,
            //     myString.Trim().Length);


            /** 
                Memory resource intensive:
            */
            // for (int i = 0; i < 100; i++)
            // {
            //     myString += "--" + i.ToString();
            // }

            /** 
                More efficient way using a StringBuilder:
            */
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}