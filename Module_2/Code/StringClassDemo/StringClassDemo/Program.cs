using System;

namespace StringClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = "RKIT";

            #region String Method Demo

            //creating the String class object with value.
            String objCopiedString = new String("RKIT");

            //ToUpper() is use to convert the string in uppercase.
            Console.WriteLine("Uppercase : " + companyName.ToUpper());

            //ToLower() is use to convert the string in lowercase.
            Console.WriteLine("Lowercase : " + companyName.ToLower());
                     
            //Equals() is used to check the string value.
            Console.WriteLine("Does both String is Equals : " + objCopiedString.Equals(companyName));

            //IndexOf() is used return the index of given char.
            Console.WriteLine("Get the Char Position : " + objCopiedString.IndexOf("K"));

            //IndexOf() is used return the index of given char.
            String insertNewString = companyName.Insert(4, " - Rajkot");
            Console.WriteLine("Insert the New String to Old : " + insertNewString);

            //Replace() is used replace the chars.
            String replaceString = companyName.Replace('R', 'r');
            Console.WriteLine("Replace the char : " + replaceString);

            //Remove() is used remove the chars of given position.
            Console.WriteLine("Remove the char : " + replaceString.Remove(1));

            //Substring() is used to create the substring from given position.
            Console.WriteLine("Create the SubString of Given Position : " + replaceString.Substring(2));

            //Trim() is used to remove the space.
            string trimString = " RKIT ";
            Console.WriteLine("Trim the char : " + trimString.Trim());
            Console.WriteLine("Trim From Left of char : " + trimString.TrimStart());
            Console.WriteLine("Trim From Right of char : " + trimString.TrimEnd());
            #endregion String Method Demo

        }
    }
}
